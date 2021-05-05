# IO.Swagger.Model.PatientEncounterOrder
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Declinedreason** | [**List&lt;Code&gt;**](Code.md) | List of codes indicating why the order was not given. If this field is not present, the order was not declined. If the array is empty, no reason has been chosen.  | [optional] 
**Contraindicationreason** | [**List&lt;Code&gt;**](Code.md) | List of codes indicating why the order was contraindicated (for vaccines only). If this field is not present, the order does not contain a contraindication reason.  | [optional] 
**Externalcodes** | [**List&lt;Code&gt;**](Code.md) | When available, contains how this order maps to external vocabularies like LOINC, CVX, SNOMED, RXNORM, etc.  | [optional] 
**Createduser** | **string** | The username of the person who created the order. | [optional] 
**Lastmodifiedby** | **string** | The username of the person who last modified the order. | [optional] 
**Lastmodifieddatetime** | **string** | The date this order was last modified. | [optional] 
**Orderid** | **int?** | The order (aka document) ID for this order. | [optional] 
**Declinedreasontext** | **string** | The user-facing description of the reason the order was not given. | [optional] 
**Description** | **string** | A human readable description for this order | [optional] 
**_Class** | **string** | The primary class of this order - - PRESCRIPTION, VACCINE, LAB, IMAGING, PATIENTINFO, etc.  | [optional] 
**Classdescription** | **string** | The human-readable description of this document class, including sub class (prescription - new vs. prescription - renewal).  | [optional] 
**Ordertypeid** | **int?** | The athena ID for this type of order. Can be used to create another order of this type. | [optional] 
**Ordertype** | **string** | The type of this order (Lab, Vaccine, etc.) | [optional] 
**Dateordered** | **string** | The timestamp when the order was created. | [optional] 
**Orderingprovider** | **string** | The username of the ordering provider, which is different than the ordering user - - who may be an intake nurse for example.  | [optional] 
**Assigneduser** | **string** | The username of the user who this order task is currently assigned to for further processing as needed. | [optional] 
**Priority** | **int?** | Priority of a order. | [optional] 
**Status** | **string** | The status the document is in (PEND, CLOSED, SUBMIT, SUBMITTED, etc).  | [optional] 
**Documentationonly** | **bool?** | If true, this order is here just as a record, and does not need to actually go out. | [optional] 
**Quantityvalue** | **string** | The dosage quantity value. | [optional] 
**Refills** | **string** | The number of refills allowed. | [optional] 
**Futuresubmitdate** | **string** | The date this order will be submitted. | [optional] 
**Ndc** | **string** | The National Drug Code for the order | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

