# IO.Swagger.Model.PatientEncounter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Diagnoses** | [**List&lt;PatientEncounterDiagnosis&gt;**](PatientEncounterDiagnosis.md) | List of diagnoses for this encounter | [optional] 
**Lastreopened** | **string** | The date the encounter was last reopened. The field will not be present if the encounter has not be closed.  | [optional] 
**Departmentid** | **int?** | The athena department ID of this encounter | [optional] 
**Appointmentid** | **int?** | Athena appointment ID resulting in this encounter | [optional] 
**Encounterid** | **int?** | Athena ID for this encounter | [optional] 
**Encountervisitname** | **string** | The visit name for this encounter | [optional] 
**Encountertype** | **string** | Type of encounter (FLOWSHEET, ORDERSONLY, VISIT, etc.). By default only VISIT and ORDERSONLY are shown, use INCLUDEALLtypeS flag to see others.  | [optional] 
**Status** | **string** | Status of this encounter (CLOSED, OPEN, PEND). By default only OPEN, CLOSED, and REVIEW statuses are shown, use INCLUDEALLSTATUSES flag to see others.  | [optional] 
**Patientlocationid** | **int?** | Athena ID for the patient location | [optional] 
**Patientlocation** | **string** | Patient location | [optional] 
**Patientstatusid** | **int?** | Athena ID for the patient status | [optional] 
**Patientstatus** | **string** | Patient status | [optional] 
**Encounterdate** | **string** | Date when this encounter occured | [optional] 
**Stage** | **string** | Last stage of the encounter | [optional] 
**Providerid** | **int?** | The ID of the provider for this encounter | [optional] 
**Providerfirstname** | **string** | First name of the provider for this encounter | [optional] 
**Providerlastname** | **string** | Last name of the provider for this encounter | [optional] 
**Providerphone** | **string** | Phone number of the provider for this encounter | [optional] 
**Lastupdated** | **string** | The date the encounter was last updated | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

