# IO.Swagger.Model.VitalAttributeReading
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Percentilespec** | [**PercentileSpec**](PercentileSpec.md) |  | [optional] 
**Vitalid** | **int?** | Unique ID for this vital attribute reading. Used to update/delete this reading. | 
**Clinicalelementid** | **string** | Key used to identify this particular vital attribute | [optional] 
**Source** | **string** | The source of this reading. | [optional] 
**Sourceid** | **int?** | External key to source. | [optional] 
**Readingid** | **int?** | Numeric key used to tie related and distinguish separate readings. So the diastolic and systolic blood pressure should have the same readingid.  | [optional] 
**Readingtaken** | **string** | Date that the reading was taken. | [optional] 
**Unit** | **string** | Unit that describes this vital&#x27;s value. | [optional] 
**Value** | **string** | The value of this reading. NOTE: for numeric values, the units are always in the &#x27;native&#x27; units per the configuration.  | [optional] 
**Code** | **string** | Code indentifier for the reading. | [optional] 
**Codeset** | **string** | Codeset of the code. | [optional] 
**Codedescription** | **string** | Description of the code identifier. | [optional] 
**Createdby** | **string** | The athenaNet username of the person who entered the vital. | [optional] 
**Createddate** | **string** | The date this vital was entered into the chart. Returned in mm/dd/yyyy hh24:mi:ss format.  | [optional] 
**Isgraphable** | **bool?** | Flag indicating if this vital is graphable. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

