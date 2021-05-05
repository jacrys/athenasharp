# IO.Swagger.Model.PatientProblem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Events** | [**List&lt;PatientProblemEvent&gt;**](PatientProblemEvent.md) | List of start and stop events for this problem, which can occur multiple times. | 
**Deactivateddate** | **string** | Date of problem deactivation. | [optional] 
**Deactivateduser** | **string** | The name of the user who deactivated the problem. | [optional] 
**Problemid** | **int?** | Athena ID for this problem | [optional] 
**Name** | **string** | Problem name | [optional] 
**Code** | **string** | Problem code | [optional] 
**Codeset** | **string** | Problem codeset (SNOMED, ICD9, ICD10, etc) | [optional] 
**Bestmatchicd10code** | **string** | If this was added from the chart or from an encounter without a selected ICD10 code, and if the primary codeset is SNOMED,  then this contains the best matching ICD10 code mapped. Because SNOMED to ICD10 is a many to many map, this will tend to give  the most generic diagnosis.  | [optional] 
**Mostrecentdiagnosisnote** | **string** | The most recent diagnosis note | [optional] 
**Lastmodifieddatetime** | **string** | The date the problem was last modified. Currently only date precision. | [optional] 
**Lastmodifiedby** | **string** | The username of the user who last modified this problem. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

