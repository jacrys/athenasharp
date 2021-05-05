# IO.Swagger.Model.PatientVital
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Readings** | **List&lt;List&lt;VitalAttributeReading&gt;&gt;** | List of vital attribute readings. One entry per attribute (so the temperature and where the temperature was taken are two different readings, tied together by the readingid  | [optional] 
**Key** | **string** | Key for this vital group. E.g., HEIGHT. | [optional] 
**Abbreviation** | **string** | Short human-readable string for this vital group. E.g., Ht. | [optional] 
**Ordering** | **int?** | Configured order for this vital group | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

