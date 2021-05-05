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
using SwaggerDateConverter = Jacrys.AthenaSharp.Client.SwaggerDateConverter;

namespace Jacrys.AthenaSharp.Model
{
    /// <summary>
    /// Provider
    /// </summary>
    [DataContract]
        public partial class Provider :  IEquatable<Provider>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Provider" /> class.
        /// </summary>
        /// <param name="billable">Indicates if this is a billable provider..</param>
        /// <param name="ansispecialtycode">This is the ANSI code for this provider&#x27;s specialty..</param>
        /// <param name="firstname">The provider&#x27;s first name..</param>
        /// <param name="entitytype">Either \&quot;Person\&quot; or \&quot;Non-Person\&quot; (e.g. X-Ray machines).</param>
        /// <param name="otherprovideridlist">When showallproviderids is set to true, a list of all other athenaNet providers IDs that may refer to this same provider. If not present with showallproviderids, there are no other IDs other than the primary ID. .</param>
        /// <param name="ansinamecode">This is the ANSI name with ANSI code for this provider&#x27;s specialty..</param>
        /// <param name="displayname">The preferred name to use when displaying this provider..</param>
        /// <param name="homedepartment">For certain purposes, this can be considered to be the \&quot;home\&quot; or default department for a provider..</param>
        /// <param name="providerid">The ID to be used for this provider. Note that in athenaNet, an individual provider (as defined by a unique NPI) may have multiple provider IDs. For the API, we have collapsed these to a single canonical ID.  (required).</param>
        /// <param name="providertypeid">This is just the ID (a text string) such as \&quot;NP\&quot; or \&quot;NP S\&quot; for the provider type..</param>
        /// <param name="providerusername">The username of the provider..</param>
        /// <param name="supervisingproviderid">The ID of the supervising provider..</param>
        /// <param name="providertype">There is a long potential list of provider type in the form \&quot;full name (id)\&quot;,  but \&quot;MD\&quot;, \&quot;NP\&quot; or \&quot;NP S\&quot; (Nurse Practitioner (Supervising)), \&quot;RES\&quot; (resident), \&quot;EQUIP\&quot;, \&quot;DO\&quot;, \&quot;PA\&quot; or \&quot;PASUP\&quot; (Physician&#x27;s Assistant (Supervising)), \&quot;TECH\&quot;, \&quot;RN\&quot;, LPT\&quot;, \&quot;CRNA\&quot; or \&quot;CRNASUP\&quot; (Certified Registered Nurse Anesthesiologist (Supervising)), and MA (Medical Assistant) are among the most common. .</param>
        /// <param name="createencounterprovideridlist">A list of provider IDs for this provider NPI that will create an encounter when the appointment is checked in  for encounter supported appointment types. Only populated if &#x27;showallproviderids&#x27; is set. .</param>
        /// <param name="schedulingname">The scheduling name for this provider (as used in athenaNet)..</param>
        /// <param name="usualdepartmentid">The \&quot;usual\&quot; department for this provider, if SHOWUSUALDEPARTMENTGUESSTHRESHOLD is set..</param>
        /// <param name="createencounteroncheckinyn">If true, appointments scheduled with this provider will create an encounter when the appointment is checked infor encounter supported appointment types. Only applies to the primary providerid. If the provider has other IDs with the same API, please use &#x27;showallproviderids&#x27; to see which IDs create encounters. .</param>
        /// <param name="specialty">A friendly name for this provider&#x27;s specialty..</param>
        /// <param name="hideinportalyn">If set, this provider does not appear in athenaCommunicator&#x27;s web portal. .</param>
        /// <param name="lastname">The provider&#x27;s last name..</param>
        /// <param name="npi">The NPI for this provider, if available..</param>
        /// <param name="providergrouplist">When showallproviderids is set to true, a list of all provider groups that this provider is registered in. Data is only relevant if a practice is using Provider-Group-Based Data Permissions in their practice. .</param>
        /// <param name="federalidnumber">The federal ID number for provider, if SHOWFEDERALIDNUMBER is set..</param>
        /// <param name="supervisingproviderusername">The username of the supervising provider..</param>
        public Provider(bool? billable = default(bool?), string ansispecialtycode = default(string), string firstname = default(string), string entitytype = default(string), string otherprovideridlist = default(string), string ansinamecode = default(string), string displayname = default(string), string homedepartment = default(string), int? providerid = default(int?), string providertypeid = default(string), string providerusername = default(string), int? supervisingproviderid = default(int?), string providertype = default(string), string createencounterprovideridlist = default(string), string schedulingname = default(string), string usualdepartmentid = default(string), bool? createencounteroncheckinyn = default(bool?), string specialty = default(string), bool? hideinportalyn = default(bool?), string lastname = default(string), long? npi = default(long?), string providergrouplist = default(string), string federalidnumber = default(string), string supervisingproviderusername = default(string))
        {
            // to ensure "providerid" is required (not null)
            if (providerid == null)
            {
                throw new InvalidDataException("providerid is a required property for Provider and cannot be null");
            }
            else
            {
                this.Providerid = providerid;
            }
            this.Billable = billable;
            this.Ansispecialtycode = ansispecialtycode;
            this.Firstname = firstname;
            this.Entitytype = entitytype;
            this.Otherprovideridlist = otherprovideridlist;
            this.Ansinamecode = ansinamecode;
            this.Displayname = displayname;
            this.Homedepartment = homedepartment;
            this.Providertypeid = providertypeid;
            this.Providerusername = providerusername;
            this.Supervisingproviderid = supervisingproviderid;
            this.Providertype = providertype;
            this.Createencounterprovideridlist = createencounterprovideridlist;
            this.Schedulingname = schedulingname;
            this.Usualdepartmentid = usualdepartmentid;
            this.Createencounteroncheckinyn = createencounteroncheckinyn;
            this.Specialty = specialty;
            this.Hideinportalyn = hideinportalyn;
            this.Lastname = lastname;
            this.Npi = npi;
            this.Providergrouplist = providergrouplist;
            this.Federalidnumber = federalidnumber;
            this.Supervisingproviderusername = supervisingproviderusername;
        }
        
