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
    /// PatientBalanceContract
    /// </summary>
    [DataContract]
        public partial class PatientBalanceContract :  IEquatable<PatientBalanceContract>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatientBalanceContract" /> class.
        /// </summary>
        /// <param name="availablebalance">The available balance on this contract..</param>
        /// <param name="contractclass">The type of contract. For example, \&quot;ONEYEAR,\&quot;.</param>
        /// <param name="maxamount">The maximum allowed amount for this contract..</param>
        public PatientBalanceContract(string availablebalance = default(string), string contractclass = default(string), string maxamount = default(string))
        {
            this.Availablebalance = availablebalance;
            this.Contractclass = contractclass;
            this.Maxamount = maxamount;
        }
        
        /// <summary>
        /// The available balance on this contract.
        /// </summary>
        /// <value>The available balance on this contract.</value>
        [DataMember(Name="availablebalance", EmitDefaultValue=false)]
        public string Availablebalance { get; set; }

        /// <summary>
        /// The type of contract. For example, \&quot;ONEYEAR,\&quot;
        /// </summary>
        /// <value>The type of contract. For example, \&quot;ONEYEAR,\&quot;</value>
        [DataMember(Name="contractclass", EmitDefaultValue=false)]
        public string Contractclass { get; set; }

        /// <summary>
        /// The maximum allowed amount for this contract.
        /// </summary>
        /// <value>The maximum allowed amount for this contract.</value>
        [DataMember(Name="maxamount", EmitDefaultValue=false)]
        public string Maxamount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatientBalanceContract {\n");
            sb.Append("  Availablebalance: ").Append(Availablebalance).Append("\n");
            sb.Append("  Contractclass: ").Append(Contractclass).Append("\n");
            sb.Append("  Maxamount: ").Append(Maxamount).Append("\n");
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
            return this.Equals(input as PatientBalanceContract);
        }

        /// <summary>
        /// Returns true if PatientBalanceContract instances are equal
        /// </summary>
        /// <param name="input">Instance of PatientBalanceContract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatientBalanceContract input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Availablebalance == input.Availablebalance ||
                    (this.Availablebalance != null &&
                    this.Availablebalance.Equals(input.Availablebalance))
                ) && 
                (
                    this.Contractclass == input.Contractclass ||
                    (this.Contractclass != null &&
                    this.Contractclass.Equals(input.Contractclass))
                ) && 
                (
                    this.Maxamount == input.Maxamount ||
                    (this.Maxamount != null &&
                    this.Maxamount.Equals(input.Maxamount))
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
                if (this.Availablebalance != null)
                    hashCode = hashCode * 59 + this.Availablebalance.GetHashCode();
                if (this.Contractclass != null)
                    hashCode = hashCode * 59 + this.Contractclass.GetHashCode();
                if (this.Maxamount != null)
                    hashCode = hashCode * 59 + this.Maxamount.GetHashCode();
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
