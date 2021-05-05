# IO.Swagger.Model.Analyte
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Analyteid** | **int?** | Athena ID for the given lab result observation/analyte | [optional] 
**Analytename** | **string** | Name / description specific to this analyte | [optional] 
**Loinc** | **string** | Logical Observation Identifiers Names and Codes ID, if available | [optional] 
**Value** | **string** | Value recorded for this observation | [optional] 
**Units** | **string** | Units for this analyte entry, if provided by the lab | [optional] 
**Analytedate** | **string** | Date when this observation was recorded | [optional] 
**Description** | **string** | General description of the lab result test | [optional] 
**Note** | **string** | Additional note for this analyte, if applicable | [optional] 
**Abnormalflag** | **string** | Status indicator of the measurement relative to normal (low, high, normal, abnormal) | [optional] 
**Abnormalhl7code** | **string** | The HL7 code related to the abnormal flag. | [optional] 
**Abnormalhl7name** | **string** | The HL7 description related to the abnormal flag. | [optional] 
**Valuestatus** | **string** | DEPRECATED - - use \&quot;abnormalflag\&quot; instead. Status indicator of the measurement relative to normal (low, high, normal, abnormal) | [optional] 
**Referencerange** | **string** | Reference range of values accepted as normal for this observation | [optional] 
**Resultstatus** | **string** | The status of the result (e.g., \&quot;final\&quot;, \&quot;preliminary\&quot;, \&quot;corrected\&quot;, etc.) | [optional] 
**Labresultstatus** | **string** | The status of the underlying lab result | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

