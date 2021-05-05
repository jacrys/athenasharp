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
    /// Error
    /// </summary>
    [DataContract]
        public partial class Error :  IEquatable<Error>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        /// <param name="missingfields">missingfields.</param>
        /// <param name="fields">fields.</param>
        /// <param name="error">error (required).</param>
        /// <param name="detailedmessage">detailedmessage.</param>
        public Error(List<string> missingfields = default(List<string>), List<string> fields = default(List<string>), string error = default(string), string detailedmessage = default(string))
        {
            // to ensure "error" is required (not null)
            if (error == null)
            {
                throw new InvalidDataException("error is a required property for Error and cannot be null");
            }
            else
            {
                this._Error = error;
            }
            this.Missingfields = missingfields;
            this.Fields = fields;
            this.Detailedmessage = detailedmessage;
        }
        
        /// <summary>
        /// Gets or Sets Missingfields
        /// </summary>
        [DataMember(Name="missingfields", EmitDefaultValue=false)]
        public List<string> Missingfields { get; set; }

        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<string> Fields { get; set; }

        /// <summary>
        /// Gets or Sets _Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string _Error { get; set; }

        /// <summary>
        /// Gets or Sets Detailedmessage
        /// </summary>
        [DataMember(Name="detailedmessage", EmitDefaultValue=false)]
        public string Detailedmessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Error {\n");
            sb.Append("  Missingfields: ").Append(Missingfields).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  _Error: ").Append(_Error).Append("\n");
            sb.Append("  Detailedmessage: ").Append(Detailedmessage).Append("\n");
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
            return this.Equals(input as Error);
        }

        /// <summary>
        /// Returns true if Error instances are equal
        /// </summary>
        /// <param name="input">Instance of Error to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Error input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Missingfields == input.Missingfields ||
                    this.Missingfields != null &&
                    input.Missingfields != null &&
                    this.Missingfields.SequenceEqual(input.Missingfields)
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    input.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this._Error == input._Error ||
                    (this._Error != null &&
                    this._Error.Equals(input._Error))
                ) && 
                (
                    this.Detailedmessage == input.Detailedmessage ||
                    (this.Detailedmessage != null &&
                    this.Detailedmessage.Equals(input.Detailedmessage))
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
                if (this.Missingfields != null)
                    hashCode = hashCode * 59 + this.Missingfields.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                if (this._Error != null)
                    hashCode = hashCode * 59 + this._Error.GetHashCode();
                if (this.Detailedmessage != null)
                    hashCode = hashCode * 59 + this.Detailedmessage.GetHashCode();
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
