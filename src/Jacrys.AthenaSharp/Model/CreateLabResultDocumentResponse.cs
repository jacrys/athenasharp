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
    /// CreateLabResultDocumentResponse
    /// </summary>
    [DataContract]
        public partial class CreateLabResultDocumentResponse :  IEquatable<CreateLabResultDocumentResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLabResultDocumentResponse" /> class.
        /// </summary>
        /// <param name="labresultid">labresultid.</param>
        /// <param name="errormessage">If the operation failed, this will contain an error message..</param>
        /// <param name="success">Returns true/false if the operation was successful. (required).</param>
        public CreateLabResultDocumentResponse(int? labresultid = default(int?), string errormessage = default(string), bool? success = default(bool?))
        {
            // to ensure "success" is required (not null)
            if (success == null)
            {
                throw new InvalidDataException("success is a required property for CreateLabResultDocumentResponse and cannot be null");
            }
            else
            {
                this.Success = success;
            }
            this.Labresultid = labresultid;
            this.Errormessage = errormessage;
        }
        
        /// <summary>
        /// Gets or Sets Labresultid
        /// </summary>
        [DataMember(Name="labresultid", EmitDefaultValue=false)]
        public int? Labresultid { get; set; }

        /// <summary>
        /// If the operation failed, this will contain an error message.
        /// </summary>
        /// <value>If the operation failed, this will contain an error message.</value>
        [DataMember(Name="errormessage", EmitDefaultValue=false)]
        public string Errormessage { get; set; }

        /// <summary>
        /// Returns true/false if the operation was successful.
        /// </summary>
        /// <value>Returns true/false if the operation was successful.</value>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateLabResultDocumentResponse {\n");
            sb.Append("  Labresultid: ").Append(Labresultid).Append("\n");
            sb.Append("  Errormessage: ").Append(Errormessage).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
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
            return this.Equals(input as CreateLabResultDocumentResponse);
        }

        /// <summary>
        /// Returns true if CreateLabResultDocumentResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateLabResultDocumentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateLabResultDocumentResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Labresultid == input.Labresultid ||
                    (this.Labresultid != null &&
                    this.Labresultid.Equals(input.Labresultid))
                ) && 
                (
                    this.Errormessage == input.Errormessage ||
                    (this.Errormessage != null &&
                    this.Errormessage.Equals(input.Errormessage))
                ) && 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
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
                if (this.Labresultid != null)
                    hashCode = hashCode * 59 + this.Labresultid.GetHashCode();
                if (this.Errormessage != null)
                    hashCode = hashCode * 59 + this.Errormessage.GetHashCode();
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
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
