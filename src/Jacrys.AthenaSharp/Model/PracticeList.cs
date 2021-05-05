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
    /// PracticeList
    /// </summary>
    [DataContract]
        public partial class PracticeList :  IEquatable<PracticeList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PracticeList" /> class.
        /// </summary>
        /// <param name="totalcount">totalcount (required).</param>
        /// <param name="practices">practices.</param>
        public PracticeList(int? totalcount = default(int?), List<Practice> practices = default(List<Practice>))
        {
            // to ensure "totalcount" is required (not null)
            if (totalcount == null)
            {
                throw new InvalidDataException("totalcount is a required property for PracticeList and cannot be null");
            }
            else
            {
                this.Totalcount = totalcount;
            }
            this.Practices = practices;
        }
        
        /// <summary>
        /// Gets or Sets Totalcount
        /// </summary>
        [DataMember(Name="totalcount", EmitDefaultValue=false)]
        public int? Totalcount { get; set; }

        /// <summary>
        /// Gets or Sets Practices
        /// </summary>
        [DataMember(Name="practices", EmitDefaultValue=false)]
        public List<Practice> Practices { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PracticeList {\n");
            sb.Append("  Totalcount: ").Append(Totalcount).Append("\n");
            sb.Append("  Practices: ").Append(Practices).Append("\n");
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
            return this.Equals(input as PracticeList);
        }

        /// <summary>
        /// Returns true if PracticeList instances are equal
        /// </summary>
        /// <param name="input">Instance of PracticeList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PracticeList input)
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
                    this.Practices == input.Practices ||
                    this.Practices != null &&
                    input.Practices != null &&
                    this.Practices.SequenceEqual(input.Practices)
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
                if (this.Practices != null)
                    hashCode = hashCode * 59 + this.Practices.GetHashCode();
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
