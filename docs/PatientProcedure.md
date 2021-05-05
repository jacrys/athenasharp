# IO.Swagger.Model.PatientProcedure
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Procedureid** | **int?** | Athena ID for this surgery | 
**Procedurecode** | **string** | Procedure code | [optional] 
**Description** | **string** | Surgery description for this procedure code | [optional] 
**Source** | **string** | Source of this procedure. Can be encounter (if performed) or historical | [optional] 
**Providerid** | **int?** | ID of the provider that performed this procedure. Only returned for entries with source&#x3D;\&quot;encounter\&quot;. | [optional] 
**Note** | **string** | Additional note for this surgery, if available | [optional] 
**Proceduredate** | **string** | Date when the surgery was performed | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

