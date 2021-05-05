# IO.Swagger.Model.PatientMedication
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Nomedicationsreported** | **bool?** | Whether the patient explicitly has no reported medications | 
**Medications** | **List&lt;List&lt;Medication&gt;&gt;** |  | 
**Sectionnote** | **string** | A section-wide note | [optional] 
**Lastupdated** | **string** | The last time any of the medications were updated | 
**Patientdownloadconsent** | **bool?** | Whether or not the patient has consented to have their medication history downloaded. There are plans to deprecate this field. | [optional] 
**Patientneedsdownloadconsent** | **bool?** | Whether or not the patient needs to consent to have medication history downloaded. This will be true if either the patient has not currently consented, or the practice is not enabled for these downloads. This field is typically used when determining whether to message to the patient that they have not consented to these downloads. Note that regardless of this setting, medication history that has already been downloaded will remain available.  | [optional] 
**Lastdownloadeddate** | **string** | The time of the last attempted medication history download from SureScripts. | [optional] 
**Lastdownloaddenied** | **bool?** | BETA FIELD: Whether or not the last medication history download was denied.  | [optional] 
**Lastdownloaddenialreason** | **string** | BETA FIELD: The reason the last medication history download was denied.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

