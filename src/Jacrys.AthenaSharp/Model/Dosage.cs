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
    /// Dosage
    /// </summary>
    [DataContract]
        public partial class Dosage :  IEquatable<Dosage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dosage" /> class.
        /// </summary>
        /// <param name="dosageaction">How the medication is taken. Examples are Chew, Take, Inhale, etc. (required).</param>
        /// <param name="dosagequantityvalue">How many of this med is taken. (required).</param>
        /// <param name="dosagequantityunit">The unit of the quantity. Example: tablets, sprays, etc.  (required).</param>
        /// <param name="dosagefrequencyvalue">How many times (in the given time unit) this should be taken..</param>
        /// <param name="dosagefrequencyunit">The unit of the frequency. Example: per day, per week. .</param>
        /// <param name="dosagefrequencydescription">A standardized patient-friendly frequency. Example: 6 per day becomes \&quot;every 4 hours\&quot;. .</param>
        /// <param name="dosageroute">How this medication is taken. Example: oral, inhalation, intranasal, etc. .</param>
        /// <param name="dosageadditionalinstructions">Additional instructions. Example: with meals .</param>
        /// <param name="dosagedurationvalue">How many duration time units this medication should be taken for..</param>
        /// <param name="dosagedurationunit">The unit of the duration. Example: days. So take this for days. .</param>
        public Dosage(string dosageaction = default(string), decimal? dosagequantityvalue = default(decimal?), string dosagequantityunit = default(string), decimal? dosagefrequencyvalue = default(decimal?), string dosagefrequencyunit = default(string), string dosagefrequencydescription = default(string), string dosageroute = default(string), string dosageadditionalinstructions = default(string), int? dosagedurationvalue = default(int?), string dosagedurationunit = default(string))
        {
            // to ensure "dosageaction" is required (not null)
            if (dosageaction == null)
            {
                throw new InvalidDataException("dosageaction is a required property for Dosage and cannot be null");
            }
            else
            {
                this.Dosageaction = dosageaction;
            }
            // to ensure "dosagequantityvalue" is required (not null)
            if (dosagequantityvalue == null)
            {
                throw new InvalidDataException("dosagequantityvalue is a required property for Dosage and cannot be null");
            }
            else
            {
                this.Dosagequantityvalue = dosagequantityvalue;
            }
            // to ensure "dosagequantityunit" is required (not null)
            if (dosagequantityunit == null)
            {
                throw new InvalidDataException("dosagequantityunit is a required property for Dosage and cannot be null");
            }
            else
            {
                this.Dosagequantityunit = dosagequantityunit;
            }
            this.Dosagefrequencyvalue = dosagefrequencyvalue;
            this.Dosagefrequencyunit = dosagefrequencyunit;
            this.Dosagefrequencydescription = dosagefrequencydescription;
            this.Dosageroute = dosageroute;
            this.Dosageadditionalinstructions = dosageadditionalinstructions;
            this.Dosagedurationvalue = dosagedurationvalue;
            this.Dosagedurationunit = dosagedurationunit;
        }
        
        /// <summary>
        /// How the medication is taken. Examples are Chew, Take, Inhale, etc.
        /// </summary>
        /// <value>How the medication is taken. Examples are Chew, Take, Inhale, etc.</value>
        [DataMember(Name="dosageaction", EmitDefaultValue=false)]
        public string Dosageaction { get; set; }

        /// <summary>
        /// How many of this med is taken.
        /// </summary>
        /// <value>How many of this med is taken.</value>
        [DataMember(Name="dosagequantityvalue", EmitDefaultValue=false)]
        public decimal? Dosagequantityvalue { get; set; }

        /// <summary>
        /// The unit of the quantity. Example: tablets, sprays, etc. 
        /// </summary>
        /// <value>The unit of the quantity. Example: tablets, sprays, etc. </value>
        [DataMember(Name="dosagequantityunit", EmitDefaultValue=false)]
        public string Dosagequantityunit { get; set; }

        /// <summary>
        /// How many times (in the given time unit) this should be taken.
        /// </summary>
        /// <value>How many times (in the given time unit) this should be taken.</value>
        [DataMember(Name="dosagefrequencyvalue", EmitDefaultValue=false)]
        public decimal? Dosagefrequencyvalue { get; set; }

        /// <summary>
        /// The unit of the frequency. Example: per day, per week. 
        /// </summary>
        /// <value>The unit of the frequency. Example: per day, per week. </value>
        [DataMember(Name="dosagefrequencyunit", EmitDefaultValue=false)]
        public string Dosagefrequencyunit { get; set; }

        /// <summary>
        /// A standardized patient-friendly frequency. Example: 6 per day becomes \&quot;every 4 hours\&quot;. 
        /// </summary>
        /// <value>A standardized patient-friendly frequency. Example: 6 per day becomes \&quot;every 4 hours\&quot;. </value>
        [DataMember(Name="dosagefrequencydescription", EmitDefaultValue=false)]
        public string Dosagefrequencydescription { get; set; }

        /// <summary>
        /// How this medication is taken. Example: oral, inhalation, intranasal, etc. 
        /// </summary>
        /// <value>How this medication is taken. Example: oral, inhalation, intranasal, etc. </value>
        [DataMember(Name="dosageroute", EmitDefaultValue=false)]
        public string Dosageroute { get; set; }

        /// <summary>
        /// Additional instructions. Example: with meals 
        /// </summary>
        /// <value>Additional instructions. Example: with meals </value>
        [DataMember(Name="dosageadditionalinstructions", EmitDefaultValue=false)]
        public string Dosageadditionalinstructions { get; set; }

        /// <summary>
        /// How many duration time units this medication should be taken for.
        /// </summary>
        /// <value>How many duration time units this medication should be taken for.</value>
        [DataMember(Name="dosagedurationvalue", EmitDefaultValue=false)]
        public int? Dosagedurationvalue { get; set; }

        /// <summary>
        /// The unit of the duration. Example: days. So take this for days. 
        /// </summary>
        /// <value>The unit of the duration. Example: days. So take this for days. </value>
        [DataMember(Name="dosagedurationunit", EmitDefaultValue=false)]
        public string Dosagedurationunit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Dosage {\n");
            sb.Append("  Dosageaction: ").Append(Dosageaction).Append("\n");
            sb.Append("  Dosagequantityvalue: ").Append(Dosagequantityvalue).Append("\n");
            sb.Append("  Dosagequantityunit: ").Append(Dosagequantityunit).Append("\n");
            sb.Append("  Dosagefrequencyvalue: ").Append(Dosagefrequencyvalue).Append("\n");
            sb.Append("  Dosagefrequencyunit: ").Append(Dosagefrequencyunit).Append("\n");
            sb.Append("  Dosagefrequencydescription: ").Append(Dosagefrequencydescription).Append("\n");
            sb.Append("  Dosageroute: ").Append(Dosageroute).Append("\n");
            sb.Append("  Dosageadditionalinstructions: ").Append(Dosageadditionalinstructions).Append("\n");
            sb.Append("  Dosagedurationvalue: ").Append(Dosagedurationvalue).Append("\n");
            sb.Append("  Dosagedurationunit: ").Append(Dosagedurationunit).Append("\n");
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
            return this.Equals(input as Dosage);
        }

        /// <summary>
        /// Returns true if Dosage instances are equal
        /// </summary>
        /// <param name="input">Instance of Dosage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Dosage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Dosageaction == input.Dosageaction ||
                    (this.Dosageaction != null &&
                    this.Dosageaction.Equals(input.Dosageaction))
                ) && 
                (
                    this.Dosagequantityvalue == input.Dosagequantityvalue ||
                    (this.Dosagequantityvalue != null &&
                    this.Dosagequantityvalue.Equals(input.Dosagequantityvalue))
                ) && 
                (
                    this.Dosagequantityunit == input.Dosagequantityunit ||
                    (this.Dosagequantityunit != null &&
                    this.Dosagequantityunit.Equals(input.Dosagequantityunit))
                ) && 
                (
                    this.Dosagefrequencyvalue == input.Dosagefrequencyvalue ||
                    (this.Dosagefrequencyvalue != null &&
                    this.Dosagefrequencyvalue.Equals(input.Dosagefrequencyvalue))
                ) && 
                (
                    this.Dosagefrequencyunit == input.Dosagefrequencyunit ||
                    (this.Dosagefrequencyunit != null &&
                    this.Dosagefrequencyunit.Equals(input.Dosagefrequencyunit))
                ) && 
                (
                    this.Dosagefrequencydescription == input.Dosagefrequencydescription ||
                    (this.Dosagefrequencydescription != null &&
                    this.Dosagefrequencydescription.Equals(input.Dosagefrequencydescription))
                ) && 
                (
                    this.Dosageroute == input.Dosageroute ||
                    (this.Dosageroute != null &&
                    this.Dosageroute.Equals(input.Dosageroute))
                ) && 
                (
                    this.Dosageadditionalinstructions == input.Dosageadditionalinstructions ||
                    (this.Dosageadditionalinstructions != null &&
                    this.Dosageadditionalinstructions.Equals(input.Dosageadditionalinstructions))
                ) && 
                (
                    this.Dosagedurationvalue == input.Dosagedurationvalue ||
                    (this.Dosagedurationvalue != null &&
                    this.Dosagedurationvalue.Equals(input.Dosagedurationvalue))
                ) && 
                (
                    this.Dosagedurationunit == input.Dosagedurationunit ||
                    (this.Dosagedurationunit != null &&
                    this.Dosagedurationunit.Equals(input.Dosagedurationunit))
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
                if (this.Dosageaction != null)
                    hashCode = hashCode * 59 + this.Dosageaction.GetHashCode();
                if (this.Dosagequantityvalue != null)
                    hashCode = hashCode * 59 + this.Dosagequantityvalue.GetHashCode();
                if (this.Dosagequantityunit != null)
                    hashCode = hashCode * 59 + this.Dosagequantityunit.GetHashCode();
                if (this.Dosagefrequencyvalue != null)
                    hashCode = hashCode * 59 + this.Dosagefrequencyvalue.GetHashCode();
                if (this.Dosagefrequencyunit != null)
                    hashCode = hashCode * 59 + this.Dosagefrequencyunit.GetHashCode();
                if (this.Dosagefrequencydescription != null)
                    hashCode = hashCode * 59 + this.Dosagefrequencydescription.GetHashCode();
                if (this.Dosageroute != null)
                    hashCode = hashCode * 59 + this.Dosageroute.GetHashCode();
                if (this.Dosageadditionalinstructions != null)
                    hashCode = hashCode * 59 + this.Dosageadditionalinstructions.GetHashCode();
                if (this.Dosagedurationvalue != null)
                    hashCode = hashCode * 59 + this.Dosagedurationvalue.GetHashCode();
                if (this.Dosagedurationunit != null)
                    hashCode = hashCode * 59 + this.Dosagedurationunit.GetHashCode();
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