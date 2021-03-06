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
    /// PatientProblemEvent
    /// </summary>
    [DataContract]
        public partial class PatientProblemEvent :  IEquatable<PatientProblemEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatientProblemEvent" /> class.
        /// </summary>
        /// <param name="diagnoses">diagnoses.</param>
        /// <param name="eventtype">The type of this event: START, END, HIDDEN, REACTIVATED, or ENCOUNTER .</param>
        /// <param name="source">The source of this event: ENCOUNTER or HISTORY .</param>
        /// <param name="status">The status of this problem event: CHRONIC or ACUTE .</param>
        /// <param name="onsetdate">The specified onset date for this problem, as entered by the practice. If available this is more accurate than the start date. .</param>
        /// <param name="startdate">The date this problem event started or was restarted. Uses the onsetdate if available, otherwise uses the date the problem was entered into the system. .</param>
        /// <param name="enddate">The date this problem event ended or was hidden.</param>
        /// <param name="encounterdate">The date of the encounter where a diagnosis matching this problem was used..</param>
        /// <param name="laterality">The laterality of this problem. Can be null, LEFT, RIGHT, or BILATERAL..</param>
        /// <param name="note">The note attached to this event..</param>
        /// <param name="createddate">The date that the user entered this problem..</param>
        /// <param name="createdby">The name of the user who entered this problem..</param>
        public PatientProblemEvent(List<Code> diagnoses = default(List<Code>), string eventtype = default(string), string source = default(string), string status = default(string), string onsetdate = default(string), string startdate = default(string), string enddate = default(string), string encounterdate = default(string), string laterality = default(string), string note = default(string), string createddate = default(string), string createdby = default(string))
        {
            this.Diagnoses = diagnoses;
            this.Eventtype = eventtype;
            this.Source = source;
            this.Status = status;
            this.Onsetdate = onsetdate;
            this.Startdate = startdate;
            this.Enddate = enddate;
            this.Encounterdate = encounterdate;
            this.Laterality = laterality;
            this.Note = note;
            this.Createddate = createddate;
            this.Createdby = createdby;
        }
        
        /// <summary>
        /// Gets or Sets Diagnoses
        /// </summary>
        [DataMember(Name="diagnoses", EmitDefaultValue=false)]
        public List<Code> Diagnoses { get; set; }

        /// <summary>
        /// The type of this event: START, END, HIDDEN, REACTIVATED, or ENCOUNTER 
        /// </summary>
        /// <value>The type of this event: START, END, HIDDEN, REACTIVATED, or ENCOUNTER </value>
        [DataMember(Name="eventtype", EmitDefaultValue=false)]
        public string Eventtype { get; set; }

        /// <summary>
        /// The source of this event: ENCOUNTER or HISTORY 
        /// </summary>
        /// <value>The source of this event: ENCOUNTER or HISTORY </value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }

        /// <summary>
        /// The status of this problem event: CHRONIC or ACUTE 
        /// </summary>
        /// <value>The status of this problem event: CHRONIC or ACUTE </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// The specified onset date for this problem, as entered by the practice. If available this is more accurate than the start date. 
        /// </summary>
        /// <value>The specified onset date for this problem, as entered by the practice. If available this is more accurate than the start date. </value>
        [DataMember(Name="onsetdate", EmitDefaultValue=false)]
        public string Onsetdate { get; set; }

        /// <summary>
        /// The date this problem event started or was restarted. Uses the onsetdate if available, otherwise uses the date the problem was entered into the system. 
        /// </summary>
        /// <value>The date this problem event started or was restarted. Uses the onsetdate if available, otherwise uses the date the problem was entered into the system. </value>
        [DataMember(Name="startdate", EmitDefaultValue=false)]
        public string Startdate { get; set; }

        /// <summary>
        /// The date this problem event ended or was hidden
        /// </summary>
        /// <value>The date this problem event ended or was hidden</value>
        [DataMember(Name="enddate", EmitDefaultValue=false)]
        public string Enddate { get; set; }

        /// <summary>
        /// The date of the encounter where a diagnosis matching this problem was used.
        /// </summary>
        /// <value>The date of the encounter where a diagnosis matching this problem was used.</value>
        [DataMember(Name="encounterdate", EmitDefaultValue=false)]
        public string Encounterdate { get; set; }

        /// <summary>
        /// The laterality of this problem. Can be null, LEFT, RIGHT, or BILATERAL.
        /// </summary>
        /// <value>The laterality of this problem. Can be null, LEFT, RIGHT, or BILATERAL.</value>
        [DataMember(Name="laterality", EmitDefaultValue=false)]
        public string Laterality { get; set; }

        /// <summary>
        /// The note attached to this event.
        /// </summary>
        /// <value>The note attached to this event.</value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }

        /// <summary>
        /// The date that the user entered this problem.
        /// </summary>
        /// <value>The date that the user entered this problem.</value>
        [DataMember(Name="createddate", EmitDefaultValue=false)]
        public string Createddate { get; set; }

        /// <summary>
        /// The name of the user who entered this problem.
        /// </summary>
        /// <value>The name of the user who entered this problem.</value>
        [DataMember(Name="createdby", EmitDefaultValue=false)]
        public string Createdby { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatientProblemEvent {\n");
            sb.Append("  Diagnoses: ").Append(Diagnoses).Append("\n");
            sb.Append("  Eventtype: ").Append(Eventtype).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Onsetdate: ").Append(Onsetdate).Append("\n");
            sb.Append("  Startdate: ").Append(Startdate).Append("\n");
            sb.Append("  Enddate: ").Append(Enddate).Append("\n");
            sb.Append("  Encounterdate: ").Append(Encounterdate).Append("\n");
            sb.Append("  Laterality: ").Append(Laterality).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  Createddate: ").Append(Createddate).Append("\n");
            sb.Append("  Createdby: ").Append(Createdby).Append("\n");
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
            return this.Equals(input as PatientProblemEvent);
        }

        /// <summary>
        /// Returns true if PatientProblemEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of PatientProblemEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatientProblemEvent input)
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
                    this.Eventtype == input.Eventtype ||
                    (this.Eventtype != null &&
                    this.Eventtype.Equals(input.Eventtype))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Onsetdate == input.Onsetdate ||
                    (this.Onsetdate != null &&
                    this.Onsetdate.Equals(input.Onsetdate))
                ) && 
                (
                    this.Startdate == input.Startdate ||
                    (this.Startdate != null &&
                    this.Startdate.Equals(input.Startdate))
                ) && 
                (
                    this.Enddate == input.Enddate ||
                    (this.Enddate != null &&
                    this.Enddate.Equals(input.Enddate))
                ) && 
                (
                    this.Encounterdate == input.Encounterdate ||
                    (this.Encounterdate != null &&
                    this.Encounterdate.Equals(input.Encounterdate))
                ) && 
                (
                    this.Laterality == input.Laterality ||
                    (this.Laterality != null &&
                    this.Laterality.Equals(input.Laterality))
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) && 
                (
                    this.Createddate == input.Createddate ||
                    (this.Createddate != null &&
                    this.Createddate.Equals(input.Createddate))
                ) && 
                (
                    this.Createdby == input.Createdby ||
                    (this.Createdby != null &&
                    this.Createdby.Equals(input.Createdby))
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
                if (this.Eventtype != null)
                    hashCode = hashCode * 59 + this.Eventtype.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Onsetdate != null)
                    hashCode = hashCode * 59 + this.Onsetdate.GetHashCode();
                if (this.Startdate != null)
                    hashCode = hashCode * 59 + this.Startdate.GetHashCode();
                if (this.Enddate != null)
                    hashCode = hashCode * 59 + this.Enddate.GetHashCode();
                if (this.Encounterdate != null)
                    hashCode = hashCode * 59 + this.Encounterdate.GetHashCode();
                if (this.Laterality != null)
                    hashCode = hashCode * 59 + this.Laterality.GetHashCode();
                if (this.Note != null)
                    hashCode = hashCode * 59 + this.Note.GetHashCode();
                if (this.Createddate != null)
                    hashCode = hashCode * 59 + this.Createddate.GetHashCode();
                if (this.Createdby != null)
                    hashCode = hashCode * 59 + this.Createdby.GetHashCode();
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
