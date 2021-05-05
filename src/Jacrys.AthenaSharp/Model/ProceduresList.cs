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
    /// ProceduresList
    /// </summary>
    [DataContract]
        public partial class ProceduresList :  IEquatable<ProceduresList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProceduresList" /> class.
        /// </summary>
        /// <param name="sectionnote">Additional note for the entire surgical history section, if any.</param>
        /// <param name="procedures">procedures (required).</param>
        public ProceduresList(string sectionnote = default(string), List<PatientProcedure> procedures = default(List<PatientProcedure>))
        {
            // to ensure "procedures" is required (not null)
            if (procedures == null)
            {
                throw new InvalidDataException("procedures is a required property for ProceduresList and cannot be null");
            }
            else
            {
                this.Procedures = procedures;
            }
            this.Sectionnote = sectionnote;
        }
        
        /// <summary>
        /// Additional note for the entire surgical history section, if any
        /// </summary>
        /// <value>Additional note for the entire surgical history section, if any</value>
        [DataMember(Name="sectionnote", EmitDefaultValue=false)]
        public string Sectionnote { get; set; }

        /// <summary>
        /// Gets or Sets Procedures
        /// </summary>
        [DataMember(Name="procedures", EmitDefaultValue=false)]
        public List<PatientProcedure> Procedures { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProceduresList {\n");
            sb.Append("  Sectionnote: ").Append(Sectionnote).Append("\n");
            sb.Append("  Procedures: ").Append(Procedures).Append("\n");
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
            return this.Equals(input as ProceduresList);
        }

        /// <summary>
        /// Returns true if ProceduresList instances are equal
        /// </summary>
        /// <param name="input">Instance of ProceduresList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProceduresList input)
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
                    this.Procedures == input.Procedures ||
                    this.Procedures != null &&
                    input.Procedures != null &&
                    this.Procedures.SequenceEqual(input.Procedures)
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
                if (this.Procedures != null)
                    hashCode = hashCode * 59 + this.Procedures.GetHashCode();
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