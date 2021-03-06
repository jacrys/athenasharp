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
    /// EncounterDiagnosis
    /// </summary>
    [DataContract]
        public partial class EncounterDiagnosis :  IEquatable<EncounterDiagnosis>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EncounterDiagnosis" /> class.
        /// </summary>
        /// <param name="diagnosisicd">The matching ICD9 or ICD10 codes for this diagnosis, where available..</param>
        /// <param name="orders">List of diagnoses for this encounter.</param>
        /// <param name="diagnosissnomed">The SNOMED code for this diagnosis. 0 means No Diagnosis..</param>
        /// <param name="diagnosis">The name of the diagnosis.</param>
        public EncounterDiagnosis(List<Code> diagnosisicd = default(List<Code>), List<PatientEncounterOrder> orders = default(List<PatientEncounterOrder>), int? diagnosissnomed = default(int?), string diagnosis = default(string))
        {
            this.Diagnosisicd = diagnosisicd;
            this.Orders = orders;
            this.Diagnosissnomed = diagnosissnomed;
            this.Diagnosis = diagnosis;
        }
        
        /// <summary>
        /// The matching ICD9 or ICD10 codes for this diagnosis, where available.
        /// </summary>
        /// <value>The matching ICD9 or ICD10 codes for this diagnosis, where available.</value>
        [DataMember(Name="diagnosisicd", EmitDefaultValue=false)]
        public List<Code> Diagnosisicd { get; set; }

        /// <summary>
        /// List of diagnoses for this encounter
        /// </summary>
        /// <value>List of diagnoses for this encounter</value>
        [DataMember(Name="orders", EmitDefaultValue=false)]
        public List<PatientEncounterOrder> Orders { get; set; }

        /// <summary>
        /// The SNOMED code for this diagnosis. 0 means No Diagnosis.
        /// </summary>
        /// <value>The SNOMED code for this diagnosis. 0 means No Diagnosis.</value>
        [DataMember(Name="diagnosissnomed", EmitDefaultValue=false)]
        public int? Diagnosissnomed { get; set; }

        /// <summary>
        /// The name of the diagnosis
        /// </summary>
        /// <value>The name of the diagnosis</value>
        [DataMember(Name="diagnosis", EmitDefaultValue=false)]
        public string Diagnosis { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EncounterDiagnosis {\n");
            sb.Append("  Diagnosisicd: ").Append(Diagnosisicd).Append("\n");
            sb.Append("  Orders: ").Append(Orders).Append("\n");
            sb.Append("  Diagnosissnomed: ").Append(Diagnosissnomed).Append("\n");
            sb.Append("  Diagnosis: ").Append(Diagnosis).Append("\n");
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
            return this.Equals(input as EncounterDiagnosis);
        }

        /// <summary>
        /// Returns true if EncounterDiagnosis instances are equal
        /// </summary>
        /// <param name="input">Instance of EncounterDiagnosis to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EncounterDiagnosis input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Diagnosisicd == input.Diagnosisicd ||
                    this.Diagnosisicd != null &&
                    input.Diagnosisicd != null &&
                    this.Diagnosisicd.SequenceEqual(input.Diagnosisicd)
                ) && 
                (
                    this.Orders == input.Orders ||
                    this.Orders != null &&
                    input.Orders != null &&
                    this.Orders.SequenceEqual(input.Orders)
                ) && 
                (
                    this.Diagnosissnomed == input.Diagnosissnomed ||
                    (this.Diagnosissnomed != null &&
                    this.Diagnosissnomed.Equals(input.Diagnosissnomed))
                ) && 
                (
                    this.Diagnosis == input.Diagnosis ||
                    (this.Diagnosis != null &&
                    this.Diagnosis.Equals(input.Diagnosis))
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
                if (this.Diagnosisicd != null)
                    hashCode = hashCode * 59 + this.Diagnosisicd.GetHashCode();
                if (this.Orders != null)
                    hashCode = hashCode * 59 + this.Orders.GetHashCode();
                if (this.Diagnosissnomed != null)
                    hashCode = hashCode * 59 + this.Diagnosissnomed.GetHashCode();
                if (this.Diagnosis != null)
                    hashCode = hashCode * 59 + this.Diagnosis.GetHashCode();
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
