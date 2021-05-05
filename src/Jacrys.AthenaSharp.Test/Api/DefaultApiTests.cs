/* 
 * athenahealth More Disruption Please (MDP) API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing DefaultApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DefaultApiTests
    {
        private DefaultApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DefaultApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DefaultApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DefaultApi
            //Assert.IsInstanceOfType(typeof(DefaultApi), instance, "instance is a DefaultApi");
        }

        /// <summary>
        /// Test AddEncounterAssesmentText
        /// </summary>
        [Test]
        public void AddEncounterAssesmentTextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Body8 body = null;
            //int? practiceid = null;
            //string apivariant = null;
            //int? encounterid = null;
            //var response = instance.AddEncounterAssesmentText(body, practiceid, apivariant, encounterid);
            //Assert.IsInstanceOf<OperationStatusData> (response, "response is OperationStatusData");
        }
        /// <summary>
        /// Test BookAppointmentById
        /// </summary>
        [Test]
        public void BookAppointmentByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? patientid = null;
            //int? appointmenttypeid = null;
            //string bookingnote = null;
            //int? departmentid = null;
            //bool? donotsendconfirmationemail = null;
            //bool? ignoreschedulablepermission = null;
            //string insurancecompany = null;
            //string insurancegroupid = null;
            //string insuranceidnumber = null;
            //string insurancenote = null;
            //string insurancephone = null;
            //string insuranceplanname = null;
            //string insurancepolicyholder = null;
            //bool? nopatientcase = null;
            //int? reasonid = null;
            //bool? urgentyn = null;
            //int? practiceid = null;
            //string apivariant = null;
            //int? appointmentId = null;
            //var response = instance.BookAppointmentById(patientid, appointmenttypeid, bookingnote, departmentid, donotsendconfirmationemail, ignoreschedulablepermission, insurancecompany, insurancegroupid, insuranceidnumber, insurancenote, insurancephone, insuranceplanname, insurancepolicyholder, nopatientcase, reasonid, urgentyn, practiceid, apivariant, appointmentId);
            //Assert.IsInstanceOf<AppointmentArray> (response, "response is AppointmentArray");
        }
        /// <summary>
        /// Test CancelAppointmentById
        /// </summary>
        [Test]
        public void CancelAppointmentByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? patientid = null;
            //int? appointmentcancelreasonid = null;
            //string cancellationreason = null;
            //int? departmentid = null;
            //bool? ignoreschedulablepermission = null;
            //bool? nopatientcase = null;
            //int? practiceid = null;
            //string apivariant = null;
            //int? appointmentId = null;
            //var response = instance.CancelAppointmentById(patientid, appointmentcancelreasonid, cancellationreason, departmentid, ignoreschedulablepermission, nopatientcase, practiceid, apivariant, appointmentId);
            //Assert.IsInstanceOf<OperationStatusData> (response, "response is OperationStatusData");
        }
        /// <summary>
        /// Test CreateAppointmentType
        /// </summary>
        [Test]
        public void CreateAppointmentTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? duration = null;
            //bool? generic = null;
            //string name = null;
            //bool? patient = null;
            //string shortname = null;
            //bool? templatetypeonly = null;
            //int? practiceid = null;
            //string apivariant = null;
            //var response = instance.CreateAppointmentType(duration, generic, name, patient, shortname, templatetypeonly, practiceid, apivariant);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        /// <summary>
        /// Test CreatePatient
        /// </summary>
        [Test]
        public void CreatePatientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address1 = null;
            //string address2 = null;
            //string city = null;
            //int? departmentid = null;
            //string dob = null;
            //string email = null;
            //string firstname = null;
            //string homephone = null;
            //string lastname = null;
            //string mobilephone = null;
            //string state = null;
            //string zip = null;
            //string sex = null;
            //string race = null;
            //int? practiceid = null;
            //string apivariant = null;
            //var response = instance.CreatePatient(address1, address2, city, departmentid, dob, email, firstname, homephone, lastname, mobilephone, state, zip, sex, race, practiceid, apivariant);
            //Assert.IsInstanceOf<List<PatientCreatedResponse>> (response, "response is List<PatientCreatedResponse>");
        }
        /// <summary>
        /// Test CreatePatientLabResultDocument
        /// </summary>
        [Test]
        public void CreatePatientLabResultDocumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accessionid = null;
            //string analytes = null;
            //string attachmentcontents = null;
            //string attachmenttype = null;
            //string autoclose = null;
            //int? departmentid = null;
            //int? documenttypeid = null;
            //int? facilityid = null;
            //string internalnote = null;
            //string interpretation = null;
            //string observationdate = null;
            //string observationtime = null;
            //string priority = null;
            //int? providerid = null;
            //string reportstatus = null;
            //string resultstatus = null;
            //string specimenreceiveddatetime = null;
            //string specimenreporteddatetime = null;
            //int? tietoorderid = null;
            //int? practiceid = null;
            //string apivariant = null;
            //int? patientId = null;
            //var response = instance.CreatePatientLabResultDocument(accessionid, analytes, attachmentcontents, attachmenttype, autoclose, departmentid, documenttypeid, facilityid, internalnote, interpretation, observationdate, observationtime, priority, providerid, reportstatus, resultstatus, specimenreceiveddatetime, specimenreporteddatetime, tietoorderid, practiceid, apivariant, patientId);
            //Assert.IsInstanceOf<CreateLabResultDocumentResponse> (response, "response is CreateLabResultDocumentResponse");
        }
        /// <summary>
        /// Test CreatePatientProblem
        /// </summary>
        [Test]
        public void CreatePatientProblemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string status = null;
            //string startdate = null;
            //int? snomedcode = null;
            //int? departmentid = null;
            //string note = null;
            //string laterality = null;
            //int? practiceid = null;
            //string apivariant = null;
            //int? patientId = null;
            //var response = instance.CreatePatientProblem(status, startdate, snomedcode, departmentid, note, laterality, practiceid, apivariant, patientId);
            //Assert.IsInstanceOf<CreatePatientProblemResponse> (response, "response is CreatePatientProblemResponse");
        }
        /// <summary>
        /// Test CreateProvider
        /// </summary>
        [Test]
        public void CreateProviderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string alternatephone = null;
            //string ansicode = null;
            //bool? billable = null;
            //string billednamecase = null;
            //string communicatordisplayname = null;
            //int? communicatorhomedepartment = null;
            //bool? crdreferring = null;
            //bool? createencounteroncheckin = null;
            //string directaddress = null;
            //int? entitytypeid = null;
            //string firstname = null;
            //bool? hideinportal = null;
            //string lastname = null;
            //int? medicalgroupid = null;
            //string middleinitial = null;
            //string namesuffix = null;
            //string ndctatnumber = null;
            //long? npinumber = null;
            //int? practiceroleid = null;
            //int? providergroupid = null;
            //string providerprofileid = null;
            //string providertype = null;
            //string reportingname = null;
            //int? scheduleresourcetypeid = null;
            //string schedulingname = null;
            //string schedulingnote = null;
            //string sex = null;
            //bool? signatureonfileflag = null;
            //string specialtyid = null;
            //int? ssn = null;
            //bool? staffbucket = null;
            //int? supervisingproviderid = null;
            //string supervisingprovidertype = null;
            //bool? trackmissingslips = null;
            //string username = null;
            //int? practiceid = null;
            //string apivariant = null;
            //var response = instance.CreateProvider(alternatephone, ansicode, billable, billednamecase, communicatordisplayname, communicatorhomedepartment, crdreferring, createencounteroncheckin, directaddress, entitytypeid, firstname, hideinportal, lastname, medicalgroupid, middleinitial, namesuffix, ndctatnumber, npinumber, practiceroleid, providergroupid, providerprofileid, providertype, reportingname, scheduleresourcetypeid, schedulingname, schedulingnote, sex, signatureonfileflag, specialtyid, ssn, staffbucket, supervisingproviderid, supervisingprovidertype, trackmissingslips, username, practiceid, apivariant);
            //Assert.IsInstanceOf<ProviderCreatedResponse> (response, "response is ProviderCreatedResponse");
        }
        /// <summary>
        /// Test DeleteAppointmentById
        /// </summary>
        [Test]
        public void DeleteAppointmentByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? practiceid = null;
            //string apivariant = null;
            //int? appointmentId = null;
            //var response = instance.DeleteAppointmentById(practiceid, apivariant, appointmentId);
            //Assert.IsInstanceOf<AppointmentIds> (response, "response is AppointmentIds");
        }
        /// <summary>
        /// Test DeleteePatientLabResultDocument
        /// </summary>
        [Test]
        public void DeleteePatientLabResultDocumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? practiceid = null;
            //string apivariant = null;
            //int? patientId = null;
            //int? labResultId = null;
            //var response = instance.DeleteePatientLabResultDocument(practiceid, apivariant, patientId, labResultId);
            //Assert.IsInstanceOf<DeleteLabResultDocumentResponse> (response, "response is DeleteLabResultDocumentResponse");
        }
        /// <summary>
        /// Test GetAppointmentById
        /// </summary>
        [Test]
        public void GetAppointmentByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? practiceid = null;
            //string apivariant = null;
            //int? appointmentId = null;
            //bool? ignorerestrictions = null;
            //bool? showclaimdetail = null;
            //bool? showcopay = null;
            //bool? showexpectedprocedurecodes = null;
            //bool? showinsurance = null;
            //bool? showpatientdetail = null;
            //var response = instance.GetAppointmentById(practiceid, apivariant, appointmentId, ignorerestrictions, showclaimdetail, showcopay, showexpectedprocedurecodes, showinsurance, showpatientdetail);
            //Assert.IsInstanceOf<Appointment> (response, "response is Appointment");
        }
        /// <summary>
        /// Test GetAppointmentTypes
        /// </summary>
        [Test]
        public void GetAppointmentTypesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? practiceid = null;
            //string apivariant = null;
            //bool? hidegeneric = null;
            //bool? hidenongeneric = null;
            //bool? hidenonpatient = null;
            //bool? hidetemplatetypeonly = null;
            //var response = instance.GetAppointmentTypes(practiceid, apivariant, hidegeneric, hidenongeneric, hidenonpatient, hidetemplatetypeonly);
            //Assert.IsInstanceOf<AppointmentTypeList> (response, "response is AppointmentTypeList");
        }
        /// <summary>
        /// Test GetBookedAppointments
        /// </summary>
        [Test]
        public void GetBookedAppointmentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? practiceid = null;
            //string apivariant = null;
            //string appointmentstatus = null;
            //int? appointmenttypeid = null;
            //int? departmentid = null;
            //string enddate = null;
            //string endlastmodified = null;
            //bool? ignorerestrictions = null;
            //int? patientid = null;
            //string providerid = null;
            //string scheduledenddate = null;
            //string scheduledstartdate = null;
            //bool? showcancelled = null;
            //bool? showclaimdetail = null;
            //bool? showcopay = null;
            //bool? showexpectedprocedurecodes = null;
            //bool? showinsurance = null;
            //bool? showpatientdetail = null;
            //bool? showremindercalldetail = null;
            //string startdate = null;
            //string startlastmodified = null;
            //var response = instance.GetBookedAppointments(practiceid, apivariant, appointmentstatus, appointmenttypeid, departmentid, enddate, endlastmodified, ignorerestrictions, patientid, providerid, scheduledenddate, scheduledstartdate, showcancelled, showclaimdetail, showcopay, showexpectedprocedurecodes, showinsurance, showpatientdetail, showremindercalldetail, startdate, startlastmodified);
            //Assert.IsInstanceOf<AppointmentList> (response, "response is AppointmentList");
        }
        /// <summary>
        /// Test GetBookedAppointmentsFromMultipleDepartments
        /// </summary>
        [Test]
        public void GetBookedAppointmentsFromMultipleDepartmentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? practiceid = null;
            //string apivariant = null;
            //string appointmentstatus = null;
            //int? appointmenttypeid = null;
            //string departmentid = null;
            //string enddate = null;
            //string endlastmodified = null;
            //bool? ignorerestrictions = null;
            //int? patientid = null;
            //string providerid = null;
            //string scheduledenddate = null;
            //string scheduledstartdate = null;
            //bool? showcancelled = null;
            //bool? showclaimdetail = null;
            //bool? showcopay = null;
            //bool? showexpectedprocedurecodes = null;
            //bool? showinsurance = null;
            //bool? showpatientdetail = null;
            //bool? showremindercalldetail = null;
            //string startdate = null;
            //string startlastmodified = null;
            //var response = instance.GetBookedAppointmentsFromMultipleDepartments(practiceid, apivariant, appointmentstatus, appointmenttypeid, departmentid, enddate, endlastmodified, ignorerestrictions, patientid, providerid, scheduledenddate, scheduledstartdate, showcancelled, showclaimdetail, showcopay, showexpectedprocedurecodes, showinsurance, showpatientdetail, showremindercalldetail, startdate, startlastmodified);
            //Assert.IsInstanceOf<AppointmentList> (response, "response is AppointmentList");
        }
        /// <summary>
        /// Test GetClaims
        /// </summary>
        [Test]
        public void GetClaimsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? practiceid = null;
            //string apivariant = null;
            //int? appointmentid = null;
            //int? providerid = null;
            //int? departmentid = null;
            //string createdenddate = null;
            //string createdstartdate = null;
            //int? patientid = null;
            //string procedurecodes = null;
            //string serviceenddate = null;
            //string servicestartdate = null;
            //bool? showcustomfields = null;
            //var response = instance.GetClaims(practiceid, apivariant, appointmentid, providerid, departmentid, createdenddate, createdstartdate, patientid, procedurecodes, serviceenddate, servicestartdate, showcustomfields);
            //Assert.IsInstanceOf<ClaimsList> (response, "response is ClaimsList");
        }
        /// <summary>
        /// Test GetDepartments
        /// </summary>
        [Test]
        public void GetDepartmentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? practiceid = null;
            //string apivariant = null;
            //int? limit = null;
            //int? offset = null;
            //bool? hospitalonly = null;
            //bool? showalldepartments = null;
            //bool? providerlist = null;
            //var response = instance.GetDepartments(practiceid, apivariant, limit, offset, hospitalonly, showalldepartments, providerlist);
            //Assert.IsInstanceOf<DepartmentList> (response, "response is DepartmentList");
        }
        /// <summary>
        /// Test GetEncounter
        /// </summary>
        [Test]
        public void GetEncounterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? practiceid = null;
            //string apivariant = null;
            //int? encounterid = null;
            //var response = instance.GetEncounter(practiceid, apivariant, encounterid);
            //Assert.IsInstanceOf<List<Encounter>> (response, "response is List<Encounter>");
        }
        /// <summary>
        /// Test GetEncounterAssesmentText
        /// </summary>
        [Test]
        public void GetEncounterAssesmentTextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? practiceid = null;
            //string apivariant = null;
            //int? encounterid = null;
            //var response = instance.GetEncounterAssesmentText(practiceid, apivariant, encounterid);
            //Assert.IsInstanceOf<List<EncounterAssesmentText>> (response, "response is List<EncounterAssesmentText>");
        }
        /// <summary>
        /// Test GetOpenAppointments
        /// </summary>
        [Test]
        public void GetOpenAppointmentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? practiceid = null;
            //string apivariant = null;
            //int? appointmenttypeid = null;
            //bool? bypassscheduletimechecks = null;
            //int? departmentid = null;
            //string enddate = null;
            //bool? ignoreschedulablepermission = null;
            //string providerid = null;
            //string reasonid = null;
            //bool? showfrozenslots = null;
            //string startdate = null;
            //var response = instance.GetOpenAppointments(practiceid, apivariant, appointmenttypeid, bypassscheduletimechecks, departmentid, enddate, ignoreschedulablepermission, providerid, reasonid, showfrozenslots, startdate);
            //Assert.IsInstanceOf<AppointmentList> (response, "response is AppointmentList");
        }
        /// <summary>
        /// Test GetPatientAnalytes
        /// </summary>
        [Test]
        public void GetPatientAnalytesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? practiceid = null;
            //string apivariant = null;
            //int? patientId = null;
            //int? departmentid = null;
            //int? allresultsbyencounterid = null;
            //string analyteresultstatus = null;
            //string enddate = null;
            //string labresultstatus = null;
            //bool? showabnormaldetails = null;
            //bool? showhidden = null;
            //bool? showtemplate = null;
            //string startdate = null;
            //var response = instance.GetPatientAnalytes(practiceid, apivariant, patientId, departmentid, allresultsbyencounterid, analyteresultstatus, enddate, labresultstatus, showabnormaldetails, showhidden, showtemplate, startdate);
            //Assert.IsInstanceOf<List<AnalytesList>> (response, "response is List<AnalytesList>");
        }
        /// <summary>
        /// Test GetPatientById
        /// </summary>
        [Test]
        public void GetPatientByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? practiceid = null;
            //string apivariant = null;
            //int? patientId = null;
            //int? departmentid = null;
            //bool? ignorerestrictions = null;
            //bool? show2015edcehrtvalues = null;
            //bool? showallclaims = null;
            //bool? showallpatientdepartmentstatus = null;
            //bool? showbalancedetails = null;
            //bool? showcustomfields = null;
            //bool? showfullssn = null;
            //bool? showinsurance = null;
            //bool? showlocalpatientid = null;
            //bool? showportalstatus = null;
            //var response = instance.GetPatientById(practiceid, apivariant, patientId, departmentid, ignorerestrictions, show2015edcehrtvalues, showallclaims, showallpatientdepartmentstatus, showbalancedetails, showcustomfields, showfullssn, showinsurance, showlocalpatientid, showportalstatus);
            //Assert.IsInstanceOf<List<Patient>> (response, "response is List<Patient>");
        }
        /// <summary>
        /// Test GetPatientCcdaRecord
        /// </summary>
        [Test]
        public void GetPatientCcdaRecordTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? practiceid = null;
            //string apivariant = null;
            //int? patientId = null;
            //var response = instance.GetPatientCcdaRecord(practiceid, apivariant, patientId);
            //Assert.IsInstanceOf<List<PatientCcda>> (response, "response is List<PatientCcda>");
        }
        /// <summary>
        /// Test GetPatientEncounterOrders
        /// </summary>
        [Test]
        public void GetPatientEncounterOrdersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? practiceid = null;
            //string apivariant = null;
            //int? encounterid = null;
            //bool? allowdischargetype = null;
            //bool? showclinicalprovider = null;
            //bool? showdeclinedorders = null;
            //bool? showexternalcodes = null;
            //var response = instance.GetPatientEncounterOrders(practiceid, apivariant, encounterid, allowdischargetype, showclinicalprovider, showdeclinedorders, showexternalcodes);
            //Assert.IsInstanceOf<List<EncounterDiagnosesList>> (response, "response is List<EncounterDiagnosesList>");
        }
        /// <summary>
        /// Test GetPatientEncounters
        /// </summary>
        [Test]
        public void GetPatientEncountersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? practiceid = null;
            //string apivariant = null;
            //int? patientId = null;
            //int? departmentid = null;
            //int? appointmentid = null;
            //int? providerid = null;
            //string enddate = null;
            //string startdate = null;
            //bool? showallstatuses = null;
            //bool? showalltypes = null;
            //bool? showdiagnoses = null;
            //var response = instance.GetPatientEncounters(practiceid, apivariant, patientId, departmentid, appointmentid, providerid, enddate, startdate, showallstatuses, showalltypes, showdiagnoses);
            //Assert.IsInstanceOf<List<EncountersList>> (response, "response is List<EncountersList>");
        }
        /// <summary>
        /// Test GetPatientLabResultDocument
        /// </summary>
        [Test]
        public void GetPatientLabResultDocumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? practiceid = null;
            //string apivariant = null;
            //int? patientId = null;
            //int? labResultId = null;
            //bool? showtemplate = null;
            //var response = instance.GetPatientLabResultDocument(practiceid, apivariant, patientId, labResultId, showtemplate);
            //Assert.IsInstanceOf<List<PatientLabResultDocumentDetails>> (response, "response is List<PatientLabResultDocumentDetails>");
        }
        /// <summary>
        /// Test GetPatientLabResultDocuments
        /// </summary>
        [Test]
        public void GetPatientLabResultDocumentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? practiceid = null;
            //string apivariant = null;
            //int? patientId = null;
            //int? departmentid = null;
            //string documentsubclass = null;
            //int? encounterid = null;
            //bool? showdeleted = null;
            //bool? showtemplate = null;
            //string status = null;
            //var response = instance.GetPatientLabResultDocuments(practiceid, apivariant, patientId, departmentid, documentsubclass, encounterid, showdeleted, showtemplate, status);
            //Assert.IsInstanceOf<PatientLabResultDocumentList> (response, "response is PatientLabResultDocumentList");
        }
        /// <summary>
        /// Test GetPatientLabResults
        /// </summary>
        [Test]
        public void GetPatientLabResultsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? practiceid = null;
            //string apivariant = null;
            //int? patientId = null;
            //int? departmentid = null;
            //int? allresultsbyencounterid = null;
            //string analyteresultstatus = null;
            //string enddate = null;
            //string labresultstatus = null;
            //bool? showabnormaldetails = null;
            //bool? showhidden = null;
            //bool? showtemplate = null;
            //string startdate = null;
            //var response = instance.GetPatientLabResults(practiceid, apivariant, patientId, departmentid, allresultsbyencounterid, analyteresultstatus, enddate, labresultstatus, showabnormaldetails, showhidden, showtemplate, startdate);
            //Assert.IsInstanceOf<LabResultList> (response, "response is LabResultList");
        }
        /// <summary>
        /// Test GetPatientMedicalHistory
        /// </summary>
        [Test]
        public void GetPatientMedicalHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? practiceid = null;
            //string apivariant = null;
            //int? patientId = null;
            //int? departmentid = null;
            //var response = instance.GetPatientMedicalHistory(practiceid, apivariant, patientId, departmentid);
            //Assert.IsInstanceOf<PatientMedicalHistory> (response, "response is PatientMedicalHistory");
        }
        /// <summary>
        /// Test GetPatientMedications
        /// </summary>
        [Test]
        public void GetPatientMedicationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? practiceid = null;
            //string apivariant = null;
            //int? patientId = null;
            //int? departmentid = null;
            //string medicationtype = null;
            //bool? showndc = null;
            //bool? showpend = null;
            //bool? showrxnorm = null;
            //var response = instance.GetPatientMedications(practiceid, apivariant, patientId, departmentid, medicationtype, showndc, showpend, showrxnorm);
            //Assert.IsInstanceOf<PatientMedication> (response, "response is PatientMedication");
        }
        /// <summary>
        /// Test GetPatientProblems
        /// </summary>
        [Test]
        public void GetPatientProblemsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? practiceid = null;
            //string apivariant = null;
            //int? patientId = null;
            //int? departmentid = null;
            //bool? showdiagnosisinfo = null;
            //bool? showinactive = null;
            //var response = instance.GetPatientProblems(practiceid, apivariant, patientId, departmentid, showdiagnosisinfo, showinactive);
            //Assert.IsInstanceOf<ProblemsList> (response, "response is ProblemsList");
        }
        /// <summary>
        /// Test GetPatientSocialHistory
        /// </summary>
        [Test]
        public void GetPatientSocialHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? practiceid = null;
            //string apivariant = null;
            //int? patientId = null;
            //int? departmentid = null;
            //string recipientcategory = null;
            //bool? shownotperformedquestions = null;
            //bool? showunansweredquestions = null;
            //var response = instance.GetPatientSocialHistory(practiceid, apivariant, patientId, departmentid, recipientcategory, shownotperformedquestions, showunansweredquestions);
            //Assert.IsInstanceOf<SocialHistoryList> (response, "response is SocialHistoryList");
        }
        /// <summary>
        /// Test GetPatientSurgicalHistory
        /// </summary>
        [Test]
        public void GetPatientSurgicalHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? practiceid = null;
            //string apivariant = null;
            //int? patientId = null;
            //int? departmentid = null;
            //var response = instance.GetPatientSurgicalHistory(practiceid, apivariant, patientId, departmentid);
            //Assert.IsInstanceOf<ProceduresList> (response, "response is ProceduresList");
        }
        /// <summary>
        /// Test GetPatientVitals
        /// </summary>
        [Test]
        public void GetPatientVitalsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? practiceid = null;
            //string apivariant = null;
            //int? patientId = null;
            //int? departmentid = null;
            //string enddate = null;
            //bool? showemptyvitals = null;
            //string startdate = null;
            //var response = instance.GetPatientVitals(practiceid, apivariant, patientId, departmentid, enddate, showemptyvitals, startdate);
            //Assert.IsInstanceOf<VitalsList> (response, "response is VitalsList");
        }
        /// <summary>
        /// Test GetPatients
        /// </summary>
        [Test]
        public void GetPatientsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? practiceid = null;
            //string apivariant = null;
            //int? departmentid = null;
            //string firstname = null;
            //string lastname = null;
            //var response = instance.GetPatients(practiceid, apivariant, departmentid, firstname, lastname);
            //Assert.IsInstanceOf<PatientList> (response, "response is PatientList");
        }
        /// <summary>
        /// Test GetPracticeInfo
        /// </summary>
        [Test]
        public void GetPracticeInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? practiceid = null;
            //string apivariant = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.GetPracticeInfo(practiceid, apivariant, limit, offset);
            //Assert.IsInstanceOf<PracticeList> (response, "response is PracticeList");
        }
        /// <summary>
        /// Test GetProviderById
        /// </summary>
        [Test]
        public void GetProviderByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? practiceid = null;
            //string apivariant = null;
            //int? providerId = null;
            //bool? showallproviderids = null;
            //int? showfederalidnumber = null;
            //decimal? showusualdepartmentguessthreshold = null;
            //var response = instance.GetProviderById(practiceid, apivariant, providerId, showallproviderids, showfederalidnumber, showusualdepartmentguessthreshold);
            //Assert.IsInstanceOf<List<Provider>> (response, "response is List<Provider>");
        }
        /// <summary>
        /// Test GetProviders
        /// </summary>
        [Test]
        public void GetProvidersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? practiceid = null;
            //string apivariant = null;
            //string name = null;
            //string providertype = null;
            //bool? showallproviderids = null;
            //int? showusualdepartmentguessthreshold = null;
            //var response = instance.GetProviders(practiceid, apivariant, name, providertype, showallproviderids, showusualdepartmentguessthreshold);
            //Assert.IsInstanceOf<ProviderList> (response, "response is ProviderList");
        }
        /// <summary>
        /// Test OpenNewAppointment
        /// </summary>
        [Test]
        public void OpenNewAppointmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appointmentdate = null;
            //string appointmenttime = null;
            //int? appointmenttypeid = null;
            //int? departmentid = null;
            //int? providerid = null;
            //int? reasonid = null;
            //int? practiceid = null;
            //string apivariant = null;
            //var response = instance.OpenNewAppointment(appointmentdate, appointmenttime, appointmenttypeid, departmentid, providerid, reasonid, practiceid, apivariant);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
    }

}