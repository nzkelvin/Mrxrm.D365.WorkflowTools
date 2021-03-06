﻿
// <copyright file="ConvertBirthdayTo.cs" company="">
// Copyright (c) 2017 All Rights Reserved
// </copyright>
// <author></author>
// <date>5/31/2017 7:16:22 AM</date>
// <summary>Implements the ConvertBirthdayTo Plugin.</summary>
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
// </auto-generated>
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Activities;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;
using System.Runtime.Serialization;

namespace Mrxrm.D365.WorkflowTools.Mrxrm.D365.WorkflowTools
{


    /// </summary>
    //Todo: Another WF to extract date or month of a date.    
    public class ConvertBirthdayTo: WorkFlowActivityBase
    {

         
        #region Properties 
        //Property for Entity account
        [RequiredArgument]
        [Input("Convert a birthday date to a next birthday date, to the number of days since the last birthday, to the number of days to the next birthday.")] 
        [ReferenceTarget("account")]
        public InArgument<EntityReference> Account { get; set; }

        [RequiredArgument]
        [Input("Date of Birth")]
        public InArgument<DateTime> DateOfBirth { get; set; }

        [Output("Next Birthday")]
        public OutArgument<DateTime> NextBirthday { get; set; }

        [Output("Days to Next Birthday")]
        public OutArgument<int> DaysToNextBirthday { get; set; }
        #endregion
        

        /// <summary>
        /// Executes the WorkFlow.
        /// </summary>
        /// <param name="crmWorkflowContext">The <see cref="LocalWorkflowContext"/> which contains the
        /// <param name="executionContext" > <see cref="CodeActivityContext"/>
        /// </param>       
        /// <remarks>
        /// For improved performance, Microsoft Dynamics 365 caches WorkFlow instances.
        /// The WorkFlow's Execute method should be written to be stateless as the constructor
        /// is not called for every invocation of the WorkFlow. Also, multiple system threads
        /// could execute the WorkFlow at the same time. All per invocation state information
        /// is stored in the context. This means that you should not use global variables in WorkFlows.
        /// </remarks>
        public override void ExecuteCRMWorkFlowActivity(CodeActivityContext executionContext, LocalWorkflowContext crmWorkflowContext)
        {                 

            if (crmWorkflowContext == null)
            {
                throw new ArgumentNullException("crmWorkflowContext");
            }

	        try
	        {
            	// TODO: Implement your custom activity handling.
	        }
	        catch (FaultException<OrganizationServiceFault> e)
            {                
                // Handle the exception.
                throw e;
            }	  

        }
         

    }

}
