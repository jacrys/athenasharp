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
    /// AppointmentDiagnosis
    /// </summary>
    [DataContract]
        public partial class AppointmentDiagnosis :  IEquatable<AppointmentDiagnosis>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentDiagnosis" /> class.
        /// </summary>
        /// <param name="diagnosisid">A unique ID related to this diagnosis..</param>
        /// <param name="diagnosisdescription">A description of this diagnosis..</param>
        /// <param name="diagnosisrawcode">The raw ICD-9 code. This will migrate to ICD-10 in the future..</param>
        /// <param name="diagnosiscategory">The category for this diagnosis..</param>
        /// <param name="deleteddiagnosis">In certain cases, diagnoses may be added and then removed from a particular claim. In normal circumstances, this will be false. However, if a diagnosis was removed, this will be true. .</param>
        /// <param name="diagnosiscodeset">Either ICD9 or ICD10..</param>
        public AppointmentDiagnosis(int? diagnosisid = default(int?), string diagnosisdescription = default(string), string diagnosisrawcode = default(string), string diagnosiscategory = default(string), string deleteddiagnosis = default(string), string diagnosiscodeset = default(string))
        {
            this.Diagnosisid = diagnosisid;
            this.Diagnosisdescription = diagnosisdescription;
            this.Diagnosisrawcode = diagnosisrawcode;
            this.Diagnosiscategory = diagnosiscategory;
            this.Deleteddiagnosis = deleteddiagnosis;
            this.Diagnosiscodeset = diagnosiscodeset;
        }
        
        /// <summary>
        /// A unique ID related to this diagnosis.
        /// </summary>
        /// <value>A unique ID related to this diagnosis.</value>
        [DataMember(Name="diagnosisid", EmitDefaultValue=false)]
        public int? Diagnosisid { get; set; }

        /// <summary>
        /// A description of this diagnosis.
        /// </summary>
        /// <value>A description of this diagnosis.</value>
        [DataMember(Name="diagnosisdescription", EmitDefaultValue=false)]
        public string Diagnosisdescription { get; set; }

        /// <summary>
        /// The raw ICD-9 code. This will migrate to ICD-10 in the future.
        /// </summary>
        /// <value>The raw ICD-9 code. This will migrate to ICD-10 in the future.</value>
        [DataMember(Name="diagnosisrawcode", EmitDefaultValue=false)]
        public string Diagnosisrawcode { get; set; }

        /// <summary>
        /// The category for this diagnosis.
        /// </summary>
        /// <value>The category for this diagnosis.</value>
        [DataMember(Name="diagnosiscategory", EmitDefaultValue=false)]
        public string Diagnosiscategory { get; set; }

        /// <summary>
        /// In certain cases, diagnoses may be added and then removed from a particular claim. In normal circumstances, this will be false. However, if a diagnosis was removed, this will be true. 
        /// </summary>
        /// <value>In certain cases, diagnoses may be added and then removed from a particular claim. In normal circumstances, this will be false. However, if a diagnosis was removed, this will be true. </value>
        [DataMember(Name="deleteddiagnosis", EmitDefaultValue=false)]
        public string Deleteddiagnosis { get; set; }

        /// <summary>
        /// Either ICD9 or ICD10.
        /// </summary>
        /// <value>Either ICD9 or ICD10.</value>
        [DataMember(Name="diagnosiscodeset", EmitDefaultValue=false)]
        public string Diagnosiscodeset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppointmentDiagnosis {\n");
            sb.Append("  Diagnosisid: ").Append(Diagnosisid).Append("\n");
            sb.Append("  Diagnosisdescription: ").Append(Diagnosisdescription).Append("\n");
            sb.Append("  Diagnosisrawcode: ").Append(Diagnosisrawcode).Append("\n");
            sb.Append("  Diagnosiscategory: ").Append(Diagnosiscategory).Append("\n");
            sb.Append("  Deleteddiagnosis: ").Append(Deleteddiagnosis).Append("\n");
            sb.Append("  Diagnosiscodeset: ").Append(Diagnosiscodeset).Append("\n");
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
            return this.Equals(input as AppointmentDiagnosis);
        }

        /// <summary>
        /// Returns true if AppointmentDiagnosis instances are equal
        /// </summary>
        /// <param name="input">Instance of AppointmentDiagnosis to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppointmentDiagnosis input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Diagnosisid == input.Diagnosisid ||
                    (this.Diagnosisid != null &&
                    this.Diagnosisid.Equals(input.Diagnosisid))
                ) && 
                (
                    this.Diagnosisdescription == input.Diagnosisdescription ||
                    (this.Diagnosisdescription != null &&
                    this.Diagnosisdescription.Equals(input.Diagnosisdescription))
                ) && 
                (
                    this.Diagnosisrawcode == input.Diagnosisrawcode ||
                    (this.Diagnosisrawcode != null &&
                    this.Diagnosisrawcode.Equals(input.Diagnosisrawcode))
                ) && 
                (
                    this.Diagnosiscategory == input.Diagnosiscategory ||
                    (this.Diagnosiscategory != null &&
                    this.Diagnosiscategory.Equals(input.Diagnosiscategory))
                ) && 
                (
                    this.Deleteddiagnosis == input.Deleteddiagnosis ||
                    (this.Deleteddiagnosis != null &&
                    this.Deleteddiagnosis.Equals(input.Deleteddiagnosis))
                ) && 
                (
                    this.Diagnosiscodeset == input.Diagnosiscodeset ||
                    (this.Diagnosiscodeset != null &&
                    this.Diagnosiscodeset.Equals(input.Diagnosiscodeset))
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
                if (this.Diagnosisid != null)
                    hashCode = hashCode * 59 + this.Diagnosisid.GetHashCode();
                if (this.Diagnosisdescription != null)
                    hashCode = hashCode * 59 + this.Diagnosisdescription.GetHashCode();
                if (this.Diagnosisrawcode != null)
                    hashCode = hashCode * 59 + this.Diagnosisrawcode.GetHashCode();
                if (this.Diagnosiscategory != null)
                    hashCode = hashCode * 59 + this.Diagnosiscategory.GetHashCode();
                if (this.Deleteddiagnosis != null)
                    hashCode = hashCode * 59 + this.Deleteddiagnosis.GetHashCode();
                if (this.Diagnosiscodeset != null)
                    hashCode = hashCode * 59 + this.Diagnosiscodeset.GetHashCode();
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