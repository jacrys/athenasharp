# IO.Swagger.Model.Body3
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Patientid** | **int?** | The athenaNet patient ID. | 
**Appointmenttypeid** | **int?** | The appointment type to be booked. This field should never be used for booking appointments for web-based scheduling. The use of this field is reserved for digital check-in (aka \&quot;kiosk\&quot;) or an application used by practice staff. One of this or reasonid is required.  | [optional] 
**Bookingnote** | **string** | A note from the patient about why this appointment is being booked | [optional] 
**Departmentid** | **int?** | The athenaNet department ID. | [optional] 
**Donotsendconfirmationemail** | **bool?** | For clients with athenaCommunicator, certain appointment types can be configured to have an appointment confirmation email sent to the patient at time of appointment booking. If this parameter is set to true, that email will not be sent. This should only be used if you plan on sending a confirmation email via another method.  | [optional] 
**Ignoreschedulablepermission** | **bool?** | By default, we allow booking of appointments marked as schedulable via the web. This flag allows you to bypass that restriction for booking.  | [optional] 
**Insurancecompany** | **string** | The name of the insurance company. | [optional] 
**Insurancegroupid** | **string** | If available, any identifier for the insurance group. | [optional] 
**Insuranceidnumber** | **string** | The insurance identifier for this individual patient. | [optional] 
**Insurancenote** | **string** | Any extra information provided by the patient about insurance coverage. | [optional] 
**Insurancephone** | **string** | The phone number for the insurance company. | [optional] 
**Insuranceplanname** | **string** | The insurance plan name (e.g. \&quot;HMO Blue\&quot;). | [optional] 
**Insurancepolicyholder** | **string** | The full name of the insurance policy holder. | [optional] 
**Nopatientcase** | **bool?** | By default, we create a patient case upon booking an appointment for new patients. Setting this to true bypasses that patient case.  | [optional] 
**Reasonid** | **int?** | The appointment reason ID to be booked. This field is required for booking appointments for web-based scheduling and is a reason that is retrieved from the /patientappointmentreasons call.  | [optional] 
**Urgentyn** | **bool?** | Set this field in order to set the urgent flag in athena (if the practice settings allow for this). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

