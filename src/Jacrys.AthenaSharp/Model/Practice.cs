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
    /// Practice
    /// </summary>
    [DataContract]
        public partial class Practice :  IEquatable<Practice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Practice" /> class.
        /// </summary>
        /// <param name="iscoordinatorsender">iscoordinatorsender (required).</param>
        /// <param name="hasclinicals">hasclinicals (required).</param>
        /// <param name="name">name.</param>
        /// <param name="golivedate">golivedate.</param>
        /// <param name="experiencemode">experiencemode.</param>
        /// <param name="hascommunicator">hascommunicator.</param>
        /// <param name="iscoordinatorreceiver">iscoordinatorreceiver.</param>
        /// <param name="hascollector">hascollector.</param>
        /// <param name="practiceid">practiceid.</param>
        public Practice(bool? iscoordinatorsender = default(bool?), bool? hasclinicals = default(bool?), string name = default(string), string golivedate = default(string), string experiencemode = default(string), bool? hascommunicator = default(bool?), bool? iscoordinatorreceiver = default(bool?), bool? hascollector = default(bool?), string practiceid = default(string))
        {
            // to ensure "iscoordinatorsender" is required (not null)
            if (iscoordinatorsender == null)
            {
                throw new InvalidDataException("iscoordinatorsender is a required property for Practice and cannot be null");
            }
            else
            {
                this.Iscoordinatorsender = iscoordinatorsender;
            }
            // to ensure "hasclinicals" is required (not null)
            if (hasclinicals == null)
            {
                throw new InvalidDataException("hasclinicals is a required property for Practice and cannot be null");
            }
            else
            {
                this.Hasclinicals = hasclinicals;
            }
            this.Name = name;
            this.Golivedate = golivedate;
            this.Experiencemode = experiencemode;
            this.Hascommunicator = hascommunicator;
            this.Iscoordinatorreceiver = iscoordinatorreceiver;
            this.Hascollector = hascollector;
            this.Practiceid = practiceid;
        }
        
        /// <summary>
        /// Gets or Sets Iscoordinatorsender
        /// </summary>
        [DataMember(Name="iscoordinatorsender", EmitDefaultValue=false)]
        public bool? Iscoordinatorsender { get; set; }

        /// <summary>
        /// Gets or Sets Hasclinicals
        /// </summary>
        [DataMember(Name="hasclinicals", EmitDefaultValue=false)]
        public bool? Hasclinicals { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Golivedate
        /// </summary>
        [DataMember(Name="golivedate", EmitDefaultValue=false)]
        public string Golivedate { get; set; }

        /// <summary>
        /// Gets or Sets Experiencemode
        /// </summary>
        [DataMember(Name="experiencemode", EmitDefaultValue=false)]
        public string Experiencemode { get; set; }

        /// <summary>
        /// Gets or Sets Hascommunicator
        /// </summary>
        [DataMember(Name="hascommunicator", EmitDefaultValue=false)]
        public bool? Hascommunicator { get; set; }

        /// <summary>
        /// Gets or Sets Iscoordinatorreceiver
        /// </summary>
        [DataMember(Name="iscoordinatorreceiver", EmitDefaultValue=false)]
        public bool? Iscoordinatorreceiver { get; set; }

        /// <summary>
        /// Gets or Sets Hascollector
        /// </summary>
        [DataMember(Name="hascollector", EmitDefaultValue=false)]
        public bool? Hascollector { get; set; }

        /// <summary>
        /// Gets or Sets Practiceid
        /// </summary>
        [DataMember(Name="practiceid", EmitDefaultValue=false)]
        public string Practiceid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Practice {\n");
            sb.Append("  Iscoordinatorsender: ").Append(Iscoordinatorsender).Append("\n");
            sb.Append("  Hasclinicals: ").Append(Hasclinicals).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Golivedate: ").Append(Golivedate).Append("\n");
            sb.Append("  Experiencemode: ").Append(Experiencemode).Append("\n");
            sb.Append("  Hascommunicator: ").Append(Hascommunicator).Append("\n");
            sb.Append("  Iscoordinatorreceiver: ").Append(Iscoordinatorreceiver).Append("\n");
            sb.Append("  Hascollector: ").Append(Hascollector).Append("\n");
            sb.Append("  Practiceid: ").Append(Practiceid).Append("\n");
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
            return this.Equals(input as Practice);
        }

        /// <summary>
        /// Returns true if Practice instances are equal
        /// </summary>
        /// <param name="input">Instance of Practice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Practice input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Iscoordinatorsender == input.Iscoordinatorsender ||
                    (this.Iscoordinatorsender != null &&
                    this.Iscoordinatorsender.Equals(input.Iscoordinatorsender))
                ) && 
                (
                    this.Hasclinicals == input.Hasclinicals ||
                    (this.Hasclinicals != null &&
                    this.Hasclinicals.Equals(input.Hasclinicals))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Golivedate == input.Golivedate ||
                    (this.Golivedate != null &&
                    this.Golivedate.Equals(input.Golivedate))
                ) && 
                (
                    this.Experiencemode == input.Experiencemode ||
                    (this.Experiencemode != null &&
                    this.Experiencemode.Equals(input.Experiencemode))
                ) && 
                (
                    this.Hascommunicator == input.Hascommunicator ||
                    (this.Hascommunicator != null &&
                    this.Hascommunicator.Equals(input.Hascommunicator))
                ) && 
                (
                    this.Iscoordinatorreceiver == input.Iscoordinatorreceiver ||
                    (this.Iscoordinatorreceiver != null &&
                    this.Iscoordinatorreceiver.Equals(input.Iscoordinatorreceiver))
                ) && 
                (
                    this.Hascollector == input.Hascollector ||
                    (this.Hascollector != null &&
                    this.Hascollector.Equals(input.Hascollector))
                ) && 
                (
                    this.Practiceid == input.Practiceid ||
                    (this.Practiceid != null &&
                    this.Practiceid.Equals(input.Practiceid))
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
                if (this.Iscoordinatorsender != null)
                    hashCode = hashCode * 59 + this.Iscoordinatorsender.GetHashCode();
                if (this.Hasclinicals != null)
                    hashCode = hashCode * 59 + this.Hasclinicals.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Golivedate != null)
                    hashCode = hashCode * 59 + this.Golivedate.GetHashCode();
                if (this.Experiencemode != null)
                    hashCode = hashCode * 59 + this.Experiencemode.GetHashCode();
                if (this.Hascommunicator != null)
                    hashCode = hashCode * 59 + this.Hascommunicator.GetHashCode();
                if (this.Iscoordinatorreceiver != null)
                    hashCode = hashCode * 59 + this.Iscoordinatorreceiver.GetHashCode();
                if (this.Hascollector != null)
                    hashCode = hashCode * 59 + this.Hascollector.GetHashCode();
                if (this.Practiceid != null)
                    hashCode = hashCode * 59 + this.Practiceid.GetHashCode();
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
