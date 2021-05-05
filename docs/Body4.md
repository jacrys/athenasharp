# IO.Swagger.Model.Body4
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Patientid** | **int?** | The athenaNet patient ID. | 
**Appointmentcancelreasonid** | **int?** | Passing in this parameter will override the default cancel reason. Valid reasons can be retrieved via a call to the GET /appointmentcancelreasons endpoint.  | [optional] 
**Cancellationreason** | **string** | A text explanation why the appointment is being cancelled | [optional] 
**Departmentid** | **int?** | The athenaNet department ID. | [optional] 
**Ignoreschedulablepermission** | **bool?** | By default, we allow booking of appointments marked as schedulable via the web. This flag allows you to bypass that restriction for booking.  | [optional] 
**Nopatientcase** | **bool?** | By default, we create a patient case upon booking an appointment for new patients. Setting this to true bypasses that patient case.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

