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
    /// Body3
    /// </summary>
    [DataContract]
        public partial class Body3 :  IEquatable<Body3>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Body3" /> class.
        /// </summary>
        /// <param name="patientid">The athenaNet patient ID. (required).</param>
        /// <param name="appointmenttypeid">The appointment type to be booked. This field should never be used for booking appointments for web-based scheduling. The use of this field is reserved for digital check-in (aka \&quot;kiosk\&quot;) or an application used by practice staff. One of this or reasonid is required. .</param>
        /// <param name="bookingnote">A note from the patient about why this appointment is being booked.</param>
        /// <param name="departmentid">The athenaNet department ID..</param>
        /// <param name="donotsendconfirmationemail">For clients with athenaCommunicator, certain appointment types can be configured to have an appointment confirmation email sent to the patient at time of appointment booking. If this parameter is set to true, that email will not be sent. This should only be used if you plan on sending a confirmation email via another method. .</param>
        /// <param name="ignoreschedulablepermission">By default, we allow booking of appointments marked as schedulable via the web. This flag allows you to bypass that restriction for booking. .</param>
        /// <param name="insurancecompany">The name of the insurance company..</param>
        /// <param name="insurancegroupid">If available, any identifier for the insurance group..</param>
        /// <param name="insuranceidnumber">The insurance identifier for this individual patient..</param>
        /// <param name="insurancenote">Any extra information provided by the patient about insurance coverage..</param>
        /// <param name="insurancephone">The phone number for the insurance company..</param>
        /// <param name="insuranceplanname">The insurance plan name (e.g. \&quot;HMO Blue\&quot;)..</param>
        /// <param name="insurancepolicyholder">The full name of the insurance policy holder..</param>
        /// <param name="nopatientcase">By default, we create a patient case upon booking an appointment for new patients. Setting this to true bypasses that patient case. .</param>
        /// <param name="reasonid">The appointment reason ID to be booked. This field is required for booking appointments for web-based scheduling and is a reason that is retrieved from the /patientappointmentreasons call. .</param>
        /// <param name="urgentyn">Set this field in order to set the urgent flag in athena (if the practice settings allow for this)..</param>
        public Body3(int? patientid = default(int?), int? appointmenttypeid = default(int?), string bookingnote = default(string), int? departmentid = default(int?), bool? donotsendconfirmationemail = default(bool?), bool? ignoreschedulablepermission = default(bool?), string insurancecompany = default(string), string insurancegroupid = default(string), string insuranceidnumber = default(string), string insurancenote = default(string), string insurancephone = default(string), string insuranceplanname = default(string), string insurancepolicyholder = default(string), bool? nopatientcase = default(bool?), int? reasonid = default(int?), bool? urgentyn = default(bool?))
        {
            // to ensure "patientid" is required (not null)
            if (patientid == null)
            {
                throw new InvalidDataException("patientid is a required property for Body3 and cannot be null");
            }
            else
            {
                this.Patientid = patientid;
            }
            this.Appointmenttypeid = appointmenttypeid;
            this.Bookingnote = bookingnote;
            this.Departmentid = departmentid;
            this.Donotsendconfirmationemail = donotsendconfirmationemail;
            this.Ignoreschedulablepermission = ignoreschedulablepermission;
            this.Insurancecompany = insurancecompany;
            this.Insurancegroupid = insurancegroupid;
            this.Insuranceidnumber = insuranceidnumber;
            this.Insurancenote = insurancenote;
            this.Insurancephone = insurancephone;
            this.Insuranceplanname = insuranceplanname;
            this.Insurancepolicyholder = insurancepolicyholder;
            this.Nopatientcase = nopatientcase;
            this.Reasonid = reasonid;
            this.Urgentyn = urgentyn;
        }
        
        /// <summary>
        /// The athenaNet patient ID.
        /// </summary>
        /// <value>The athenaNet patient ID.</value>
        [DataMember(Name="patientid", EmitDefaultValue=false)]
        public int? Patientid { get; set; }

        /// <summary>
        /// The appointment type to be booked. This field should never be used for booking appointments for web-based scheduling. The use of this field is reserved for digital check-in (aka \&quot;kiosk\&quot;) or an application used by practice staff. One of this or reasonid is required. 
        /// </summary>
        /// <value>The appointment type to be booked. This field should never be used for booking appointments for web-based scheduling. The use of this field is reserved for digital check-in (aka \&quot;kiosk\&quot;) or an application used by practice staff. One of this or reasonid is required. </value>
        [DataMember(Name="appointmenttypeid", EmitDefaultValue=false)]
        public int? Appointmenttypeid { get; set; }

        /// <summary>
        /// A note from the patient about why this appointment is being booked
        /// </summary>
        /// <value>A note from the patient about why this appointment is being booked</value>
        [DataMember(Name="bookingnote", EmitDefaultValue=false)]
        public string Bookingnote { get; set; }

        /// <summary>
        /// The athenaNet department ID.
        /// </summary>
        /// <value>The athenaNet department ID.</value>
        [DataMember(Name="departmentid", EmitDefaultValue=false)]
        public int? Departmentid { get; set; }

        /// <summary>
        /// For clients with athenaCommunicator, certain appointment types can be configured to have an appointment confirmation email sent to the patient at time of appointment booking. If this parameter is set to true, that email will not be sent. This should only be used if you plan on sending a confirmation email via another method. 
        /// </summary>
        /// <value>For clients with athenaCommunicator, certain appointment types can be configured to have an appointment confirmation email sent to the patient at time of appointment booking. If this parameter is set to true, that email will not be sent. This should only be used if you plan on sending a confirmation email via another method. </value>
        [DataMember(Name="donotsendconfirmationemail", EmitDefaultValue=false)]
        public bool? Donotsendconfirmationemail { get; set; }

        /// <summary>
        /// By default, we allow booking of appointments marked as schedulable via the web. This flag allows you to bypass that restriction for booking. 
        /// </summary>
        /// <value>By default, we allow booking of appointments marked as schedulable via the web. This flag allows you to bypass that restriction for booking. </value>
        [DataMember(Name="ignoreschedulablepermission", EmitDefaultValue=false)]
        public bool? Ignoreschedulablepermission { get; set; }

        /// <summary>
        /// The name of the insurance company.
        /// </summary>
        /// <value>The name of the insurance company.</value>
        [DataMember(Name="insurancecompany", EmitDefaultValue=false)]
        public string Insurancecompany { get; set; }

        /// <summary>
        /// If available, any identifier for the insurance group.
        /// </summary>
        /// <value>If available, any identifier for the insurance group.</value>
        [DataMember(Name="insurancegroupid", EmitDefaultValue=false)]
        public string Insurancegroupid { get; set; }

        /// <summary>
        /// The insurance identifier for this individual patient.
        /// </summary>
        /// <value>The insurance identifier for this individual patient.</value>
        [DataMember(Name="insuranceidnumber", EmitDefaultValue=false)]
        public string Insuranceidnumber { get; set; }

        /// <summary>
        /// Any extra information provided by the patient about insurance coverage.
        /// </summary>
        /// <value>Any extra information provided by the patient about insurance coverage.</value>
        [DataMember(Name="insurancenote", EmitDefaultValue=false)]
        public string Insurancenote { get; set; }

        /// <summary>
        /// The phone number for the insurance company.
        /// </summary>
        /// <value>The phone number for the insurance company.</value>
        [DataMember(Name="insurancephone", EmitDefaultValue=false)]
        public string Insurancephone { get; set; }

        /// <summary>
        /// The insurance plan name (e.g. \&quot;HMO Blue\&quot;).
        /// </summary>
        /// <value>The insurance plan name (e.g. \&quot;HMO Blue\&quot;).</value>
        [DataMember(Name="insuranceplanname", EmitDefaultValue=false)]
        public string Insuranceplanname { get; set; }

        /// <summary>
        /// The full name of the insurance policy holder.
        /// </summary>
        /// <value>The full name of the insurance policy holder.</value>
        [DataMember(Name="insurancepolicyholder", EmitDefaultValue=false)]
        public string Insurancepolicyholder { get; set; }

        /// <summary>
        /// By default, we create a patient case upon booking an appointment for new patients. Setting this to true bypasses that patient case. 
        /// </summary>
        /// <value>By default, we create a patient case upon booking an appointment for new patients. Setting this to true bypasses that patient case. </value>
        [DataMember(Name="nopatientcase", EmitDefaultValue=false)]
        public bool? Nopatientcase { get; set; }

        /// <summary>
        /// The appointment reason ID to be booked. This field is required for booking appointments for web-based scheduling and is a reason that is retrieved from the /patientappointmentreasons call. 
        /// </summary>
        /// <value>The appointment reason ID to be booked. This field is required for booking appointments for web-based scheduling and is a reason that is retrieved from the /patientappointmentreasons call. </value>
        [DataMember(Name="reasonid", EmitDefaultValue=false)]
        public int? Reasonid { get; set; }

        /// <summary>
        /// Set this field in order to set the urgent flag in athena (if the practice settings allow for this).
        /// </summary>
        /// <value>Set this field in order to set the urgent flag in athena (if the practice settings allow for this).</value>
        [DataMember(Name="urgentyn", EmitDefaultValue=false)]
        public bool? Urgentyn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Body3 {\n");
            sb.Append("  Patientid: ").Append(Patientid).Append("\n");
            sb.Append("  Appointmenttypeid: ").Append(Appointmenttypeid).Append("\n");
            sb.Append("  Bookingnote: ").Append(Bookingnote).Append("\n");
            sb.Append("  Departmentid: ").Append(Departmentid).Append("\n");
            sb.Append("  Donotsendconfirmationemail: ").Append(Donotsendconfirmationemail).Append("\n");
            sb.Append("  Ignoreschedulablepermission: ").Append(Ignoreschedulablepermission).Append("\n");
            sb.Append("  Insurancecompany: ").Append(Insurancecompany).Append("\n");
            sb.Append("  Insurancegroupid: ").Append(Insurancegroupid).Append("\n");
            sb.Append("  Insuranceidnumber: ").Append(Insuranceidnumber).Append("\n");
            sb.Append("  Insurancenote: ").Append(Insurancenote).Append("\n");
            sb.Append("  Insurancephone: ").Append(Insurancephone).Append("\n");
            sb.Append("  Insuranceplanname: ").Append(Insuranceplanname).Append("\n");
            sb.Append("  Insurancepolicyholder: ").Append(Insurancepolicyholder).Append("\n");
            sb.Append("  Nopatientcase: ").Append(Nopatientcase).Append("\n");
            sb.Append("  Reasonid: ").Append(Reasonid).Append("\n");
            sb.Append("  Urgentyn: ").Append(Urgentyn).Append("\n");
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
            return this.Equals(input as Body3);
        }

        /// <summary>
        /// Returns true if Body3 instances are equal
        /// </summary>
        /// <param name="input">Instance of Body3 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Body3 input)
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
                    this.Appointmenttypeid == input.Appointmenttypeid ||
                    (this.Appointmenttypeid != null &&
                    this.Appointmenttypeid.Equals(input.Appointmenttypeid))
                ) && 
                (
                    this.Bookingnote == input.Bookingnote ||
                    (this.Bookingnote != null &&
                    this.Bookingnote.Equals(input.Bookingnote))
                ) && 
                (
                    this.Departmentid == input.Departmentid ||
                    (this.Departmentid != null &&
                    this.Departmentid.Equals(input.Departmentid))
                ) && 
                (
                    this.Donotsendconfirmationemail == input.Donotsendconfirmationemail ||
                    (this.Donotsendconfirmationemail != null &&
                    this.Donotsendconfirmationemail.Equals(input.Donotsendconfirmationemail))
                ) && 
                (
                    this.Ignoreschedulablepermission == input.Ignoreschedulablepermission ||
                    (this.Ignoreschedulablepermission != null &&
                    this.Ignoreschedulablepermission.Equals(input.Ignoreschedulablepermission))
                ) && 
                (
                    this.Insurancecompany == input.Insurancecompany ||
                    (this.Insurancecompany != null &&
                    this.Insurancecompany.Equals(input.Insurancecompany))
                ) && 
                (
                    this.Insurancegroupid == input.Insurancegroupid ||
                    (this.Insurancegroupid != null &&
                    this.Insurancegroupid.Equals(input.Insurancegroupid))
                ) && 
                (
                    this.Insuranceidnumber == input.Insuranceidnumber ||
                    (this.Insuranceidnumber != null &&
                    this.Insuranceidnumber.Equals(input.Insuranceidnumber))
                ) && 
                (
                    this.Insurancenote == input.Insurancenote ||
                    (this.Insurancenote != null &&
                    this.Insurancenote.Equals(input.Insurancenote))
                ) && 
                (
                    this.Insurancephone == input.Insurancephone ||
                    (this.Insurancephone != null &&
                    this.Insurancephone.Equals(input.Insurancephone))
                ) && 
                (
                    this.Insuranceplanname == input.Insuranceplanname ||
                    (this.Insuranceplanname != null &&
                    this.Insuranceplanname.Equals(input.Insuranceplanname))
                ) && 
                (
                    this.Insurancepolicyholder == input.Insurancepolicyholder ||
                    (this.Insurancepolicyholder != null &&
                    this.Insurancepolicyholder.Equals(input.Insurancepolicyholder))
                ) && 
                (
                    this.Nopatientcase == input.Nopatientcase ||
                    (this.Nopatientcase != null &&
                    this.Nopatientcase.Equals(input.Nopatientcase))
                ) && 
                (
                    this.Reasonid == input.Reasonid ||
                    (this.Reasonid != null &&
                    this.Reasonid.Equals(input.Reasonid))
                ) && 
                (
                    this.Urgentyn == input.Urgentyn ||
                    (this.Urgentyn != null &&
                    this.Urgentyn.Equals(input.Urgentyn))
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
                if (this.Appointmenttypeid != null)
                    hashCode = hashCode * 59 + this.Appointmenttypeid.GetHashCode();
                if (this.Bookingnote != null)
                    hashCode = hashCode * 59 + this.Bookingnote.GetHashCode();
                if (this.Departmentid != null)
                    hashCode = hashCode * 59 + this.Departmentid.GetHashCode();
                if (this.Donotsendconfirmationemail != null)
                    hashCode = hashCode * 59 + this.Donotsendconfirmationemail.GetHashCode();
                if (this.Ignoreschedulablepermission != null)
                    hashCode = hashCode * 59 + this.Ignoreschedulablepermission.GetHashCode();
                if (this.Insurancecompany != null)
                    hashCode = hashCode * 59 + this.Insurancecompany.GetHashCode();
                if (this.Insurancegroupid != null)
                    hashCode = hashCode * 59 + this.Insurancegroupid.GetHashCode();
                if (this.Insuranceidnumber != null)
                    hashCode = hashCode * 59 + this.Insuranceidnumber.GetHashCode();
                if (this.Insurancenote != null)
                    hashCode = hashCode * 59 + this.Insurancenote.GetHashCode();
                if (this.Insurancephone != null)
                    hashCode = hashCode * 59 + this.Insurancephone.GetHashCode();
                if (this.Insuranceplanname != null)
                    hashCode = hashCode * 59 + this.Insuranceplanname.GetHashCode();
                if (this.Insurancepolicyholder != null)
                    hashCode = hashCode * 59 + this.Insurancepolicyholder.GetHashCode();
                if (this.Nopatientcase != null)
                    hashCode = hashCode * 59 + this.Nopatientcase.GetHashCode();
                if (this.Reasonid != null)
                    hashCode = hashCode * 59 + this.Reasonid.GetHashCode();
                if (this.Urgentyn != null)
                    hashCode = hashCode * 59 + this.Urgentyn.GetHashCode();
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