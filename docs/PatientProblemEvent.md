# IO.Swagger.Model.PatientProblemEvent
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Diagnoses** | [**List&lt;Code&gt;**](Code.md) |  | [optional] 
**Eventtype** | **string** | The type of this event: START, END, HIDDEN, REACTIVATED, or ENCOUNTER  | [optional] 
**Source** | **string** | The source of this event: ENCOUNTER or HISTORY  | [optional] 
**Status** | **string** | The status of this problem event: CHRONIC or ACUTE  | [optional] 
**Onsetdate** | **string** | The specified onset date for this problem, as entered by the practice. If available this is more accurate than the start date.  | [optional] 
**Startdate** | **string** | The date this problem event started or was restarted. Uses the onsetdate if available, otherwise uses the date the problem was entered into the system.  | [optional] 
**Enddate** | **string** | The date this problem event ended or was hidden | [optional] 
**Encounterdate** | **string** | The date of the encounter where a diagnosis matching this problem was used. | [optional] 
**Laterality** | **string** | The laterality of this problem. Can be null, LEFT, RIGHT, or BILATERAL. | [optional] 
**Note** | **string** | The note attached to this event. | [optional] 
**Createddate** | **string** | The date that the user entered this problem. | [optional] 
**Createdby** | **string** | The name of the user who entered this problem. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

