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
    /// Template
    /// </summary>
    [DataContract]
        public partial class Template :  IEquatable<Template>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Template" /> class.
        /// </summary>
        /// <param name="templateid">ID for this social history template (required).</param>
        /// <param name="templatename">Name for this social history template (required).</param>
        public Template(int? templateid = default(int?), string templatename = default(string))
        {
            // to ensure "templateid" is required (not null)
            if (templateid == null)
            {
                throw new InvalidDataException("templateid is a required property for Template and cannot be null");
            }
            else
            {
                this.Templateid = templateid;
            }
            // to ensure "templatename" is required (not null)
            if (templatename == null)
            {
                throw new InvalidDataException("templatename is a required property for Template and cannot be null");
            }
            else
            {
                this.Templatename = templatename;
            }
        }
        
        /// <summary>
        /// ID for this social history template
        /// </summary>
        /// <value>ID for this social history template</value>
        [DataMember(Name="templateid", EmitDefaultValue=false)]
        public int? Templateid { get; set; }

        /// <summary>
        /// Name for this social history template
        /// </summary>
        /// <value>Name for this social history template</value>
        [DataMember(Name="templatename", EmitDefaultValue=false)]
        public string Templatename { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Template {\n");
            sb.Append("  Templateid: ").Append(Templateid).Append("\n");
            sb.Append("  Templatename: ").Append(Templatename).Append("\n");
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
            return this.Equals(input as Template);
        }

        /// <summary>
        /// Returns true if Template instances are equal
        /// </summary>
        /// <param name="input">Instance of Template to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Template input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Templateid == input.Templateid ||
                    (this.Templateid != null &&
                    this.Templateid.Equals(input.Templateid))
                ) && 
                (
                    this.Templatename == input.Templatename ||
                    (this.Templatename != null &&
                    this.Templatename.Equals(input.Templatename))
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
                if (this.Templateid != null)
                    hashCode = hashCode * 59 + this.Templateid.GetHashCode();
                if (this.Templatename != null)
                    hashCode = hashCode * 59 + this.Templatename.GetHashCode();
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