# IO.Swagger.Model.Dosage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Dosageaction** | **string** | How the medication is taken. Examples are Chew, Take, Inhale, etc. | 
**Dosagequantityvalue** | [**decimal?**](BigDecimal.md) | How many of this med is taken. | 
**Dosagequantityunit** | **string** | The unit of the quantity. Example: tablets, sprays, etc.  | 
**Dosagefrequencyvalue** | [**decimal?**](BigDecimal.md) | How many times (in the given time unit) this should be taken. | [optional] 
**Dosagefrequencyunit** | **string** | The unit of the frequency. Example: per day, per week.  | [optional] 
**Dosagefrequencydescription** | **string** | A standardized patient-friendly frequency. Example: 6 per day becomes \&quot;every 4 hours\&quot;.  | [optional] 
**Dosageroute** | **string** | How this medication is taken. Example: oral, inhalation, intranasal, etc.  | [optional] 
**Dosageadditionalinstructions** | **string** | Additional instructions. Example: with meals  | [optional] 
**Dosagedurationvalue** | **int?** | How many duration time units this medication should be taken for. | [optional] 
**Dosagedurationunit** | **string** | The unit of the duration. Example: days. So take this for days.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

