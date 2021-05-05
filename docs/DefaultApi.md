# IO.Swagger.Api.DefaultApi

All URIs are relative to *https://api.platform.athenahealth.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddEncounterAssesmentText**](DefaultApi.md#addencounterassesmenttext) | **PUT** /{apivariant}/{practiceid}/chart/encounter/{encounterid}/assessment | Append text to the assessment note
[**BookAppointmentById**](DefaultApi.md#bookappointmentbyid) | **PUT** /{apivariant}/{practiceid}/appointments/{appointmentId} | Set Information about a single patient&#x27;s appointment by id
[**CancelAppointmentById**](DefaultApi.md#cancelappointmentbyid) | **PUT** /{apivariant}/{practiceid}/appointments/{appointmentId}/cancel | Cancel an existing appointment.
[**CreateAppointmentType**](DefaultApi.md#createappointmenttype) | **POST** /{apivariant}/{practiceid}/appointmenttypes | Creates new appointment type
[**CreatePatient**](DefaultApi.md#createpatient) | **POST** /{apivariant}/{practiceid}/patients | Register new patient
[**CreatePatientLabResultDocument**](DefaultApi.md#createpatientlabresultdocument) | **POST** /{apivariant}/{practiceid}/patients/{patientId}/documents/labresult | Create single lab result
[**CreatePatientProblem**](DefaultApi.md#createpatientproblem) | **POST** /{apivariant}/{practiceid}/chart/{patientId}/problems | Adds problem to patient chart.
[**CreateProvider**](DefaultApi.md#createprovider) | **POST** /{apivariant}/{practiceid}/providers | Create new provider
[**DeleteAppointmentById**](DefaultApi.md#deleteappointmentbyid) | **DELETE** /{apivariant}/{practiceid}/appointments/{appointmentId} | Delete information about a single patient&#x27;s appointment by id. Only open appointments can be deleted.
[**DeleteePatientLabResultDocument**](DefaultApi.md#deleteepatientlabresultdocument) | **DELETE** /{apivariant}/{practiceid}/patients/{patientId}/documents/labresult/{labResultId} | Delete single lab result
[**GetAppointmentById**](DefaultApi.md#getappointmentbyid) | **GET** /{apivariant}/{practiceid}/appointments/{appointmentId} | Get Information about a single patient&#x27;s appointment by id
[**GetAppointmentTypes**](DefaultApi.md#getappointmenttypes) | **GET** /{apivariant}/{practiceid}/appointmenttypes | Get appointment types
[**GetBookedAppointments**](DefaultApi.md#getbookedappointments) | **GET** /{apivariant}/{practiceid}/appointments/booked | Get booked appointments
[**GetBookedAppointmentsFromMultipleDepartments**](DefaultApi.md#getbookedappointmentsfrommultipledepartments) | **GET** /{apivariant}/{practiceid}/appointments/booked/multipledepartment | Get booked appointments
[**GetClaims**](DefaultApi.md#getclaims) | **GET** /{apivariant}/{practiceid}/claims | Get claims
[**GetDepartments**](DefaultApi.md#getdepartments) | **GET** /{apivariant}/{practiceid}/departments | Get department IDs
[**GetEncounter**](DefaultApi.md#getencounter) | **GET** /{apivariant}/{practiceid}/chart/encounter/{encounterid} | Get encounter by id.
[**GetEncounterAssesmentText**](DefaultApi.md#getencounterassesmenttext) | **GET** /{apivariant}/{practiceid}/chart/encounter/{encounterid}/assessment | Given an encounter returns the assessment text.
[**GetOpenAppointments**](DefaultApi.md#getopenappointments) | **GET** /{apivariant}/{practiceid}/appointments/open | Get open appointment slots
[**GetPatientAnalytes**](DefaultApi.md#getpatientanalytes) | **GET** /{apivariant}/{practiceid}/chart/{patientId}/analytes | Get patient medical history
[**GetPatientById**](DefaultApi.md#getpatientbyid) | **GET** /{apivariant}/{practiceid}/patients/{patientId} | Get a patient by ID
[**GetPatientCcdaRecord**](DefaultApi.md#getpatientccdarecord) | **GET** /{apivariant}/{practiceid}/patients/{patientId}/ccda | Get a patient CCDA informtion by ID
[**GetPatientEncounterOrders**](DefaultApi.md#getpatientencounterorders) | **GET** /{apivariant}/{practiceid}/chart/encounter/{encounterid}/orders | Get encounters for the speicic patient.
[**GetPatientEncounters**](DefaultApi.md#getpatientencounters) | **GET** /{apivariant}/{practiceid}/chart/{patientId}/encounters | Get encounters for the speicic patient.
[**GetPatientLabResultDocument**](DefaultApi.md#getpatientlabresultdocument) | **GET** /{apivariant}/{practiceid}/patients/{patientId}/documents/labresult/{labResultId} | Get information about patient lab result document
[**GetPatientLabResultDocuments**](DefaultApi.md#getpatientlabresultdocuments) | **GET** /{apivariant}/{practiceid}/patients/{patientId}/documents/labresult | Get a patient lab results documents
[**GetPatientLabResults**](DefaultApi.md#getpatientlabresults) | **GET** /{apivariant}/{practiceid}/chart/{patientId}/labresults | Get patient medical history
[**GetPatientMedicalHistory**](DefaultApi.md#getpatientmedicalhistory) | **GET** /{apivariant}/{practiceid}/chart/{patientId}/medicalhistory | Get patient medical history
[**GetPatientMedications**](DefaultApi.md#getpatientmedications) | **GET** /{apivariant}/{practiceid}/chart/{patientId}/medications | Get patient medications
[**GetPatientProblems**](DefaultApi.md#getpatientproblems) | **GET** /{apivariant}/{practiceid}/chart/{patientId}/problems | Get patient medical history
[**GetPatientSocialHistory**](DefaultApi.md#getpatientsocialhistory) | **GET** /{apivariant}/{practiceid}/chart/{patientId}/socialhistory | List of social history data for this patient.
[**GetPatientSurgicalHistory**](DefaultApi.md#getpatientsurgicalhistory) | **GET** /{apivariant}/{practiceid}/chart/{patientId}/surgicalhistory | Get patient medical history
[**GetPatientVitals**](DefaultApi.md#getpatientvitals) | **GET** /{apivariant}/{practiceid}/chart/{patientId}/vitals | Get patient medical history
[**GetPatients**](DefaultApi.md#getpatients) | **GET** /{apivariant}/{practiceid}/patients | Search for patients
[**GetPracticeInfo**](DefaultApi.md#getpracticeinfo) | **GET** /{apivariant}/{practiceid}/practiceinfo | Get available practice IDs
[**GetProviderById**](DefaultApi.md#getproviderbyid) | **GET** /{apivariant}/{practiceid}/providers/{providerId} | Get a providers
[**GetProviders**](DefaultApi.md#getproviders) | **GET** /{apivariant}/{practiceid}/providers | Get a providers
[**OpenNewAppointment**](DefaultApi.md#opennewappointment) | **POST** /{apivariant}/{practiceid}/appointments/open | Provides the ability to add new open appointment slots

<a name="addencounterassesmenttext"></a>
# **AddEncounterAssesmentText**
> OperationStatusData AddEncounterAssesmentText (Body8 body, int? practiceid, string apivariant, int? encounterid)

Append text to the assessment note

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddEncounterAssesmentTextExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var body = new Body8(); // Body8 | 
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API
            var encounterid = 56;  // int? | The encounter ID.

            try
            {
                // Append text to the assessment note
                OperationStatusData result = apiInstance.AddEncounterAssesmentText(body, practiceid, apivariant, encounterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.AddEncounterAssesmentText: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body8**](Body8.md)|  | 
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 
 **encounterid** | **int?**| The encounter ID. | 

### Return type

[**OperationStatusData**](OperationStatusData.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="bookappointmentbyid"></a>
# **BookAppointmentById**
> AppointmentArray BookAppointmentById (int? patientid, int? appointmenttypeid, string bookingnote, int? departmentid, bool? donotsendconfirmationemail, bool? ignoreschedulablepermission, string insurancecompany, string insurancegroupid, string insuranceidnumber, string insurancenote, string insurancephone, string insuranceplanname, string insurancepolicyholder, bool? nopatientcase, int? reasonid, bool? urgentyn, int? practiceid, string apivariant, int? appointmentId)

Set Information about a single patient's appointment by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BookAppointmentByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var patientid = 56;  // int? | 
            var appointmenttypeid = 56;  // int? | 
            var bookingnote = bookingnote_example;  // string | 
            var departmentid = 56;  // int? | 
            var donotsendconfirmationemail = true;  // bool? | 
            var ignoreschedulablepermission = true;  // bool? | 
            var insurancecompany = insurancecompany_example;  // string | 
            var insurancegroupid = insurancegroupid_example;  // string | 
            var insuranceidnumber = insuranceidnumber_example;  // string | 
            var insurancenote = insurancenote_example;  // string | 
            var insurancephone = insurancephone_example;  // string | 
            var insuranceplanname = insuranceplanname_example;  // string | 
            var insurancepolicyholder = insurancepolicyholder_example;  // string | 
            var nopatientcase = true;  // bool? | 
            var reasonid = 56;  // int? | 
            var urgentyn = true;  // bool? | 
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API
            var appointmentId = 56;  // int? | Id of the appointment.

            try
            {
                // Set Information about a single patient's appointment by id
                AppointmentArray result = apiInstance.BookAppointmentById(patientid, appointmenttypeid, bookingnote, departmentid, donotsendconfirmationemail, ignoreschedulablepermission, insurancecompany, insurancegroupid, insuranceidnumber, insurancenote, insurancephone, insuranceplanname, insurancepolicyholder, nopatientcase, reasonid, urgentyn, practiceid, apivariant, appointmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.BookAppointmentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **patientid** | **int?**|  | 
 **appointmenttypeid** | **int?**|  | 
 **bookingnote** | **string**|  | 
 **departmentid** | **int?**|  | 
 **donotsendconfirmationemail** | **bool?**|  | 
 **ignoreschedulablepermission** | **bool?**|  | 
 **insurancecompany** | **string**|  | 
 **insurancegroupid** | **string**|  | 
 **insuranceidnumber** | **string**|  | 
 **insurancenote** | **string**|  | 
 **insurancephone** | **string**|  | 
 **insuranceplanname** | **string**|  | 
 **insurancepolicyholder** | **string**|  | 
 **nopatientcase** | **bool?**|  | 
 **reasonid** | **int?**|  | 
 **urgentyn** | **bool?**|  | 
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 
 **appointmentId** | **int?**| Id of the appointment. | 

### Return type

[**AppointmentArray**](AppointmentArray.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="cancelappointmentbyid"></a>
# **CancelAppointmentById**
> OperationStatusData CancelAppointmentById (int? patientid, int? appointmentcancelreasonid, string cancellationreason, int? departmentid, bool? ignoreschedulablepermission, bool? nopatientcase, int? practiceid, string apivariant, int? appointmentId)

Cancel an existing appointment.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CancelAppointmentByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var patientid = 56;  // int? | 
            var appointmentcancelreasonid = 56;  // int? | 
            var cancellationreason = cancellationreason_example;  // string | 
            var departmentid = 56;  // int? | 
            var ignoreschedulablepermission = true;  // bool? | 
            var nopatientcase = true;  // bool? | 
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API
            var appointmentId = 56;  // int? | Id of the appointment.

            try
            {
                // Cancel an existing appointment.
                OperationStatusData result = apiInstance.CancelAppointmentById(patientid, appointmentcancelreasonid, cancellationreason, departmentid, ignoreschedulablepermission, nopatientcase, practiceid, apivariant, appointmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CancelAppointmentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **patientid** | **int?**|  | 
 **appointmentcancelreasonid** | **int?**|  | 
 **cancellationreason** | **string**|  | 
 **departmentid** | **int?**|  | 
 **ignoreschedulablepermission** | **bool?**|  | 
 **nopatientcase** | **bool?**|  | 
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 
 **appointmentId** | **int?**| Id of the appointment. | 

### Return type

[**OperationStatusData**](OperationStatusData.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createappointmenttype"></a>
# **CreateAppointmentType**
> InlineResponse2001 CreateAppointmentType (int? duration, bool? generic, string name, bool? patient, string shortname, bool? templatetypeonly, int? practiceid, string apivariant)

Creates new appointment type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateAppointmentTypeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var duration = 56;  // int? | 
            var generic = true;  // bool? | 
            var name = name_example;  // string | 
            var patient = true;  // bool? | 
            var shortname = shortname_example;  // string | 
            var templatetypeonly = true;  // bool? | 
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API

            try
            {
                // Creates new appointment type
                InlineResponse2001 result = apiInstance.CreateAppointmentType(duration, generic, name, patient, shortname, templatetypeonly, practiceid, apivariant);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateAppointmentType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **duration** | **int?**|  | 
 **generic** | **bool?**|  | 
 **name** | **string**|  | 
 **patient** | **bool?**|  | 
 **shortname** | **string**|  | 
 **templatetypeonly** | **bool?**|  | 
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createpatient"></a>
# **CreatePatient**
> List<PatientCreatedResponse> CreatePatient (string address1, string address2, string city, int? departmentid, string dob, string email, string firstname, string homephone, string lastname, string mobilephone, string state, string zip, string sex, string race, int? practiceid, string apivariant)

Register new patient

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreatePatientExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var address1 = address1_example;  // string | 
            var address2 = address2_example;  // string | 
            var city = city_example;  // string | 
            var departmentid = 56;  // int? | 
            var dob = dob_example;  // string | 
            var email = email_example;  // string | 
            var firstname = firstname_example;  // string | 
            var homephone = homephone_example;  // string | 
            var lastname = lastname_example;  // string | 
            var mobilephone = mobilephone_example;  // string | 
            var state = state_example;  // string | 
            var zip = zip_example;  // string | 
            var sex = sex_example;  // string | 
            var race = race_example;  // string | 
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API

            try
            {
                // Register new patient
                List&lt;PatientCreatedResponse&gt; result = apiInstance.CreatePatient(address1, address2, city, departmentid, dob, email, firstname, homephone, lastname, mobilephone, state, zip, sex, race, practiceid, apivariant);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CreatePatient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address1** | **string**|  | 
 **address2** | **string**|  | 
 **city** | **string**|  | 
 **departmentid** | **int?**|  | 
 **dob** | **string**|  | 
 **email** | **string**|  | 
 **firstname** | **string**|  | 
 **homephone** | **string**|  | 
 **lastname** | **string**|  | 
 **mobilephone** | **string**|  | 
 **state** | **string**|  | 
 **zip** | **string**|  | 
 **sex** | **string**|  | 
 **race** | **string**|  | 
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 

### Return type

[**List<PatientCreatedResponse>**](PatientCreatedResponse.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createpatientlabresultdocument"></a>
# **CreatePatientLabResultDocument**
> CreateLabResultDocumentResponse CreatePatientLabResultDocument (string accessionid, string analytes, string attachmentcontents, string attachmenttype, string autoclose, int? departmentid, int? documenttypeid, int? facilityid, string internalnote, string interpretation, string observationdate, string observationtime, string priority, int? providerid, string reportstatus, string resultstatus, string specimenreceiveddatetime, string specimenreporteddatetime, int? tietoorderid, int? practiceid, string apivariant, int? patientId)

Create single lab result

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreatePatientLabResultDocumentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var accessionid = accessionid_example;  // string | 
            var analytes = analytes_example;  // string | 
            var attachmentcontents = attachmentcontents_example;  // string | 
            var attachmenttype = attachmenttype_example;  // string | 
            var autoclose = autoclose_example;  // string | 
            var departmentid = 56;  // int? | 
            var documenttypeid = 56;  // int? | 
            var facilityid = 56;  // int? | 
            var internalnote = internalnote_example;  // string | 
            var interpretation = interpretation_example;  // string | 
            var observationdate = observationdate_example;  // string | 
            var observationtime = observationtime_example;  // string | 
            var priority = priority_example;  // string | 
            var providerid = 56;  // int? | 
            var reportstatus = reportstatus_example;  // string | 
            var resultstatus = resultstatus_example;  // string | 
            var specimenreceiveddatetime = specimenreceiveddatetime_example;  // string | 
            var specimenreporteddatetime = specimenreporteddatetime_example;  // string | 
            var tietoorderid = 56;  // int? | 
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API
            var patientId = 56;  // int? | Id of the patient for which get information

            try
            {
                // Create single lab result
                CreateLabResultDocumentResponse result = apiInstance.CreatePatientLabResultDocument(accessionid, analytes, attachmentcontents, attachmenttype, autoclose, departmentid, documenttypeid, facilityid, internalnote, interpretation, observationdate, observationtime, priority, providerid, reportstatus, resultstatus, specimenreceiveddatetime, specimenreporteddatetime, tietoorderid, practiceid, apivariant, patientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CreatePatientLabResultDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessionid** | **string**|  | 
 **analytes** | **string**|  | 
 **attachmentcontents** | **string**|  | 
 **attachmenttype** | **string**|  | 
 **autoclose** | **string**|  | 
 **departmentid** | **int?**|  | 
 **documenttypeid** | **int?**|  | 
 **facilityid** | **int?**|  | 
 **internalnote** | **string**|  | 
 **interpretation** | **string**|  | 
 **observationdate** | **string**|  | 
 **observationtime** | **string**|  | 
 **priority** | **string**|  | 
 **providerid** | **int?**|  | 
 **reportstatus** | **string**|  | 
 **resultstatus** | **string**|  | 
 **specimenreceiveddatetime** | **string**|  | 
 **specimenreporteddatetime** | **string**|  | 
 **tietoorderid** | **int?**|  | 
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 
 **patientId** | **int?**| Id of the patient for which get information | 

### Return type

[**CreateLabResultDocumentResponse**](CreateLabResultDocumentResponse.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createpatientproblem"></a>
# **CreatePatientProblem**
> CreatePatientProblemResponse CreatePatientProblem (string status, string startdate, int? snomedcode, int? departmentid, string note, string laterality, int? practiceid, string apivariant, int? patientId)

Adds problem to patient chart.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreatePatientProblemExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var status = status_example;  // string | 
            var startdate = startdate_example;  // string | 
            var snomedcode = 56;  // int? | 
            var departmentid = 56;  // int? | 
            var note = note_example;  // string | 
            var laterality = laterality_example;  // string | 
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API
            var patientId = 56;  // int? | Id of the patient for which get medications

            try
            {
                // Adds problem to patient chart.
                CreatePatientProblemResponse result = apiInstance.CreatePatientProblem(status, startdate, snomedcode, departmentid, note, laterality, practiceid, apivariant, patientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CreatePatientProblem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **status** | **string**|  | 
 **startdate** | **string**|  | 
 **snomedcode** | **int?**|  | 
 **departmentid** | **int?**|  | 
 **note** | **string**|  | 
 **laterality** | **string**|  | 
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 
 **patientId** | **int?**| Id of the patient for which get medications | 

### Return type

[**CreatePatientProblemResponse**](CreatePatientProblemResponse.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createprovider"></a>
# **CreateProvider**
> ProviderCreatedResponse CreateProvider (string alternatephone, string ansicode, bool? billable, string billednamecase, string communicatordisplayname, int? communicatorhomedepartment, bool? crdreferring, bool? createencounteroncheckin, string directaddress, int? entitytypeid, string firstname, bool? hideinportal, string lastname, int? medicalgroupid, string middleinitial, string namesuffix, string ndctatnumber, long? npinumber, int? practiceroleid, int? providergroupid, string providerprofileid, string providertype, string reportingname, int? scheduleresourcetypeid, string schedulingname, string schedulingnote, string sex, bool? signatureonfileflag, string specialtyid, int? ssn, bool? staffbucket, int? supervisingproviderid, string supervisingprovidertype, bool? trackmissingslips, string username, int? practiceid, string apivariant)

Create new provider

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateProviderExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var alternatephone = alternatephone_example;  // string | 
            var ansicode = ansicode_example;  // string | 
            var billable = true;  // bool? | 
            var billednamecase = billednamecase_example;  // string | 
            var communicatordisplayname = communicatordisplayname_example;  // string | 
            var communicatorhomedepartment = 56;  // int? | 
            var crdreferring = true;  // bool? | 
            var createencounteroncheckin = true;  // bool? | 
            var directaddress = directaddress_example;  // string | 
            var entitytypeid = 56;  // int? | 
            var firstname = firstname_example;  // string | 
            var hideinportal = true;  // bool? | 
            var lastname = lastname_example;  // string | 
            var medicalgroupid = 56;  // int? | 
            var middleinitial = middleinitial_example;  // string | 
            var namesuffix = namesuffix_example;  // string | 
            var ndctatnumber = ndctatnumber_example;  // string | 
            var npinumber = 789;  // long? | 
            var practiceroleid = 56;  // int? | 
            var providergroupid = 56;  // int? | 
            var providerprofileid = providerprofileid_example;  // string | 
            var providertype = providertype_example;  // string | 
            var reportingname = reportingname_example;  // string | 
            var scheduleresourcetypeid = 56;  // int? | 
            var schedulingname = schedulingname_example;  // string | 
            var schedulingnote = schedulingnote_example;  // string | 
            var sex = sex_example;  // string | 
            var signatureonfileflag = true;  // bool? | 
            var specialtyid = specialtyid_example;  // string | 
            var ssn = 56;  // int? | 
            var staffbucket = true;  // bool? | 
            var supervisingproviderid = 56;  // int? | 
            var supervisingprovidertype = supervisingprovidertype_example;  // string | 
            var trackmissingslips = true;  // bool? | 
            var username = username_example;  // string | 
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API

            try
            {
                // Create new provider
                ProviderCreatedResponse result = apiInstance.CreateProvider(alternatephone, ansicode, billable, billednamecase, communicatordisplayname, communicatorhomedepartment, crdreferring, createencounteroncheckin, directaddress, entitytypeid, firstname, hideinportal, lastname, medicalgroupid, middleinitial, namesuffix, ndctatnumber, npinumber, practiceroleid, providergroupid, providerprofileid, providertype, reportingname, scheduleresourcetypeid, schedulingname, schedulingnote, sex, signatureonfileflag, specialtyid, ssn, staffbucket, supervisingproviderid, supervisingprovidertype, trackmissingslips, username, practiceid, apivariant);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateProvider: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **alternatephone** | **string**|  | 
 **ansicode** | **string**|  | 
 **billable** | **bool?**|  | 
 **billednamecase** | **string**|  | 
 **communicatordisplayname** | **string**|  | 
 **communicatorhomedepartment** | **int?**|  | 
 **crdreferring** | **bool?**|  | 
 **createencounteroncheckin** | **bool?**|  | 
 **directaddress** | **string**|  | 
 **entitytypeid** | **int?**|  | 
 **firstname** | **string**|  | 
 **hideinportal** | **bool?**|  | 
 **lastname** | **string**|  | 
 **medicalgroupid** | **int?**|  | 
 **middleinitial** | **string**|  | 
 **namesuffix** | **string**|  | 
 **ndctatnumber** | **string**|  | 
 **npinumber** | **long?**|  | 
 **practiceroleid** | **int?**|  | 
 **providergroupid** | **int?**|  | 
 **providerprofileid** | **string**|  | 
 **providertype** | **string**|  | 
 **reportingname** | **string**|  | 
 **scheduleresourcetypeid** | **int?**|  | 
 **schedulingname** | **string**|  | 
 **schedulingnote** | **string**|  | 
 **sex** | **string**|  | 
 **signatureonfileflag** | **bool?**|  | 
 **specialtyid** | **string**|  | 
 **ssn** | **int?**|  | 
 **staffbucket** | **bool?**|  | 
 **supervisingproviderid** | **int?**|  | 
 **supervisingprovidertype** | **string**|  | 
 **trackmissingslips** | **bool?**|  | 
 **username** | **string**|  | 
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 

### Return type

[**ProviderCreatedResponse**](ProviderCreatedResponse.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteappointmentbyid"></a>
# **DeleteAppointmentById**
> AppointmentIds DeleteAppointmentById (int? practiceid, string apivariant, int? appointmentId)

Delete information about a single patient's appointment by id. Only open appointments can be deleted.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAppointmentByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API
            var appointmentId = 56;  // int? | Id of the appointment.

            try
            {
                // Delete information about a single patient's appointment by id. Only open appointments can be deleted.
                AppointmentIds result = apiInstance.DeleteAppointmentById(practiceid, apivariant, appointmentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteAppointmentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 
 **appointmentId** | **int?**| Id of the appointment. | 

### Return type

[**AppointmentIds**](AppointmentIds.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteepatientlabresultdocument"></a>
# **DeleteePatientLabResultDocument**
> DeleteLabResultDocumentResponse DeleteePatientLabResultDocument (int? practiceid, string apivariant, int? patientId, int? labResultId)

Delete single lab result

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteePatientLabResultDocumentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API
            var patientId = 56;  // int? | Id of the patient for which get information
            var labResultId = 56;  // int? | Id of the lab result

            try
            {
                // Delete single lab result
                DeleteLabResultDocumentResponse result = apiInstance.DeleteePatientLabResultDocument(practiceid, apivariant, patientId, labResultId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteePatientLabResultDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 
 **patientId** | **int?**| Id of the patient for which get information | 
 **labResultId** | **int?**| Id of the lab result | 

### Return type

[**DeleteLabResultDocumentResponse**](DeleteLabResultDocumentResponse.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getappointmentbyid"></a>
# **GetAppointmentById**
> Appointment GetAppointmentById (int? practiceid, string apivariant, int? appointmentId, bool? ignorerestrictions = null, bool? showclaimdetail = null, bool? showcopay = null, bool? showexpectedprocedurecodes = null, bool? showinsurance = null, bool? showpatientdetail = null)

Get Information about a single patient's appointment by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAppointmentByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API
            var appointmentId = 56;  // int? | Id of the appointment.
            var ignorerestrictions = true;  // bool? | When showing patient detail for appointments, the patient information for patients with record restrictions and blocked patients will not be shown. Setting this flag to true will show that information for those patients.  (optional) 
            var showclaimdetail = true;  // bool? | Include claim information, if available, associated with an appointment.  (optional) 
            var showcopay = true;  // bool? | By default, the expected co-pay is returned. For performance purposes, you can set this to false and copay will not be populated.  (optional) 
            var showexpectedprocedurecodes = true;  // bool? | Show the expetcted procedurecodes. (optional) 
            var showinsurance = true;  // bool? | Include patient insurance information. Shows insurance packages for the appointment if any are selected, and all patient packages otherwise.  (optional) 
            var showpatientdetail = true;  // bool? | Include patient information for each patient associated with an appointment. (optional) 

            try
            {
                // Get Information about a single patient's appointment by id
                Appointment result = apiInstance.GetAppointmentById(practiceid, apivariant, appointmentId, ignorerestrictions, showclaimdetail, showcopay, showexpectedprocedurecodes, showinsurance, showpatientdetail);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAppointmentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 
 **appointmentId** | **int?**| Id of the appointment. | 
 **ignorerestrictions** | **bool?**| When showing patient detail for appointments, the patient information for patients with record restrictions and blocked patients will not be shown. Setting this flag to true will show that information for those patients.  | [optional] 
 **showclaimdetail** | **bool?**| Include claim information, if available, associated with an appointment.  | [optional] 
 **showcopay** | **bool?**| By default, the expected co-pay is returned. For performance purposes, you can set this to false and copay will not be populated.  | [optional] 
 **showexpectedprocedurecodes** | **bool?**| Show the expetcted procedurecodes. | [optional] 
 **showinsurance** | **bool?**| Include patient insurance information. Shows insurance packages for the appointment if any are selected, and all patient packages otherwise.  | [optional] 
 **showpatientdetail** | **bool?**| Include patient information for each patient associated with an appointment. | [optional] 

### Return type

[**Appointment**](Appointment.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getappointmenttypes"></a>
# **GetAppointmentTypes**
> AppointmentTypeList GetAppointmentTypes (int? practiceid, string apivariant, bool? hidegeneric = null, bool? hidenongeneric = null, bool? hidenonpatient = null, bool? hidetemplatetypeonly = null)

Get appointment types

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAppointmentTypesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API
            var hidegeneric = true;  // bool? | By default, we show both generic and non-generic types. Setting this to true will hide the generic types (and show only non-generic types). (optional) 
            var hidenongeneric = true;  // bool? | By default, we show both generic and non-generic types. Setting this to true will hide non-generic types (and show only generic types). (optional) 
            var hidenonpatient = true;  // bool? | This defaults to true if not specified, and thus will hide non-patient facing types. Setting this to false would thus show non-patient facing types. (optional) 
            var hidetemplatetypeonly = true;  // bool? | By default, we show both \"template only\" and not-template only types. Setting this to true, the results will omit template only types. (\"Template only\" is a setting that makes the type appear in schedules, but forces users to select a non-template type upon booking.) (optional) 

            try
            {
                // Get appointment types
                AppointmentTypeList result = apiInstance.GetAppointmentTypes(practiceid, apivariant, hidegeneric, hidenongeneric, hidenonpatient, hidetemplatetypeonly);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAppointmentTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 
 **hidegeneric** | **bool?**| By default, we show both generic and non-generic types. Setting this to true will hide the generic types (and show only non-generic types). | [optional] 
 **hidenongeneric** | **bool?**| By default, we show both generic and non-generic types. Setting this to true will hide non-generic types (and show only generic types). | [optional] 
 **hidenonpatient** | **bool?**| This defaults to true if not specified, and thus will hide non-patient facing types. Setting this to false would thus show non-patient facing types. | [optional] 
 **hidetemplatetypeonly** | **bool?**| By default, we show both \&quot;template only\&quot; and not-template only types. Setting this to true, the results will omit template only types. (\&quot;Template only\&quot; is a setting that makes the type appear in schedules, but forces users to select a non-template type upon booking.) | [optional] 

### Return type

[**AppointmentTypeList**](AppointmentTypeList.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getbookedappointments"></a>
# **GetBookedAppointments**
> AppointmentList GetBookedAppointments (int? practiceid, string apivariant, string appointmentstatus = null, int? appointmenttypeid = null, int? departmentid = null, string enddate = null, string endlastmodified = null, bool? ignorerestrictions = null, int? patientid = null, string providerid = null, string scheduledenddate = null, string scheduledstartdate = null, bool? showcancelled = null, bool? showclaimdetail = null, bool? showcopay = null, bool? showexpectedprocedurecodes = null, bool? showinsurance = null, bool? showpatientdetail = null, bool? showremindercalldetail = null, string startdate = null, string startlastmodified = null)

Get booked appointments

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBookedAppointmentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API
            var appointmentstatus = appointmentstatus_example;  // string | Filter appointments by status. (optional) 
            var appointmenttypeid = 56;  // int? | Filter by appointment type ID. (optional) 
            var departmentid = 56;  // int? | The athenaNet department ID. (optional) 
            var enddate = enddate_example;  // string | End of the appointment search date range (mm/dd/yyyy). Inclusive. (optional) 
            var endlastmodified = endlastmodified_example;  // string | Identify appointments modified prior to this date/time (mm/dd/yyyy hh:mi:ss). Inclusive. Note: This can only be used if a startlastmodified value is supplied as well.  (optional) 
            var ignorerestrictions = true;  // bool? | When showing patient detail for appointments, the patient information for patients with record restrictions and blocked patients will not be shown. Setting this flag to true will show that information for those patients.  (optional) 
            var patientid = 56;  // int? | The athenaNet patient ID. If operating in a Provider Group Enterprise practice, this should be the enterprise patient ID.  (optional) 
            var providerid = providerid_example;  // string | The athenaNet provider ID. Multiple IDs (either as a comma delimited list or multiple POSTed values) are allowed. (optional) 
            var scheduledenddate = scheduledenddate_example;  // string | End of the appointment scheduled search date range (mm/dd/yyyy). Inclusive. (optional) 
            var scheduledstartdate = scheduledstartdate_example;  // string | Start of the appointment scheduled search date range (mm/dd/yyyy). Inclusive. (optional) 
            var showcancelled = true;  // bool? | Include appointments that have been cancelled. (optional) 
            var showclaimdetail = true;  // bool? | Include claim information, if available, associated with an appointment.  (optional) 
            var showcopay = true;  // bool? | By default, the expected co-pay is returned. For performance purposes, you can set this to false and copay will not be populated.  (optional) 
            var showexpectedprocedurecodes = true;  // bool? | Show the expetcted procedurecodes. (optional) 
            var showinsurance = true;  // bool? | Include patient insurance information. Shows insurance packages for the appointment if any are selected, and all patient packages otherwise.  (optional) 
            var showpatientdetail = true;  // bool? | Include patient information for each patient associated with an appointment. (optional) 
            var showremindercalldetail = true;  // bool? | Include all remindercall related results, if available, associated with an appointment.  (optional) 
            var startdate = startdate_example;  // string | Start of the appointment search date range (mm/dd/yyyy). Inclusive. (optional) 
            var startlastmodified = startlastmodified_example;  // string | Identify appointments modified after this date/time (mm/dd/yyyy hh:mi:ss). Inclusive. (optional) 

            try
            {
                // Get booked appointments
                AppointmentList result = apiInstance.GetBookedAppointments(practiceid, apivariant, appointmentstatus, appointmenttypeid, departmentid, enddate, endlastmodified, ignorerestrictions, patientid, providerid, scheduledenddate, scheduledstartdate, showcancelled, showclaimdetail, showcopay, showexpectedprocedurecodes, showinsurance, showpatientdetail, showremindercalldetail, startdate, startlastmodified);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetBookedAppointments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 
 **appointmentstatus** | **string**| Filter appointments by status. | [optional] 
 **appointmenttypeid** | **int?**| Filter by appointment type ID. | [optional] 
 **departmentid** | **int?**| The athenaNet department ID. | [optional] 
 **enddate** | **string**| End of the appointment search date range (mm/dd/yyyy). Inclusive. | [optional] 
 **endlastmodified** | **string**| Identify appointments modified prior to this date/time (mm/dd/yyyy hh:mi:ss). Inclusive. Note: This can only be used if a startlastmodified value is supplied as well.  | [optional] 
 **ignorerestrictions** | **bool?**| When showing patient detail for appointments, the patient information for patients with record restrictions and blocked patients will not be shown. Setting this flag to true will show that information for those patients.  | [optional] 
 **patientid** | **int?**| The athenaNet patient ID. If operating in a Provider Group Enterprise practice, this should be the enterprise patient ID.  | [optional] 
 **providerid** | **string**| The athenaNet provider ID. Multiple IDs (either as a comma delimited list or multiple POSTed values) are allowed. | [optional] 
 **scheduledenddate** | **string**| End of the appointment scheduled search date range (mm/dd/yyyy). Inclusive. | [optional] 
 **scheduledstartdate** | **string**| Start of the appointment scheduled search date range (mm/dd/yyyy). Inclusive. | [optional] 
 **showcancelled** | **bool?**| Include appointments that have been cancelled. | [optional] 
 **showclaimdetail** | **bool?**| Include claim information, if available, associated with an appointment.  | [optional] 
 **showcopay** | **bool?**| By default, the expected co-pay is returned. For performance purposes, you can set this to false and copay will not be populated.  | [optional] 
 **showexpectedprocedurecodes** | **bool?**| Show the expetcted procedurecodes. | [optional] 
 **showinsurance** | **bool?**| Include patient insurance information. Shows insurance packages for the appointment if any are selected, and all patient packages otherwise.  | [optional] 
 **showpatientdetail** | **bool?**| Include patient information for each patient associated with an appointment. | [optional] 
 **showremindercalldetail** | **bool?**| Include all remindercall related results, if available, associated with an appointment.  | [optional] 
 **startdate** | **string**| Start of the appointment search date range (mm/dd/yyyy). Inclusive. | [optional] 
 **startlastmodified** | **string**| Identify appointments modified after this date/time (mm/dd/yyyy hh:mi:ss). Inclusive. | [optional] 

### Return type

[**AppointmentList**](AppointmentList.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getbookedappointmentsfrommultipledepartments"></a>
# **GetBookedAppointmentsFromMultipleDepartments**
> AppointmentList GetBookedAppointmentsFromMultipleDepartments (int? practiceid, string apivariant, string appointmentstatus = null, int? appointmenttypeid = null, string departmentid = null, string enddate = null, string endlastmodified = null, bool? ignorerestrictions = null, int? patientid = null, string providerid = null, string scheduledenddate = null, string scheduledstartdate = null, bool? showcancelled = null, bool? showclaimdetail = null, bool? showcopay = null, bool? showexpectedprocedurecodes = null, bool? showinsurance = null, bool? showpatientdetail = null, bool? showremindercalldetail = null, string startdate = null, string startlastmodified = null)

Get booked appointments

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBookedAppointmentsFromMultipleDepartmentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API
            var appointmentstatus = appointmentstatus_example;  // string | Filter appointments by status. (optional) 
            var appointmenttypeid = 56;  // int? | Filter by appointment type ID. (optional) 
            var departmentid = departmentid_example;  // string | The athenaNet department ID. Multiple IDs (either as a comma delimited list or multiple POSTed values) are allowed. (optional) 
            var enddate = enddate_example;  // string | End of the appointment search date range (mm/dd/yyyy). Inclusive. (optional) 
            var endlastmodified = endlastmodified_example;  // string | Identify appointments modified prior to this date/time (mm/dd/yyyy hh:mi:ss). Inclusive. Note: This can only be used if a startlastmodified value is supplied as well.  (optional) 
            var ignorerestrictions = true;  // bool? | When showing patient detail for appointments, the patient information for patients with record restrictions and blocked patients will not be shown. Setting this flag to true will show that information for those patients.  (optional) 
            var patientid = 56;  // int? | The athenaNet patient ID. If operating in a Provider Group Enterprise practice, this should be the enterprise patient ID.  (optional) 
            var providerid = providerid_example;  // string | The athenaNet provider ID. Multiple IDs (either as a comma delimited list or multiple POSTed values) are allowed. (optional) 
            var scheduledenddate = scheduledenddate_example;  // string | End of the appointment scheduled search date range (mm/dd/yyyy). Inclusive. (optional) 
            var scheduledstartdate = scheduledstartdate_example;  // string | Start of the appointment scheduled search date range (mm/dd/yyyy). Inclusive. (optional) 
            var showcancelled = true;  // bool? | Include appointments that have been cancelled. (optional) 
            var showclaimdetail = true;  // bool? | Include claim information, if available, associated with an appointment.  (optional) 
            var showcopay = true;  // bool? | By default, the expected co-pay is returned. For performance purposes, you can set this to false and copay will not be populated.  (optional) 
            var showexpectedprocedurecodes = true;  // bool? | Show the expetcted procedurecodes. (optional) 
            var showinsurance = true;  // bool? | Include patient insurance information. Shows insurance packages for the appointment if any are selected, and all patient packages otherwise.  (optional) 
            var showpatientdetail = true;  // bool? | Include patient information for each patient associated with an appointment. (optional) 
            var showremindercalldetail = true;  // bool? | Include all remindercall related results, if available, associated with an appointment.  (optional) 
            var startdate = startdate_example;  // string | Start of the appointment search date range (mm/dd/yyyy). Inclusive. (optional) 
            var startlastmodified = startlastmodified_example;  // string | Identify appointments modified after this date/time (mm/dd/yyyy hh:mi:ss). Inclusive. (optional) 

            try
            {
                // Get booked appointments
                AppointmentList result = apiInstance.GetBookedAppointmentsFromMultipleDepartments(practiceid, apivariant, appointmentstatus, appointmenttypeid, departmentid, enddate, endlastmodified, ignorerestrictions, patientid, providerid, scheduledenddate, scheduledstartdate, showcancelled, showclaimdetail, showcopay, showexpectedprocedurecodes, showinsurance, showpatientdetail, showremindercalldetail, startdate, startlastmodified);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetBookedAppointmentsFromMultipleDepartments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 
 **appointmentstatus** | **string**| Filter appointments by status. | [optional] 
 **appointmenttypeid** | **int?**| Filter by appointment type ID. | [optional] 
 **departmentid** | **string**| The athenaNet department ID. Multiple IDs (either as a comma delimited list or multiple POSTed values) are allowed. | [optional] 
 **enddate** | **string**| End of the appointment search date range (mm/dd/yyyy). Inclusive. | [optional] 
 **endlastmodified** | **string**| Identify appointments modified prior to this date/time (mm/dd/yyyy hh:mi:ss). Inclusive. Note: This can only be used if a startlastmodified value is supplied as well.  | [optional] 
 **ignorerestrictions** | **bool?**| When showing patient detail for appointments, the patient information for patients with record restrictions and blocked patients will not be shown. Setting this flag to true will show that information for those patients.  | [optional] 
 **patientid** | **int?**| The athenaNet patient ID. If operating in a Provider Group Enterprise practice, this should be the enterprise patient ID.  | [optional] 
 **providerid** | **string**| The athenaNet provider ID. Multiple IDs (either as a comma delimited list or multiple POSTed values) are allowed. | [optional] 
 **scheduledenddate** | **string**| End of the appointment scheduled search date range (mm/dd/yyyy). Inclusive. | [optional] 
 **scheduledstartdate** | **string**| Start of the appointment scheduled search date range (mm/dd/yyyy). Inclusive. | [optional] 
 **showcancelled** | **bool?**| Include appointments that have been cancelled. | [optional] 
 **showclaimdetail** | **bool?**| Include claim information, if available, associated with an appointment.  | [optional] 
 **showcopay** | **bool?**| By default, the expected co-pay is returned. For performance purposes, you can set this to false and copay will not be populated.  | [optional] 
 **showexpectedprocedurecodes** | **bool?**| Show the expetcted procedurecodes. | [optional] 
 **showinsurance** | **bool?**| Include patient insurance information. Shows insurance packages for the appointment if any are selected, and all patient packages otherwise.  | [optional] 
 **showpatientdetail** | **bool?**| Include patient information for each patient associated with an appointment. | [optional] 
 **showremindercalldetail** | **bool?**| Include all remindercall related results, if available, associated with an appointment.  | [optional] 
 **startdate** | **string**| Start of the appointment search date range (mm/dd/yyyy). Inclusive. | [optional] 
 **startlastmodified** | **string**| Identify appointments modified after this date/time (mm/dd/yyyy hh:mi:ss). Inclusive. | [optional] 

### Return type

[**AppointmentList**](AppointmentList.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getclaims"></a>
# **GetClaims**
> ClaimsList GetClaims (int? practiceid, string apivariant, int? appointmentid = null, int? providerid = null, int? departmentid = null, string createdenddate = null, string createdstartdate = null, int? patientid = null, string procedurecodes = null, string serviceenddate = null, string servicestartdate = null, bool? showcustomfields = null)

Get claims

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClaimsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API
            var appointmentid = 56;  // int? | One or more appointment IDs. (optional) 
            var providerid = 56;  // int? | Will match either the provider or the supervising provider. (optional) 
            var departmentid = 56;  // int? | The department ID of the service department for the claims being searched for. (optional) 
            var createdenddate = createdenddate_example;  // string | The claim creation date, end of range, inclusive. (optional) 
            var createdstartdate = createdstartdate_example;  // string | The claim creation date, start of range, inclusive. (optional) 
            var patientid = 56;  // int? | The patient ID associated with the claims to search for (optional) 
            var procedurecodes = procedurecodes_example;  // string | One or more procedure codes (optional) 
            var serviceenddate = serviceenddate_example;  // string | The service date, end of range, inclusive. (optional) 
            var servicestartdate = servicestartdate_example;  // string | The service date, start of range, inclusive. (optional) 
            var showcustomfields = true;  // bool? | Include custom fields for the claims. (optional) 

            try
            {
                // Get claims
                ClaimsList result = apiInstance.GetClaims(practiceid, apivariant, appointmentid, providerid, departmentid, createdenddate, createdstartdate, patientid, procedurecodes, serviceenddate, servicestartdate, showcustomfields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetClaims: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 
 **appointmentid** | **int?**| One or more appointment IDs. | [optional] 
 **providerid** | **int?**| Will match either the provider or the supervising provider. | [optional] 
 **departmentid** | **int?**| The department ID of the service department for the claims being searched for. | [optional] 
 **createdenddate** | **string**| The claim creation date, end of range, inclusive. | [optional] 
 **createdstartdate** | **string**| The claim creation date, start of range, inclusive. | [optional] 
 **patientid** | **int?**| The patient ID associated with the claims to search for | [optional] 
 **procedurecodes** | **string**| One or more procedure codes | [optional] 
 **serviceenddate** | **string**| The service date, end of range, inclusive. | [optional] 
 **servicestartdate** | **string**| The service date, start of range, inclusive. | [optional] 
 **showcustomfields** | **bool?**| Include custom fields for the claims. | [optional] 

### Return type

[**ClaimsList**](ClaimsList.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getdepartments"></a>
# **GetDepartments**
> DepartmentList GetDepartments (int? practiceid, string apivariant, int? limit = null, int? offset = null, bool? hospitalonly = null, bool? showalldepartments = null, bool? providerlist = null)

Get department IDs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDepartmentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API
            var limit = 56;  // int? | Number of entries to return (default 1500, max 5000) (optional) 
            var offset = 56;  // int? | Starting point of entries; 0-indexed (optional) 
            var hospitalonly = true;  // bool? | If set to true, return hospital only departments. (optional) 
            var showalldepartments = true;  // bool? | By default, departments hidden in the portal do not appear. When this is set to true, that restriction is not applied. Default is false. (optional) 
            var providerlist = true;  // bool? | If set to true, list providers who see patients in this department. Default is false. (optional) 

            try
            {
                // Get department IDs
                DepartmentList result = apiInstance.GetDepartments(practiceid, apivariant, limit, offset, hospitalonly, showalldepartments, providerlist);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetDepartments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 
 **limit** | **int?**| Number of entries to return (default 1500, max 5000) | [optional] 
 **offset** | **int?**| Starting point of entries; 0-indexed | [optional] 
 **hospitalonly** | **bool?**| If set to true, return hospital only departments. | [optional] 
 **showalldepartments** | **bool?**| By default, departments hidden in the portal do not appear. When this is set to true, that restriction is not applied. Default is false. | [optional] 
 **providerlist** | **bool?**| If set to true, list providers who see patients in this department. Default is false. | [optional] 

### Return type

[**DepartmentList**](DepartmentList.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getencounter"></a>
# **GetEncounter**
> List<Encounter> GetEncounter (int? practiceid, string apivariant, int? encounterid)

Get encounter by id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEncounterExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API
            var encounterid = 56;  // int? | The encounter ID.

            try
            {
                // Get encounter by id.
                List&lt;Encounter&gt; result = apiInstance.GetEncounter(practiceid, apivariant, encounterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetEncounter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 
 **encounterid** | **int?**| The encounter ID. | 

### Return type

[**List<Encounter>**](Encounter.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getencounterassesmenttext"></a>
# **GetEncounterAssesmentText**
> List<EncounterAssesmentText> GetEncounterAssesmentText (int? practiceid, string apivariant, int? encounterid)

Given an encounter returns the assessment text.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEncounterAssesmentTextExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API
            var encounterid = 56;  // int? | The encounter ID.

            try
            {
                // Given an encounter returns the assessment text.
                List&lt;EncounterAssesmentText&gt; result = apiInstance.GetEncounterAssesmentText(practiceid, apivariant, encounterid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetEncounterAssesmentText: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 
 **encounterid** | **int?**| The encounter ID. | 

### Return type

[**List<EncounterAssesmentText>**](EncounterAssesmentText.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getopenappointments"></a>
# **GetOpenAppointments**
> AppointmentList GetOpenAppointments (int? practiceid, string apivariant, int? appointmenttypeid = null, bool? bypassscheduletimechecks = null, int? departmentid = null, string enddate = null, bool? ignoreschedulablepermission = null, string providerid = null, string reasonid = null, bool? showfrozenslots = null, string startdate = null)

Get open appointment slots

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOpenAppointmentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API
            var appointmenttypeid = 56;  // int? | Normally, an appointment reason ID should be used which will map to the correct underlying appointment type in athenaNet. This field will ignore the practice's existing setup for what should be scheduled. Please consult with athenahealth before using. Either an appointmenttypeid or a reasonid must be specified or no results will be returned.  (optional) 
            var bypassscheduletimechecks = true;  // bool? | Bypass checks that usually require returned appointments to be some amount of hours in the future (as configured by the practice, defaulting to 24 hours), and also ignores the setting that only  shows appointments for a certain number of days in the future (also configurable by the practice, defaulting to 90 days).  (optional) 
            var departmentid = 56;  // int? | The athenaNet department ID. (optional) 
            var enddate = enddate_example;  // string | End of the appointment search date range (mm/dd/yyyy). Inclusive. Defaults to seven days from startdate. (optional) 
            var ignoreschedulablepermission = true;  // bool? | By default, we show only appointments that are are available to scheduled via the API. This flag allows you to bypass that restriction for viewing available appointments (but you still may not be able to schedule based on this permission!). This flag does not, however, show the full schedule (that is, appointments that are already booked).   (optional) 
            var providerid = providerid_example;  // string | The athenaNet provider ID. Required if a reasonid other than -1 is specified. (optional) 
            var reasonid = reasonid_example;  // string | The athenaNet patient appointment reason ID, from GET /patientappointmentreasons. While this is not technically required due to some unusual use cases, it is highly recommended for most calls. We do allow a special value of -1 for the reasonid. This reasonid will return open, web-schedulable slots regardless of reason. However, slots returned using a search of -1 may return slots that are not bookable by any reason ID (they may be bookable by specific appointment type IDs instead). This argument allows multiple valid reason IDs to be specified (e.g. reasonid=1,2,3), so if you are looking for slots that match \"any\" reason, it is recommended that you enumerate the set of reasons you are looking for. Either a reasonid or an appointmenttypeid must be specified or no results will be returned. If a reasonid other than -1 is specified then a providerid must also be specified.  (optional) 
            var showfrozenslots = true;  // bool? | By default, we hide appointments that are frozen from being returned via the API.  This flag allows you to show frozen slots in the set of results returned.  (optional) 
            var startdate = startdate_example;  // string | Start of the appointment search date range (mm/dd/yyyy). Inclusive. Defaults to today. (optional) 

            try
            {
                // Get open appointment slots
                AppointmentList result = apiInstance.GetOpenAppointments(practiceid, apivariant, appointmenttypeid, bypassscheduletimechecks, departmentid, enddate, ignoreschedulablepermission, providerid, reasonid, showfrozenslots, startdate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetOpenAppointments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 
 **appointmenttypeid** | **int?**| Normally, an appointment reason ID should be used which will map to the correct underlying appointment type in athenaNet. This field will ignore the practice&#x27;s existing setup for what should be scheduled. Please consult with athenahealth before using. Either an appointmenttypeid or a reasonid must be specified or no results will be returned.  | [optional] 
 **bypassscheduletimechecks** | **bool?**| Bypass checks that usually require returned appointments to be some amount of hours in the future (as configured by the practice, defaulting to 24 hours), and also ignores the setting that only  shows appointments for a certain number of days in the future (also configurable by the practice, defaulting to 90 days).  | [optional] 
 **departmentid** | **int?**| The athenaNet department ID. | [optional] 
 **enddate** | **string**| End of the appointment search date range (mm/dd/yyyy). Inclusive. Defaults to seven days from startdate. | [optional] 
 **ignoreschedulablepermission** | **bool?**| By default, we show only appointments that are are available to scheduled via the API. This flag allows you to bypass that restriction for viewing available appointments (but you still may not be able to schedule based on this permission!). This flag does not, however, show the full schedule (that is, appointments that are already booked).   | [optional] 
 **providerid** | **string**| The athenaNet provider ID. Required if a reasonid other than -1 is specified. | [optional] 
 **reasonid** | **string**| The athenaNet patient appointment reason ID, from GET /patientappointmentreasons. While this is not technically required due to some unusual use cases, it is highly recommended for most calls. We do allow a special value of -1 for the reasonid. This reasonid will return open, web-schedulable slots regardless of reason. However, slots returned using a search of -1 may return slots that are not bookable by any reason ID (they may be bookable by specific appointment type IDs instead). This argument allows multiple valid reason IDs to be specified (e.g. reasonid&#x3D;1,2,3), so if you are looking for slots that match \&quot;any\&quot; reason, it is recommended that you enumerate the set of reasons you are looking for. Either a reasonid or an appointmenttypeid must be specified or no results will be returned. If a reasonid other than -1 is specified then a providerid must also be specified.  | [optional] 
 **showfrozenslots** | **bool?**| By default, we hide appointments that are frozen from being returned via the API.  This flag allows you to show frozen slots in the set of results returned.  | [optional] 
 **startdate** | **string**| Start of the appointment search date range (mm/dd/yyyy). Inclusive. Defaults to today. | [optional] 

### Return type

[**AppointmentList**](AppointmentList.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpatientanalytes"></a>
# **GetPatientAnalytes**
> List<AnalytesList> GetPatientAnalytes (int? practiceid, string apivariant, int? patientId, int? departmentid, int? allresultsbyencounterid = null, string analyteresultstatus = null, string enddate = null, string labresultstatus = null, bool? showabnormaldetails = null, bool? showhidden = null, bool? showtemplate = null, string startdate = null)

Get patient medical history

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPatientAnalytesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API
            var patientId = 56;  // int? | Id of the patient for which get medications
            var departmentid = 56;  // int? | The athenanet department ID
            var allresultsbyencounterid = 56;  // int? | ID used to return lab results for a specific encounter. (optional) 
            var analyteresultstatus = analyteresultstatus_example;  // string | Filter the results based on the analyte's result status. Since the result status is a free text field, this list is not exhaustive, but does represent a majority of the used statuses.  (optional) 
            var enddate = enddate_example;  // string | Filter lab orders not individual results that are on or before this date. Example: enddate=1/21/2018. If no enddate is specified, all lab orders found since startdate will be included if specified.  (optional) 
            var labresultstatus = labresultstatus_example;  // string | Filter the results based on the lab result's result status. Since the result status is a free text field, this list is not exhaustive, but does represent a majority of the used statuses.  (optional) 
            var showabnormaldetails = true;  // bool? | Include the translation of the abnormalflag into HL7 code standards. (optional) 
            var showhidden = true;  // bool? | Includes the lab results and analytes marked as hidden. Hidden lab results and analytes are created when they are manually entered, for example on the qm tab or in flowsheets.  (optional) 
            var showtemplate = true;  // bool? | If true, interpretation template added to the document is also returned. (optional) 
            var startdate = startdate_example;  // string | Filter lab orders not individual results that are on or after this date. Example: startdate=6/21/2015. If no startdate is specified, all prior lab orders will be included until enddate if specified.  (optional) 

            try
            {
                // Get patient medical history
                List&lt;AnalytesList&gt; result = apiInstance.GetPatientAnalytes(practiceid, apivariant, patientId, departmentid, allresultsbyencounterid, analyteresultstatus, enddate, labresultstatus, showabnormaldetails, showhidden, showtemplate, startdate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetPatientAnalytes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 
 **patientId** | **int?**| Id of the patient for which get medications | 
 **departmentid** | **int?**| The athenanet department ID | 
 **allresultsbyencounterid** | **int?**| ID used to return lab results for a specific encounter. | [optional] 
 **analyteresultstatus** | **string**| Filter the results based on the analyte&#x27;s result status. Since the result status is a free text field, this list is not exhaustive, but does represent a majority of the used statuses.  | [optional] 
 **enddate** | **string**| Filter lab orders not individual results that are on or before this date. Example: enddate&#x3D;1/21/2018. If no enddate is specified, all lab orders found since startdate will be included if specified.  | [optional] 
 **labresultstatus** | **string**| Filter the results based on the lab result&#x27;s result status. Since the result status is a free text field, this list is not exhaustive, but does represent a majority of the used statuses.  | [optional] 
 **showabnormaldetails** | **bool?**| Include the translation of the abnormalflag into HL7 code standards. | [optional] 
 **showhidden** | **bool?**| Includes the lab results and analytes marked as hidden. Hidden lab results and analytes are created when they are manually entered, for example on the qm tab or in flowsheets.  | [optional] 
 **showtemplate** | **bool?**| If true, interpretation template added to the document is also returned. | [optional] 
 **startdate** | **string**| Filter lab orders not individual results that are on or after this date. Example: startdate&#x3D;6/21/2015. If no startdate is specified, all prior lab orders will be included until enddate if specified.  | [optional] 

### Return type

[**List<AnalytesList>**](AnalytesList.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpatientbyid"></a>
# **GetPatientById**
> List<Patient> GetPatientById (int? practiceid, string apivariant, int? patientId, int? departmentid = null, bool? ignorerestrictions = null, bool? show2015edcehrtvalues = null, bool? showallclaims = null, bool? showallpatientdepartmentstatus = null, bool? showbalancedetails = null, bool? showcustomfields = null, bool? showfullssn = null, bool? showinsurance = null, bool? showlocalpatientid = null, bool? showportalstatus = null)

Get a patient by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPatientByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API
            var patientId = 56;  // int? | Id of the patient for which get information
            var departmentid = 56;  // int? | This is the ID for the department of the patient you are retrieving. If you are calling this on an enterprise practice with multiple financial groups (also called \"provider groups\"), this  will ensure you are retrieving the correct patient and not a copy that is in a different department.  (optional) 
            var ignorerestrictions = true;  // bool? | Set to true to allow ability to find patients with record restrictions and blocked patients. This should only be used when there is no reflection to the patient at all that a match was found or not found.  (optional) 
            var show2015edcehrtvalues = true;  // bool? | Use 2015 Ed. CEHRT compliant strings for describing gender identity and sexual orientation. (optional) 
            var showallclaims = true;  // bool? | Include information on claims where there is no outstanding patient balance. (Only to be used when showbalancedetails is selected.)  (optional) 
            var showallpatientdepartmentstatus = true;  // bool? | Include an array of all departments the patient is a part of along with all statuses for those departments. (optional) 
            var showbalancedetails = true;  // bool? | Show detailed information on patient balances. (optional) 
            var showcustomfields = true;  // bool? | Include custom fields for the patient. (optional) 
            var showfullssn = true;  // bool? | If set, will show full SSN instead of a masked number. (optional) 
            var showinsurance = true;  // bool? | Include patient insurance information. (optional) 
            var showlocalpatientid = true;  // bool? | If set, will show local patient id. (optional) 
            var showportalstatus = true;  // bool? | If set, will include portal enrollment status in response. (optional) 

            try
            {
                // Get a patient by ID
                List&lt;Patient&gt; result = apiInstance.GetPatientById(practiceid, apivariant, patientId, departmentid, ignorerestrictions, show2015edcehrtvalues, showallclaims, showallpatientdepartmentstatus, showbalancedetails, showcustomfields, showfullssn, showinsurance, showlocalpatientid, showportalstatus);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetPatientById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 
 **patientId** | **int?**| Id of the patient for which get information | 
 **departmentid** | **int?**| This is the ID for the department of the patient you are retrieving. If you are calling this on an enterprise practice with multiple financial groups (also called \&quot;provider groups\&quot;), this  will ensure you are retrieving the correct patient and not a copy that is in a different department.  | [optional] 
 **ignorerestrictions** | **bool?**| Set to true to allow ability to find patients with record restrictions and blocked patients. This should only be used when there is no reflection to the patient at all that a match was found or not found.  | [optional] 
 **show2015edcehrtvalues** | **bool?**| Use 2015 Ed. CEHRT compliant strings for describing gender identity and sexual orientation. | [optional] 
 **showallclaims** | **bool?**| Include information on claims where there is no outstanding patient balance. (Only to be used when showbalancedetails is selected.)  | [optional] 
 **showallpatientdepartmentstatus** | **bool?**| Include an array of all departments the patient is a part of along with all statuses for those departments. | [optional] 
 **showbalancedetails** | **bool?**| Show detailed information on patient balances. | [optional] 
 **showcustomfields** | **bool?**| Include custom fields for the patient. | [optional] 
 **showfullssn** | **bool?**| If set, will show full SSN instead of a masked number. | [optional] 
 **showinsurance** | **bool?**| Include patient insurance information. | [optional] 
 **showlocalpatientid** | **bool?**| If set, will show local patient id. | [optional] 
 **showportalstatus** | **bool?**| If set, will include portal enrollment status in response. | [optional] 

### Return type

[**List<Patient>**](Patient.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpatientccdarecord"></a>
# **GetPatientCcdaRecord**
> List<PatientCcda> GetPatientCcdaRecord (int? practiceid, string apivariant, int? patientId)

Get a patient CCDA informtion by ID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPatientCcdaRecordExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API
            var patientId = 56;  // int? | Id of the patient for which get information

            try
            {
                // Get a patient CCDA informtion by ID
                List&lt;PatientCcda&gt; result = apiInstance.GetPatientCcdaRecord(practiceid, apivariant, patientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetPatientCcdaRecord: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 
 **patientId** | **int?**| Id of the patient for which get information | 

### Return type

[**List<PatientCcda>**](PatientCcda.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpatientencounterorders"></a>
# **GetPatientEncounterOrders**
> List<EncounterDiagnosesList> GetPatientEncounterOrders (int? practiceid, string apivariant, int? encounterid, bool? allowdischargetype = null, bool? showclinicalprovider = null, bool? showdeclinedorders = null, bool? showexternalcodes = null)

Get encounters for the speicic patient.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPatientEncounterOrdersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API
            var encounterid = 56;  // int? | The encounter ID.
            var allowdischargetype = true;  // bool? | If set, this will allow getting orders for a discharge encounter type. (optional) 
            var showclinicalprovider = true;  // bool? | If set, this will show the information about the provider receiving the order. (optional) 
            var showdeclinedorders = true;  // bool? | If set, include orders that were declined (optional) 
            var showexternalcodes = true;  // bool? | If set, translate the order information to relevant external vocabularies, where available. Examples are medictions to RxNorm and NDC, vaccines to CVX and MVX, labs to LOINC, etc. Our mappings are not exhaustive.  (optional) 

            try
            {
                // Get encounters for the speicic patient.
                List&lt;EncounterDiagnosesList&gt; result = apiInstance.GetPatientEncounterOrders(practiceid, apivariant, encounterid, allowdischargetype, showclinicalprovider, showdeclinedorders, showexternalcodes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetPatientEncounterOrders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 
 **encounterid** | **int?**| The encounter ID. | 
 **allowdischargetype** | **bool?**| If set, this will allow getting orders for a discharge encounter type. | [optional] 
 **showclinicalprovider** | **bool?**| If set, this will show the information about the provider receiving the order. | [optional] 
 **showdeclinedorders** | **bool?**| If set, include orders that were declined | [optional] 
 **showexternalcodes** | **bool?**| If set, translate the order information to relevant external vocabularies, where available. Examples are medictions to RxNorm and NDC, vaccines to CVX and MVX, labs to LOINC, etc. Our mappings are not exhaustive.  | [optional] 

### Return type

[**List<EncounterDiagnosesList>**](EncounterDiagnosesList.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpatientencounters"></a>
# **GetPatientEncounters**
> List<EncountersList> GetPatientEncounters (int? practiceid, string apivariant, int? patientId, int? departmentid, int? appointmentid = null, int? providerid = null, string enddate = null, string startdate = null, bool? showallstatuses = null, bool? showalltypes = null, bool? showdiagnoses = null)

Get encounters for the speicic patient.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPatientEncountersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API
            var patientId = 56;  // int? | Id of the patient for which get medications
            var departmentid = 56;  // int? | The department for this patient. A patient may have multiple charts, and the department determines which chart to retrieve. 
            var appointmentid = 56;  // int? | Find the encounter for this appointment. (optional) 
            var providerid = 56;  // int? | The ID of the provider for this encounter (optional) 
            var enddate = enddate_example;  // string | Omit any encounters later than this date (optional) 
            var startdate = startdate_example;  // string | Omit any encounters earlier than this date (optional) 
            var showallstatuses = true;  // bool? | By default only encounters in OPEN, CLOSED, or REVIEW status are retrieved, with this flag, encounters aren't filtered by status.  (optional) 
            var showalltypes = true;  // bool? | Retrieve all encounter types, by default only VISIT and ORDERSONLY are retrieved. (optional) 
            var showdiagnoses = true;  // bool? | Query diagnosis information for every encounter (optional) 

            try
            {
                // Get encounters for the speicic patient.
                List&lt;EncountersList&gt; result = apiInstance.GetPatientEncounters(practiceid, apivariant, patientId, departmentid, appointmentid, providerid, enddate, startdate, showallstatuses, showalltypes, showdiagnoses);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetPatientEncounters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 
 **patientId** | **int?**| Id of the patient for which get medications | 
 **departmentid** | **int?**| The department for this patient. A patient may have multiple charts, and the department determines which chart to retrieve.  | 
 **appointmentid** | **int?**| Find the encounter for this appointment. | [optional] 
 **providerid** | **int?**| The ID of the provider for this encounter | [optional] 
 **enddate** | **string**| Omit any encounters later than this date | [optional] 
 **startdate** | **string**| Omit any encounters earlier than this date | [optional] 
 **showallstatuses** | **bool?**| By default only encounters in OPEN, CLOSED, or REVIEW status are retrieved, with this flag, encounters aren&#x27;t filtered by status.  | [optional] 
 **showalltypes** | **bool?**| Retrieve all encounter types, by default only VISIT and ORDERSONLY are retrieved. | [optional] 
 **showdiagnoses** | **bool?**| Query diagnosis information for every encounter | [optional] 

### Return type

[**List<EncountersList>**](EncountersList.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpatientlabresultdocument"></a>
# **GetPatientLabResultDocument**
> List<PatientLabResultDocumentDetails> GetPatientLabResultDocument (int? practiceid, string apivariant, int? patientId, int? labResultId, bool? showtemplate = null)

Get information about patient lab result document

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPatientLabResultDocumentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API
            var patientId = 56;  // int? | Id of the patient for which get information
            var labResultId = 56;  // int? | Id of the lab result
            var showtemplate = true;  // bool? | If true, interpretation template added to the document is also returned.  (optional) 

            try
            {
                // Get information about patient lab result document
                List&lt;PatientLabResultDocumentDetails&gt; result = apiInstance.GetPatientLabResultDocument(practiceid, apivariant, patientId, labResultId, showtemplate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetPatientLabResultDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 
 **patientId** | **int?**| Id of the patient for which get information | 
 **labResultId** | **int?**| Id of the lab result | 
 **showtemplate** | **bool?**| If true, interpretation template added to the document is also returned.  | [optional] 

### Return type

[**List<PatientLabResultDocumentDetails>**](PatientLabResultDocumentDetails.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpatientlabresultdocuments"></a>
# **GetPatientLabResultDocuments**
> PatientLabResultDocumentList GetPatientLabResultDocuments (int? practiceid, string apivariant, int? patientId, int? departmentid = null, string documentsubclass = null, int? encounterid = null, bool? showdeleted = null, bool? showtemplate = null, string status = null)

Get a patient lab results documents

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPatientLabResultDocumentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API
            var patientId = 56;  // int? | Id of the patient for which get information
            var departmentid = 56;  // int? | The athenaNet department id.  (optional) 
            var documentsubclass = documentsubclass_example;  // string | The document subclass to filter document results.  (optional) 
            var encounterid = 56;  // int? | Show only documents attached to this encounter.  (optional) 
            var showdeleted = true;  // bool? | The document subclass to filter document results.  (optional) 
            var showtemplate = true;  // bool? | If true, interpretation template added to the document is also returned.  (optional) 
            var status = status_example;  // string | The status of the task to filter document results.  (optional) 

            try
            {
                // Get a patient lab results documents
                PatientLabResultDocumentList result = apiInstance.GetPatientLabResultDocuments(practiceid, apivariant, patientId, departmentid, documentsubclass, encounterid, showdeleted, showtemplate, status);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetPatientLabResultDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 
 **patientId** | **int?**| Id of the patient for which get information | 
 **departmentid** | **int?**| The athenaNet department id.  | [optional] 
 **documentsubclass** | **string**| The document subclass to filter document results.  | [optional] 
 **encounterid** | **int?**| Show only documents attached to this encounter.  | [optional] 
 **showdeleted** | **bool?**| The document subclass to filter document results.  | [optional] 
 **showtemplate** | **bool?**| If true, interpretation template added to the document is also returned.  | [optional] 
 **status** | **string**| The status of the task to filter document results.  | [optional] 

### Return type

[**PatientLabResultDocumentList**](PatientLabResultDocumentList.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpatientlabresults"></a>
# **GetPatientLabResults**
> LabResultList GetPatientLabResults (int? practiceid, string apivariant, int? patientId, int? departmentid, int? allresultsbyencounterid = null, string analyteresultstatus = null, string enddate = null, string labresultstatus = null, bool? showabnormaldetails = null, bool? showhidden = null, bool? showtemplate = null, string startdate = null)

Get patient medical history

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPatientLabResultsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API
            var patientId = 56;  // int? | Id of the patient for which get medications
            var departmentid = 56;  // int? | The athenanet department ID
            var allresultsbyencounterid = 56;  // int? | ID used to return lab results for a specific encounter. (optional) 
            var analyteresultstatus = analyteresultstatus_example;  // string | Filter the results based on the analyte's result status. Since the result status is a free text field, this list is not exhaustive, but does represent a majority of the used statuses.  (optional) 
            var enddate = enddate_example;  // string | Filter lab orders not individual results that are on or before this date. Example: enddate=1/21/2018. If no enddate is specified, all lab orders found since startdate will be included if specified.  (optional) 
            var labresultstatus = labresultstatus_example;  // string | Filter the results based on the lab result's result status. Since the result status is a free text field, this list is not exhaustive, but does represent a majority of the used statuses.  (optional) 
            var showabnormaldetails = true;  // bool? | Include the translation of the abnormalflag into HL7 code standards. (optional) 
            var showhidden = true;  // bool? | Includes the lab results and analytes marked as hidden. Hidden lab results and analytes are created when they are manually entered, for example on the qm tab or in flowsheets.  (optional) 
            var showtemplate = true;  // bool? | If true, interpretation template added to the document is also returned. (optional) 
            var startdate = startdate_example;  // string | Filter lab orders not individual results that are on or after this date. Example: startdate=6/21/2015. If no startdate is specified, all prior lab orders will be included until enddate if specified.  (optional) 

            try
            {
                // Get patient medical history
                LabResultList result = apiInstance.GetPatientLabResults(practiceid, apivariant, patientId, departmentid, allresultsbyencounterid, analyteresultstatus, enddate, labresultstatus, showabnormaldetails, showhidden, showtemplate, startdate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetPatientLabResults: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 
 **patientId** | **int?**| Id of the patient for which get medications | 
 **departmentid** | **int?**| The athenanet department ID | 
 **allresultsbyencounterid** | **int?**| ID used to return lab results for a specific encounter. | [optional] 
 **analyteresultstatus** | **string**| Filter the results based on the analyte&#x27;s result status. Since the result status is a free text field, this list is not exhaustive, but does represent a majority of the used statuses.  | [optional] 
 **enddate** | **string**| Filter lab orders not individual results that are on or before this date. Example: enddate&#x3D;1/21/2018. If no enddate is specified, all lab orders found since startdate will be included if specified.  | [optional] 
 **labresultstatus** | **string**| Filter the results based on the lab result&#x27;s result status. Since the result status is a free text field, this list is not exhaustive, but does represent a majority of the used statuses.  | [optional] 
 **showabnormaldetails** | **bool?**| Include the translation of the abnormalflag into HL7 code standards. | [optional] 
 **showhidden** | **bool?**| Includes the lab results and analytes marked as hidden. Hidden lab results and analytes are created when they are manually entered, for example on the qm tab or in flowsheets.  | [optional] 
 **showtemplate** | **bool?**| If true, interpretation template added to the document is also returned. | [optional] 
 **startdate** | **string**| Filter lab orders not individual results that are on or after this date. Example: startdate&#x3D;6/21/2015. If no startdate is specified, all prior lab orders will be included until enddate if specified.  | [optional] 

### Return type

[**LabResultList**](LabResultList.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpatientmedicalhistory"></a>
# **GetPatientMedicalHistory**
> PatientMedicalHistory GetPatientMedicalHistory (int? practiceid, string apivariant, int? patientId, int? departmentid)

Get patient medical history

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPatientMedicalHistoryExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API
            var patientId = 56;  // int? | Id of the patient for which get medications
            var departmentid = 56;  // int? | The athenanet department ID

            try
            {
                // Get patient medical history
                PatientMedicalHistory result = apiInstance.GetPatientMedicalHistory(practiceid, apivariant, patientId, departmentid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetPatientMedicalHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 
 **patientId** | **int?**| Id of the patient for which get medications | 
 **departmentid** | **int?**| The athenanet department ID | 

### Return type

[**PatientMedicalHistory**](PatientMedicalHistory.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpatientmedications"></a>
# **GetPatientMedications**
> PatientMedication GetPatientMedications (int? practiceid, string apivariant, int? patientId, int? departmentid, string medicationtype = null, bool? showndc = null, bool? showpend = null, bool? showrxnorm = null)

Get patient medications

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPatientMedicationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API
            var patientId = 56;  // int? | Id of the patient for which get medications
            var departmentid = 56;  // int? | The athenanet department ID
            var medicationtype = medicationtype_example;  // string | Historical or Active or Denied. Will return a list of a patient's active or historical or denied medications. (optional) 
            var showndc = true;  // bool? | Shows the list of NDC numbers related to the medication. (optional) 
            var showpend = true;  // bool? | Include pending medications associated with approved future orders. These medications have not yet been submitted. (optional) 
            var showrxnorm = true;  // bool? | Shows the list of RxNorm Identifiers related to the medication. The list may contain both branded and generic identifiers. (optional) 

            try
            {
                // Get patient medications
                PatientMedication result = apiInstance.GetPatientMedications(practiceid, apivariant, patientId, departmentid, medicationtype, showndc, showpend, showrxnorm);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetPatientMedications: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 
 **patientId** | **int?**| Id of the patient for which get medications | 
 **departmentid** | **int?**| The athenanet department ID | 
 **medicationtype** | **string**| Historical or Active or Denied. Will return a list of a patient&#x27;s active or historical or denied medications. | [optional] 
 **showndc** | **bool?**| Shows the list of NDC numbers related to the medication. | [optional] 
 **showpend** | **bool?**| Include pending medications associated with approved future orders. These medications have not yet been submitted. | [optional] 
 **showrxnorm** | **bool?**| Shows the list of RxNorm Identifiers related to the medication. The list may contain both branded and generic identifiers. | [optional] 

### Return type

[**PatientMedication**](PatientMedication.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpatientproblems"></a>
# **GetPatientProblems**
> ProblemsList GetPatientProblems (int? practiceid, string apivariant, int? patientId, int? departmentid, bool? showdiagnosisinfo = null, bool? showinactive = null)

Get patient medical history

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPatientProblemsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API
            var patientId = 56;  // int? | Id of the patient for which get medications
            var departmentid = 56;  // int? | The department for this patient. A patient may have multiple charts, and the department determines which chart to retrieve. 
            var showdiagnosisinfo = true;  // bool? | If true, will include every encounter and associated diagnosis with each problem.  Also fills the bestmatchicd10code field with the best conversion from the problem SNOMED  code to ICD10 code if there is no user-selected ICD10 code in an encounter diagnosis event. Please note that the bestmatchicd10code may not always be accurate.  (optional) 
            var showinactive = true;  // bool? | Also show inactive (but not soft deleted) problems. (optional) 

            try
            {
                // Get patient medical history
                ProblemsList result = apiInstance.GetPatientProblems(practiceid, apivariant, patientId, departmentid, showdiagnosisinfo, showinactive);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetPatientProblems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 
 **patientId** | **int?**| Id of the patient for which get medications | 
 **departmentid** | **int?**| The department for this patient. A patient may have multiple charts, and the department determines which chart to retrieve.  | 
 **showdiagnosisinfo** | **bool?**| If true, will include every encounter and associated diagnosis with each problem.  Also fills the bestmatchicd10code field with the best conversion from the problem SNOMED  code to ICD10 code if there is no user-selected ICD10 code in an encounter diagnosis event. Please note that the bestmatchicd10code may not always be accurate.  | [optional] 
 **showinactive** | **bool?**| Also show inactive (but not soft deleted) problems. | [optional] 

### Return type

[**ProblemsList**](ProblemsList.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpatientsocialhistory"></a>
# **GetPatientSocialHistory**
> SocialHistoryList GetPatientSocialHistory (int? practiceid, string apivariant, int? patientId, int? departmentid, string recipientcategory = null, bool? shownotperformedquestions = null, bool? showunansweredquestions = null)

List of social history data for this patient.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPatientSocialHistoryExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API
            var patientId = 56;  // int? | Id of the patient for which get medications
            var departmentid = 56;  // int? | The department for this patient. A patient may have multiple charts, and the department determines which chart to retrieve. 
            var recipientcategory = recipientcategory_example;  // string | The intended audience for the data. If given, questions marked as confidential for this audience will be withheld.   (optional) 
            var shownotperformedquestions = true;  // bool? | Include questions that the provider did not perform. (optional) 
            var showunansweredquestions = true;  // bool? | Include questions where there is no current answer. (optional) 

            try
            {
                // List of social history data for this patient.
                SocialHistoryList result = apiInstance.GetPatientSocialHistory(practiceid, apivariant, patientId, departmentid, recipientcategory, shownotperformedquestions, showunansweredquestions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetPatientSocialHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 
 **patientId** | **int?**| Id of the patient for which get medications | 
 **departmentid** | **int?**| The department for this patient. A patient may have multiple charts, and the department determines which chart to retrieve.  | 
 **recipientcategory** | **string**| The intended audience for the data. If given, questions marked as confidential for this audience will be withheld.   | [optional] 
 **shownotperformedquestions** | **bool?**| Include questions that the provider did not perform. | [optional] 
 **showunansweredquestions** | **bool?**| Include questions where there is no current answer. | [optional] 

### Return type

[**SocialHistoryList**](SocialHistoryList.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpatientsurgicalhistory"></a>
# **GetPatientSurgicalHistory**
> ProceduresList GetPatientSurgicalHistory (int? practiceid, string apivariant, int? patientId, int? departmentid)

Get patient medical history

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPatientSurgicalHistoryExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API
            var patientId = 56;  // int? | Id of the patient for which get medications
            var departmentid = 56;  // int? | The department for this patient. A patient may have multiple charts, and the department determines which chart to retrieve. 

            try
            {
                // Get patient medical history
                ProceduresList result = apiInstance.GetPatientSurgicalHistory(practiceid, apivariant, patientId, departmentid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetPatientSurgicalHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 
 **patientId** | **int?**| Id of the patient for which get medications | 
 **departmentid** | **int?**| The department for this patient. A patient may have multiple charts, and the department determines which chart to retrieve.  | 

### Return type

[**ProceduresList**](ProceduresList.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpatientvitals"></a>
# **GetPatientVitals**
> VitalsList GetPatientVitals (int? practiceid, string apivariant, int? patientId, int? departmentid, string enddate = null, bool? showemptyvitals = null, string startdate = null)

Get patient medical history

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPatientVitalsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API
            var patientId = 56;  // int? | Id of the patient for which get medications
            var departmentid = 56;  // int? | The department for this patient. A patient may have multiple charts, and the department determines which chart to retrieve. 
            var enddate = enddate_example;  // string | Only retrieve vitals that were taking on or before this date  (optional) 
            var showemptyvitals = true;  // bool? | Show configured vitals that have no readings for this patient. (optional) 
            var startdate = startdate_example;  // string | Only retrieve vitals that were taking on or after this date  (optional) 

            try
            {
                // Get patient medical history
                VitalsList result = apiInstance.GetPatientVitals(practiceid, apivariant, patientId, departmentid, enddate, showemptyvitals, startdate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetPatientVitals: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 
 **patientId** | **int?**| Id of the patient for which get medications | 
 **departmentid** | **int?**| The department for this patient. A patient may have multiple charts, and the department determines which chart to retrieve.  | 
 **enddate** | **string**| Only retrieve vitals that were taking on or before this date  | [optional] 
 **showemptyvitals** | **bool?**| Show configured vitals that have no readings for this patient. | [optional] 
 **startdate** | **string**| Only retrieve vitals that were taking on or after this date  | [optional] 

### Return type

[**VitalsList**](VitalsList.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpatients"></a>
# **GetPatients**
> PatientList GetPatients (int? practiceid, string apivariant, int? departmentid = null, string firstname = null, string lastname = null)

Search for patients

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPatientsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API
            var departmentid = 56;  // int? | Primary (registration) department ID. (optional) 
            var firstname = firstname_example;  // string | First name of the patient to find. (optional) 
            var lastname = lastname_example;  // string | Last name of the patient to find. (optional) 

            try
            {
                // Search for patients
                PatientList result = apiInstance.GetPatients(practiceid, apivariant, departmentid, firstname, lastname);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetPatients: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 
 **departmentid** | **int?**| Primary (registration) department ID. | [optional] 
 **firstname** | **string**| First name of the patient to find. | [optional] 
 **lastname** | **string**| Last name of the patient to find. | [optional] 

### Return type

[**PatientList**](PatientList.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpracticeinfo"></a>
# **GetPracticeInfo**
> PracticeList GetPracticeInfo (int? practiceid, string apivariant, int? limit = null, int? offset = null)

Get available practice IDs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPracticeInfoExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API
            var limit = 56;  // int? | Number of entries to return (default 1500, max 5000) (optional) 
            var offset = 56;  // int? | Starting point of entries; 0-indexed (optional) 

            try
            {
                // Get available practice IDs
                PracticeList result = apiInstance.GetPracticeInfo(practiceid, apivariant, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetPracticeInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 
 **limit** | **int?**| Number of entries to return (default 1500, max 5000) | [optional] 
 **offset** | **int?**| Starting point of entries; 0-indexed | [optional] 

### Return type

[**PracticeList**](PracticeList.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getproviderbyid"></a>
# **GetProviderById**
> List<Provider> GetProviderById (int? practiceid, string apivariant, int? providerId, bool? showallproviderids = null, int? showfederalidnumber = null, decimal? showusualdepartmentguessthreshold = null)

Get a providers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProviderByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API
            var providerId = 56;  // int? | Id of the provider for which get information
            var showallproviderids = true;  // bool? | In athenaNet's internal data structures, a single provider can be represented by multiple IDs. These IDs are used in certain external messages (e.g. HL7) and thus these IDs may need to be known by the API user as well. When set to true, a list of all of these ancillary IDs will be provided.  (optional) 
            var showfederalidnumber = 56;  // int? | Include the provider's federal ID number in results.  (optional) 
            var showusualdepartmentguessthreshold = 1.2;  // decimal? | There are situations where determining where a provider \"normally\" practices is desired. Unfortuantely, there is no such concept in athenaNet since providers often practice in multiple locations. However, we can use some intelligence to determine this by looking back over the previous few months (90 days) to see actual practice. To enable this, set this value between 0 and 1; it is highly recommended to be at least .5. This is the ratio of appointments in a given department to the total number of appointments for that provider. A value of .5 means \"the provider's appointments are 50% in the department guessed.\" Setting this to 1 would only return a department if ALL of the provider's appointments were in one department.  (optional) 

            try
            {
                // Get a providers
                List&lt;Provider&gt; result = apiInstance.GetProviderById(practiceid, apivariant, providerId, showallproviderids, showfederalidnumber, showusualdepartmentguessthreshold);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetProviderById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 
 **providerId** | **int?**| Id of the provider for which get information | 
 **showallproviderids** | **bool?**| In athenaNet&#x27;s internal data structures, a single provider can be represented by multiple IDs. These IDs are used in certain external messages (e.g. HL7) and thus these IDs may need to be known by the API user as well. When set to true, a list of all of these ancillary IDs will be provided.  | [optional] 
 **showfederalidnumber** | **int?**| Include the provider&#x27;s federal ID number in results.  | [optional] 
 **showusualdepartmentguessthreshold** | **decimal?**| There are situations where determining where a provider \&quot;normally\&quot; practices is desired. Unfortuantely, there is no such concept in athenaNet since providers often practice in multiple locations. However, we can use some intelligence to determine this by looking back over the previous few months (90 days) to see actual practice. To enable this, set this value between 0 and 1; it is highly recommended to be at least .5. This is the ratio of appointments in a given department to the total number of appointments for that provider. A value of .5 means \&quot;the provider&#x27;s appointments are 50% in the department guessed.\&quot; Setting this to 1 would only return a department if ALL of the provider&#x27;s appointments were in one department.  | [optional] 

### Return type

[**List<Provider>**](Provider.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getproviders"></a>
# **GetProviders**
> ProviderList GetProviders (int? practiceid, string apivariant, string name = null, string providertype = null, bool? showallproviderids = null, int? showusualdepartmentguessthreshold = null)

Get a providers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProvidersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API
            var name = name_example;  // string | Id of the patient for which get information (optional) 
            var providertype = providertype_example;  // string | The provider type to filter the results on. Valid provider type values can be found by using GET /reference/providertypes. (optional) 
            var showallproviderids = true;  // bool? | In athenaNet's internal data structures, a single provider can be represented by multiple IDs. These IDs are used in certain external messages (e.g. HL7) and thus these IDs may need to be known by the API user as well. When set to true, a list of all of these ancillary IDs will be provided.  (optional) 
            var showusualdepartmentguessthreshold = 56;  // int? | There are situations where determining where a provider \"normally\" practices is desired. Unfortuantely, there is no such concept in athenaNet since providers often practice in multiple locations. However, we can use some intelligence to determine this by looking back over the previous few months (90 days) to see actual practice. To enable this, set this value between 0 and 1; it is highly recommended to be at least .5. This is the ratio of appointments in a given department to the total number of appointments for that provider. A value of .5 means \"the provider's appointments are 50% in the department guessed.\" Setting this to 1 would only return a department if ALL of the provider's appointments were in one department.  (optional) 

            try
            {
                // Get a providers
                ProviderList result = apiInstance.GetProviders(practiceid, apivariant, name, providertype, showallproviderids, showusualdepartmentguessthreshold);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetProviders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 
 **name** | **string**| Id of the patient for which get information | [optional] 
 **providertype** | **string**| The provider type to filter the results on. Valid provider type values can be found by using GET /reference/providertypes. | [optional] 
 **showallproviderids** | **bool?**| In athenaNet&#x27;s internal data structures, a single provider can be represented by multiple IDs. These IDs are used in certain external messages (e.g. HL7) and thus these IDs may need to be known by the API user as well. When set to true, a list of all of these ancillary IDs will be provided.  | [optional] 
 **showusualdepartmentguessthreshold** | **int?**| There are situations where determining where a provider \&quot;normally\&quot; practices is desired. Unfortuantely, there is no such concept in athenaNet since providers often practice in multiple locations. However, we can use some intelligence to determine this by looking back over the previous few months (90 days) to see actual practice. To enable this, set this value between 0 and 1; it is highly recommended to be at least .5. This is the ratio of appointments in a given department to the total number of appointments for that provider. A value of .5 means \&quot;the provider&#x27;s appointments are 50% in the department guessed.\&quot; Setting this to 1 would only return a department if ALL of the provider&#x27;s appointments were in one department.  | [optional] 

### Return type

[**ProviderList**](ProviderList.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="opennewappointment"></a>
# **OpenNewAppointment**
> InlineResponse200 OpenNewAppointment (string appointmentdate, string appointmenttime, int? appointmenttypeid, int? departmentid, int? providerid, int? reasonid, int? practiceid, string apivariant)

Provides the ability to add new open appointment slots

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OpenNewAppointmentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: defaultSecurityScheme
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var appointmentdate = appointmentdate_example;  // string | 
            var appointmenttime = appointmenttime_example;  // string | 
            var appointmenttypeid = 56;  // int? | 
            var departmentid = 56;  // int? | 
            var providerid = 56;  // int? | 
            var reasonid = 56;  // int? | 
            var practiceid = 56;  // int? | Id of the practice
            var apivariant = apivariant_example;  // string | Variant of the API

            try
            {
                // Provides the ability to add new open appointment slots
                InlineResponse200 result = apiInstance.OpenNewAppointment(appointmentdate, appointmenttime, appointmenttypeid, departmentid, providerid, reasonid, practiceid, apivariant);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.OpenNewAppointment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appointmentdate** | **string**|  | 
 **appointmenttime** | **string**|  | 
 **appointmenttypeid** | **int?**|  | 
 **departmentid** | **int?**|  | 
 **providerid** | **int?**|  | 
 **reasonid** | **int?**|  | 
 **practiceid** | **int?**| Id of the practice | 
 **apivariant** | **string**| Variant of the API | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[defaultSecurityScheme](../README.md#defaultSecurityScheme)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
