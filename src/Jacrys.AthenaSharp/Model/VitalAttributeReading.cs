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
    /// VitalAttributeReading
    /// </summary>
    [DataContract]
        public partial class VitalAttributeReading :  IEquatable<VitalAttributeReading>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VitalAttributeReading" /> class.
        /// </summary>
        /// <param name="percentilespec">percentilespec.</param>
        /// <param name="vitalid">Unique ID for this vital attribute reading. Used to update/delete this reading. (required).</param>
        /// <param name="clinicalelementid">Key used to identify this particular vital attribute.</param>
        /// <param name="source">The source of this reading..</param>
        /// <param name="sourceid">External key to source..</param>
        /// <param name="readingid">Numeric key used to tie related and distinguish separate readings. So the diastolic and systolic blood pressure should have the same readingid. .</param>
        /// <param name="readingtaken">Date that the reading was taken..</param>
        /// <param name="unit">Unit that describes this vital&#x27;s value..</param>
        /// <param name="value">The value of this reading. NOTE: for numeric values, the units are always in the &#x27;native&#x27; units per the configuration. .</param>
        /// <param name="code">Code indentifier for the reading..</param>
        /// <param name="codeset">Codeset of the code..</param>
        /// <param name="codedescription">Description of the code identifier..</param>
        /// <param name="createdby">The athenaNet username of the person who entered the vital..</param>
        /// <param name="createddate">The date this vital was entered into the chart. Returned in mm/dd/yyyy hh24:mi:ss format. .</param>
        /// <param name="isgraphable">Flag indicating if this vital is graphable..</param>
        public VitalAttributeReading(PercentileSpec percentilespec = default(PercentileSpec), int? vitalid = default(int?), string clinicalelementid = default(string), string source = default(string), int? sourceid = default(int?), int? readingid = default(int?), string readingtaken = default(string), string unit = default(string), string value = default(string), string code = default(string), string codeset = default(string), string codedescription = default(string), string createdby = default(string), string createddate = default(string), bool? isgraphable = default(bool?))
        {
            // to ensure "vitalid" is required (not null)
            if (vitalid == null)
            {
                throw new InvalidDataException("vitalid is a required property for VitalAttributeReading and cannot be null");
            }
            else
            {
                this.Vitalid = vitalid;
            }
            this.Percentilespec = percentilespec;
            this.Clinicalelementid = clinicalelementid;
            this.Source = source;
            this.Sourceid = sourceid;
            this.Readingid = readingid;
            this.Readingtaken = readingtaken;
            this.Unit = unit;
            this.Value = value;
            this.Code = code;
            this.Codeset = codeset;
            this.Codedescription = codedescription;
            this.Createdby = createdby;
            this.Createddate = createddate;
            this.Isgraphable = isgraphable;
        }
        
        /// <summary>
        /// Gets or Sets Percentilespec
        /// </summary>
        [DataMember(Name="percentilespec", EmitDefaultValue=false)]
        public PercentileSpec Percentilespec { get; set; }

        /// <summary>
        /// Unique ID for this vital attribute reading. Used to update/delete this reading.
        /// </summary>
        /// <value>Unique ID for this vital attribute reading. Used to update/delete this reading.</value>
        [DataMember(Name="vitalid", EmitDefaultValue=false)]
        public int? Vitalid { get; set; }

        /// <summary>
        /// Key used to identify this particular vital attribute
        /// </summary>
        /// <value>Key used to identify this particular vital attribute</value>
        [DataMember(Name="clinicalelementid", EmitDefaultValue=false)]
        public string Clinicalelementid { get; set; }

        /// <summary>
        /// The source of this reading.
        /// </summary>
        /// <value>The source of this reading.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }

        /// <summary>
        /// External key to source.
        /// </summary>
        /// <value>External key to source.</value>
        [DataMember(Name="sourceid", EmitDefaultValue=false)]
        public int? Sourceid { get; set; }

        /// <summary>
        /// Numeric key used to tie related and distinguish separate readings. So the diastolic and systolic blood pressure should have the same readingid. 
        /// </summary>
        /// <value>Numeric key used to tie related and distinguish separate readings. So the diastolic and systolic blood pressure should have the same readingid. </value>
        [DataMember(Name="readingid", EmitDefaultValue=false)]
        public int? Readingid { get; set; }

        /// <summary>
        /// Date that the reading was taken.
        /// </summary>
        /// <value>Date that the reading was taken.</value>
        [DataMember(Name="readingtaken", EmitDefaultValue=false)]
        public string Readingtaken { get; set; }

        /// <summary>
        /// Unit that describes this vital&#x27;s value.
        /// </summary>
        /// <value>Unit that describes this vital&#x27;s value.</value>
        [DataMember(Name="unit", EmitDefaultValue=false)]
        public string Unit { get; set; }

        /// <summary>
        /// The value of this reading. NOTE: for numeric values, the units are always in the &#x27;native&#x27; units per the configuration. 
        /// </summary>
        /// <value>The value of this reading. NOTE: for numeric values, the units are always in the &#x27;native&#x27; units per the configuration. </value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Code indentifier for the reading.
        /// </summary>
        /// <value>Code indentifier for the reading.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Codeset of the code.
        /// </summary>
        /// <value>Codeset of the code.</value>
        [DataMember(Name="codeset", EmitDefaultValue=false)]
        public string Codeset { get; set; }

        /// <summary>
        /// Description of the code identifier.
        /// </summary>
        /// <value>Description of the code identifier.</value>
        [DataMember(Name="codedescription", EmitDefaultValue=false)]
        public string Codedescription { get; set; }

        /// <summary>
        /// The athenaNet username of the person who entered the vital.
        /// </summary>
        /// <value>The athenaNet username of the person who entered the vital.</value>
        [DataMember(Name="createdby", EmitDefaultValue=false)]
        public string Createdby { get; set; }

        /// <summary>
        /// The date this vital was entered into the chart. Returned in mm/dd/yyyy hh24:mi:ss format. 
        /// </summary>
        /// <value>The date this vital was entered into the chart. Returned in mm/dd/yyyy hh24:mi:ss format. </value>
        [DataMember(Name="createddate", EmitDefaultValue=false)]
        public string Createddate { get; set; }

        /// <summary>
        /// Flag indicating if this vital is graphable.
        /// </summary>
        /// <value>Flag indicating if this vital is graphable.</value>
        [DataMember(Name="isgraphable", EmitDefaultValue=false)]
        public bool? Isgraphable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VitalAttributeReading {\n");
            sb.Append("  Percentilespec: ").Append(Percentilespec).Append("\n");
            sb.Append("  Vitalid: ").Append(Vitalid).Append("\n");
            sb.Append("  Clinicalelementid: ").Append(Clinicalelementid).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Sourceid: ").Append(Sourceid).Append("\n");
            sb.Append("  Readingid: ").Append(Readingid).Append("\n");
            sb.Append("  Readingtaken: ").Append(Readingtaken).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Codeset: ").Append(Codeset).Append("\n");
            sb.Append("  Codedescription: ").Append(Codedescription).Append("\n");
            sb.Append("  Createdby: ").Append(Createdby).Append("\n");
            sb.Append("  Createddate: ").Append(Createddate).Append("\n");
            sb.Append("  Isgraphable: ").Append(Isgraphable).Append("\n");
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
            return this.Equals(input as VitalAttributeReading);
        }

        /// <summary>
        /// Returns true if VitalAttributeReading instances are equal
        /// </summary>
        /// <param name="input">Instance of VitalAttributeReading to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VitalAttributeReading input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Percentilespec == input.Percentilespec ||
                    (this.Percentilespec != null &&
                    this.Percentilespec.Equals(input.Percentilespec))
                ) && 
                (
                    this.Vitalid == input.Vitalid ||
                    (this.Vitalid != null &&
                    this.Vitalid.Equals(input.Vitalid))
                ) && 
                (
                    this.Clinicalelementid == input.Clinicalelementid ||
                    (this.Clinicalelementid != null &&
                    this.Clinicalelementid.Equals(input.Clinicalelementid))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Sourceid == input.Sourceid ||
                    (this.Sourceid != null &&
                    this.Sourceid.Equals(input.Sourceid))
                ) && 
                (
                    this.Readingid == input.Readingid ||
                    (this.Readingid != null &&
                    this.Readingid.Equals(input.Readingid))
                ) && 
                (
                    this.Readingtaken == input.Readingtaken ||
                    (this.Readingtaken != null &&
                    this.Readingtaken.Equals(input.Readingtaken))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Codeset == input.Codeset ||
                    (this.Codeset != null &&
                    this.Codeset.Equals(input.Codeset))
                ) && 
                (
                    this.Codedescription == input.Codedescription ||
                    (this.Codedescription != null &&
                    this.Codedescription.Equals(input.Codedescription))
                ) && 
                (
                    this.Createdby == input.Createdby ||
                    (this.Createdby != null &&
                    this.Createdby.Equals(input.Createdby))
                ) && 
                (
                    this.Createddate == input.Createddate ||
                    (this.Createddate != null &&
                    this.Createddate.Equals(input.Createddate))
                ) && 
                (
                    this.Isgraphable == input.Isgraphable ||
                    (this.Isgraphable != null &&
                    this.Isgraphable.Equals(input.Isgraphable))
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
                if (this.Percentilespec != null)
                    hashCode = hashCode * 59 + this.Percentilespec.GetHashCode();
                if (this.Vitalid != null)
                    hashCode = hashCode * 59 + this.Vitalid.GetHashCode();
                if (this.Clinicalelementid != null)
                    hashCode = hashCode * 59 + this.Clinicalelementid.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Sourceid != null)
                    hashCode = hashCode * 59 + this.Sourceid.GetHashCode();
                if (this.Readingid != null)
                    hashCode = hashCode * 59 + this.Readingid.GetHashCode();
                if (this.Readingtaken != null)
                    hashCode = hashCode * 59 + this.Readingtaken.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Codeset != null)
                    hashCode = hashCode * 59 + this.Codeset.GetHashCode();
                if (this.Codedescription != null)
                    hashCode = hashCode * 59 + this.Codedescription.GetHashCode();
                if (this.Createdby != null)
                    hashCode = hashCode * 59 + this.Createdby.GetHashCode();
                if (this.Createddate != null)
                    hashCode = hashCode * 59 + this.Createddate.GetHashCode();
                if (this.Isgraphable != null)
                    hashCode = hashCode * 59 + this.Isgraphable.GetHashCode();
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
