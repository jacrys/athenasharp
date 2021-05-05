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
    /// PatientProblem
    /// </summary>
    [DataContract]
        public partial class PatientProblem :  IEquatable<PatientProblem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatientProblem" /> class.
        /// </summary>
        /// <param name="events">List of start and stop events for this problem, which can occur multiple times. (required).</param>
        /// <param name="deactivateddate">Date of problem deactivation..</param>
        /// <param name="deactivateduser">The name of the user who deactivated the problem..</param>
        /// <param name="problemid">Athena ID for this problem.</param>
        /// <param name="name">Problem name.</param>
        /// <param name="code">Problem code.</param>
        /// <param name="codeset">Problem codeset (SNOMED, ICD9, ICD10, etc).</param>
        /// <param name="bestmatchicd10code">If this was added from the chart or from an encounter without a selected ICD10 code, and if the primary codeset is SNOMED,  then this contains the best matching ICD10 code mapped. Because SNOMED to ICD10 is a many to many map, this will tend to give  the most generic diagnosis. .</param>
        /// <param name="mostrecentdiagnosisnote">The most recent diagnosis note.</param>
        /// <param name="lastmodifieddatetime">The date the problem was last modified. Currently only date precision..</param>
        /// <param name="lastmodifiedby">The username of the user who last modified this problem..</param>
        public PatientProblem(List<PatientProblemEvent> events = default(List<PatientProblemEvent>), string deactivateddate = default(string), string deactivateduser = default(string), int? problemid = default(int?), string name = default(string), string code = default(string), string codeset = default(string), string bestmatchicd10code = default(string), string mostrecentdiagnosisnote = default(string), string lastmodifieddatetime = default(string), string lastmodifiedby = default(string))
        {
            // to ensure "events" is required (not null)
            if (events == null)
            {
                throw new InvalidDataException("events is a required property for PatientProblem and cannot be null");
            }
            else
            {
                this.Events = events;
            }
            this.Deactivateddate = deactivateddate;
            this.Deactivateduser = deactivateduser;
            this.Problemid = problemid;
            this.Name = name;
            this.Code = code;
            this.Codeset = codeset;
            this.Bestmatchicd10code = bestmatchicd10code;
            this.Mostrecentdiagnosisnote = mostrecentdiagnosisnote;
            this.Lastmodifieddatetime = lastmodifieddatetime;
            this.Lastmodifiedby = lastmodifiedby;
        }
        
        /// <summary>
        /// List of start and stop events for this problem, which can occur multiple times.
        /// </summary>
        /// <value>List of start and stop events for this problem, which can occur multiple times.</value>
        [DataMember(Name="events", EmitDefaultValue=false)]
        public List<PatientProblemEvent> Events { get; set; }

        /// <summary>
        /// Date of problem deactivation.
        /// </summary>
        /// <value>Date of problem deactivation.</value>
        [DataMember(Name="deactivateddate", EmitDefaultValue=false)]
        public string Deactivateddate { get; set; }

        /// <summary>
        /// The name of the user who deactivated the problem.
        /// </summary>
        /// <value>The name of the user who deactivated the problem.</value>
        [DataMember(Name="deactivateduser", EmitDefaultValue=false)]
        public string Deactivateduser { get; set; }

        /// <summary>
        /// Athena ID for this problem
        /// </summary>
        /// <value>Athena ID for this problem</value>
        [DataMember(Name="problemid", EmitDefaultValue=false)]
        public int? Problemid { get; set; }

        /// <summary>
        /// Problem name
        /// </summary>
        /// <value>Problem name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Problem code
        /// </summary>
        /// <value>Problem code</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Problem codeset (SNOMED, ICD9, ICD10, etc)
        /// </summary>
        /// <value>Problem codeset (SNOMED, ICD9, ICD10, etc)</value>
        [DataMember(Name="codeset", EmitDefaultValue=false)]
        public string Codeset { get; set; }

        /// <summary>
        /// If this was added from the chart or from an encounter without a selected ICD10 code, and if the primary codeset is SNOMED,  then this contains the best matching ICD10 code mapped. Because SNOMED to ICD10 is a many to many map, this will tend to give  the most generic diagnosis. 
        /// </summary>
        /// <value>If this was added from the chart or from an encounter without a selected ICD10 code, and if the primary codeset is SNOMED,  then this contains the best matching ICD10 code mapped. Because SNOMED to ICD10 is a many to many map, this will tend to give  the most generic diagnosis. </value>
        [DataMember(Name="bestmatchicd10code", EmitDefaultValue=false)]
        public string Bestmatchicd10code { get; set; }

        /// <summary>
        /// The most recent diagnosis note
        /// </summary>
        /// <value>The most recent diagnosis note</value>
        [DataMember(Name="mostrecentdiagnosisnote", EmitDefaultValue=false)]
        public string Mostrecentdiagnosisnote { get; set; }

        /// <summary>
        /// The date the problem was last modified. Currently only date precision.
        /// </summary>
        /// <value>The date the problem was last modified. Currently only date precision.</value>
        [DataMember(Name="lastmodifieddatetime", EmitDefaultValue=false)]
        public string Lastmodifieddatetime { get; set; }

        /// <summary>
        /// The username of the user who last modified this problem.
        /// </summary>
        /// <value>The username of the user who last modified this problem.</value>
        [DataMember(Name="lastmodifiedby", EmitDefaultValue=false)]
        public string Lastmodifiedby { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatientProblem {\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  Deactivateddate: ").Append(Deactivateddate).Append("\n");
            sb.Append("  Deactivateduser: ").Append(Deactivateduser).Append("\n");
            sb.Append("  Problemid: ").Append(Problemid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Codeset: ").Append(Codeset).Append("\n");
            sb.Append("  Bestmatchicd10code: ").Append(Bestmatchicd10code).Append("\n");
            sb.Append("  Mostrecentdiagnosisnote: ").Append(Mostrecentdiagnosisnote).Append("\n");
            sb.Append("  Lastmodifieddatetime: ").Append(Lastmodifieddatetime).Append("\n");
            sb.Append("  Lastmodifiedby: ").Append(Lastmodifiedby).Append("\n");
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
            return this.Equals(input as PatientProblem);
        }

        /// <summary>
        /// Returns true if PatientProblem instances are equal
        /// </summary>
        /// <param name="input">Instance of PatientProblem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatientProblem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Events == input.Events ||
                    this.Events != null &&
                    input.Events != null &&
                    this.Events.SequenceEqual(input.Events)
                ) && 
                (
                    this.Deactivateddate == input.Deactivateddate ||
                    (this.Deactivateddate != null &&
                    this.Deactivateddate.Equals(input.Deactivateddate))
                ) && 
                (
                    this.Deactivateduser == input.Deactivateduser ||
                    (this.Deactivateduser != null &&
                    this.Deactivateduser.Equals(input.Deactivateduser))
                ) && 
                (
                    this.Problemid == input.Problemid ||
                    (this.Problemid != null &&
                    this.Problemid.Equals(input.Problemid))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Codeset == input.Codeset ||
                    (this.Codeset != null &&
                    this.Codeset.Equals(input.Codeset))
                ) && 
                (
                    this.Bestmatchicd10code == input.Bestmatchicd10code ||
                    (this.Bestmatchicd10code != null &&
                    this.Bestmatchicd10code.Equals(input.Bestmatchicd10code))
                ) && 
                (
                    this.Mostrecentdiagnosisnote == input.Mostrecentdiagnosisnote ||
                    (this.Mostrecentdiagnosisnote != null &&
                    this.Mostrecentdiagnosisnote.Equals(input.Mostrecentdiagnosisnote))
                ) && 
                (
                    this.Lastmodifieddatetime == input.Lastmodifieddatetime ||
                    (this.Lastmodifieddatetime != null &&
                    this.Lastmodifieddatetime.Equals(input.Lastmodifieddatetime))
                ) && 
                (
                    this.Lastmodifiedby == input.Lastmodifiedby ||
                    (this.Lastmodifiedby != null &&
                    this.Lastmodifiedby.Equals(input.Lastmodifiedby))
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
                if (this.Events != null)
                    hashCode = hashCode * 59 + this.Events.GetHashCode();
                if (this.Deactivateddate != null)
                    hashCode = hashCode * 59 + this.Deactivateddate.GetHashCode();
                if (this.Deactivateduser != null)
                    hashCode = hashCode * 59 + this.Deactivateduser.GetHashCode();
                if (this.Problemid != null)
                    hashCode = hashCode * 59 + this.Problemid.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Codeset != null)
                    hashCode = hashCode * 59 + this.Codeset.GetHashCode();
                if (this.Bestmatchicd10code != null)
                    hashCode = hashCode * 59 + this.Bestmatchicd10code.GetHashCode();
                if (this.Mostrecentdiagnosisnote != null)
                    hashCode = hashCode * 59 + this.Mostrecentdiagnosisnote.GetHashCode();
                if (this.Lastmodifieddatetime != null)
                    hashCode = hashCode * 59 + this.Lastmodifieddatetime.GetHashCode();
                if (this.Lastmodifiedby != null)
                    hashCode = hashCode * 59 + this.Lastmodifiedby.GetHashCode();
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
