# IO.Swagger.Model.EncounterDiagnosis
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Diagnosisicd** | [**List&lt;Code&gt;**](Code.md) | The matching ICD9 or ICD10 codes for this diagnosis, where available. | [optional] 
**Orders** | [**List&lt;PatientEncounterOrder&gt;**](PatientEncounterOrder.md) | List of diagnoses for this encounter | [optional] 
**Diagnosissnomed** | **int?** | The SNOMED code for this diagnosis. 0 means No Diagnosis. | [optional] 
**Diagnosis** | **string** | The name of the diagnosis | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

