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
    /// PatientEncounter
    /// </summary>
    [DataContract]
        public partial class PatientEncounter :  IEquatable<PatientEncounter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatientEncounter" /> class.
        /// </summary>
        /// <param name="diagnoses">List of diagnoses for this encounter.</param>
        /// <param name="lastreopened">The date the encounter was last reopened. The field will not be present if the encounter has not be closed. .</param>
        /// <param name="departmentid">The athena department ID of this encounter.</param>
        /// <param name="appointmentid">Athena appointment ID resulting in this encounter.</param>
        /// <param name="encounterid">Athena ID for this encounter.</param>
        /// <param name="encountervisitname">The visit name for this encounter.</param>
        /// <param name="encountertype">Type of encounter (FLOWSHEET, ORDERSONLY, VISIT, etc.). By default only VISIT and ORDERSONLY are shown, use INCLUDEALLtypeS flag to see others. .</param>
        /// <param name="status">Status of this encounter (CLOSED, OPEN, PEND). By default only OPEN, CLOSED, and REVIEW statuses are shown, use INCLUDEALLSTATUSES flag to see others. .</param>
        /// <param name="patientlocationid">Athena ID for the patient location.</param>
        /// <param name="patientlocation">Patient location.</param>
        /// <param name="patientstatusid">Athena ID for the patient status.</param>
        /// <param name="patientstatus">Patient status.</param>
        /// <param name="encounterdate">Date when this encounter occured.</param>
        /// <param name="stage">Last stage of the encounter.</param>
        /// <param name="providerid">The ID of the provider for this encounter.</param>
        /// <param name="providerfirstname">First name of the provider for this encounter.</param>
        /// <param name="providerlastname">Last name of the provider for this encounter.</param>
        /// <param name="providerphone">Phone number of the provider for this encounter.</param>
        /// <param name="lastupdated">The date the encounter was last updated.</param>
        public PatientEncounter(List<PatientEncounterDiagnosis> diagnoses = default(List<PatientEncounterDiagnosis>), string lastreopened = default(string), int? departmentid = default(int?), int? appointmentid = default(int?), int? encounterid = default(int?), string encountervisitname = default(string), string encountertype = default(string), string status = default(string), int? patientlocationid = default(int?), string patientlocation = default(string), int? patientstatusid = default(int?), string patientstatus = default(string), string encounterdate = default(string), string stage = default(string), int? providerid = default(int?), string providerfirstname = default(string), string providerlastname = default(string), string providerphone = default(string), string lastupdated = default(string))
        {
            this.Diagnoses = diagnoses;
            this.Lastreopened = lastreopened;
            this.Departmentid = departmentid;
            this.Appointmentid = appointmentid;
            this.Encounterid = encounterid;
            this.Encountervisitname = encountervisitname;
            this.Encountertype = encountertype;
            this.Status = status;
            this.Patientlocationid = patientlocationid;
            this.Patientlocation = patientlocation;
            this.Patientstatusid = patientstatusid;
            this.Patientstatus = patientstatus;
            this.Encounterdate = encounterdate;
            this.Stage = stage;
            this.Providerid = providerid;
            this.Providerfirstname = providerfirstname;
            this.Providerlastname = providerlastname;
            this.Providerphone = providerphone;
            this.Lastupdated = lastupdated;
        }
        
        /// <summary>
        /// List of diagnoses for this encounter
        /// </summary>
        /// <value>List of diagnoses for this encounter</value>
        [DataMember(Name="diagnoses", EmitDefaultValue=false)]
        public List<PatientEncounterDiagnosis> Diagnoses { get; set; }

        /// <summary>
        /// The date the encounter was last reopened. The field will not be present if the encounter has not be closed. 
        /// </summary>
        /// <value>The date the encounter was last reopened. The field will not be present if the encounter has not be closed. </value>
        [DataMember(Name="lastreopened", EmitDefaultValue=false)]
        public string Lastreopened { get; set; }

        /// <summary>
        /// The athena department ID of this encounter
        /// </summary>
        /// <value>The athena department ID of this encounter</value>
        [DataMember(Name="departmentid", EmitDefaultValue=false)]
        public int? Departmentid { get; set; }

        /// <summary>
        /// Athena appointment ID resulting in this encounter
        /// </summary>
        /// <value>Athena appointment ID resulting in this encounter</value>
        [DataMember(Name="appointmentid", EmitDefaultValue=false)]
        public int? Appointmentid { get; set; }

        /// <summary>
        /// Athena ID for this encounter
        /// </summary>
        /// <value>Athena ID for this encounter</value>
        [DataMember(Name="encounterid", EmitDefaultValue=false)]
        public int? Encounterid { get; set; }

        /// <summary>
        /// The visit name for this encounter
        /// </summary>
        /// <value>The visit name for this encounter</value>
        [DataMember(Name="encountervisitname", EmitDefaultValue=false)]
        public string Encountervisitname { get; set; }

        /// <summary>
        /// Type of encounter (FLOWSHEET, ORDERSONLY, VISIT, etc.). By default only VISIT and ORDERSONLY are shown, use INCLUDEALLtypeS flag to see others. 
        /// </summary>
        /// <value>Type of encounter (FLOWSHEET, ORDERSONLY, VISIT, etc.). By default only VISIT and ORDERSONLY are shown, use INCLUDEALLtypeS flag to see others. </value>
        [DataMember(Name="encountertype", EmitDefaultValue=false)]
        public string Encountertype { get; set; }

        /// <summary>
        /// Status of this encounter (CLOSED, OPEN, PEND). By default only OPEN, CLOSED, and REVIEW statuses are shown, use INCLUDEALLSTATUSES flag to see others. 
        /// </summary>
        /// <value>Status of this encounter (CLOSED, OPEN, PEND). By default only OPEN, CLOSED, and REVIEW statuses are shown, use INCLUDEALLSTATUSES flag to see others. </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Athena ID for the patient location
        /// </summary>
        /// <value>Athena ID for the patient location</value>
        [DataMember(Name="patientlocationid", EmitDefaultValue=false)]
        public int? Patientlocationid { get; set; }

        /// <summary>
        /// Patient location
        /// </summary>
        /// <value>Patient location</value>
        [DataMember(Name="patientlocation", EmitDefaultValue=false)]
        public string Patientlocation { get; set; }

        /// <summary>
        /// Athena ID for the patient status
        /// </summary>
        /// <value>Athena ID for the patient status</value>
        [DataMember(Name="patientstatusid", EmitDefaultValue=false)]
        public int? Patientstatusid { get; set; }

        /// <summary>
        /// Patient status
        /// </summary>
        /// <value>Patient status</value>
        [DataMember(Name="patientstatus", EmitDefaultValue=false)]
        public string Patientstatus { get; set; }

        /// <summary>
        /// Date when this encounter occured
        /// </summary>
        /// <value>Date when this encounter occured</value>
        [DataMember(Name="encounterdate", EmitDefaultValue=false)]
        public string Encounterdate { get; set; }

        /// <summary>
        /// Last stage of the encounter
        /// </summary>
        /// <value>Last stage of the encounter</value>
        [DataMember(Name="stage", EmitDefaultValue=false)]
        public string Stage { get; set; }

        /// <summary>
        /// The ID of the provider for this encounter
        /// </summary>
        /// <value>The ID of the provider for this encounter</value>
        [DataMember(Name="providerid", EmitDefaultValue=false)]
        public int? Providerid { get; set; }

        /// <summary>
        /// First name of the provider for this encounter
        /// </summary>
        /// <value>First name of the provider for this encounter</value>
        [DataMember(Name="providerfirstname", EmitDefaultValue=false)]
        public string Providerfirstname { get; set; }

        /// <summary>
        /// Last name of the provider for this encounter
        /// </summary>
        /// <value>Last name of the provider for this encounter</value>
        [DataMember(Name="providerlastname", EmitDefaultValue=false)]
        public string Providerlastname { get; set; }

        /// <summary>
        /// Phone number of the provider for this encounter
        /// </summary>
        /// <value>Phone number of the provider for this encounter</value>
        [DataMember(Name="providerphone", EmitDefaultValue=false)]
        public string Providerphone { get; set; }

        /// <summary>
        /// The date the encounter was last updated
        /// </summary>
        /// <value>The date the encounter was last updated</value>
        [DataMember(Name="lastupdated", EmitDefaultValue=false)]
        public string Lastupdated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatientEncounter {\n");
            sb.Append("  Diagnoses: ").Append(Diagnoses).Append("\n");
            sb.Append("  Lastreopened: ").Append(Lastreopened).Append("\n");
            sb.Append("  Departmentid: ").Append(Departmentid).Append("\n");
            sb.Append("  Appointmentid: ").Append(Appointmentid).Append("\n");
            sb.Append("  Encounterid: ").Append(Encounterid).Append("\n");
            sb.Append("  Encountervisitname: ").Append(Encountervisitname).Append("\n");
            sb.Append("  Encountertype: ").Append(Encountertype).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Patientlocationid: ").Append(Patientlocationid).Append("\n");
            sb.Append("  Patientlocation: ").Append(Patientlocation).Append("\n");
            sb.Append("  Patientstatusid: ").Append(Patientstatusid).Append("\n");
            sb.Append("  Patientstatus: ").Append(Patientstatus).Append("\n");
            sb.Append("  Encounterdate: ").Append(Encounterdate).Append("\n");
            sb.Append("  Stage: ").Append(Stage).Append("\n");
            sb.Append("  Providerid: ").Append(Providerid).Append("\n");
            sb.Append("  Providerfirstname: ").Append(Providerfirstname).Append("\n");
            sb.Append("  Providerlastname: ").Append(Providerlastname).Append("\n");
            sb.Append("  Providerphone: ").Append(Providerphone).Append("\n");
            sb.Append("  Lastupdated: ").Append(Lastupdated).Append("\n");
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
            return this.Equals(input as PatientEncounter);
        }

        /// <summary>
        /// Returns true if PatientEncounter instances are equal
        /// </summary>
        /// <param name="input">Instance of PatientEncounter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatientEncounter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Diagnoses == input.Diagnoses ||
                    this.Diagnoses != null &&
                    input.Diagnoses != null &&
                    this.Diagnoses.SequenceEqual(input.Diagnoses)
                ) && 
                (
                    this.Lastreopened == input.Lastreopened ||
                    (this.Lastreopened != null &&
                    this.Lastreopened.Equals(input.Lastreopened))
                ) && 
                (
                    this.Departmentid == input.Departmentid ||
                    (this.Departmentid != null &&
                    this.Departmentid.Equals(input.Departmentid))
                ) && 
                (
                    this.Appointmentid == input.Appointmentid ||
                    (this.Appointmentid != null &&
                    this.Appointmentid.Equals(input.Appointmentid))
                ) && 
                (
                    this.Encounterid == input.Encounterid ||
                    (this.Encounterid != null &&
                    this.Encounterid.Equals(input.Encounterid))
                ) && 
                (
                    this.Encountervisitname == input.Encountervisitname ||
                    (this.Encountervisitname != null &&
                    this.Encountervisitname.Equals(input.Encountervisitname))
                ) && 
                (
                    this.Encountertype == input.Encountertype ||
                    (this.Encountertype != null &&
                    this.Encountertype.Equals(input.Encountertype))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Patientlocationid == input.Patientlocationid ||
                    (this.Patientlocationid != null &&
                    this.Patientlocationid.Equals(input.Patientlocationid))
                ) && 
                (
                    this.Patientlocation == input.Patientlocation ||
                    (this.Patientlocation != null &&
                    this.Patientlocation.Equals(input.Patientlocation))
                ) && 
                (
                    this.Patientstatusid == input.Patientstatusid ||
                    (this.Patientstatusid != null &&
                    this.Patientstatusid.Equals(input.Patientstatusid))
                ) && 
                (
                    this.Patientstatus == input.Patientstatus ||
                    (this.Patientstatus != null &&
                    this.Patientstatus.Equals(input.Patientstatus))
                ) && 
                (
                    this.Encounterdate == input.Encounterdate ||
                    (this.Encounterdate != null &&
                    this.Encounterdate.Equals(input.Encounterdate))
                ) && 
                (
                    this.Stage == input.Stage ||
                    (this.Stage != null &&
                    this.Stage.Equals(input.Stage))
                ) && 
                (
                    this.Providerid == input.Providerid ||
                    (this.Providerid != null &&
                    this.Providerid.Equals(input.Providerid))
                ) && 
                (
                    this.Providerfirstname == input.Providerfirstname ||
                    (this.Providerfirstname != null &&
                    this.Providerfirstname.Equals(input.Providerfirstname))
                ) && 
                (
                    this.Providerlastname == input.Providerlastname ||
                    (this.Providerlastname != null &&
                    this.Providerlastname.Equals(input.Providerlastname))
                ) && 
                (
                    this.Providerphone == input.Providerphone ||
                    (this.Providerphone != null &&
                    this.Providerphone.Equals(input.Providerphone))
                ) && 
                (
                    this.Lastupdated == input.Lastupdated ||
                    (this.Lastupdated != null &&
                    this.Lastupdated.Equals(input.Lastupdated))
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
                if (this.Diagnoses != null)
                    hashCode = hashCode * 59 + this.Diagnoses.GetHashCode();
                if (this.Lastreopened != null)
                    hashCode = hashCode * 59 + this.Lastreopened.GetHashCode();
                if (this.Departmentid != null)
                    hashCode = hashCode * 59 + this.Departmentid.GetHashCode();
                if (this.Appointmentid != null)
                    hashCode = hashCode * 59 + this.Appointmentid.GetHashCode();
                if (this.Encounterid != null)
                    hashCode = hashCode * 59 + this.Encounterid.GetHashCode();
                if (this.Encountervisitname != null)
                    hashCode = hashCode * 59 + this.Encountervisitname.GetHashCode();
                if (this.Encountertype != null)
                    hashCode = hashCode * 59 + this.Encountertype.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Patientlocationid != null)
                    hashCode = hashCode * 59 + this.Patientlocationid.GetHashCode();
                if (this.Patientlocation != null)
                    hashCode = hashCode * 59 + this.Patientlocation.GetHashCode();
                if (this.Patientstatusid != null)
                    hashCode = hashCode * 59 + this.Patientstatusid.GetHashCode();
                if (this.Patientstatus != null)
                    hashCode = hashCode * 59 + this.Patientstatus.GetHashCode();
                if (this.Encounterdate != null)
                    hashCode = hashCode * 59 + this.Encounterdate.GetHashCode();
                if (this.Stage != null)
                    hashCode = hashCode * 59 + this.Stage.GetHashCode();
                if (this.Providerid != null)
                    hashCode = hashCode * 59 + this.Providerid.GetHashCode();
                if (this.Providerfirstname != null)
                    hashCode = hashCode * 59 + this.Providerfirstname.GetHashCode();
                if (this.Providerlastname != null)
                    hashCode = hashCode * 59 + this.Providerlastname.GetHashCode();
                if (this.Providerphone != null)
                    hashCode = hashCode * 59 + this.Providerphone.GetHashCode();
                if (this.Lastupdated != null)
                    hashCode = hashCode * 59 + this.Lastupdated.GetHashCode();
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
