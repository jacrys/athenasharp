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
    /// Analyte
    /// </summary>
    [DataContract]
        public partial class Analyte :  IEquatable<Analyte>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Analyte" /> class.
        /// </summary>
        /// <param name="analyteid">Athena ID for the given lab result observation/analyte.</param>
        /// <param name="analytename">Name / description specific to this analyte.</param>
        /// <param name="loinc">Logical Observation Identifiers Names and Codes ID, if available.</param>
        /// <param name="value">Value recorded for this observation.</param>
        /// <param name="units">Units for this analyte entry, if provided by the lab.</param>
        /// <param name="analytedate">Date when this observation was recorded.</param>
        /// <param name="description">General description of the lab result test.</param>
        /// <param name="note">Additional note for this analyte, if applicable.</param>
        /// <param name="abnormalflag">Status indicator of the measurement relative to normal (low, high, normal, abnormal).</param>
        /// <param name="abnormalhl7code">The HL7 code related to the abnormal flag..</param>
        /// <param name="abnormalhl7name">The HL7 description related to the abnormal flag..</param>
        /// <param name="valuestatus">DEPRECATED - - use \&quot;abnormalflag\&quot; instead. Status indicator of the measurement relative to normal (low, high, normal, abnormal).</param>
        /// <param name="referencerange">Reference range of values accepted as normal for this observation.</param>
        /// <param name="resultstatus">The status of the result (e.g., \&quot;final\&quot;, \&quot;preliminary\&quot;, \&quot;corrected\&quot;, etc.).</param>
        /// <param name="labresultstatus">The status of the underlying lab result.</param>
        public Analyte(int? analyteid = default(int?), string analytename = default(string), string loinc = default(string), string value = default(string), string units = default(string), string analytedate = default(string), string description = default(string), string note = default(string), string abnormalflag = default(string), string abnormalhl7code = default(string), string abnormalhl7name = default(string), string valuestatus = default(string), string referencerange = default(string), string resultstatus = default(string), string labresultstatus = default(string))
        {
            this.Analyteid = analyteid;
            this.Analytename = analytename;
            this.Loinc = loinc;
            this.Value = value;
            this.Units = units;
            this.Analytedate = analytedate;
            this.Description = description;
            this.Note = note;
            this.Abnormalflag = abnormalflag;
            this.Abnormalhl7code = abnormalhl7code;
            this.Abnormalhl7name = abnormalhl7name;
            this.Valuestatus = valuestatus;
            this.Referencerange = referencerange;
            this.Resultstatus = resultstatus;
            this.Labresultstatus = labresultstatus;
        }
        
        /// <summary>
        /// Athena ID for the given lab result observation/analyte
        /// </summary>
        /// <value>Athena ID for the given lab result observation/analyte</value>
        [DataMember(Name="analyteid", EmitDefaultValue=false)]
        public int? Analyteid { get; set; }

        /// <summary>
        /// Name / description specific to this analyte
        /// </summary>
        /// <value>Name / description specific to this analyte</value>
        [DataMember(Name="analytename", EmitDefaultValue=false)]
        public string Analytename { get; set; }

        /// <summary>
        /// Logical Observation Identifiers Names and Codes ID, if available
        /// </summary>
        /// <value>Logical Observation Identifiers Names and Codes ID, if available</value>
        [DataMember(Name="loinc", EmitDefaultValue=false)]
        public string Loinc { get; set; }

        /// <summary>
        /// Value recorded for this observation
        /// </summary>
        /// <value>Value recorded for this observation</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Units for this analyte entry, if provided by the lab
        /// </summary>
        /// <value>Units for this analyte entry, if provided by the lab</value>
        [DataMember(Name="units", EmitDefaultValue=false)]
        public string Units { get; set; }

        /// <summary>
        /// Date when this observation was recorded
        /// </summary>
        /// <value>Date when this observation was recorded</value>
        [DataMember(Name="analytedate", EmitDefaultValue=false)]
        public string Analytedate { get; set; }

        /// <summary>
        /// General description of the lab result test
        /// </summary>
        /// <value>General description of the lab result test</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Additional note for this analyte, if applicable
        /// </summary>
        /// <value>Additional note for this analyte, if applicable</value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }

        /// <summary>
        /// Status indicator of the measurement relative to normal (low, high, normal, abnormal)
        /// </summary>
        /// <value>Status indicator of the measurement relative to normal (low, high, normal, abnormal)</value>
        [DataMember(Name="abnormalflag", EmitDefaultValue=false)]
        public string Abnormalflag { get; set; }

        /// <summary>
        /// The HL7 code related to the abnormal flag.
        /// </summary>
        /// <value>The HL7 code related to the abnormal flag.</value>
        [DataMember(Name="abnormalhl7code", EmitDefaultValue=false)]
        public string Abnormalhl7code { get; set; }

        /// <summary>
        /// The HL7 description related to the abnormal flag.
        /// </summary>
        /// <value>The HL7 description related to the abnormal flag.</value>
        [DataMember(Name="abnormalhl7name", EmitDefaultValue=false)]
        public string Abnormalhl7name { get; set; }

        /// <summary>
        /// DEPRECATED - - use \&quot;abnormalflag\&quot; instead. Status indicator of the measurement relative to normal (low, high, normal, abnormal)
        /// </summary>
        /// <value>DEPRECATED - - use \&quot;abnormalflag\&quot; instead. Status indicator of the measurement relative to normal (low, high, normal, abnormal)</value>
        [DataMember(Name="valuestatus", EmitDefaultValue=false)]
        public string Valuestatus { get; set; }

        /// <summary>
        /// Reference range of values accepted as normal for this observation
        /// </summary>
        /// <value>Reference range of values accepted as normal for this observation</value>
        [DataMember(Name="referencerange", EmitDefaultValue=false)]
        public string Referencerange { get; set; }

        /// <summary>
        /// The status of the result (e.g., \&quot;final\&quot;, \&quot;preliminary\&quot;, \&quot;corrected\&quot;, etc.)
        /// </summary>
        /// <value>The status of the result (e.g., \&quot;final\&quot;, \&quot;preliminary\&quot;, \&quot;corrected\&quot;, etc.)</value>
        [DataMember(Name="resultstatus", EmitDefaultValue=false)]
        public string Resultstatus { get; set; }

        /// <summary>
        /// The status of the underlying lab result
        /// </summary>
        /// <value>The status of the underlying lab result</value>
        [DataMember(Name="labresultstatus", EmitDefaultValue=false)]
        public string Labresultstatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Analyte {\n");
            sb.Append("  Analyteid: ").Append(Analyteid).Append("\n");
            sb.Append("  Analytename: ").Append(Analytename).Append("\n");
            sb.Append("  Loinc: ").Append(Loinc).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  Analytedate: ").Append(Analytedate).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  Abnormalflag: ").Append(Abnormalflag).Append("\n");
            sb.Append("  Abnormalhl7code: ").Append(Abnormalhl7code).Append("\n");
            sb.Append("  Abnormalhl7name: ").Append(Abnormalhl7name).Append("\n");
            sb.Append("  Valuestatus: ").Append(Valuestatus).Append("\n");
            sb.Append("  Referencerange: ").Append(Referencerange).Append("\n");
            sb.Append("  Resultstatus: ").Append(Resultstatus).Append("\n");
            sb.Append("  Labresultstatus: ").Append(Labresultstatus).Append("\n");
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
            return this.Equals(input as Analyte);
        }

        /// <summary>
        /// Returns true if Analyte instances are equal
        /// </summary>
        /// <param name="input">Instance of Analyte to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Analyte input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Analyteid == input.Analyteid ||
                    (this.Analyteid != null &&
                    this.Analyteid.Equals(input.Analyteid))
                ) && 
                (
                    this.Analytename == input.Analytename ||
                    (this.Analytename != null &&
                    this.Analytename.Equals(input.Analytename))
                ) && 
                (
                    this.Loinc == input.Loinc ||
                    (this.Loinc != null &&
                    this.Loinc.Equals(input.Loinc))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Units == input.Units ||
                    (this.Units != null &&
                    this.Units.Equals(input.Units))
                ) && 
                (
                    this.Analytedate == input.Analytedate ||
                    (this.Analytedate != null &&
                    this.Analytedate.Equals(input.Analytedate))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) && 
                (
                    this.Abnormalflag == input.Abnormalflag ||
                    (this.Abnormalflag != null &&
                    this.Abnormalflag.Equals(input.Abnormalflag))
                ) && 
                (
                    this.Abnormalhl7code == input.Abnormalhl7code ||
                    (this.Abnormalhl7code != null &&
                    this.Abnormalhl7code.Equals(input.Abnormalhl7code))
                ) && 
                (
                    this.Abnormalhl7name == input.Abnormalhl7name ||
                    (this.Abnormalhl7name != null &&
                    this.Abnormalhl7name.Equals(input.Abnormalhl7name))
                ) && 
                (
                    this.Valuestatus == input.Valuestatus ||
                    (this.Valuestatus != null &&
                    this.Valuestatus.Equals(input.Valuestatus))
                ) && 
                (
                    this.Referencerange == input.Referencerange ||
                    (this.Referencerange != null &&
                    this.Referencerange.Equals(input.Referencerange))
                ) && 
                (
                    this.Resultstatus == input.Resultstatus ||
                    (this.Resultstatus != null &&
                    this.Resultstatus.Equals(input.Resultstatus))
                ) && 
                (
                    this.Labresultstatus == input.Labresultstatus ||
                    (this.Labresultstatus != null &&
                    this.Labresultstatus.Equals(input.Labresultstatus))
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
                if (this.Analyteid != null)
                    hashCode = hashCode * 59 + this.Analyteid.GetHashCode();
                if (this.Analytename != null)
                    hashCode = hashCode * 59 + this.Analytename.GetHashCode();
                if (this.Loinc != null)
                    hashCode = hashCode * 59 + this.Loinc.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Units != null)
                    hashCode = hashCode * 59 + this.Units.GetHashCode();
                if (this.Analytedate != null)
                    hashCode = hashCode * 59 + this.Analytedate.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Note != null)
                    hashCode = hashCode * 59 + this.Note.GetHashCode();
                if (this.Abnormalflag != null)
                    hashCode = hashCode * 59 + this.Abnormalflag.GetHashCode();
                if (this.Abnormalhl7code != null)
                    hashCode = hashCode * 59 + this.Abnormalhl7code.GetHashCode();
                if (this.Abnormalhl7name != null)
                    hashCode = hashCode * 59 + this.Abnormalhl7name.GetHashCode();
                if (this.Valuestatus != null)
                    hashCode = hashCode * 59 + this.Valuestatus.GetHashCode();
                if (this.Referencerange != null)
                    hashCode = hashCode * 59 + this.Referencerange.GetHashCode();
                if (this.Resultstatus != null)
                    hashCode = hashCode * 59 + this.Resultstatus.GetHashCode();
                if (this.Labresultstatus != null)
                    hashCode = hashCode * 59 + this.Labresultstatus.GetHashCode();
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
