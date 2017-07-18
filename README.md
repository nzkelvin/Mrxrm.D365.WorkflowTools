# Mr. Xrm WorkflowTools
## Relationship Utilities
### DistributeWorkflowActivityOneToMany
Inspired by [the DistributeWF project](https://crm2011distributewf.codeplex.com/). I have remade the custom workflow entity with the latest Dynamics 365 SDK. I have also added extra enhancements. For example, the parent record doesn't have to be the primary record of the current workflow. It can be any lookup field. 

From a parent record, this custom activity allows you to trigger any workflow on its children records. For example, on updating an account's address, you want to automantically populate its children contacts with the same address.

You can also distribute a workflow to sibling records.