# IO.Swagger.Model.LabResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Analytes** | [**List&lt;Analyte&gt;**](Analyte.md) | Individual lab result observations/analytes | [optional] 
**Providerid** | **int?** | The provider ID for this document. | [optional] 
**Attachmentexists** | **bool?** | This flag depicts if the lab result has a scanned document attachment or not. | [optional] 
**Labresultdatetime** | **string** | The observation date and time associated with this lab result. Returned in mm/dd/yyyy hh24:mi:ss format.  | [optional] 
**Priority** | **string** | Document priority, when available. 1 is high, 2 is normal. Some labs use other numbers or characters that are lab-specific.  | [optional] 
**Patientnote** | **string** | The external note for the patient. | [optional] 
**Internalnote** | **string** | The &#x27;Internal Note&#x27; attached to this document. | [optional] 
**Facilityid** | **int?** | The ID of the clinical provider associated with this clinical document. Clinical providers are a master list of providers throughout the country. These include providers as well as radiology centers, labs and pharmacies.  | [optional] 
**Labresultid** | **int?** | Athena ID for this lab result | 
**Orderid** | **string** | The athena ID of the associated order document | [optional] 
**Description** | **string** | Description for this lab result | [optional] 
**Labresultloinc** | **string** | The LOINC for the result document or associated order. | [optional] 
**Labresultdate** | **string** | Observation date associated with this lab result | [optional] 
**Labresultnote** | **string** | Additional note associated with this lab result, if any | [optional] 
**Resultstatus** | **string** | The status of the result (e.g., \&quot;final\&quot;, \&quot;preliminary\&quot;, \&quot;corrected\&quot;, etc.) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

