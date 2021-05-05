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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Body2
    /// </summary>
    [DataContract]
        public partial class Body2 :  IEquatable<Body2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Body2" /> class.
        /// </summary>
        /// <param name="alternatephone">The phone number of the provider..</param>
        /// <param name="ansicode">The provider taxonomy code of the provider..</param>
        /// <param name="billable">This provider is a supervising provider and is credentialed to bill for services. (required).</param>
        /// <param name="billednamecase">The billing name of the provider..</param>
        /// <param name="communicatordisplayname">The communicator display name for the provider..</param>
        /// <param name="communicatorhomedepartment">The communicator home department for the provider..</param>
        /// <param name="crdreferring">This provider is a Coordinator referring provider..</param>
        /// <param name="createencounteroncheckin">Automatically create encounters at check-in..</param>
        /// <param name="directaddress">The direct email address for the provider..</param>
        /// <param name="entitytypeid">The entity type of provider. 1 &#x3D; person, 2 &#x3D; non-person (required).</param>
        /// <param name="firstname">The first name of the provider..</param>
        /// <param name="hideinportal">Hide this provider in the Patient Portal..</param>
        /// <param name="lastname">The last name of the provider..</param>
        /// <param name="medicalgroupid">The medical group of the provider. (required).</param>
        /// <param name="middleinitial">The middle name of the provider..</param>
        /// <param name="namesuffix">The suffix of the provider..</param>
        /// <param name="ndctatnumber">The NDC TAT number for this provider..</param>
        /// <param name="npinumber">The NPI of the provider..</param>
        /// <param name="practiceroleid">The practice role ID for the provider..</param>
        /// <param name="providergroupid">The provider group of the provider. (required).</param>
        /// <param name="providerprofileid">The provider profile of the provider (integer or &#x27;NEW&#x27;).</param>
        /// <param name="providertype">The abbreviation for the provider type of the provider. (e.g., MD, NP). See GET /reference/providertypes for a mapping of abbreviation to provider type.  .</param>
        /// <param name="reportingname">The reporting name for the provider..</param>
        /// <param name="scheduleresourcetypeid">The scheduling resource type id of the provider..</param>
        /// <param name="schedulingname">The scheduling name of the provider. (required).</param>
        /// <param name="schedulingnote">The scheduling note for the provider..</param>
        /// <param name="sex">The sex of the provider (M or F).</param>
        /// <param name="signatureonfileflag">This provider&#x27;s signature is on file. (required).</param>
        /// <param name="specialtyid">The specialty ID of the provider. See GET /reference/providerspecialties for a mapping of ID to specialty name..</param>
        /// <param name="ssn">The SSN of the provider..</param>
        /// <param name="staffbucket">Create a staff bucket for this provider..</param>
        /// <param name="supervisingproviderid">The supervising provider ID for this provider..</param>
        /// <param name="supervisingprovidertype">If set to self,set supervisingprovider to itself..</param>
        /// <param name="trackmissingslips">This provider renders services that should be tracked on the Missing Slips Worklist..</param>
        /// <param name="username">The username for the provider..</param>
        public Body2(string alternatephone = default(string), string ansicode = default(string), bool? billable = default(bool?), string billednamecase = default(string), string communicatordisplayname = default(string), int? communicatorhomedepartment = default(int?), bool? crdreferring = default(bool?), bool? createencounteroncheckin = default(bool?), string directaddress = default(string), int? entitytypeid = default(int?), string firstname = default(string), bool? hideinportal = default(bool?), string lastname = default(string), int? medicalgroupid = default(int?), string middleinitial = default(string), string namesuffix = default(string), string ndctatnumber = default(string), long? npinumber = default(long?), int? practiceroleid = default(int?), int? providergroupid = default(int?), string providerprofileid = default(string), string providertype = default(string), string reportingname = default(string), int? scheduleresourcetypeid = default(int?), string schedulingname = default(string), string schedulingnote = default(string), string sex = default(string), bool? signatureonfileflag = default(bool?), string specialtyid = default(string), int? ssn = default(int?), bool? staffbucket = default(bool?), int? supervisingproviderid = default(int?), string supervisingprovidertype = default(string), bool? trackmissingslips = default(bool?), string username = default(string))
        {
            // to ensure "billable" is required (not null)
            if (billable == null)
            {
                throw new InvalidDataException("billable is a required property for Body2 and cannot be null");
            }
            else
            {
                this.Billable = billable;
            }
            // to ensure "entitytypeid" is required (not null)
            if (entitytypeid == null)
            {
                throw new InvalidDataException("entitytypeid is a required property for Body2 and cannot be null");
            }
            else
            {
                this.Entitytypeid = entitytypeid;
            }
            // to ensure "medicalgroupid" is required (not null)
            if (medicalgroupid == null)
            {
                throw new InvalidDataException("medicalgroupid is a required property for Body2 and cannot be null");
            }
            else
            {
                this.Medicalgroupid = medicalgroupid;
            }
            // to ensure "providergroupid" is required (not null)
            if (providergroupid == null)
            {
                throw new InvalidDataException("providergroupid is a required property for Body2 and cannot be null");
            }
            else
            {
                this.Providergroupid = providergroupid;
            }
            // to ensure "schedulingname" is required (not null)
            if (schedulingname == null)
            {
                throw new InvalidDataException("schedulingname is a required property for Body2 and cannot be null");
            }
            else
            {
                this.Schedulingname = schedulingname;
            }
            // to ensure "signatureonfileflag" is required (not null)
            if (signatureonfileflag == null)
            {
                throw new InvalidDataException("signatureonfileflag is a required property for Body2 and cannot be null");
            }
            else
            {
                this.Signatureonfileflag = signatureonfileflag;
            }
            this.Alternatephone = alternatephone;
            this.Ansicode = ansicode;
            this.Billednamecase = billednamecase;
            this.Communicatordisplayname = communicatordisplayname;
            this.Communicatorhomedepartment = communicatorhomedepartment;
            this.Crdreferring = crdreferring;
            this.Createencounteroncheckin = createencounteroncheckin;
            this.Directaddress = directaddress;
            this.Firstname = firstname;
            this.Hideinportal = hideinportal;
            this.Lastname = lastname;
            this.Middleinitial = middleinitial;
            this.Namesuffix = namesuffix;
            this.Ndctatnumber = ndctatnumber;
            this.Npinumber = npinumber;
            this.Practiceroleid = practiceroleid;
            this.Providerprofileid = providerprofileid;
            this.Providertype = providertype;
            this.Reportingname = reportingname;
            this.Scheduleresourcetypeid = scheduleresourcetypeid;
            this.Schedulingnote = schedulingnote;
            this.Sex = sex;
            this.Specialtyid = specialtyid;
            this.Ssn = ssn;
            this.Staffbucket = staffbucket;
            this.Supervisingproviderid = supervisingproviderid;
            this.Supervisingprovidertype = supervisingprovidertype;
            this.Trackmissingslips = trackmissingslips;
            this.Username = username;
        }
        
        /// <summary>
        /// The phone number of the provider.
        /// </summary>
        /// <value>The phone number of the provider.</value>
        [DataMember(Name="alternatephone", EmitDefaultValue=false)]
        public string Alternatephone { get; set; }

        /// <summary>
        /// The provider taxonomy code of the provider.
        /// </summary>
        /// <value>The provider taxonomy code of the provider.</value>
        [DataMember(Name="ansicode", EmitDefaultValue=false)]
        public string Ansicode { get; set; }

        /// <summary>
        /// This provider is a supervising provider and is credentialed to bill for services.
        /// </summary>
        /// <value>This provider is a supervising provider and is credentialed to bill for services.</value>
        [DataMember(Name="billable", EmitDefaultValue=false)]
        public bool? Billable { get; set; }

        /// <summary>
        /// The billing name of the provider.
        /// </summary>
        /// <value>The billing name of the provider.</value>
        [DataMember(Name="billednamecase", EmitDefaultValue=false)]
        public string Billednamecase { get; set; }

        /// <summary>
        /// The communicator display name for the provider.
        /// </summary>
        /// <value>The communicator display name for the provider.</value>
        [DataMember(Name="communicatordisplayname", EmitDefaultValue=false)]
        public string Communicatordisplayname { get; set; }

        /// <summary>
        /// The communicator home department for the provider.
        /// </summary>
        /// <value>The communicator home department for the provider.</value>
        [DataMember(Name="communicatorhomedepartment", EmitDefaultValue=false)]
        public int? Communicatorhomedepartment { get; set; }

        /// <summary>
        /// This provider is a Coordinator referring provider.
        /// </summary>
        /// <value>This provider is a Coordinator referring provider.</value>
        [DataMember(Name="crdreferring", EmitDefaultValue=false)]
        public bool? Crdreferring { get; set; }

        /// <summary>
        /// Automatically create encounters at check-in.
        /// </summary>
        /// <value>Automatically create encounters at check-in.</value>
        [DataMember(Name="createencounteroncheckin", EmitDefaultValue=false)]
        public bool? Createencounteroncheckin { get; set; }

        /// <summary>
        /// The direct email address for the provider.
        /// </summary>
        /// <value>The direct email address for the provider.</value>
        [DataMember(Name="directaddress", EmitDefaultValue=false)]
        public string Directaddress { get; set; }

        /// <summary>
        /// The entity type of provider. 1 &#x3D; person, 2 &#x3D; non-person
        /// </summary>
        /// <value>The entity type of provider. 1 &#x3D; person, 2 &#x3D; non-person</value>
        [DataMember(Name="entitytypeid", EmitDefaultValue=false)]
        public int? Entitytypeid { get; set; }

        /// <summary>
        /// The first name of the provider.
        /// </summary>
        /// <value>The first name of the provider.</value>
        [DataMember(Name="firstname", EmitDefaultValue=false)]
        public string Firstname { get; set; }

        /// <summary>
        /// Hide this provider in the Patient Portal.
        /// </summary>
        /// <value>Hide this provider in the Patient Portal.</value>
        [DataMember(Name="hideinportal", EmitDefaultValue=false)]
        public bool? Hideinportal { get; set; }

        /// <summary>
        /// The last name of the provider.
        /// </summary>
        /// <value>The last name of the provider.</value>
        [DataMember(Name="lastname", EmitDefaultValue=false)]
        public string Lastname { get; set; }

        /// <summary>
        /// The medical group of the provider.
        /// </summary>
        /// <value>The medical group of the provider.</value>
        [DataMember(Name="medicalgroupid", EmitDefaultValue=false)]
        public int? Medicalgroupid { get; set; }

        /// <summary>
        /// The middle name of the provider.
        /// </summary>
        /// <value>The middle name of the provider.</value>
        [DataMember(Name="middleinitial", EmitDefaultValue=false)]
        public string Middleinitial { get; set; }

        /// <summary>
        /// The suffix of the provider.
        /// </summary>
        /// <value>The suffix of the provider.</value>
        [DataMember(Name="namesuffix", EmitDefaultValue=false)]
        public string Namesuffix { get; set; }

        /// <summary>
        /// The NDC TAT number for this provider.
        /// </summary>
        /// <value>The NDC TAT number for this provider.</value>
        [DataMember(Name="ndctatnumber", EmitDefaultValue=false)]
        public string Ndctatnumber { get; set; }

        /// <summary>
        /// The NPI of the provider.
        /// </summary>
        /// <value>The NPI of the provider.</value>
        [DataMember(Name="npinumber", EmitDefaultValue=false)]
        public long? Npinumber { get; set; }

        /// <summary>
        /// The practice role ID for the provider.
        /// </summary>
        /// <value>The practice role ID for the provider.</value>
        [DataMember(Name="practiceroleid", EmitDefaultValue=false)]
        public int? Practiceroleid { get; set; }

        /// <summary>
        /// The provider group of the provider.
        /// </summary>
        /// <value>The provider group of the provider.</value>
        [DataMember(Name="providergroupid", EmitDefaultValue=false)]
        public int? Providergroupid { get; set; }

        /// <summary>
        /// The provider profile of the provider (integer or &#x27;NEW&#x27;)
        /// </summary>
        /// <value>The provider profile of the provider (integer or &#x27;NEW&#x27;)</value>
        [DataMember(Name="providerprofileid", EmitDefaultValue=false)]
        public string Providerprofileid { get; set; }

        /// <summary>
        /// The abbreviation for the provider type of the provider. (e.g., MD, NP). See GET /reference/providertypes for a mapping of abbreviation to provider type.  
        /// </summary>
        /// <value>The abbreviation for the provider type of the provider. (e.g., MD, NP). See GET /reference/providertypes for a mapping of abbreviation to provider type.  </value>
        [DataMember(Name="providertype", EmitDefaultValue=false)]
        public string Providertype { get; set; }

        /// <summary>
        /// The reporting name for the provider.
        /// </summary>
        /// <value>The reporting name for the provider.</value>
        [DataMember(Name="reportingname", EmitDefaultValue=false)]
        public string Reportingname { get; set; }

        /// <summary>
        /// The scheduling resource type id of the provider.
        /// </summary>
        /// <value>The scheduling resource type id of the provider.</value>
        [DataMember(Name="scheduleresourcetypeid", EmitDefaultValue=false)]
        public int? Scheduleresourcetypeid { get; set; }

        /// <summary>
        /// The scheduling name of the provider.
        /// </summary>
        /// <value>The scheduling name of the provider.</value>
        [DataMember(Name="schedulingname", EmitDefaultValue=false)]
        public string Schedulingname { get; set; }

        /// <summary>
        /// The scheduling note for the provider.
        /// </summary>
        /// <value>The scheduling note for the provider.</value>
        [DataMember(Name="schedulingnote", EmitDefaultValue=false)]
        public string Schedulingnote { get; set; }

        /// <summary>
        /// The sex of the provider (M or F)
        /// </summary>
        /// <value>The sex of the provider (M or F)</value>
        [DataMember(Name="sex", EmitDefaultValue=false)]
        public string Sex { get; set; }

        /// <summary>
        /// This provider&#x27;s signature is on file.
        /// </summary>
        /// <value>This provider&#x27;s signature is on file.</value>
        [DataMember(Name="signatureonfileflag", EmitDefaultValue=false)]
        public bool? Signatureonfileflag { get; set; }

        /// <summary>
        /// The specialty ID of the provider. See GET /reference/providerspecialties for a mapping of ID to specialty name.
        /// </summary>
        /// <value>The specialty ID of the provider. See GET /reference/providerspecialties for a mapping of ID to specialty name.</value>
        [DataMember(Name="specialtyid", EmitDefaultValue=false)]
        public string Specialtyid { get; set; }

        /// <summary>
        /// The SSN of the provider.
        /// </summary>
        /// <value>The SSN of the provider.</value>
        [DataMember(Name="ssn", EmitDefaultValue=false)]
        public int? Ssn { get; set; }

        /// <summary>
        /// Create a staff bucket for this provider.
        /// </summary>
        /// <value>Create a staff bucket for this provider.</value>
        [DataMember(Name="staffbucket", EmitDefaultValue=false)]
        public bool? Staffbucket { get; set; }

        /// <summary>
        /// The supervising provider ID for this provider.
        /// </summary>
        /// <value>The supervising provider ID for this provider.</value>
        [DataMember(Name="supervisingproviderid", EmitDefaultValue=false)]
        public int? Supervisingproviderid { get; set; }

        /// <summary>
        /// If set to self,set supervisingprovider to itself.
        /// </summary>
        /// <value>If set to self,set supervisingprovider to itself.</value>
        [DataMember(Name="supervisingprovidertype", EmitDefaultValue=false)]
        public string Supervisingprovidertype { get; set; }

        /// <summary>
        /// This provider renders services that should be tracked on the Missing Slips Worklist.
        /// </summary>
        /// <value>This provider renders services that should be tracked on the Missing Slips Worklist.</value>
        [DataMember(Name="trackmissingslips", EmitDefaultValue=false)]
        public bool? Trackmissingslips { get; set; }

        /// <summary>
        /// The username for the provider.
        /// </summary>
        /// <value>The username for the provider.</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Body2 {\n");
            sb.Append("  Alternatephone: ").Append(Alternatephone).Append("\n");
            sb.Append("  Ansicode: ").Append(Ansicode).Append("\n");
            sb.Append("  Billable: ").Append(Billable).Append("\n");
            sb.Append("  Billednamecase: ").Append(Billednamecase).Append("\n");
            sb.Append("  Communicatordisplayname: ").Append(Communicatordisplayname).Append("\n");
            sb.Append("  Communicatorhomedepartment: ").Append(Communicatorhomedepartment).Append("\n");
            sb.Append("  Crdreferring: ").Append(Crdreferring).Append("\n");
            sb.Append("  Createencounteroncheckin: ").Append(Createencounteroncheckin).Append("\n");
            sb.Append("  Directaddress: ").Append(Directaddress).Append("\n");
            sb.Append("  Entitytypeid: ").Append(Entitytypeid).Append("\n");
            sb.Append("  Firstname: ").Append(Firstname).Append("\n");
            sb.Append("  Hideinportal: ").Append(Hideinportal).Append("\n");
            sb.Append("  Lastname: ").Append(Lastname).Append("\n");
            sb.Append("  Medicalgroupid: ").Append(Medicalgroupid).Append("\n");
            sb.Append("  Middleinitial: ").Append(Middleinitial).Append("\n");
            sb.Append("  Namesuffix: ").Append(Namesuffix).Append("\n");
            sb.Append("  Ndctatnumber: ").Append(Ndctatnumber).Append("\n");
            sb.Append("  Npinumber: ").Append(Npinumber).Append("\n");
            sb.Append("  Practiceroleid: ").Append(Practiceroleid).Append("\n");
            sb.Append("  Providergroupid: ").Append(Providergroupid).Append("\n");
            sb.Append("  Providerprofileid: ").Append(Providerprofileid).Append("\n");
            sb.Append("  Providertype: ").Append(Providertype).Append("\n");
            sb.Append("  Reportingname: ").Append(Reportingname).Append("\n");
            sb.Append("  Scheduleresourcetypeid: ").Append(Scheduleresourcetypeid).Append("\n");
            sb.Append("  Schedulingname: ").Append(Schedulingname).Append("\n");
            sb.Append("  Schedulingnote: ").Append(Schedulingnote).Append("\n");
            sb.Append("  Sex: ").Append(Sex).Append("\n");
            sb.Append("  Signatureonfileflag: ").Append(Signatureonfileflag).Append("\n");
            sb.Append("  Specialtyid: ").Append(Specialtyid).Append("\n");
            sb.Append("  Ssn: ").Append(Ssn).Append("\n");
            sb.Append("  Staffbucket: ").Append(Staffbucket).Append("\n");
            sb.Append("  Supervisingproviderid: ").Append(Supervisingproviderid).Append("\n");
            sb.Append("  Supervisingprovidertype: ").Append(Supervisingprovidertype).Append("\n");
            sb.Append("  Trackmissingslips: ").Append(Trackmissingslips).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Body2);
        }

        /// <summary>
        /// Returns true if Body2 instances are equal
        /// </summary>
        /// <param name="input">Instance of Body2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Body2 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Alternatephone == input.Alternatephone ||
                    (this.Alternatephone != null &&
                    this.Alternatephone.Equals(input.Alternatephone))
                ) && 
                (
                    this.Ansicode == input.Ansicode ||
                    (this.Ansicode != null &&
                    this.Ansicode.Equals(input.Ansicode))
                ) && 
                (
                    this.Billable == input.Billable ||
                    (this.Billable != null &&
                    this.Billable.Equals(input.Billable))
                ) && 
                (
                    this.Billednamecase == input.Billednamecase ||
                    (this.Billednamecase != null &&
                    this.Billednamecase.Equals(input.Billednamecase))
                ) && 
                (
                    this.Communicatordisplayname == input.Communicatordisplayname ||
                    (this.Communicatordisplayname != null &&
                    this.Communicatordisplayname.Equals(input.Communicatordisplayname))
                ) && 
                (
                    this.Communicatorhomedepartment == input.Communicatorhomedepartment ||
                    (this.Communicatorhomedepartment != null &&
                    this.Communicatorhomedepartment.Equals(input.Communicatorhomedepartment))
                ) && 
                (
                    this.Crdreferring == input.Crdreferring ||
                    (this.Crdreferring != null &&
                    this.Crdreferring.Equals(input.Crdreferring))
                ) && 
                (
                    this.Createencounteroncheckin == input.Createencounteroncheckin ||
                    (this.Createencounteroncheckin != null &&
                    this.Createencounteroncheckin.Equals(input.Createencounteroncheckin))
                ) && 
                (
                    this.Directaddress == input.Directaddress ||
                    (this.Directaddress != null &&
                    this.Directaddress.Equals(input.Directaddress))
                ) && 
                (
                    this.Entitytypeid == input.Entitytypeid ||
                    (this.Entitytypeid != null &&
                    this.Entitytypeid.Equals(input.Entitytypeid))
                ) && 
                (
                    this.Firstname == input.Firstname ||
                    (this.Firstname != null &&
                    this.Firstname.Equals(input.Firstname))
                ) && 
                (
                    this.Hideinportal == input.Hideinportal ||
                    (this.Hideinportal != null &&
                    this.Hideinportal.Equals(input.Hideinportal))
                ) && 
                (
                    this.Lastname == input.Lastname ||
                    (this.Lastname != null &&
                    this.Lastname.Equals(input.Lastname))
                ) && 
                (
                    this.Medicalgroupid == input.Medicalgroupid ||
                    (this.Medicalgroupid != null &&
                    this.Medicalgroupid.Equals(input.Medicalgroupid))
                ) && 
                (
                    this.Middleinitial == input.Middleinitial ||
                    (this.Middleinitial != null &&
                    this.Middleinitial.Equals(input.Middleinitial))
                ) && 
                (
                    this.Namesuffix == input.Namesuffix ||
                    (this.Namesuffix != null &&
                    this.Namesuffix.Equals(input.Namesuffix))
                ) && 
                (
                    this.Ndctatnumber == input.Ndctatnumber ||
                    (this.Ndctatnumber != null &&
                    this.Ndctatnumber.Equals(input.Ndctatnumber))
                ) && 
                (
                    this.Npinumber == input.Npinumber ||
                    (this.Npinumber != null &&
                    this.Npinumber.Equals(input.Npinumber))
                ) && 
                (
                    this.Practiceroleid == input.Practiceroleid ||
                    (this.Practiceroleid != null &&
                    this.Practiceroleid.Equals(input.Practiceroleid))
                ) && 
                (
                    this.Providergroupid == input.Providergroupid ||
                    (this.Providergroupid != null &&
                    this.Providergroupid.Equals(input.Providergroupid))
                ) && 
                (
                    this.Providerprofileid == input.Providerprofileid ||
                    (this.Providerprofileid != null &&
                    this.Providerprofileid.Equals(input.Providerprofileid))
                ) && 
                (
                    this.Providertype == input.Providertype ||
                    (this.Providertype != null &&
                    this.Providertype.Equals(input.Providertype))
                ) && 
                (
                    this.Reportingname == input.Reportingname ||
                    (this.Reportingname != null &&
                    this.Reportingname.Equals(input.Reportingname))
                ) && 
                (
                    this.Scheduleresourcetypeid == input.Scheduleresourcetypeid ||
                    (this.Scheduleresourcetypeid != null &&
                    this.Scheduleresourcetypeid.Equals(input.Scheduleresourcetypeid))
                ) && 
                (
                    this.Schedulingname == input.Schedulingname ||
                    (this.Schedulingname != null &&
                    this.Schedulingname.Equals(input.Schedulingname))
                ) && 
                (
                    this.Schedulingnote == input.Schedulingnote ||
                    (this.Schedulingnote != null &&
                    this.Schedulingnote.Equals(input.Schedulingnote))
                ) && 
                (
                    this.Sex == input.Sex ||
                    (this.Sex != null &&
                    this.Sex.Equals(input.Sex))
                ) && 
                (
                    this.Signatureonfileflag == input.Signatureonfileflag ||
                    (this.Signatureonfileflag != null &&
                    this.Signatureonfileflag.Equals(input.Signatureonfileflag))
                ) && 
                (
                    this.Specialtyid == input.Specialtyid ||
                    (this.Specialtyid != null &&
                    this.Specialtyid.Equals(input.Specialtyid))
                ) && 
                (
                    this.Ssn == input.Ssn ||
                    (this.Ssn != null &&
                    this.Ssn.Equals(input.Ssn))
                ) && 
                (
                    this.Staffbucket == input.Staffbucket ||
                    (this.Staffbucket != null &&
                    this.Staffbucket.Equals(input.Staffbucket))
                ) && 
                (
                    this.Supervisingproviderid == input.Supervisingproviderid ||
                    (this.Supervisingproviderid != null &&
                    this.Supervisingproviderid.Equals(input.Supervisingproviderid))
                ) && 
                (
                    this.Supervisingprovidertype == input.Supervisingprovidertype ||
                    (this.Supervisingprovidertype != null &&
                    this.Supervisingprovidertype.Equals(input.Supervisingprovidertype))
                ) && 
                (
                    this.Trackmissingslips == input.Trackmissingslips ||
                    (this.Trackmissingslips != null &&
                    this.Trackmissingslips.Equals(input.Trackmissingslips))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Alternatephone != null)
                    hashCode = hashCode * 59 + this.Alternatephone.GetHashCode();
                if (this.Ansicode != null)
                    hashCode = hashCode * 59 + this.Ansicode.GetHashCode();
                if (this.Billable != null)
                    hashCode = hashCode * 59 + this.Billable.GetHashCode();
                if (this.Billednamecase != null)
                    hashCode = hashCode * 59 + this.Billednamecase.GetHashCode();
                if (this.Communicatordisplayname != null)
                    hashCode = hashCode * 59 + this.Communicatordisplayname.GetHashCode();
                if (this.Communicatorhomedepartment != null)
                    hashCode = hashCode * 59 + this.Communicatorhomedepartment.GetHashCode();
                if (this.Crdreferring != null)
                    hashCode = hashCode * 59 + this.Crdreferring.GetHashCode();
                if (this.Createencounteroncheckin != null)
                    hashCode = hashCode * 59 + this.Createencounteroncheckin.GetHashCode();
                if (this.Directaddress != null)
                    hashCode = hashCode * 59 + this.Directaddress.GetHashCode();
                if (this.Entitytypeid != null)
                    hashCode = hashCode * 59 + this.Entitytypeid.GetHashCode();
                if (this.Firstname != null)
                    hashCode = hashCode * 59 + this.Firstname.GetHashCode();
                if (this.Hideinportal != null)
                    hashCode = hashCode * 59 + this.Hideinportal.GetHashCode();
                if (this.Lastname != null)
                    hashCode = hashCode * 59 + this.Lastname.GetHashCode();
                if (this.Medicalgroupid != null)
                    hashCode = hashCode * 59 + this.Medicalgroupid.GetHashCode();
                if (this.Middleinitial != null)
                    hashCode = hashCode * 59 + this.Middleinitial.GetHashCode();
                if (this.Namesuffix != null)
                    hashCode = hashCode * 59 + this.Namesuffix.GetHashCode();
                if (this.Ndctatnumber != null)
                    hashCode = hashCode * 59 + this.Ndctatnumber.GetHashCode();
                if (this.Npinumber != null)
                    hashCode = hashCode * 59 + this.Npinumber.GetHashCode();
                if (this.Practiceroleid != null)
                    hashCode = hashCode * 59 + this.Practiceroleid.GetHashCode();
                if (this.Providergroupid != null)
                    hashCode = hashCode * 59 + this.Providergroupid.GetHashCode();
                if (this.Providerprofileid != null)
                    hashCode = hashCode * 59 + this.Providerprofileid.GetHashCode();
                if (this.Providertype != null)
                    hashCode = hashCode * 59 + this.Providertype.GetHashCode();
                if (this.Reportingname != null)
                    hashCode = hashCode * 59 + this.Reportingname.GetHashCode();
                if (this.Scheduleresourcetypeid != null)
                    hashCode = hashCode * 59 + this.Scheduleresourcetypeid.GetHashCode();
                if (this.Schedulingname != null)
                    hashCode = hashCode * 59 + this.Schedulingname.GetHashCode();
                if (this.Schedulingnote != null)
                    hashCode = hashCode * 59 + this.Schedulingnote.GetHashCode();
                if (this.Sex != null)
                    hashCode = hashCode * 59 + this.Sex.GetHashCode();
                if (this.Signatureonfileflag != null)
                    hashCode = hashCode * 59 + this.Signatureonfileflag.GetHashCode();
                if (this.Specialtyid != null)
                    hashCode = hashCode * 59 + this.Specialtyid.GetHashCode();
                if (this.Ssn != null)
                    hashCode = hashCode * 59 + this.Ssn.GetHashCode();
                if (this.Staffbucket != null)
                    hashCode = hashCode * 59 + this.Staffbucket.GetHashCode();
                if (this.Supervisingproviderid != null)
                    hashCode = hashCode * 59 + this.Supervisingproviderid.GetHashCode();
                if (this.Supervisingprovidertype != null)
                    hashCode = hashCode * 59 + this.Supervisingprovidertype.GetHashCode();
                if (this.Trackmissingslips != null)
                    hashCode = hashCode * 59 + this.Trackmissingslips.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
