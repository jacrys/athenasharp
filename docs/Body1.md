# IO.Swagger.Model.Body1
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Accessionid** | **string** | A unique identifier given to a document to track it over time. | [optional] 
**Analytes** | **string** | message | [optional] 
**Attachmentcontents** | **string** | The file contents that will be attached to this document. Currently PDFs and PNGs are supported. PNG files must be Base64 encoded. | [optional] 
**Attachmenttype** | **string** | The file type of the attachment. Currently PDFs and PNGs are supported. Defaults to PDF. | [optional] 
**Autoclose** | **string** | Documents will, normally, automatically appear in the clinical inbox for providers to review.  In some cases, you might want to force the document to skip the clinical inbox, and go directly to the patient chart with a \&quot;closed\&quot; status. For that case, set this to true.   | [optional] 
**Departmentid** | **int?** | The athenaNet department ID associated with the uploaded document. | [optional] 
**Documenttypeid** | **int?** | A specific document type identifier. | [optional] 
**Facilityid** | **int?** | The ID of the facility or clinical provider who received the order. | [optional] 
**Internalnote** | **string** | An internal note for the provider or staff. Updating this will append to any previous notes. | [optional] 
**Interpretation** | **string** | The practice entered interpretation of this result. Updating this will append to any previous values. | [optional] 
**Observationdate** | **string** | The date an observation was made (mm/dd/yyyy). | [optional] 
**Observationtime** | **string** | The time an observation was made (hh24:mi). 24 hour time. | [optional] 
**Priority** | **string** | Priority of this result. 1 is high; 2 is normal. | [optional] 
**Providerid** | **int?** | The ID of the ordering provider. | [optional] 
**Reportstatus** | **string** | The status of the report. | [optional] 
**Resultstatus** | **string** | The status of the result. | [optional] 
**Specimenreceiveddatetime** | **string** | Date-time indicating when the specimen was received in format (yyyy-mm-ddThh:mm:ss). | [optional] 
**Specimenreporteddatetime** | **string** | Date-time indicating when the specimen was reported in format (yyyy-mm-ddThh:mm:ss). | [optional] 
**Tietoorderid** | **int?** | Tie the result document to this order. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

