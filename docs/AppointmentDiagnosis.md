# IO.Swagger.Model.AppointmentDiagnosis
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Diagnosisid** | **int?** | A unique ID related to this diagnosis. | [optional] 
**Diagnosisdescription** | **string** | A description of this diagnosis. | [optional] 
**Diagnosisrawcode** | **string** | The raw ICD-9 code. This will migrate to ICD-10 in the future. | [optional] 
**Diagnosiscategory** | **string** | The category for this diagnosis. | [optional] 
**Deleteddiagnosis** | **string** | In certain cases, diagnoses may be added and then removed from a particular claim. In normal circumstances, this will be false. However, if a diagnosis was removed, this will be true.  | [optional] 
**Diagnosiscodeset** | **string** | Either ICD9 or ICD10. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

