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
    /// PatientBalance
    /// </summary>
    [DataContract]
        public partial class PatientBalance :  IEquatable<PatientBalance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatientBalance" /> class.
        /// </summary>
        /// <param name="contracts">Information related to existing credit card contracts..</param>
        /// <param name="providergroupid">Athena ID for this financial group..</param>
        /// <param name="departmentlist">Comma separated list of department IDs that belong to this group.</param>
        /// <param name="balance">Balance for this provider group..</param>
        /// <param name="cleanbalance">Indicates whether the balance is associated with a contract, payment plan, or collections agency..</param>
        /// <param name="collectionsbalance">The outstanding amount associated with a collections agency..</param>
        /// <param name="paymentplanbalance">The outstanding amount associated with a payment plan..</param>
        public PatientBalance(List<PatientBalanceContract> contracts = default(List<PatientBalanceContract>), string providergroupid = default(string), string departmentlist = default(string), string balance = default(string), bool? cleanbalance = default(bool?), string collectionsbalance = default(string), string paymentplanbalance = default(string))
        {
            this.Contracts = contracts;
            this.Providergroupid = providergroupid;
            this.Departmentlist = departmentlist;
            this.Balance = balance;
            this.Cleanbalance = cleanbalance;
            this.Collectionsbalance = collectionsbalance;
            this.Paymentplanbalance = paymentplanbalance;
        }
        
        /// <summary>
        /// Information related to existing credit card contracts.
        /// </summary>
        /// <value>Information related to existing credit card contracts.</value>
        [DataMember(Name="contracts", EmitDefaultValue=false)]
        public List<PatientBalanceContract> Contracts { get; set; }

        /// <summary>
        /// Athena ID for this financial group.
        /// </summary>
        /// <value>Athena ID for this financial group.</value>
        [DataMember(Name="providergroupid", EmitDefaultValue=false)]
        public string Providergroupid { get; set; }

        /// <summary>
        /// Comma separated list of department IDs that belong to this group
        /// </summary>
        /// <value>Comma separated list of department IDs that belong to this group</value>
        [DataMember(Name="departmentlist", EmitDefaultValue=false)]
        public string Departmentlist { get; set; }

        /// <summary>
        /// Balance for this provider group.
        /// </summary>
        /// <value>Balance for this provider group.</value>
        [DataMember(Name="balance", EmitDefaultValue=false)]
        public string Balance { get; set; }

        /// <summary>
        /// Indicates whether the balance is associated with a contract, payment plan, or collections agency.
        /// </summary>
        /// <value>Indicates whether the balance is associated with a contract, payment plan, or collections agency.</value>
        [DataMember(Name="cleanbalance", EmitDefaultValue=false)]
        public bool? Cleanbalance { get; set; }

        /// <summary>
        /// The outstanding amount associated with a collections agency.
        /// </summary>
        /// <value>The outstanding amount associated with a collections agency.</value>
        [DataMember(Name="collectionsbalance", EmitDefaultValue=false)]
        public string Collectionsbalance { get; set; }

        /// <summary>
        /// The outstanding amount associated with a payment plan.
        /// </summary>
        /// <value>The outstanding amount associated with a payment plan.</value>
        [DataMember(Name="paymentplanbalance", EmitDefaultValue=false)]
        public string Paymentplanbalance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatientBalance {\n");
            sb.Append("  Contracts: ").Append(Contracts).Append("\n");
            sb.Append("  Providergroupid: ").Append(Providergroupid).Append("\n");
            sb.Append("  Departmentlist: ").Append(Departmentlist).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  Cleanbalance: ").Append(Cleanbalance).Append("\n");
            sb.Append("  Collectionsbalance: ").Append(Collectionsbalance).Append("\n");
            sb.Append("  Paymentplanbalance: ").Append(Paymentplanbalance).Append("\n");
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
            return this.Equals(input as PatientBalance);
        }

        /// <summary>
        /// Returns true if PatientBalance instances are equal
        /// </summary>
        /// <param name="input">Instance of PatientBalance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatientBalance input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Contracts == input.Contracts ||
                    this.Contracts != null &&
                    input.Contracts != null &&
                    this.Contracts.SequenceEqual(input.Contracts)
                ) && 
                (
                    this.Providergroupid == input.Providergroupid ||
                    (this.Providergroupid != null &&
                    this.Providergroupid.Equals(input.Providergroupid))
                ) && 
                (
                    this.Departmentlist == input.Departmentlist ||
                    (this.Departmentlist != null &&
                    this.Departmentlist.Equals(input.Departmentlist))
                ) && 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && 
                (
                    this.Cleanbalance == input.Cleanbalance ||
                    (this.Cleanbalance != null &&
                    this.Cleanbalance.Equals(input.Cleanbalance))
                ) && 
                (
                    this.Collectionsbalance == input.Collectionsbalance ||
                    (this.Collectionsbalance != null &&
                    this.Collectionsbalance.Equals(input.Collectionsbalance))
                ) && 
                (
                    this.Paymentplanbalance == input.Paymentplanbalance ||
                    (this.Paymentplanbalance != null &&
                    this.Paymentplanbalance.Equals(input.Paymentplanbalance))
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
                if (this.Contracts != null)
                    hashCode = hashCode * 59 + this.Contracts.GetHashCode();
                if (this.Providergroupid != null)
                    hashCode = hashCode * 59 + this.Providergroupid.GetHashCode();
                if (this.Departmentlist != null)
                    hashCode = hashCode * 59 + this.Departmentlist.GetHashCode();
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.Cleanbalance != null)
                    hashCode = hashCode * 59 + this.Cleanbalance.GetHashCode();
                if (this.Collectionsbalance != null)
                    hashCode = hashCode * 59 + this.Collectionsbalance.GetHashCode();
                if (this.Paymentplanbalance != null)
                    hashCode = hashCode * 59 + this.Paymentplanbalance.GetHashCode();
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
