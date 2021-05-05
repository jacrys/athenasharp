# IO.Swagger.Model.Body5
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Appointmentdate** | **string** | The appointment date for the new open appointment slot (mm/dd/yyyy). | 
**Appointmenttime** | **string** | The time (hh24:mi) for the new appointment slot. Multiple times (either as a comma delimited list or multiple POSTed values) are allowed. 24 hour time.   | 
**Appointmenttypeid** | **int?** | The appointment type ID to be created. Either this or a reason must be provided. | [optional] 
**Departmentid** | **int?** | The athenaNet department ID. | 
**Providerid** | **int?** | The athenaNet provider ID. | 
**Reasonid** | **int?** | The appointment reason (/patientappointmentreasons) to be created. Either this or a raw appointment type ID must be provided.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

