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
    /// AppointmentTypeList
    /// </summary>
    [DataContract]
        public partial class AppointmentTypeList :  IEquatable<AppointmentTypeList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentTypeList" /> class.
        /// </summary>
        /// <param name="totalcount">totalcount (required).</param>
        /// <param name="appointmenttypes">appointmenttypes (required).</param>
        public AppointmentTypeList(int? totalcount = default(int?), List<AppointmentType> appointmenttypes = default(List<AppointmentType>))
        {
            // to ensure "totalcount" is required (not null)
            if (totalcount == null)
            {
                throw new InvalidDataException("totalcount is a required property for AppointmentTypeList and cannot be null");
            }
            else
            {
                this.Totalcount = totalcount;
            }
            // to ensure "appointmenttypes" is required (not null)
            if (appointmenttypes == null)
            {
                throw new InvalidDataException("appointmenttypes is a required property for AppointmentTypeList and cannot be null");
            }
            else
            {
                this.Appointmenttypes = appointmenttypes;
            }
        }
        
        /// <summary>
        /// Gets or Sets Totalcount
        /// </summary>
        [DataMember(Name="totalcount", EmitDefaultValue=false)]
        public int? Totalcount { get; set; }

        /// <summary>
        /// Gets or Sets Appointmenttypes
        /// </summary>
        [DataMember(Name="appointmenttypes", EmitDefaultValue=false)]
        public List<AppointmentType> Appointmenttypes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppointmentTypeList {\n");
            sb.Append("  Totalcount: ").Append(Totalcount).Append("\n");
            sb.Append("  Appointmenttypes: ").Append(Appointmenttypes).Append("\n");
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
            return this.Equals(input as AppointmentTypeList);
        }

        /// <summary>
        /// Returns true if AppointmentTypeList instances are equal
        /// </summary>
        /// <param name="input">Instance of AppointmentTypeList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppointmentTypeList input)
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
                    this.Appointmenttypes == input.Appointmenttypes ||
                    this.Appointmenttypes != null &&
                    input.Appointmenttypes != null &&
                    this.Appointmenttypes.SequenceEqual(input.Appointmenttypes)
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
                if (this.Appointmenttypes != null)
                    hashCode = hashCode * 59 + this.Appointmenttypes.GetHashCode();
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