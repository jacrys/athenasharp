# IO.Swagger.Model.Body6
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Duration** | **int?** | The expected duration, in minutes, of the appointment type. Note, this value cannot be changed after creation, so please choose carefully.  | 
**Generic** | **bool?** | If set to true, this type serves as a \&quot;generic\&quot; type, that will match any type when searching. Defaults to false.  | [optional] 
**Name** | **string** | The name of the appointment type. Maximum length of 30 characters. | 
**Patient** | **bool?** | If set to true, this type serves as a \&quot;patient\&quot; type, meaning that is is a type that can be used for booking patients. If set to false, then it this type will not be used for patient (e.g. \&quot;Lunch\&quot; or \&quot;Vacation\&quot;). Non-patient types are mostly used to reserving time for providers to not see patients.  | 
**Shortname** | **string** | The short name code of the appointment type. Maximum length of 4 characters. Used for making schedule templates. Note, this value cannot be changed after creation, so please choose carefully.  | 
**Templatetypeonly** | **bool?** | If set to true, this type serves as a \&quot;template-only\&quot; type, meaning that it can be used for building schedule templates,  but cannot be used for booking appointments (i.e. another type must be chosen). Defaults to false.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