        /// <summary>
        /// Indicates if this is a billable provider.
        /// </summary>
        /// <value>Indicates if this is a billable provider.</value>
        [DataMember(Name="billable", EmitDefaultValue=false)]
        public bool? Billable { get; set; }

        /// <summary>
        /// This is the ANSI code for this provider&#x27;s specialty.
        /// </summary>
        /// <value>This is the ANSI code for this provider&#x27;s specialty.</value>
        [DataMember(Name="ansispecialtycode", EmitDefaultValue=false)]
        public string Ansispecialtycode { get; set; }

        /// <summary>
        /// The provider&#x27;s first name.
        /// </summary>
        /// <value>The provider&#x27;s first name.</value>
        [DataMember(Name="firstname", EmitDefaultValue=false)]
        public string Firstname { get; set; }

        /// <summary>
        /// Either \&quot;Person\&quot; or \&quot;Non-Person\&quot; (e.g. X-Ray machines)
        /// </summary>
        /// <value>Either \&quot;Person\&quot; or \&quot;Non-Person\&quot; (e.g. X-Ray machines)</value>
        [DataMember(Name="entitytype", EmitDefaultValue=false)]
        public string Entitytype { get; set; }

        /// <summary>
        /// When showallproviderids is set to true, a list of all other athenaNet providers IDs that may refer to this same provider. If not present with showallproviderids, there are no other IDs other than the primary ID. 
        /// </summary>
        /// <value>When showallproviderids is set to true, a list of all other athenaNet providers IDs that may refer to this same provider. If not present with showallproviderids, there are no other IDs other than the primary ID. </value>
        [DataMember(Name="otherprovideridlist", EmitDefaultValue=false)]
        public string Otherprovideridlist { get; set; }

        /// <summary>
        /// This is the ANSI name with ANSI code for this provider&#x27;s specialty.
        /// </summary>
        /// <value>This is the ANSI name with ANSI code for this provider&#x27;s specialty.</value>
        [DataMember(Name="ansinamecode", EmitDefaultValue=false)]
        public string Ansinamecode { get; set; }

        /// <summary>
        /// The preferred name to use when displaying this provider.
        /// </summary>
        /// <value>The preferred name to use when displaying this provider.</value>
        [DataMember(Name="displayname", EmitDefaultValue=false)]
        public string Displayname { get; set; }

