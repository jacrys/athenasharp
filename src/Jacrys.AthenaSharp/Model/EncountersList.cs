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
    /// EncountersList
    /// </summary>
    [DataContract]
        public partial class EncountersList :  IEquatable<EncountersList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EncountersList" /> class.
        /// </summary>
        /// <param name="totalcount">totalcount (required).</param>
        /// <param name="encounters">encounters (required).</param>
        public EncountersList(int? totalcount = default(int?), List<PatientEncounter> encounters = default(List<PatientEncounter>))
        {
            // to ensure "totalcount" is required (not null)
            if (totalcount == null)
            {
                throw new InvalidDataException("totalcount is a required property for EncountersList and cannot be null");
            }
            else
            {
                this.Totalcount = totalcount;
            }
            // to ensure "encounters" is required (not null)
            if (encounters == null)
            {
                throw new InvalidDataException("encounters is a required property for EncountersList and cannot be null");
            }
            else
            {
                this.Encounters = encounters;
            }
        }
        
        /// <summary>
        /// Gets or Sets Totalcount
        /// </summary>
        [DataMember(Name="totalcount", EmitDefaultValue=false)]
        public int? Totalcount { get; set; }

        /// <summary>
        /// Gets or Sets Encounters
        /// </summary>
        [DataMember(Name="encounters", EmitDefaultValue=false)]
        public List<PatientEncounter> Encounters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EncountersList {\n");
            sb.Append("  Totalcount: ").Append(Totalcount).Append("\n");
            sb.Append("  Encounters: ").Append(Encounters).Append("\n");
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
            return this.Equals(input as EncountersList);
        }

        /// <summary>
        /// Returns true if EncountersList instances are equal
        /// </summary>
        /// <param name="input">Instance of EncountersList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EncountersList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Totalcount == input.Totalcount ||
                    (this.Totalcount != null &&
                    this.Totalcount.Equals(input.Totalcount))
                ) && 
                (
                    this.Encounters == input.Encounters ||
                    this.Encounters != null &&
                    input.Encounters != null &&
                    this.Encounters.SequenceEqual(input.Encounters)
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
                if (this.Totalcount != null)
                    hashCode = hashCode * 59 + this.Totalcount.GetHashCode();
                if (this.Encounters != null)
                    hashCode = hashCode * 59 + this.Encounters.GetHashCode();
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
