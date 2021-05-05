# IO.Swagger.Model.ProviderCreatedResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Providerid** | **int?** | The ID to be used for this provider. Note that in athenaNet, an individual provider (as defined by a unique NPI) may have multiple provider IDs. For the API, we have collapsed these to a single canonical ID. For updates and deletes, this will be either 1 or -1 depending on success or failure.  | 
**Errorreason** | **string** | Error message if the operation did not work. | [optional] 
**Alertmessage** | **string** | Alert message if the operation did not work. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

