# IO.Swagger.Model.PatientPortalStatus
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Familyregisteredyn** | **bool?** | Is there a family member registered with access to this patient. | [optional] 
**Lastloginentity** | **string** | Either \&quot;PATIENT\&quot; or \&quot;FAMILY\&quot;, the last entity who accessed this patient. | [optional] 
**Noportalyn** | **bool?** | The privacy setting for blocking the patient from the portal is set. | [optional] 
**Portalregistrationdate** | **string** | The date the patient registered for the portal. | [optional] 
**Entitytodisplay** | **string** | Either \&quot;FAMILY\&quot; or \&quot;PATIENT\&quot;. | [optional] 
**Status** | **string** | The status of the patient. Possible statuses: REGISTERED: The patient is registered for the portal. NOTREGISTERED: The patient is not registered for the portal. FAMILYLOGIN: This patient is set up for a family member to login. NOPORTAL: The privacy setting for blocking the patient from the portal is set. BLOCKEDFAILEDLOGINS: The patient is blocked because of failed login attempts. FAMILYBLOCKEDFAILEDLOGINS: The family member is blocked because of failed login attempts.  | [optional] 
**Termsaccepted** | **bool?** | Has this patient accepted the portal&#x27;s Terms and Conditions. This is a good indicator if the patient has actually logged in to the portal or simply is registered without ever having logged in. | [optional] 
**Registeredyn** | **bool?** | If this patient is registered or not for the portal. | [optional] 
**Blockedfailedloginsyn** | **bool?** | Is this patient blocked from the portal due to failed login attempts. | [optional] 
**Lastlogindate** | **string** | The last login date. | [optional] 
**Familyblockedfailedloginsyn** | **bool?** | Is this patient&#x27;s family blocked from the portal due to failed login attempts. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

