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
    /// Body5
    /// </summary>
    [DataContract]
        public partial class Body5 :  IEquatable<Body5>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Body5" /> class.
        /// </summary>
        /// <param name="appointmentdate">The appointment date for the new open appointment slot (mm/dd/yyyy). (required).</param>
        /// <param name="appointmenttime">The time (hh24:mi) for the new appointment slot. Multiple times (either as a comma delimited list or multiple POSTed values) are allowed. 24 hour time.   (required).</param>
        /// <param name="appointmenttypeid">The appointment type ID to be created. Either this or a reason must be provided..</param>
        /// <param name="departmentid">The athenaNet department ID. (required).</param>
        /// <param name="providerid">The athenaNet provider ID. (required).</param>
        /// <param name="reasonid">The appointment reason (/patientappointmentreasons) to be created. Either this or a raw appointment type ID must be provided. .</param>
        public Body5(string appointmentdate = default(string), string appointmenttime = default(string), int? appointmenttypeid = default(int?), int? departmentid = default(int?), int? providerid = default(int?), int? reasonid = default(int?))
        {
            // to ensure "appointmentdate" is required (not null)
            if (appointmentdate == null)
            {
                throw new InvalidDataException("appointmentdate is a required property for Body5 and cannot be null");
            }
            else
            {
                this.Appointmentdate = appointmentdate;
            }
            // to ensure "appointmenttime" is required (not null)
            if (appointmenttime == null)
            {
                throw new InvalidDataException("appointmenttime is a required property for Body5 and cannot be null");
            }
            else
            {
                this.Appointmenttime = appointmenttime;
            }
            // to ensure "departmentid" is required (not null)
            if (departmentid == null)
            {
                throw new InvalidDataException("departmentid is a required property for Body5 and cannot be null");
            }
            else
            {
                this.Departmentid = departmentid;
            }
            // to ensure "providerid" is required (not null)
            if (providerid == null)
            {
                throw new InvalidDataException("providerid is a required property for Body5 and cannot be null");
            }
            else
            {
                this.Providerid = providerid;
            }
            this.Appointmenttypeid = appointmenttypeid;
            this.Reasonid = reasonid;
        }
        
        /// <summary>
        /// The appointment date for the new open appointment slot (mm/dd/yyyy).
        /// </summary>
        /// <value>The appointment date for the new open appointment slot (mm/dd/yyyy).</value>
        [DataMember(Name="appointmentdate", EmitDefaultValue=false)]
        public string Appointmentdate { get; set; }

        /// <summary>
        /// The time (hh24:mi) for the new appointment slot. Multiple times (either as a comma delimited list or multiple POSTed values) are allowed. 24 hour time.  
        /// </summary>
        /// <value>The time (hh24:mi) for the new appointment slot. Multiple times (either as a comma delimited list or multiple POSTed values) are allowed. 24 hour time.  </value>
        [DataMember(Name="appointmenttime", EmitDefaultValue=false)]
        public string Appointmenttime { get; set; }

        /// <summary>
        /// The appointment type ID to be created. Either this or a reason must be provided.
        /// </summary>
        /// <value>The appointment type ID to be created. Either this or a reason must be provided.</value>
        [DataMember(Name="appointmenttypeid", EmitDefaultValue=false)]
        public int? Appointmenttypeid { get; set; }

        /// <summary>
        /// The athenaNet department ID.
        /// </summary>
        /// <value>The athenaNet department ID.</value>
        [DataMember(Name="departmentid", EmitDefaultValue=false)]
        public int? Departmentid { get; set; }

        /// <summary>
        /// The athenaNet provider ID.
        /// </summary>
        /// <value>The athenaNet provider ID.</value>
        [DataMember(Name="providerid", EmitDefaultValue=false)]
        public int? Providerid { get; set; }

        /// <summary>
        /// The appointment reason (/patientappointmentreasons) to be created. Either this or a raw appointment type ID must be provided. 
        /// </summary>
        /// <value>The appointment reason (/patientappointmentreasons) to be created. Either this or a raw appointment type ID must be provided. </value>
        [DataMember(Name="reasonid", EmitDefaultValue=false)]
        public int? Reasonid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Body5 {\n");
            sb.Append("  Appointmentdate: ").Append(Appointmentdate).Append("\n");
            sb.Append("  Appointmenttime: ").Append(Appointmenttime).Append("\n");
            sb.Append("  Appointmenttypeid: ").Append(Appointmenttypeid).Append("\n");
            sb.Append("  Departmentid: ").Append(Departmentid).Append("\n");
            sb.Append("  Providerid: ").Append(Providerid).Append("\n");
            sb.Append("  Reasonid: ").Append(Reasonid).Append("\n");
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
            return this.Equals(input as Body5);
        }

        /// <summary>
        /// Returns true if Body5 instances are equal
        /// </summary>
        /// <param name="input">Instance of Body5 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Body5 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Appointmentdate == input.Appointmentdate ||
                    (this.Appointmentdate != null &&
                    this.Appointmentdate.Equals(input.Appointmentdate))
                ) && 
                (
                    this.Appointmenttime == input.Appointmenttime ||
                    (this.Appointmenttime != null &&
                    this.Appointmenttime.Equals(input.Appointmenttime))
                ) && 
                (
                    this.Appointmenttypeid == input.Appointmenttypeid ||
                    (this.Appointmenttypeid != null &&
                    this.Appointmenttypeid.Equals(input.Appointmenttypeid))
                ) && 
                (
                    this.Departmentid == input.Departmentid ||
                    (this.Departmentid != null &&
                    this.Departmentid.Equals(input.Departmentid))
                ) && 
                (
                    this.Providerid == input.Providerid ||
                    (this.Providerid != null &&
                    this.Providerid.Equals(input.Providerid))
                ) && 
                (
                    this.Reasonid == input.Reasonid ||
                    (this.Reasonid != null &&
                    this.Reasonid.Equals(input.Reasonid))
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
                if (this.Appointmentdate != null)
                    hashCode = hashCode * 59 + this.Appointmentdate.GetHashCode();
                if (this.Appointmenttime != null)
                    hashCode = hashCode * 59 + this.Appointmenttime.GetHashCode();
                if (this.Appointmenttypeid != null)
                    hashCode = hashCode * 59 + this.Appointmenttypeid.GetHashCode();
                if (this.Departmentid != null)
                    hashCode = hashCode * 59 + this.Departmentid.GetHashCode();
                if (this.Providerid != null)
                    hashCode = hashCode * 59 + this.Providerid.GetHashCode();
                if (this.Reasonid != null)
                    hashCode = hashCode * 59 + this.Reasonid.GetHashCode();
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
