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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = Jacrys.AthenaSharp.Client.SwaggerDateConverter;

namespace Jacrys.AthenaSharp.Model
{
    /// <summary>
    /// PatientVital
    /// </summary>
    [DataContract]
        public partial class PatientVital :  IEquatable<PatientVital>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatientVital" /> class.
        /// </summary>
        /// <param name="readings">List of vital attribute readings. One entry per attribute (so the temperature and where the temperature was taken are two different readings, tied together by the readingid .</param>
        /// <param name="key">Key for this vital group. E.g., HEIGHT..</param>
        /// <param name="abbreviation">Short human-readable string for this vital group. E.g., Ht..</param>
        /// <param name="ordering">Configured order for this vital group.</param>
        public PatientVital(List<List<VitalAttributeReading>> readings = default(List<List<VitalAttributeReading>>), string key = default(string), string abbreviation = default(string), int? ordering = default(int?))
        {
            this.Readings = readings;
            this.Key = key;
            this.Abbreviation = abbreviation;
            this.Ordering = ordering;
        }
        
        /// <summary>
        /// List of vital attribute readings. One entry per attribute (so the temperature and where the temperature was taken are two different readings, tied together by the readingid 
        /// </summary>
        /// <value>List of vital attribute readings. One entry per attribute (so the temperature and where the temperature was taken are two different readings, tied together by the readingid </value>
        [DataMember(Name="readings", EmitDefaultValue=false)]
        public List<List<VitalAttributeReading>> Readings { get; set; }

        /// <summary>
        /// Key for this vital group. E.g., HEIGHT.
        /// </summary>
        /// <value>Key for this vital group. E.g., HEIGHT.</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// Short human-readable string for this vital group. E.g., Ht.
        /// </summary>
        /// <value>Short human-readable string for this vital group. E.g., Ht.</value>
        [DataMember(Name="abbreviation", EmitDefaultValue=false)]
        public string Abbreviation { get; set; }

        /// <summary>
        /// Configured order for this vital group
        /// </summary>
        /// <value>Configured order for this vital group</value>
        [DataMember(Name="ordering", EmitDefaultValue=false)]
        public int? Ordering { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatientVital {\n");
            sb.Append("  Readings: ").Append(Readings).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Abbreviation: ").Append(Abbreviation).Append("\n");
            sb.Append("  Ordering: ").Append(Ordering).Append("\n");
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
            return this.Equals(input as PatientVital);
        }

        /// <summary>
        /// Returns true if PatientVital instances are equal
        /// </summary>
        /// <param name="input">Instance of PatientVital to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatientVital input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Readings == input.Readings ||
                    this.Readings != null &&
                    input.Readings != null &&
                    this.Readings.SequenceEqual(input.Readings)
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Abbreviation == input.Abbreviation ||
                    (this.Abbreviation != null &&
                    this.Abbreviation.Equals(input.Abbreviation))
                ) && 
                (
                    this.Ordering == input.Ordering ||
                    (this.Ordering != null &&
                    this.Ordering.Equals(input.Ordering))
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
                if (this.Readings != null)
                    hashCode = hashCode * 59 + this.Readings.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Abbreviation != null)
                    hashCode = hashCode * 59 + this.Abbreviation.GetHashCode();
                if (this.Ordering != null)
                    hashCode = hashCode * 59 + this.Ordering.GetHashCode();
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
