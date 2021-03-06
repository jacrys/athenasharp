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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = Jacrys.AthenaSharp.Client.SwaggerDateConverter;

namespace Jacrys.AthenaSharp.Model
{
    /// <summary>
    /// Department
    /// </summary>
    [DataContract]
        public partial class Department :  IEquatable<Department>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Department" /> class.
        /// </summary>
        /// <param name="creditcardtypes">creditcardtypes (required).</param>
        /// <param name="timezoneoffset">timezoneoffset (required).</param>
        /// <param name="singleappointmentcontractmax">singleappointmentcontractmax.</param>
        /// <param name="state">state.</param>
        /// <param name="placeofservicefacility">placeofservicefacility.</param>
        /// <param name="latitude">latitude.</param>
        /// <param name="departmentid">departmentid.</param>
        /// <param name="address">address.</param>
        /// <param name="placeofservicetypeid">placeofservicetypeid.</param>
        /// <param name="longitude">longitude.</param>
        /// <param name="clinicals">clinicals.</param>
        /// <param name="timezone">timezone.</param>
        /// <param name="name">name.</param>
        /// <param name="patientdepartmentname">patientdepartmentname.</param>
        /// <param name="chartsharinggroupid">chartsharinggroupid.</param>
        /// <param name="placeofservicetypename">placeofservicetypename.</param>
        /// <param name="zip">zip.</param>
        /// <param name="timezonename">timezonename.</param>
        /// <param name="communicatorbrandid">communicatorbrandid.</param>
        /// <param name="medicationhistoryconsent">medicationhistoryconsent.</param>
        /// <param name="ishospitaldepartment">ishospitaldepartment.</param>
        /// <param name="providergroupid">providergroupid.</param>
        /// <param name="portalurl">portalurl.</param>
        /// <param name="city">city.</param>
        /// <param name="servicedepartment">servicedepartment.</param>
        /// <param name="oneyearcontractmax">oneyearcontractmax.</param>
        /// <param name="fax">fax.</param>
        /// <param name="providergroupname">providergroupname.</param>
        /// <param name="doesnotobservedst">doesnotobservedst.</param>
        /// <param name="phone">phone.</param>
        /// <param name="ecommercecreditcardtypes">ecommercecreditcardtypes.</param>
        public Department(List<string> creditcardtypes = default(List<string>), int? timezoneoffset = default(int?), string singleappointmentcontractmax = default(string), string state = default(string), bool? placeofservicefacility = default(bool?), string latitude = default(string), int? departmentid = default(int?), string address = default(string), string placeofservicetypeid = default(string), string longitude = default(string), string clinicals = default(string), int? timezone = default(int?), string name = default(string), string patientdepartmentname = default(string), string chartsharinggroupid = default(string), string placeofservicetypename = default(string), string zip = default(string), string timezonename = default(string), string communicatorbrandid = default(string), bool? medicationhistoryconsent = default(bool?), bool? ishospitaldepartment = default(bool?), string providergroupid = default(string), string portalurl = default(string), string city = default(string), bool? servicedepartment = default(bool?), string oneyearcontractmax = default(string), string fax = default(string), string providergroupname = default(string), string doesnotobservedst = default(string), string phone = default(string), List<string> ecommercecreditcardtypes = default(List<string>))
        {
            // to ensure "timezoneoffset" is required (not null)
            if (timezoneoffset == null)
            {
                throw new InvalidDataException("timezoneoffset is a required property for Department and cannot be null");
            }
            else
            {
                this.Timezoneoffset = timezoneoffset;
            }
            this.Singleappointmentcontractmax = singleappointmentcontractmax;
            this.State = state;
            this.Placeofservicefacility = placeofservicefacility;
            this.Latitude = latitude;
            this.Departmentid = departmentid;
            this.Address = address;
            this.Placeofservicetypeid = placeofservicetypeid;
            this.Longitude = longitude;
            this.Clinicals = clinicals;
            this.Timezone = timezone;
            this.Name = name;
            this.Patientdepartmentname = patientdepartmentname;
            this.Chartsharinggroupid = chartsharinggroupid;
            this.Placeofservicetypename = placeofservicetypename;
            this.Zip = zip;
            this.Timezonename = timezonename;
            this.Communicatorbrandid = communicatorbrandid;
            this.Medicationhistoryconsent = medicationhistoryconsent;
            this.Ishospitaldepartment = ishospitaldepartment;
            this.Providergroupid = providergroupid;
            this.Portalurl = portalurl;
            this.City = city;
            this.Servicedepartment = servicedepartment;
            this.Oneyearcontractmax = oneyearcontractmax;
            this.Fax = fax;
            this.Providergroupname = providergroupname;
            this.Doesnotobservedst = doesnotobservedst;
            this.Phone = phone;
            this.Ecommercecreditcardtypes = ecommercecreditcardtypes;
        }