        /// <summary>
        /// For certain purposes, this can be considered to be the \&quot;home\&quot; or default department for a provider.
        /// </summary>
        /// <value>For certain purposes, this can be considered to be the \&quot;home\&quot; or default department for a provider.</value>
        [DataMember(Name="homedepartment", EmitDefaultValue=false)]
        public string Homedepartment { get; set; }

        /// <summary>
        /// The ID to be used for this provider. Note that in athenaNet, an individual provider (as defined by a unique NPI) may have multiple provider IDs. For the API, we have collapsed these to a single canonical ID. 
        /// </summary>
        /// <value>The ID to be used for this provider. Note that in athenaNet, an individual provider (as defined by a unique NPI) may have multiple provider IDs. For the API, we have collapsed these to a single canonical ID. </value>
        [DataMember(Name="providerid", EmitDefaultValue=false)]
        public int? Providerid { get; set; }

        /// <summary>
        /// This is just the ID (a text string) such as \&quot;NP\&quot; or \&quot;NP S\&quot; for the provider type.
        /// </summary>
        /// <value>This is just the ID (a text string) such as \&quot;NP\&quot; or \&quot;NP S\&quot; for the provider type.</value>
        [DataMember(Name="providertypeid", EmitDefaultValue=false)]
        public string Providertypeid { get; set; }

        /// <summary>
        /// The username of the provider.
        /// </summary>
        /// <value>The username of the provider.</value>
        [DataMember(Name="providerusername", EmitDefaultValue=false)]
        public string Providerusername { get; set; }

        /// <summary>
        /// The ID of the supervising provider.
        /// </summary>
        /// <value>The ID of the supervising provider.</value>
        [DataMember(Name="supervisingproviderid", EmitDefaultValue=false)]
        public int? Supervisingproviderid { get; set; }

        /// <summary>
        /// There is a long potential list of provider type in the form \&quot;full name (id)\&quot;,  but \&quot;MD\&quot;, \&quot;NP\&quot; or \&quot;NP S\&quot; (Nurse Practitioner (Supervising)), \&quot;RES\&quot; (resident), \&quot;EQUIP\&quot;, \&quot;DO\&quot;, \&quot;PA\&quot; or \&quot;PASUP\&quot; (Physician&#x27;s Assistant (Supervising)), \&quot;TECH\&quot;, \&quot;RN\&quot;, LPT\&quot;, \&quot;CRNA\&quot; or \&quot;CRNASUP\&quot; (Certified Registered Nurse Anesthesiologist (Supervising)), and MA (Medical Assistant) are among the most common. 
        /// </summary>
        /// <value>There is a long potential list of provider type in the form \&quot;full name (id)\&quot;,  but \&quot;MD\&quot;, \&quot;NP\&quot; or \&quot;NP S\&quot; (Nurse Practitioner (Supervising)), \&quot;RES\&quot; (resident), \&quot;EQUIP\&quot;, \&quot;DO\&quot;, \&quot;PA\&quot; or \&quot;PASUP\&quot; (Physician&#x27;s Assistant (Supervising)), \&quot;TECH\&quot;, \&quot;RN\&quot;, LPT\&quot;, \&quot;CRNA\&quot; or \&quot;CRNASUP\&quot; (Certified Registered Nurse Anesthesiologist (Supervising)), and MA (Medical Assistant) are among the most common. </value>
        [DataMember(Name="providertype", EmitDefaultValue=false)]
        public string Providertype { get; set; }

        /// <summary>
        /// A list of provider IDs for this provider NPI that will create an encounter when the appointment is checked in  for encounter supported appointment types. Only populated if &#x27;showallproviderids&#x27; is set. 
        /// </summary>
        /// <value>A list of provider IDs for this provider NPI that will create an encounter when the appointment is checked in  for encounter supported appointment types. Only populated if &#x27;showallproviderids&#x27; is set. </value>
        [DataMember(Name="createencounterprovideridlist", EmitDefaultValue=false)]
        public string Createencounterprovideridlist { get; set; }

        /// <summary>
        /// The scheduling name for this provider (as used in athenaNet).
        /// </summary>
        /// <value>The scheduling name for this provider (as used in athenaNet).</value>
        [DataMember(Name="schedulingname", EmitDefaultValue=false)]
        public string Schedulingname { get; set; }

