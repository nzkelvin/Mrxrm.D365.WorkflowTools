using System;
using System.Configuration;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using Mrxrm.D365.WorkflowTools.Mrxrm.D365.WorkflowTools;

namespace Mrxrm.D365.WorkflowTools.IntegrationTests.DistributeWorkflowActivityManyToMany_Tests
{
    [TestClass]
    public class When_DistributeWorkflowActivityManyToMany_GetKeys
    {
        [TestMethod]
        public void Given_SystemUser_Then_RelatedRolesFound()
        {
            string connStr = ConfigurationManager.ConnectionStrings["Xrm"]?.ConnectionString;
            var client = new CrmServiceClient(connStr);

            var wfActivity = new DistributeWorkflowActivityManyToMany();

            // Action
            var keys = wfActivity.GetKeys(new EntityReference("systemuser", new Guid("{A111715C-1524-4D20-A032-836A014B4959}")),
                "systemuserroles_association", client.OrganizationServiceProxy);

            Assert.IsTrue(keys.Any(k => k == new Guid("{f38af038-5ac8-e611-8101-c4346bc5c21c}")));
        }

        [TestMethod]
        public void Given_RoleExists_Then_RelatedUsersFound()
        {
            string connStr = ConfigurationManager.ConnectionStrings["Xrm"]?.ConnectionString;
            var client = new CrmServiceClient(connStr);

            var wfActivity = new DistributeWorkflowActivityManyToMany();

            // Action
            var keys = wfActivity.GetKeys(new EntityReference("role", new Guid("{f38af038-5ac8-e611-8101-c4346bc5c21c}")),
                "systemuserroles_association", client.OrganizationServiceProxy);

            Assert.IsTrue(keys.Any(k => k == new Guid("{A111715C-1524-4D20-A032-836A014B4959}")));
        }
    }
}
