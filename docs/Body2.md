# IO.Swagger.Model.Body2
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Alternatephone** | **string** | The phone number of the provider. | [optional] 
**Ansicode** | **string** | The provider taxonomy code of the provider. | [optional] 
**Billable** | **bool?** | This provider is a supervising provider and is credentialed to bill for services. | 
**Billednamecase** | **string** | The billing name of the provider. | [optional] 
**Communicatordisplayname** | **string** | The communicator display name for the provider. | [optional] 
**Communicatorhomedepartment** | **int?** | The communicator home department for the provider. | [optional] 
**Crdreferring** | **bool?** | This provider is a Coordinator referring provider. | [optional] 
**Createencounteroncheckin** | **bool?** | Automatically create encounters at check-in. | [optional] 
**Directaddress** | **string** | The direct email address for the provider. | [optional] 
**Entitytypeid** | **int?** | The entity type of provider. 1 &#x3D; person, 2 &#x3D; non-person | 
**Firstname** | **string** | The first name of the provider. | [optional] 
**Hideinportal** | **bool?** | Hide this provider in the Patient Portal. | [optional] 
**Lastname** | **string** | The last name of the provider. | [optional] 
**Medicalgroupid** | **int?** | The medical group of the provider. | 
**Middleinitial** | **string** | The middle name of the provider. | [optional] 
**Namesuffix** | **string** | The suffix of the provider. | [optional] 
**Ndctatnumber** | **string** | The NDC TAT number for this provider. | [optional] 
**Npinumber** | **long?** | The NPI of the provider. | [optional] 
**Practiceroleid** | **int?** | The practice role ID for the provider. | [optional] 
**Providergroupid** | **int?** | The provider group of the provider. | 
**Providerprofileid** | **string** | The provider profile of the provider (integer or &#x27;NEW&#x27;) | [optional] 
**Providertype** | **string** | The abbreviation for the provider type of the provider. (e.g., MD, NP). See GET /reference/providertypes for a mapping of abbreviation to provider type.   | [optional] 
**Reportingname** | **string** | The reporting name for the provider. | [optional] 
**Scheduleresourcetypeid** | **int?** | The scheduling resource type id of the provider. | [optional] 
**Schedulingname** | **string** | The scheduling name of the provider. | 
**Schedulingnote** | **string** | The scheduling note for the provider. | [optional] 
**Sex** | **string** | The sex of the provider (M or F) | [optional] 
**Signatureonfileflag** | **bool?** | This provider&#x27;s signature is on file. | 
**Specialtyid** | **string** | The specialty ID of the provider. See GET /reference/providerspecialties for a mapping of ID to specialty name. | [optional] 
**Ssn** | **int?** | The SSN of the provider. | [optional] 
**Staffbucket** | **bool?** | Create a staff bucket for this provider. | [optional] 
**Supervisingproviderid** | **int?** | The supervising provider ID for this provider. | [optional] 
**Supervisingprovidertype** | **string** | If set to self,set supervisingprovider to itself. | [optional] 
**Trackmissingslips** | **bool?** | This provider renders services that should be tracked on the Missing Slips Worklist. | [optional] 
**Username** | **string** | The username for the provider. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

