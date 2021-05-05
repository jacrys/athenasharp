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
    /// PatientCcda
    /// </summary>
    [DataContract]
        public partial class PatientCcda :  IEquatable<PatientCcda>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatientCcda" /> class.
        /// </summary>
        /// <param name="ccda">Content of CCDA record for the patient..</param>
        public PatientCcda(string ccda = default(string))
        {
            this.Ccda = ccda;
        }
        
        /// <summary>
        /// Content of CCDA record for the patient.
        /// </summary>
        /// <value>Content of CCDA record for the patient.</value>
        [DataMember(Name="ccda", EmitDefaultValue=false)]
        public string Ccda { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatientCcda {\n");
            sb.Append("  Ccda: ").Append(Ccda).Append("\n");
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
            return this.Equals(input as PatientCcda);
        }

        /// <summary>
        /// Returns true if PatientCcda instances are equal
        /// </summary>
        /// <param name="input">Instance of PatientCcda to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatientCcda input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ccda == input.Ccda ||
                    (this.Ccda != null &&
                    this.Ccda.Equals(input.Ccda))
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
                if (this.Ccda != null)
                    hashCode = hashCode * 59 + this.Ccda.GetHashCode();
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
