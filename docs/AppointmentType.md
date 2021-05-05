# IO.Swagger.Model.AppointmentType
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the appointment type. | 
**Duration** | **int?** | Expected duration of the appointment in minutes. | [optional] 
**Genericyn** | **bool?** | If true, this type is a \&quot;generic\&quot; type able to be filled with other types of appointments. | [optional] 
**Shortname** | **string** | The short name code of the appointment type. | [optional] 
**Patientyn** | **bool?** | If true, this type is a patient-facing type. | [optional] 
**Patientdisplayname** | **string** | Patient friendly appointment type name. Defaults to regular name. | [optional] 
**Appointmenttypeid** | **int?** | The appointment type ID. | 
**Templatetypeonlyyn** | **bool?** | If true, this type is a \&quot;template-only\&quot; type, and must be filled with a different appointment type upon booking. | [optional] 
**Createencounteroncheckin** | **bool?** | If true, then this appointments of this type will generated an encounter when checked in, with certain conditions. It&#x27;s rather complex, but the rendering provider on the appointment must also have the create encounter feature set, the department must have athena Clinicals enabled, and other rarer and less visible settings.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

