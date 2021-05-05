# IO.Swagger.Model.Body
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address1** | **string** | Patient&#x27;s address - 1st line (Max length: 100) | [optional] 
**Address2** | **string** | Patient&#x27;s address - 2nd line (Max length: 100) | [optional] 
**City** | **string** | Patient&#x27;s city (Max length: 30) | [optional] 
**Departmentid** | **int?** | Primary (registration) department ID. | [optional] 
**Dob** | **string** | Patient&#x27;s DOB (mm/dd/yyyy) | [optional] 
**Email** | **string** | Patient&#x27;s email address. &#x27;declined&#x27; can be used to indicate just that. | [optional] 
**Firstname** | **string** | Patient&#x27;s first name | [optional] 
**Homephone** | **string** | The patient&#x27;s home phone number. Invalid numbers in a GET will be ignored. Patient phone numbers and other data may change, and one phone number may be associated with multiple patients. You are responsible for taking additional steps to verify patient identity and for using this data in accordance with applicable law, including HIPAA. Only phone numbers that exist in the North American Naming Plan (NANP) are acceptable for input. | [optional] 
**Lastname** | **string** | Patient&#x27;s last name | [optional] 
**Mobilephone** | **string** | The patient&#x27;s mobile phone number. On input, &#x27;declined&#x27; can be used to indicate no number. (Alternatively, hasmobile can also be set to false. \&quot;declined\&quot; simply does this for you.) Invalid numbers in a GET will be ignored. Patient phone numbers and other data may change, and one phone number may be associated with multiple patients. You are responsible for taking additional steps to verify patient identity and for using this data in accordance with applicable law, including HIPAA. Only phone numbers that exist in the North American Naming Plan (NANP) are acceptable for input. | [optional] 
**State** | **string** | Patient&#x27;s state (2 letter abbreviation) | [optional] 
**Zip** | **string** | Patient&#x27;s zip. Matching occurs on first 5 characters. | [optional] 
**Sex** | **string** | Patient&#x27;s sex (M/F) | [optional] 
**Race** | **string** | The patient race, using the 2.16.840.1.113883.5.104 codeset. See http://www.hl7.org/implement/standards/fhir/terminologies-v3.html Special case: use \&quot;declined\&quot; to indicate that the patient declined to answer. Multiple values or a tab-seperated list of codes is acceptable for multiple races for input. The first race will be considered \&quot;primary\&quot;. Note: you must update all values at once if you update any.   | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

