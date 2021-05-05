# IO.Swagger.Model.PatientBalance
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Contracts** | [**List&lt;PatientBalanceContract&gt;**](PatientBalanceContract.md) | Information related to existing credit card contracts. | [optional] 
**Providergroupid** | **string** | Athena ID for this financial group. | [optional] 
**Departmentlist** | **string** | Comma separated list of department IDs that belong to this group | [optional] 
**Balance** | **string** | Balance for this provider group. | [optional] 
**Cleanbalance** | **bool?** | Indicates whether the balance is associated with a contract, payment plan, or collections agency. | [optional] 
**Collectionsbalance** | **string** | The outstanding amount associated with a collections agency. | [optional] 
**Paymentplanbalance** | **string** | The outstanding amount associated with a payment plan. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

