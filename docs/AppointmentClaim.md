# IO.Swagger.Model.AppointmentClaim
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Referringproviderid** | **int?** | The referring provider ID for this claim. See /referringproviders. This is not the same as the ID from the /providers call. | [optional] 
**Primaryinsurancepayer** | [**AppointmentInsurancePayer**](AppointmentInsurancePayer.md) |  | [optional] 
**Secondaryinsurancepayer** | [**AppointmentInsurancePayer**](AppointmentInsurancePayer.md) |  | [optional] 
**Diagnoses** | [**List&lt;AppointmentDiagnosis&gt;**](AppointmentDiagnosis.md) | message | [optional] 
**Claimcreateddate** | **string** | The date the claim was created. | [optional] 
**Procedures** | [**List&lt;AppointmentProcedure&gt;**](AppointmentProcedure.md) | Procedures is an array of all procedures. /ccda is a better clinical representation. These fields are:  | [optional] 
**Billedservicedate** | **string** | The billed date of service. | [optional] 
**Billedproviderid** | **int?** | The provider ID of the billing provider for this claim. | [optional] 
**Appointmentid** | **int?** | The appointment ID associated with this claim. | [optional] 
**Chargeamount** | **string** | The total amount billed for all services from this claim. | [optional] 
**Transactionid** | **int?** | A unique ID for the primary transaction this claim represents. May be useful for debugging. | [optional] 
**Claimid** | **int?** | athenaNet&#x27;s internal ID for this claim, specific to the practice. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

