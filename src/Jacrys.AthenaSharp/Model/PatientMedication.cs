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
    /// PatientMedication
    /// </summary>
    [DataContract]
        public partial class PatientMedication :  IEquatable<PatientMedication>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatientMedication" /> class.
        /// </summary>
        /// <param name="nomedicationsreported">Whether the patient explicitly has no reported medications (required).</param>
        /// <param name="medications">medications (required).</param>
        /// <param name="sectionnote">A section-wide note.</param>
        /// <param name="lastupdated">The last time any of the medications were updated (required).</param>
        /// <param name="patientdownloadconsent">Whether or not the patient has consented to have their medication history downloaded. There are plans to deprecate this field..</param>
        /// <param name="patientneedsdownloadconsent">Whether or not the patient needs to consent to have medication history downloaded. This will be true if either the patient has not currently consented, or the practice is not enabled for these downloads. This field is typically used when determining whether to message to the patient that they have not consented to these downloads. Note that regardless of this setting, medication history that has already been downloaded will remain available. .</param>
        /// <param name="lastdownloadeddate">The time of the last attempted medication history download from SureScripts..</param>
        /// <param name="lastdownloaddenied">BETA FIELD: Whether or not the last medication history download was denied. .</param>
        /// <param name="lastdownloaddenialreason">BETA FIELD: The reason the last medication history download was denied. .</param>
        public PatientMedication(bool? nomedicationsreported = default(bool?), List<List<Medication>> medications = default(List<List<Medication>>), string sectionnote = default(string), string lastupdated = default(string), bool? patientdownloadconsent = default(bool?), bool? patientneedsdownloadconsent = default(bool?), string lastdownloadeddate = default(string), bool? lastdownloaddenied = default(bool?), string lastdownloaddenialreason = default(string))
        {
            // to ensure "nomedicationsreported" is required (not null)
            if (nomedicationsreported == null)
            {
                throw new InvalidDataException("nomedicationsreported is a required property for PatientMedication and cannot be null");
            }
            else
            {
                this.Nomedicationsreported = nomedicationsreported;
            }
            // to ensure "medications" is required (not null)
            if (medications == null)
            {
                throw new InvalidDataException("medications is a required property for PatientMedication and cannot be null");
            }
            else
            {
                this.Medications = medications;
            }
            // to ensure "lastupdated" is required (not null)
            if (lastupdated == null)
            {
                throw new InvalidDataException("lastupdated is a required property for PatientMedication and cannot be null");
            }
            else
            {
                this.Lastupdated = lastupdated;
            }
            this.Sectionnote = sectionnote;
            this.Patientdownloadconsent = patientdownloadconsent;
            this.Patientneedsdownloadconsent = patientneedsdownloadconsent;
            this.Lastdownloadeddate = lastdownloadeddate;
            this.Lastdownloaddenied = lastdownloaddenied;
            this.Lastdownloaddenialreason = lastdownloaddenialreason;
        }
        
        /// <summary>
        /// Whether the patient explicitly has no reported medications
        /// </summary>
        /// <value>Whether the patient explicitly has no reported medications</value>
        [DataMember(Name="nomedicationsreported", EmitDefaultValue=false)]
        public bool? Nomedicationsreported { get; set; }

        /// <summary>
        /// Gets or Sets Medications
        /// </summary>
        [DataMember(Name="medications", EmitDefaultValue=false)]
        public List<List<Medication>> Medications { get; set; }

        /// <summary>
        /// A section-wide note
        /// </summary>
        /// <value>A section-wide note</value>
        [DataMember(Name="sectionnote", EmitDefaultValue=false)]
        public string Sectionnote { get; set; }

        /// <summary>
        /// The last time any of the medications were updated
        /// </summary>
        /// <value>The last time any of the medications were updated</value>
        [DataMember(Name="lastupdated", EmitDefaultValue=false)]
        public string Lastupdated { get; set; }

        /// <summary>
        /// Whether or not the patient has consented to have their medication history downloaded. There are plans to deprecate this field.
        /// </summary>
        /// <value>Whether or not the patient has consented to have their medication history downloaded. There are plans to deprecate this field.</value>
        [DataMember(Name="patientdownloadconsent", EmitDefaultValue=false)]
        public bool? Patientdownloadconsent { get; set; }

        /// <summary>
        /// Whether or not the patient needs to consent to have medication history downloaded. This will be true if either the patient has not currently consented, or the practice is not enabled for these downloads. This field is typically used when determining whether to message to the patient that they have not consented to these downloads. Note that regardless of this setting, medication history that has already been downloaded will remain available. 
        /// </summary>
        /// <value>Whether or not the patient needs to consent to have medication history downloaded. This will be true if either the patient has not currently consented, or the practice is not enabled for these downloads. This field is typically used when determining whether to message to the patient that they have not consented to these downloads. Note that regardless of this setting, medication history that has already been downloaded will remain available. </value>
        [DataMember(Name="patientneedsdownloadconsent", EmitDefaultValue=false)]
        public bool? Patientneedsdownloadconsent { get; set; }

        /// <summary>
        /// The time of the last attempted medication history download from SureScripts.
        /// </summary>
        /// <value>The time of the last attempted medication history download from SureScripts.</value>
        [DataMember(Name="lastdownloadeddate", EmitDefaultValue=false)]
        public string Lastdownloadeddate { get; set; }

        /// <summary>
        /// BETA FIELD: Whether or not the last medication history download was denied. 
        /// </summary>
        /// <value>BETA FIELD: Whether or not the last medication history download was denied. </value>
        [DataMember(Name="lastdownloaddenied", EmitDefaultValue=false)]
        public bool? Lastdownloaddenied { get; set; }

        /// <summary>
        /// BETA FIELD: The reason the last medication history download was denied. 
        /// </summary>
        /// <value>BETA FIELD: The reason the last medication history download was denied. </value>
        [DataMember(Name="lastdownloaddenialreason", EmitDefaultValue=false)]
        public string Lastdownloaddenialreason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatientMedication {\n");
            sb.Append("  Nomedicationsreported: ").Append(Nomedicationsreported).Append("\n");
            sb.Append("  Medications: ").Append(Medications).Append("\n");
            sb.Append("  Sectionnote: ").Append(Sectionnote).Append("\n");
            sb.Append("  Lastupdated: ").Append(Lastupdated).Append("\n");
            sb.Append("  Patientdownloadconsent: ").Append(Patientdownloadconsent).Append("\n");
            sb.Append("  Patientneedsdownloadconsent: ").Append(Patientneedsdownloadconsent).Append("\n");
            sb.Append("  Lastdownloadeddate: ").Append(Lastdownloadeddate).Append("\n");
            sb.Append("  Lastdownloaddenied: ").Append(Lastdownloaddenied).Append("\n");
            sb.Append("  Lastdownloaddenialreason: ").Append(Lastdownloaddenialreason).Append("\n");
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
            return this.Equals(input as PatientMedication);
        }

        /// <summary>
        /// Returns true if PatientMedication instances are equal
        /// </summary>
        /// <param name="input">Instance of PatientMedication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatientMedication input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Nomedicationsreported == input.Nomedicationsreported ||
                    (this.Nomedicationsreported != null &&
                    this.Nomedicationsreported.Equals(input.Nomedicationsreported))
                ) && 
                (
                    this.Medications == input.Medications ||
                    this.Medications != null &&
                    input.Medications != null &&
                    this.Medications.SequenceEqual(input.Medications)
                ) && 
                (
                    this.Sectionnote == input.Sectionnote ||
                    (this.Sectionnote != null &&
                    this.Sectionnote.Equals(input.Sectionnote))
                ) && 
                (
                    this.Lastupdated == input.Lastupdated ||
                    (this.Lastupdated != null &&
                    this.Lastupdated.Equals(input.Lastupdated))
                ) && 
                (
                    this.Patientdownloadconsent == input.Patientdownloadconsent ||
                    (this.Patientdownloadconsent != null &&
                    this.Patientdownloadconsent.Equals(input.Patientdownloadconsent))
                ) && 
                (
                    this.Patientneedsdownloadconsent == input.Patientneedsdownloadconsent ||
                    (this.Patientneedsdownloadconsent != null &&
                    this.Patientneedsdownloadconsent.Equals(input.Patientneedsdownloadconsent))
                ) && 
                (
                    this.Lastdownloadeddate == input.Lastdownloadeddate ||
                    (this.Lastdownloadeddate != null &&
                    this.Lastdownloadeddate.Equals(input.Lastdownloadeddate))
                ) && 
                (
                    this.Lastdownloaddenied == input.Lastdownloaddenied ||
                    (this.Lastdownloaddenied != null &&
                    this.Lastdownloaddenied.Equals(input.Lastdownloaddenied))
                ) && 
                (
                    this.Lastdownloaddenialreason == input.Lastdownloaddenialreason ||
                    (this.Lastdownloaddenialreason != null &&
                    this.Lastdownloaddenialreason.Equals(input.Lastdownloaddenialreason))
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
                if (this.Nomedicationsreported != null)
                    hashCode = hashCode * 59 + this.Nomedicationsreported.GetHashCode();
                if (this.Medications != null)
                    hashCode = hashCode * 59 + this.Medications.GetHashCode();
                if (this.Sectionnote != null)
                    hashCode = hashCode * 59 + this.Sectionnote.GetHashCode();
                if (this.Lastupdated != null)
                    hashCode = hashCode * 59 + this.Lastupdated.GetHashCode();
                if (this.Patientdownloadconsent != null)
                    hashCode = hashCode * 59 + this.Patientdownloadconsent.GetHashCode();
                if (this.Patientneedsdownloadconsent != null)
                    hashCode = hashCode * 59 + this.Patientneedsdownloadconsent.GetHashCode();
                if (this.Lastdownloadeddate != null)
                    hashCode = hashCode * 59 + this.Lastdownloadeddate.GetHashCode();
                if (this.Lastdownloaddenied != null)
                    hashCode = hashCode * 59 + this.Lastdownloaddenied.GetHashCode();
                if (this.Lastdownloaddenialreason != null)
                    hashCode = hashCode * 59 + this.Lastdownloaddenialreason.GetHashCode();
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
