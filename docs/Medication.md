# IO.Swagger.Model.Medication
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Events** | [**List&lt;MedicationEvent&gt;**](MedicationEvent.md) | The list of events for this medication. Can be START, END, ORDER, ENTER, FILL, or HIDE.  | 
**Structuredsig** | [**Dosage**](Dosage.md) |  | [optional] 
**Medicationentryid** | **string** | Primary ID for this medication entry. Those starting with C are clinical prescriptions, and those starting with H are historical (entered, downloaded, etc).  | [optional] 
**Medicationid** | **int?** | Athena ID for this medication. | 
**_Medication** | **string** | The name of the medication. | [optional] 
**Isstructuredsig** | **bool?** | Whether the sig for this entry is structured. | [optional] 
**Unstructuredsig** | **string** | The unstructured sig for this medication, if any. If there is a structured sig, this will contain the formatted version of that sig.  | [optional] 
**Source** | **string** | How this medication was entered. This can be the ordering provider, a medication history download (express scripts, medco, etc),  ATHENA (which means it was entered manually), etc.  | [optional] 
**Status** | **string** | The status of this medication. Medications in PEND status are associated with approved future orders and have not yet been submitted.  | [optional] 
**Organclass** | **string** | The organ class for this medication. This is equivalent to a medication class. | [optional] 
**Therapeuticclass** | **string** | The therapeutic class for this medication. This is equivalent to a medication subclass. | [optional] 
**Futuresubmitdate** | **string** | The date a medication will be submitted. Included if the medication is in PEND status and attached to a approved future order. | [optional] 
**Encounterid** | **int?** | If this was a prescription, this contains the ID of the encounter where it was ordered or administered | [optional] 
**Createdby** | **string** | The athenaNet username of the person who entered or ordered the medication. Downloaded medications have INTERFACE for this field.  | [optional] 
**Approvedby** | **string** | For clinical prescriptions, the athenaNet username of the person who approved this prescription. | [optional] 
**Billingndc** | **string** | The billing NDC code for this medication. | [optional] 
**Orderingmode** | **string** | The ordering mode for prescriptions. Can be PRESCRIBE, DISPENSE, or ADMINISTER. | [optional] 
**Quantity** | **int?** | The total quantity prescribed, dispensed, administered. This is not currently available for historical (downloaded) medications. | [optional] 
**Quantityunit** | **string** | The unit of the quantity. Example: tablets, sprays, etc.  | [optional] 
**Refillsallowed** | **int?** | The number of refills allowed when this medication was ordered. | [optional] 
**Issafetorenew** | **bool?** | Is this medication safe to renew? | [optional] 
**Stopreason** | **string** | The reason why this medication was stopped. | [optional] 
**Providernote** | **string** | Non-patient facing note for ths prescription. Labeled \&quot;internal note\&quot; in the UI. | [optional] 
**Patientnote** | **string** | Patient-facing note for this prescription. Labeled \&quot;note\&quot; in the UI. | [optional] 
**Pharmacy** | **string** | The name of the pharmacy where this medication was filled. | [optional] 
**Pharmacyncpdpid** | **string** | The NCPDP ID of the pharmacy for this medication.. See http://www.ncpdp.org/ for details. | [optional] 
**Prescribedby** | **string** | The user who prescribed this medication. | [optional] 
**Ndcoptions** | **string** | The list of NDC numbers that correspond to this medication. | [optional] 
**Rxnorm** | **List&lt;string&gt;** | The list of RxNorm Identifiers that correspond to this medication. This list may contain both branded and generic identifiers | [optional] 
**Route** | **string** | The route for the prescription. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

