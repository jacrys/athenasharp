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
    /// Body4
    /// </summary>
    [DataContract]
        public partial class Body4 :  IEquatable<Body4>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Body4" /> class.
        /// </summary>
        /// <param name="patientid">The athenaNet patient ID. (required).</param>
        /// <param name="appointmentcancelreasonid">Passing in this parameter will override the default cancel reason. Valid reasons can be retrieved via a call to the GET /appointmentcancelreasons endpoint. .</param>
        /// <param name="cancellationreason">A text explanation why the appointment is being cancelled.</param>
        /// <param name="departmentid">The athenaNet department ID..</param>
        /// <param name="ignoreschedulablepermission">By default, we allow booking of appointments marked as schedulable via the web. This flag allows you to bypass that restriction for booking. .</param>
        /// <param name="nopatientcase">By default, we create a patient case upon booking an appointment for new patients. Setting this to true bypasses that patient case. .</param>
        public Body4(int? patientid = default(int?), int? appointmentcancelreasonid = default(int?), string cancellationreason = default(string), int? departmentid = default(int?), bool? ignoreschedulablepermission = default(bool?), bool? nopatientcase = default(bool?))
        {
            // to ensure "patientid" is required (not null)
            if (patientid == null)
            {
                throw new InvalidDataException("patientid is a required property for Body4 and cannot be null");
            }
            else
            {
                this.Patientid = patientid;
            }
            this.Appointmentcancelreasonid = appointmentcancelreasonid;
            this.Cancellationreason = cancellationreason;
            this.Departmentid = departmentid;
            this.Ignoreschedulablepermission = ignoreschedulablepermission;
            this.Nopatientcase = nopatientcase;
        }
        
        /// <summary>
        /// The athenaNet patient ID.
        /// </summary>
        /// <value>The athenaNet patient ID.</value>
        [DataMember(Name="patientid", EmitDefaultValue=false)]
        public int? Patientid { get; set; }

        /// <summary>
        /// Passing in this parameter will override the default cancel reason. Valid reasons can be retrieved via a call to the GET /appointmentcancelreasons endpoint. 
        /// </summary>
        /// <value>Passing in this parameter will override the default cancel reason. Valid reasons can be retrieved via a call to the GET /appointmentcancelreasons endpoint. </value>
        [DataMember(Name="appointmentcancelreasonid", EmitDefaultValue=false)]
        public int? Appointmentcancelreasonid { get; set; }

        /// <summary>
        /// A text explanation why the appointment is being cancelled
        /// </summary>
        /// <value>A text explanation why the appointment is being cancelled</value>
        [DataMember(Name="cancellationreason", EmitDefaultValue=false)]
        public string Cancellationreason { get; set; }

        /// <summary>
        /// The athenaNet department ID.
        /// </summary>
        /// <value>The athenaNet department ID.</value>
        [DataMember(Name="departmentid", EmitDefaultValue=false)]
        public int? Departmentid { get; set; }

        /// <summary>
        /// By default, we allow booking of appointments marked as schedulable via the web. This flag allows you to bypass that restriction for booking. 
        /// </summary>
        /// <value>By default, we allow booking of appointments marked as schedulable via the web. This flag allows you to bypass that restriction for booking. </value>
        [DataMember(Name="ignoreschedulablepermission", EmitDefaultValue=false)]
        public bool? Ignoreschedulablepermission { get; set; }

        /// <summary>
        /// By default, we create a patient case upon booking an appointment for new patients. Setting this to true bypasses that patient case. 
        /// </summary>
        /// <value>By default, we create a patient case upon booking an appointment for new patients. Setting this to true bypasses that patient case. </value>
        [DataMember(Name="nopatientcase", EmitDefaultValue=false)]
        public bool? Nopatientcase { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Body4 {\n");
            sb.Append("  Patientid: ").Append(Patientid).Append("\n");
            sb.Append("  Appointmentcancelreasonid: ").Append(Appointmentcancelreasonid).Append("\n");
            sb.Append("  Cancellationreason: ").Append(Cancellationreason).Append("\n");
            sb.Append("  Departmentid: ").Append(Departmentid).Append("\n");
            sb.Append("  Ignoreschedulablepermission: ").Append(Ignoreschedulablepermission).Append("\n");
            sb.Append("  Nopatientcase: ").Append(Nopatientcase).Append("\n");
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
            return this.Equals(input as Body4);
        }

        /// <summary>
        /// Returns true if Body4 instances are equal
        /// </summary>
        /// <param name="input">Instance of Body4 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Body4 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Patientid == input.Patientid ||
                    (this.Patientid != null &&
                    this.Patientid.Equals(input.Patientid))
                ) && 
                (
                    this.Appointmentcancelreasonid == input.Appointmentcancelreasonid ||
                    (this.Appointmentcancelreasonid != null &&
                    this.Appointmentcancelreasonid.Equals(input.Appointmentcancelreasonid))
                ) && 
                (
                    this.Cancellationreason == input.Cancellationreason ||
                    (this.Cancellationreason != null &&
                    this.Cancellationreason.Equals(input.Cancellationreason))
                ) && 
                (
                    this.Departmentid == input.Departmentid ||
                    (this.Departmentid != null &&
                    this.Departmentid.Equals(input.Departmentid))
                ) && 
                (
                    this.Ignoreschedulablepermission == input.Ignoreschedulablepermission ||
                    (this.Ignoreschedulablepermission != null &&
                    this.Ignoreschedulablepermission.Equals(input.Ignoreschedulablepermission))
                ) && 
                (
                    this.Nopatientcase == input.Nopatientcase ||
                    (this.Nopatientcase != null &&
                    this.Nopatientcase.Equals(input.Nopatientcase))
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
                if (this.Patientid != null)
                    hashCode = hashCode * 59 + this.Patientid.GetHashCode();
                if (this.Appointmentcancelreasonid != null)
                    hashCode = hashCode * 59 + this.Appointmentcancelreasonid.GetHashCode();
                if (this.Cancellationreason != null)
                    hashCode = hashCode * 59 + this.Cancellationreason.GetHashCode();
                if (this.Departmentid != null)
                    hashCode = hashCode * 59 + this.Departmentid.GetHashCode();
                if (this.Ignoreschedulablepermission != null)
                    hashCode = hashCode * 59 + this.Ignoreschedulablepermission.GetHashCode();
                if (this.Nopatientcase != null)
                    hashCode = hashCode * 59 + this.Nopatientcase.GetHashCode();
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