        /// <summary>
        /// Gets or Sets Creditcardtypes
        /// </summary>
        [DataMember(Name="creditcardtypes", EmitDefaultValue=false)]
        public List<string> Creditcardtypes { get; set; }

        /// <summary>
        /// Gets or Sets Timezoneoffset
        /// </summary>
        [DataMember(Name="timezoneoffset", EmitDefaultValue=false)]
        public int? Timezoneoffset { get; set; }

        /// <summary>
        /// Gets or Sets Singleappointmentcontractmax
        /// </summary>
        [DataMember(Name="singleappointmentcontractmax", EmitDefaultValue=false)]
        public string Singleappointmentcontractmax { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets Placeofservicefacility
        /// </summary>
        [DataMember(Name="placeofservicefacility", EmitDefaultValue=false)]
        public bool? Placeofservicefacility { get; set; }

        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [DataMember(Name="latitude", EmitDefaultValue=false)]
        public string Latitude { get; set; }

        /// <summary>
        /// Gets or Sets Departmentid
        /// </summary>
        [DataMember(Name="departmentid", EmitDefaultValue=false)]
        public int? Departmentid { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Placeofservicetypeid
        /// </summary>
        [DataMember(Name="placeofservicetypeid", EmitDefaultValue=false)]
        public string Placeofservicetypeid { get; set; }

        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [DataMember(Name="longitude", EmitDefaultValue=false)]
        public string Longitude { get; set; }

        /// <summary>
        /// Gets or Sets Clinicals
        /// </summary>
        [DataMember(Name="clinicals", EmitDefaultValue=false)]
        public string Clinicals { get; set; }

        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public int? Timezone { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Patientdepartmentname
        /// </summary>
        [DataMember(Name="patientdepartmentname", EmitDefaultValue=false)]
        public string Patientdepartmentname { get; set; }

        /// <summary>
        /// Gets or Sets Chartsharinggroupid
        /// </summary>
        [DataMember(Name="chartsharinggroupid", EmitDefaultValue=false)]
        public string Chartsharinggroupid { get; set; }

        /// <summary>
        /// Gets or Sets Placeofservicetypename
        /// </summary>
        [DataMember(Name="placeofservicetypename", EmitDefaultValue=false)]
        public string Placeofservicetypename { get; set; }

        /// <summary>
        /// Gets or Sets Zip
        /// </summary>
        [DataMember(Name="zip", EmitDefaultValue=false)]
        public string Zip { get; set; }

        /// <summary>
        /// Gets or Sets Timezonename
        /// </summary>
        [DataMember(Name="timezonename", EmitDefaultValue=false)]
        public string Timezonename { get; set; }

        /// <summary>
        /// Gets or Sets Communicatorbrandid
        /// </summary>
        [DataMember(Name="communicatorbrandid", EmitDefaultValue=false)]
        public string Communicatorbrandid { get; set; }

        /// <summary>
        /// Gets or Sets Medicationhistoryconsent
        /// </summary>
        [DataMember(Name="medicationhistoryconsent", EmitDefaultValue=false)]
        public bool? Medicationhistoryconsent { get; set; }

        /// <summary>
        /// Gets or Sets Ishospitaldepartment
        /// </summary>
        [DataMember(Name="ishospitaldepartment", EmitDefaultValue=false)]
        public bool? Ishospitaldepartment { get; set; }

        /// <summary>
        /// Gets or Sets Providergroupid
        /// </summary>
        [DataMember(Name="providergroupid", EmitDefaultValue=false)]
        public string Providergroupid { get; set; }

        /// <summary>
        /// Gets or Sets Portalurl
        /// </summary>
        [DataMember(Name="portalurl", EmitDefaultValue=false)]
        public string Portalurl { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets Servicedepartment
        /// </summary>
        [DataMember(Name="servicedepartment", EmitDefaultValue=false)]
        public bool? Servicedepartment { get; set; }

        /// <summary>
        /// Gets or Sets Oneyearcontractmax
        /// </summary>
        [DataMember(Name="oneyearcontractmax", EmitDefaultValue=false)]
        public string Oneyearcontractmax { get; set; }

        /// <summary>
        /// Gets or Sets Fax
        /// </summary>
        [DataMember(Name="fax", EmitDefaultValue=false)]
        public string Fax { get; set; }

        /// <summary>
        /// Gets or Sets Providergroupname
        /// </summary>
        [DataMember(Name="providergroupname", EmitDefaultValue=false)]
        public string Providergroupname { get; set; }

        /// <summary>
        /// Gets or Sets Doesnotobservedst
        /// </summary>
        [DataMember(Name="doesnotobservedst", EmitDefaultValue=false)]
        public string Doesnotobservedst { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets Ecommercecreditcardtypes
        /// </summary>
        [DataMember(Name="ecommercecreditcardtypes", EmitDefaultValue=false)]
        public List<string> Ecommercecreditcardtypes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Department {\n");
            sb.Append("  Creditcardtypes: ").Append(Creditcardtypes).Append("\n");
            sb.Append("  Timezoneoffset: ").Append(Timezoneoffset).Append("\n");
            sb.Append("  Singleappointmentcontractmax: ").Append(Singleappointmentcontractmax).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Placeofservicefacility: ").Append(Placeofservicefacility).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Departmentid: ").Append(Departmentid).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Placeofservicetypeid: ").Append(Placeofservicetypeid).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Clinicals: ").Append(Clinicals).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Patientdepartmentname: ").Append(Patientdepartmentname).Append("\n");
            sb.Append("  Chartsharinggroupid: ").Append(Chartsharinggroupid).Append("\n");
            sb.Append("  Placeofservicetypename: ").Append(Placeofservicetypename).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  Timezonename: ").Append(Timezonename).Append("\n");
            sb.Append("  Communicatorbrandid: ").Append(Communicatorbrandid).Append("\n");
            sb.Append("  Medicationhistoryconsent: ").Append(Medicationhistoryconsent).Append("\n");
            sb.Append("  Ishospitaldepartment: ").Append(Ishospitaldepartment).Append("\n");
            sb.Append("  Providergroupid: ").Append(Providergroupid).Append("\n");
            sb.Append("  Portalurl: ").Append(Portalurl).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Servicedepartment: ").Append(Servicedepartment).Append("\n");
            sb.Append("  Oneyearcontractmax: ").Append(Oneyearcontractmax).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  Providergroupname: ").Append(Providergroupname).Append("\n");
            sb.Append("  Doesnotobservedst: ").Append(Doesnotobservedst).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Ecommercecreditcardtypes: ").Append(Ecommercecreditcardtypes).Append("\n");
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
            return this.Equals(input as Department);
        }

        /// <summary>
        /// Returns true if Department instances are equal
        /// </summary>
        /// <param name="input">Instance of Department to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Department input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Creditcardtypes == input.Creditcardtypes ||
                    this.Creditcardtypes != null &&
                    input.Creditcardtypes != null &&
                    this.Creditcardtypes.SequenceEqual(input.Creditcardtypes)
                ) &&
                (
                    this.Timezoneoffset == input.Timezoneoffset ||
                    (this.Timezoneoffset != null &&
                    this.Timezoneoffset.Equals(input.Timezoneoffset))
                ) &&
                (
                    this.Singleappointmentcontractmax == input.Singleappointmentcontractmax ||
                    (this.Singleappointmentcontractmax != null &&
                    this.Singleappointmentcontractmax.Equals(input.Singleappointmentcontractmax))
                ) &&
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) &&
                (
                    this.Placeofservicefacility == input.Placeofservicefacility ||
                    (this.Placeofservicefacility != null &&
                    this.Placeofservicefacility.Equals(input.Placeofservicefacility))
                ) &&
                (
                    this.Latitude == input.Latitude ||
                    (this.Latitude != null &&
                    this.Latitude.Equals(input.Latitude))
                ) &&
                (
                    this.Departmentid == input.Departmentid ||
                    (this.Departmentid != null &&
                    this.Departmentid.Equals(input.Departmentid))
                ) &&
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) &&
                (
                    this.Placeofservicetypeid == input.Placeofservicetypeid ||
                    (this.Placeofservicetypeid != null &&
                    this.Placeofservicetypeid.Equals(input.Placeofservicetypeid))
                ) &&
                (
                    this.Longitude == input.Longitude ||
                    (this.Longitude != null &&
                    this.Longitude.Equals(input.Longitude))
                ) &&
                (
                    this.Clinicals == input.Clinicals ||
                    (this.Clinicals != null &&
                    this.Clinicals.Equals(input.Clinicals))
                ) &&
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) &&
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) &&
                (
                    this.Patientdepartmentname == input.Patientdepartmentname ||
                    (this.Patientdepartmentname != null &&
                    this.Patientdepartmentname.Equals(input.Patientdepartmentname))
                ) &&
                (
                    this.Chartsharinggroupid == input.Chartsharinggroupid ||
                    (this.Chartsharinggroupid != null &&
                    this.Chartsharinggroupid.Equals(input.Chartsharinggroupid))
                ) &&
                (
                    this.Placeofservicetypename == input.Placeofservicetypename ||
                    (this.Placeofservicetypename != null &&
                    this.Placeofservicetypename.Equals(input.Placeofservicetypename))
                ) &&
                (
                    this.Zip == input.Zip ||
                    (this.Zip != null &&
                    this.Zip.Equals(input.Zip))
                ) &&
                (
                    this.Timezonename == input.Timezonename ||
                    (this.Timezonename != null &&
                    this.Timezonename.Equals(input.Timezonename))
                ) &&
                (
                    this.Communicatorbrandid == input.Communicatorbrandid ||
                    (this.Communicatorbrandid != null &&
                    this.Communicatorbrandid.Equals(input.Communicatorbrandid))
                ) &&
                (
                    this.Medicationhistoryconsent == input.Medicationhistoryconsent ||
                    (this.Medicationhistoryconsent != null &&
                    this.Medicationhistoryconsent.Equals(input.Medicationhistoryconsent))
                ) &&
                (
                    this.Ishospitaldepartment == input.Ishospitaldepartment ||
                    (this.Ishospitaldepartment != null &&
                    this.Ishospitaldepartment.Equals(input.Ishospitaldepartment))
                ) &&
                (
                    this.Providergroupid == input.Providergroupid ||
                    (this.Providergroupid != null &&
                    this.Providergroupid.Equals(input.Providergroupid))
                ) &&
                (
                    this.Portalurl == input.Portalurl ||
                    (this.Portalurl != null &&
                    this.Portalurl.Equals(input.Portalurl))
                ) &&
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) &&
                (
                    this.Servicedepartment == input.Servicedepartment ||
                    (this.Servicedepartment != null &&
                    this.Servicedepartment.Equals(input.Servicedepartment))
                ) &&
                (
                    this.Oneyearcontractmax == input.Oneyearcontractmax ||
                    (this.Oneyearcontractmax != null &&
                    this.Oneyearcontractmax.Equals(input.Oneyearcontractmax))
                ) &&
                (
                    this.Fax == input.Fax ||
                    (this.Fax != null &&
                    this.Fax.Equals(input.Fax))
                ) &&
                (
                    this.Providergroupname == input.Providergroupname ||
                    (this.Providergroupname != null &&
                    this.Providergroupname.Equals(input.Providergroupname))
                ) &&
                (
                    this.Doesnotobservedst == input.Doesnotobservedst ||
                    (this.Doesnotobservedst != null &&
                    this.Doesnotobservedst.Equals(input.Doesnotobservedst))
                ) &&
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) &&
                (
                    this.Ecommercecreditcardtypes == input.Ecommercecreditcardtypes ||
                    this.Ecommercecreditcardtypes != null &&
                    input.Ecommercecreditcardtypes != null &&
                    this.Ecommercecreditcardtypes.SequenceEqual(input.Ecommercecreditcardtypes)
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
                if (this.Creditcardtypes != null)
                    hashCode = hashCode * 59 + this.Creditcardtypes.GetHashCode();
                if (this.Timezoneoffset != null)
                    hashCode = hashCode * 59 + this.Timezoneoffset.GetHashCode();
                if (this.Singleappointmentcontractmax != null)
                    hashCode = hashCode * 59 + this.Singleappointmentcontractmax.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Placeofservicefacility != null)
                    hashCode = hashCode * 59 + this.Placeofservicefacility.GetHashCode();
                if (this.Latitude != null)
                    hashCode = hashCode * 59 + this.Latitude.GetHashCode();
                if (this.Departmentid != null)
                    hashCode = hashCode * 59 + this.Departmentid.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Placeofservicetypeid != null)
                    hashCode = hashCode * 59 + this.Placeofservicetypeid.GetHashCode();
                if (this.Longitude != null)
                    hashCode = hashCode * 59 + this.Longitude.GetHashCode();
                if (this.Clinicals != null)
                    hashCode = hashCode * 59 + this.Clinicals.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Patientdepartmentname != null)
                    hashCode = hashCode * 59 + this.Patientdepartmentname.GetHashCode();
                if (this.Chartsharinggroupid != null)
                    hashCode = hashCode * 59 + this.Chartsharinggroupid.GetHashCode();
                if (this.Placeofservicetypename != null)
                    hashCode = hashCode * 59 + this.Placeofservicetypename.GetHashCode();
                if (this.Zip != null)
                    hashCode = hashCode * 59 + this.Zip.GetHashCode();
                if (this.Timezonename != null)
                    hashCode = hashCode * 59 + this.Timezonename.GetHashCode();
                if (this.Communicatorbrandid != null)
                    hashCode = hashCode * 59 + this.Communicatorbrandid.GetHashCode();
                if (this.Medicationhistoryconsent != null)
                    hashCode = hashCode * 59 + this.Medicationhistoryconsent.GetHashCode();
                if (this.Ishospitaldepartment != null)
                    hashCode = hashCode * 59 + this.Ishospitaldepartment.GetHashCode();
                if (this.Providergroupid != null)
                    hashCode = hashCode * 59 + this.Providergroupid.GetHashCode();
                if (this.Portalurl != null)
                    hashCode = hashCode * 59 + this.Portalurl.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Servicedepartment != null)
                    hashCode = hashCode * 59 + this.Servicedepartment.GetHashCode();
                if (this.Oneyearcontractmax != null)
                    hashCode = hashCode * 59 + this.Oneyearcontractmax.GetHashCode();
                if (this.Fax != null)
                    hashCode = hashCode * 59 + this.Fax.GetHashCode();
                if (this.Providergroupname != null)
                    hashCode = hashCode * 59 + this.Providergroupname.GetHashCode();
                if (this.Doesnotobservedst != null)
                    hashCode = hashCode * 59 + this.Doesnotobservedst.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Ecommercecreditcardtypes != null)
                    hashCode = hashCode * 59 + this.Ecommercecreditcardtypes.GetHashCode();
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