        /// <summary>
        /// The \&quot;usual\&quot; department for this provider, if SHOWUSUALDEPARTMENTGUESSTHRESHOLD is set.
        /// </summary>
        /// <value>The \&quot;usual\&quot; department for this provider, if SHOWUSUALDEPARTMENTGUESSTHRESHOLD is set.</value>
        [DataMember(Name="usualdepartmentid", EmitDefaultValue=false)]
        public string Usualdepartmentid { get; set; }

        /// <summary>
        /// If true, appointments scheduled with this provider will create an encounter when the appointment is checked infor encounter supported appointment types. Only applies to the primary providerid. If the provider has other IDs with the same API, please use &#x27;showallproviderids&#x27; to see which IDs create encounters. 
        /// </summary>
        /// <value>If true, appointments scheduled with this provider will create an encounter when the appointment is checked infor encounter supported appointment types. Only applies to the primary providerid. If the provider has other IDs with the same API, please use &#x27;showallproviderids&#x27; to see which IDs create encounters. </value>
        [DataMember(Name="createencounteroncheckinyn", EmitDefaultValue=false)]
        public bool? Createencounteroncheckinyn { get; set; }

        /// <summary>
        /// A friendly name for this provider&#x27;s specialty.
        /// </summary>
        /// <value>A friendly name for this provider&#x27;s specialty.</value>
        [DataMember(Name="specialty", EmitDefaultValue=false)]
        public string Specialty { get; set; }

        /// <summary>
        /// If set, this provider does not appear in athenaCommunicator&#x27;s web portal. 
        /// </summary>
        /// <value>If set, this provider does not appear in athenaCommunicator&#x27;s web portal. </value>
        [DataMember(Name="hideinportalyn", EmitDefaultValue=false)]
        public bool? Hideinportalyn { get; set; }

        /// <summary>
        /// The provider&#x27;s last name.
        /// </summary>
        /// <value>The provider&#x27;s last name.</value>
        [DataMember(Name="lastname", EmitDefaultValue=false)]
        public string Lastname { get; set; }

        /// <summary>
        /// The NPI for this provider, if available.
        /// </summary>
        /// <value>The NPI for this provider, if available.</value>
        [DataMember(Name="npi", EmitDefaultValue=false)]
        public long? Npi { get; set; }

        /// <summary>
        /// When showallproviderids is set to true, a list of all provider groups that this provider is registered in. Data is only relevant if a practice is using Provider-Group-Based Data Permissions in their practice. 
        /// </summary>
        /// <value>When showallproviderids is set to true, a list of all provider groups that this provider is registered in. Data is only relevant if a practice is using Provider-Group-Based Data Permissions in their practice. </value>
        [DataMember(Name="providergrouplist", EmitDefaultValue=false)]
        public string Providergrouplist { get; set; }

        /// <summary>
        /// The federal ID number for provider, if SHOWFEDERALIDNUMBER is set.
        /// </summary>
        /// <value>The federal ID number for provider, if SHOWFEDERALIDNUMBER is set.</value>
        [DataMember(Name="federalidnumber", EmitDefaultValue=false)]
        public string Federalidnumber { get; set; }

