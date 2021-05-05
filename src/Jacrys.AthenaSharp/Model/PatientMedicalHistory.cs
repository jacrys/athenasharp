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
    /// PatientMedicalHistory
    /// </summary>
    [DataContract]
        public partial class PatientMedicalHistory :  IEquatable<PatientMedicalHistory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatientMedicalHistory" /> class.
        /// </summary>
        /// <param name="sectionnote">Additional notes for the entire medical history section, if any.</param>
        /// <param name="questions">questions.</param>
        public PatientMedicalHistory(string sectionnote = default(string), List<PatientMedicalHistoryQuestion> questions = default(List<PatientMedicalHistoryQuestion>))
        {
            this.Sectionnote = sectionnote;
            this.Questions = questions;
        }
        
        /// <summary>
        /// Additional notes for the entire medical history section, if any
        /// </summary>
        /// <value>Additional notes for the entire medical history section, if any</value>
        [DataMember(Name="sectionnote", EmitDefaultValue=false)]
        public string Sectionnote { get; set; }

        /// <summary>
        /// Gets or Sets Questions
        /// </summary>
        [DataMember(Name="questions", EmitDefaultValue=false)]
        public List<PatientMedicalHistoryQuestion> Questions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatientMedicalHistory {\n");
            sb.Append("  Sectionnote: ").Append(Sectionnote).Append("\n");
            sb.Append("  Questions: ").Append(Questions).Append("\n");
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
            return this.Equals(input as PatientMedicalHistory);
        }

        /// <summary>
        /// Returns true if PatientMedicalHistory instances are equal
        /// </summary>
        /// <param name="input">Instance of PatientMedicalHistory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatientMedicalHistory input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sectionnote == input.Sectionnote ||
                    (this.Sectionnote != null &&
                    this.Sectionnote.Equals(input.Sectionnote))
                ) && 
                (
                    this.Questions == input.Questions ||
                    this.Questions != null &&
                    input.Questions != null &&
                    this.Questions.SequenceEqual(input.Questions)
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
                if (this.Sectionnote != null)
                    hashCode = hashCode * 59 + this.Sectionnote.GetHashCode();
                if (this.Questions != null)
                    hashCode = hashCode * 59 + this.Questions.GetHashCode();
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
