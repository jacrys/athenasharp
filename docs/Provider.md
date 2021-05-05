# IO.Swagger.Model.Provider
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Billable** | **bool?** | Indicates if this is a billable provider. | [optional] 
**Ansispecialtycode** | **string** | This is the ANSI code for this provider&#x27;s specialty. | [optional] 
**Firstname** | **string** | The provider&#x27;s first name. | [optional] 
**Entitytype** | **string** | Either \&quot;Person\&quot; or \&quot;Non-Person\&quot; (e.g. X-Ray machines) | [optional] 
**Otherprovideridlist** | **string** | When showallproviderids is set to true, a list of all other athenaNet providers IDs that may refer to this same provider. If not present with showallproviderids, there are no other IDs other than the primary ID.  | [optional] 
**Ansinamecode** | **string** | This is the ANSI name with ANSI code for this provider&#x27;s specialty. | [optional] 
**Displayname** | **string** | The preferred name to use when displaying this provider. | [optional] 
**Homedepartment** | **string** | For certain purposes, this can be considered to be the \&quot;home\&quot; or default department for a provider. | [optional] 
**Providerid** | **int?** | The ID to be used for this provider. Note that in athenaNet, an individual provider (as defined by a unique NPI) may have multiple provider IDs. For the API, we have collapsed these to a single canonical ID.  | 
**Providertypeid** | **string** | This is just the ID (a text string) such as \&quot;NP\&quot; or \&quot;NP S\&quot; for the provider type. | [optional] 
**Providerusername** | **string** | The username of the provider. | [optional] 
**Supervisingproviderid** | **int?** | The ID of the supervising provider. | [optional] 
**Providertype** | **string** | There is a long potential list of provider type in the form \&quot;full name (id)\&quot;,  but \&quot;MD\&quot;, \&quot;NP\&quot; or \&quot;NP S\&quot; (Nurse Practitioner (Supervising)), \&quot;RES\&quot; (resident), \&quot;EQUIP\&quot;, \&quot;DO\&quot;, \&quot;PA\&quot; or \&quot;PASUP\&quot; (Physician&#x27;s Assistant (Supervising)), \&quot;TECH\&quot;, \&quot;RN\&quot;, LPT\&quot;, \&quot;CRNA\&quot; or \&quot;CRNASUP\&quot; (Certified Registered Nurse Anesthesiologist (Supervising)), and MA (Medical Assistant) are among the most common.  | [optional] 
**Createencounterprovideridlist** | **string** | A list of provider IDs for this provider NPI that will create an encounter when the appointment is checked in  for encounter supported appointment types. Only populated if &#x27;showallproviderids&#x27; is set.  | [optional] 
**Schedulingname** | **string** | The scheduling name for this provider (as used in athenaNet). | [optional] 
**Usualdepartmentid** | **string** | The \&quot;usual\&quot; department for this provider, if SHOWUSUALDEPARTMENTGUESSTHRESHOLD is set. | [optional] 
**Createencounteroncheckinyn** | **bool?** | If true, appointments scheduled with this provider will create an encounter when the appointment is checked infor encounter supported appointment types. Only applies to the primary providerid. If the provider has other IDs with the same API, please use &#x27;showallproviderids&#x27; to see which IDs create encounters.  | [optional] 
**Specialty** | **string** | A friendly name for this provider&#x27;s specialty. | [optional] 
**Hideinportalyn** | **bool?** | If set, this provider does not appear in athenaCommunicator&#x27;s web portal.  | [optional] 
**Lastname** | **string** | The provider&#x27;s last name. | [optional] 
**Npi** | **long?** | The NPI for this provider, if available. | [optional] 
**Providergrouplist** | **string** | When showallproviderids is set to true, a list of all provider groups that this provider is registered in. Data is only relevant if a practice is using Provider-Group-Based Data Permissions in their practice.  | [optional] 
**Federalidnumber** | **string** | The federal ID number for provider, if SHOWFEDERALIDNUMBER is set. | [optional] 
**Supervisingproviderusername** | **string** | The username of the supervising provider. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