        /// <summary>
        /// The username of the supervising provider.
        /// </summary>
        /// <value>The username of the supervising provider.</value>
        [DataMember(Name="supervisingproviderusername", EmitDefaultValue=false)]
        public string Supervisingproviderusername { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Provider {\n");
            sb.Append("  Billable: ").Append(Billable).Append("\n");
            sb.Append("  Ansispecialtycode: ").Append(Ansispecialtycode).Append("\n");
            sb.Append("  Firstname: ").Append(Firstname).Append("\n");
            sb.Append("  Entitytype: ").Append(Entitytype).Append("\n");
            sb.Append("  Otherprovideridlist: ").Append(Otherprovideridlist).Append("\n");
            sb.Append("  Ansinamecode: ").Append(Ansinamecode).Append("\n");
            sb.Append("  Displayname: ").Append(Displayname).Append("\n");
            sb.Append("  Homedepartment: ").Append(Homedepartment).Append("\n");
            sb.Append("  Providerid: ").Append(Providerid).Append("\n");
            sb.Append("  Providertypeid: ").Append(Providertypeid).Append("\n");
            sb.Append("  Providerusername: ").Append(Providerusername).Append("\n");
            sb.Append("  Supervisingproviderid: ").Append(Supervisingproviderid).Append("\n");
            sb.Append("  Providertype: ").Append(Providertype).Append("\n");
            sb.Append("  Createencounterprovideridlist: ").Append(Createencounterprovideridlist).Append("\n");
            sb.Append("  Schedulingname: ").Append(Schedulingname).Append("\n");
            sb.Append("  Usualdepartmentid: ").Append(Usualdepartmentid).Append("\n");
            sb.Append("  Createencounteroncheckinyn: ").Append(Createencounteroncheckinyn).Append("\n");
            sb.Append("  Specialty: ").Append(Specialty).Append("\n");
            sb.Append("  Hideinportalyn: ").Append(Hideinportalyn).Append("\n");
            sb.Append("  Lastname: ").Append(Lastname).Append("\n");
            sb.Append("  Npi: ").Append(Npi).Append("\n");
            sb.Append("  Providergrouplist: ").Append(Providergrouplist).Append("\n");
            sb.Append("  Federalidnumber: ").Append(Federalidnumber).Append("\n");
            sb.Append("  Supervisingproviderusername: ").Append(Supervisingproviderusername).Append("\n");
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
            return this.Equals(input as Provider);
        }

        /// <summary>
        /// Returns true if Provider instances are equal
        /// </summary>
        /// <param name="input">Instance of Provider to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Provider input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Billable == input.Billable ||
                    (this.Billable != null &&
                    this.Billable.Equals(input.Billable))
                ) && 
                (
                    this.Ansispecialtycode == input.Ansispecialtycode ||
                    (this.Ansispecialtycode != null &&
                    this.Ansispecialtycode.Equals(input.Ansispecialtycode))
                ) && 
                (
                    this.Firstname == input.Firstname ||
                    (this.Firstname != null &&
                    this.Firstname.Equals(input.Firstname))
                ) && 
                (
                    this.Entitytype == input.Entitytype ||
                    (this.Entitytype != null &&
                    this.Entitytype.Equals(input.Entitytype))
                ) && 
                (
                    this.Otherprovideridlist == input.Otherprovideridlist ||
                    (this.Otherprovideridlist != null &&
                    this.Otherprovideridlist.Equals(input.Otherprovideridlist))
                ) && 
                (
                    this.Ansinamecode == input.Ansinamecode ||
                    (this.Ansinamecode != null &&
                    this.Ansinamecode.Equals(input.Ansinamecode))
                ) && 
                (
                    this.Displayname == input.Displayname ||
                    (this.Displayname != null &&
                    this.Displayname.Equals(input.Displayname))
                ) && 
                (
                    this.Homedepartment == input.Homedepartment ||
                    (this.Homedepartment != null &&
                    this.Homedepartment.Equals(input.Homedepartment))
                ) && 
                (
                    this.Providerid == input.Providerid ||
                    (this.Providerid != null &&
                    this.Providerid.Equals(input.Providerid))
                ) && 
                (
                    this.Providertypeid == input.Providertypeid ||
                    (this.Providertypeid != null &&
                    this.Providertypeid.Equals(input.Providertypeid))
                ) && 
                (
                    this.Providerusername == input.Providerusername ||
                    (this.Providerusername != null &&
                    this.Providerusername.Equals(input.Providerusername))
                ) && 
                (
                    this.Supervisingproviderid == input.Supervisingproviderid ||
                    (this.Supervisingproviderid != null &&
                    this.Supervisingproviderid.Equals(input.Supervisingproviderid))
                ) && 
                (
                    this.Providertype == input.Providertype ||
                    (this.Providertype != null &&
                    this.Providertype.Equals(input.Providertype))
                ) && 
                (
                    this.Createencounterprovideridlist == input.Createencounterprovideridlist ||
                    (this.Createencounterprovideridlist != null &&
                    this.Createencounterprovideridlist.Equals(input.Createencounterprovideridlist))
                ) && 
                (
                    this.Schedulingname == input.Schedulingname ||
                    (this.Schedulingname != null &&
                    this.Schedulingname.Equals(input.Schedulingname))
                ) && 
                (
                    this.Usualdepartmentid == input.Usualdepartmentid ||
                    (this.Usualdepartmentid != null &&
                    this.Usualdepartmentid.Equals(input.Usualdepartmentid))
                ) && 
                (
                    this.Createencounteroncheckinyn == input.Createencounteroncheckinyn ||
                    (this.Createencounteroncheckinyn != null &&
                    this.Createencounteroncheckinyn.Equals(input.Createencounteroncheckinyn))
                ) && 
                (
                    this.Specialty == input.Specialty ||
                    (this.Specialty != null &&
                    this.Specialty.Equals(input.Specialty))
                ) && 
                (
                    this.Hideinportalyn == input.Hideinportalyn ||
                    (this.Hideinportalyn != null &&
                    this.Hideinportalyn.Equals(input.Hideinportalyn))
                ) && 
                (
                    this.Lastname == input.Lastname ||
                    (this.Lastname != null &&
                    this.Lastname.Equals(input.Lastname))
                ) && 
                (
                    this.Npi == input.Npi ||
                    (this.Npi != null &&
                    this.Npi.Equals(input.Npi))
                ) && 
                (
                    this.Providergrouplist == input.Providergrouplist ||
                    (this.Providergrouplist != null &&
                    this.Providergrouplist.Equals(input.Providergrouplist))
                ) && 
                (
                    this.Federalidnumber == input.Federalidnumber ||
                    (this.Federalidnumber != null &&
                    this.Federalidnumber.Equals(input.Federalidnumber))
                ) && 
                (
                    this.Supervisingproviderusername == input.Supervisingproviderusername ||
                    (this.Supervisingproviderusername != null &&
                    this.Supervisingproviderusername.Equals(input.Supervisingproviderusername))
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
                if (this.Billable != null)
                    hashCode = hashCode * 59 + this.Billable.GetHashCode();
                if (this.Ansispecialtycode != null)
                    hashCode = hashCode * 59 + this.Ansispecialtycode.GetHashCode();
                if (this.Firstname != null)
                    hashCode = hashCode * 59 + this.Firstname.GetHashCode();
                if (this.Entitytype != null)
                    hashCode = hashCode * 59 + this.Entitytype.GetHashCode();
                if (this.Otherprovideridlist != null)
                    hashCode = hashCode * 59 + this.Otherprovideridlist.GetHashCode();
                if (this.Ansinamecode != null)
                    hashCode = hashCode * 59 + this.Ansinamecode.GetHashCode();
                if (this.Displayname != null)
                    hashCode = hashCode * 59 + this.Displayname.GetHashCode();
                if (this.Homedepartment != null)
                    hashCode = hashCode * 59 + this.Homedepartment.GetHashCode();
                if (this.Providerid != null)
                    hashCode = hashCode * 59 + this.Providerid.GetHashCode();
                if (this.Providertypeid != null)
                    hashCode = hashCode * 59 + this.Providertypeid.GetHashCode();
                if (this.Providerusername != null)
                    hashCode = hashCode * 59 + this.Providerusername.GetHashCode();
                if (this.Supervisingproviderid != null)
                    hashCode = hashCode * 59 + this.Supervisingproviderid.GetHashCode();
                if (this.Providertype != null)
                    hashCode = hashCode * 59 + this.Providertype.GetHashCode();
                if (this.Createencounterprovideridlist != null)
                    hashCode = hashCode * 59 + this.Createencounterprovideridlist.GetHashCode();
                if (this.Schedulingname != null)
                    hashCode = hashCode * 59 + this.Schedulingname.GetHashCode();
                if (this.Usualdepartmentid != null)
                    hashCode = hashCode * 59 + this.Usualdepartmentid.GetHashCode();
                if (this.Createencounteroncheckinyn != null)
                    hashCode = hashCode * 59 + this.Createencounteroncheckinyn.GetHashCode();
                if (this.Specialty != null)
                    hashCode = hashCode * 59 + this.Specialty.GetHashCode();
                if (this.Hideinportalyn != null)
                    hashCode = hashCode * 59 + this.Hideinportalyn.GetHashCode();
                if (this.Lastname != null)
                    hashCode = hashCode * 59 + this.Lastname.GetHashCode();
                if (this.Npi != null)
                    hashCode = hashCode * 59 + this.Npi.GetHashCode();
                if (this.Providergrouplist != null)
                    hashCode = hashCode * 59 + this.Providergrouplist.GetHashCode();
                if (this.Federalidnumber != null)
                    hashCode = hashCode * 59 + this.Federalidnumber.GetHashCode();
                if (this.Supervisingproviderusername != null)
                    hashCode = hashCode * 59 + this.Supervisingproviderusername.GetHashCode();
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
