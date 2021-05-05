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
    /// Medication
    /// </summary>
    [DataContract]
        public partial class Medication :  IEquatable<Medication>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Medication" /> class.
        /// </summary>
        /// <param name="events">The list of events for this medication. Can be START, END, ORDER, ENTER, FILL, or HIDE.  (required).</param>
        /// <param name="structuredsig">structuredsig.</param>
        /// <param name="medicationentryid">Primary ID for this medication entry. Those starting with C are clinical prescriptions, and those starting with H are historical (entered, downloaded, etc). .</param>
        /// <param name="medicationid">Athena ID for this medication. (required).</param>
        /// <param name="medication">The name of the medication..</param>
        /// <param name="isstructuredsig">Whether the sig for this entry is structured..</param>
        /// <param name="unstructuredsig">The unstructured sig for this medication, if any. If there is a structured sig, this will contain the formatted version of that sig. .</param>
        /// <param name="source">How this medication was entered. This can be the ordering provider, a medication history download (express scripts, medco, etc),  ATHENA (which means it was entered manually), etc. .</param>
        /// <param name="status">The status of this medication. Medications in PEND status are associated with approved future orders and have not yet been submitted. .</param>
        /// <param name="organclass">The organ class for this medication. This is equivalent to a medication class..</param>
        /// <param name="therapeuticclass">The therapeutic class for this medication. This is equivalent to a medication subclass..</param>
        /// <param name="futuresubmitdate">The date a medication will be submitted. Included if the medication is in PEND status and attached to a approved future order..</param>
        /// <param name="encounterid">If this was a prescription, this contains the ID of the encounter where it was ordered or administered.</param>
        /// <param name="createdby">The athenaNet username of the person who entered or ordered the medication. Downloaded medications have INTERFACE for this field. .</param>
        /// <param name="approvedby">For clinical prescriptions, the athenaNet username of the person who approved this prescription..</param>
        /// <param name="billingndc">The billing NDC code for this medication..</param>
        /// <param name="orderingmode">The ordering mode for prescriptions. Can be PRESCRIBE, DISPENSE, or ADMINISTER..</param>
        /// <param name="quantity">The total quantity prescribed, dispensed, administered. This is not currently available for historical (downloaded) medications..</param>
        /// <param name="quantityunit">The unit of the quantity. Example: tablets, sprays, etc. .</param>
        /// <param name="refillsallowed">The number of refills allowed when this medication was ordered..</param>
        /// <param name="issafetorenew">Is this medication safe to renew?.</param>
        /// <param name="stopreason">The reason why this medication was stopped..</param>
        /// <param name="providernote">Non-patient facing note for ths prescription. Labeled \&quot;internal note\&quot; in the UI..</param>
        /// <param name="patientnote">Patient-facing note for this prescription. Labeled \&quot;note\&quot; in the UI..</param>
        /// <param name="pharmacy">The name of the pharmacy where this medication was filled..</param>
        /// <param name="pharmacyncpdpid">The NCPDP ID of the pharmacy for this medication.. See http://www.ncpdp.org/ for details..</param>
        /// <param name="prescribedby">The user who prescribed this medication..</param>
        /// <param name="ndcoptions">The list of NDC numbers that correspond to this medication..</param>
        /// <param name="rxnorm">The list of RxNorm Identifiers that correspond to this medication. This list may contain both branded and generic identifiers.</param>
        /// <param name="route">The route for the prescription..</param>
        public Medication(List<MedicationEvent> events = default(List<MedicationEvent>), Dosage structuredsig = default(Dosage), string medicationentryid = default(string), int? medicationid = default(int?), string medication = default(string), bool? isstructuredsig = default(bool?), string unstructuredsig = default(string), string source = default(string), string status = default(string), string organclass = default(string), string therapeuticclass = default(string), string futuresubmitdate = default(string), int? encounterid = default(int?), string createdby = default(string), string approvedby = default(string), string billingndc = default(string), string orderingmode = default(string), int? quantity = default(int?), string quantityunit = default(string), int? refillsallowed = default(int?), bool? issafetorenew = default(bool?), string stopreason = default(string), string providernote = default(string), string patientnote = default(string), string pharmacy = default(string), string pharmacyncpdpid = default(string), string prescribedby = default(string), string ndcoptions = default(string), List<string> rxnorm = default(List<string>), string route = default(string))
        {
            // to ensure "events" is required (not null)
            if (events == null)
            {
                throw new InvalidDataException("events is a required property for Medication and cannot be null");
            }
            else
            {
                this.Events = events;
            }
            // to ensure "medicationid" is required (not null)
            if (medicationid == null)
            {
                throw new InvalidDataException("medicationid is a required property for Medication and cannot be null");
            }
            else
            {
                this.Medicationid = medicationid;
            }
            this.Structuredsig = structuredsig;
            this.Medicationentryid = medicationentryid;
            this._Medication = medication;
            this.Isstructuredsig = isstructuredsig;
            this.Unstructuredsig = unstructuredsig;
            this.Source = source;
            this.Status = status;
            this.Organclass = organclass;
            this.Therapeuticclass = therapeuticclass;
            this.Futuresubmitdate = futuresubmitdate;
            this.Encounterid = encounterid;
            this.Createdby = createdby;
            this.Approvedby = approvedby;
            this.Billingndc = billingndc;
            this.Orderingmode = orderingmode;
            this.Quantity = quantity;
            this.Quantityunit = quantityunit;
            this.Refillsallowed = refillsallowed;
            this.Issafetorenew = issafetorenew;
            this.Stopreason = stopreason;
            this.Providernote = providernote;
            this.Patientnote = patientnote;
            this.Pharmacy = pharmacy;
            this.Pharmacyncpdpid = pharmacyncpdpid;
            this.Prescribedby = prescribedby;
            this.Ndcoptions = ndcoptions;
            this.Rxnorm = rxnorm;
            this.Route = route;
        }
        
        /// <summary>
        /// The list of events for this medication. Can be START, END, ORDER, ENTER, FILL, or HIDE. 
        /// </summary>
        /// <value>The list of events for this medication. Can be START, END, ORDER, ENTER, FILL, or HIDE. </value>
        [DataMember(Name="events", EmitDefaultValue=false)]
        public List<MedicationEvent> Events { get; set; }

        /// <summary>
        /// Gets or Sets Structuredsig
        /// </summary>
        [DataMember(Name="structuredsig", EmitDefaultValue=false)]
        public Dosage Structuredsig { get; set; }

        /// <summary>
        /// Primary ID for this medication entry. Those starting with C are clinical prescriptions, and those starting with H are historical (entered, downloaded, etc). 
        /// </summary>
        /// <value>Primary ID for this medication entry. Those starting with C are clinical prescriptions, and those starting with H are historical (entered, downloaded, etc). </value>
        [DataMember(Name="medicationentryid", EmitDefaultValue=false)]
        public string Medicationentryid { get; set; }

        /// <summary>
        /// Athena ID for this medication.
        /// </summary>
        /// <value>Athena ID for this medication.</value>
        [DataMember(Name="medicationid", EmitDefaultValue=false)]
        public int? Medicationid { get; set; }

        /// <summary>
        /// The name of the medication.
        /// </summary>
        /// <value>The name of the medication.</value>
        [DataMember(Name="medication", EmitDefaultValue=false)]
        public string _Medication { get; set; }

        /// <summary>
        /// Whether the sig for this entry is structured.
        /// </summary>
        /// <value>Whether the sig for this entry is structured.</value>
        [DataMember(Name="isstructuredsig", EmitDefaultValue=false)]
        public bool? Isstructuredsig { get; set; }

        /// <summary>
        /// The unstructured sig for this medication, if any. If there is a structured sig, this will contain the formatted version of that sig. 
        /// </summary>
        /// <value>The unstructured sig for this medication, if any. If there is a structured sig, this will contain the formatted version of that sig. </value>
        [DataMember(Name="unstructuredsig", EmitDefaultValue=false)]
        public string Unstructuredsig { get; set; }

        /// <summary>
        /// How this medication was entered. This can be the ordering provider, a medication history download (express scripts, medco, etc),  ATHENA (which means it was entered manually), etc. 
        /// </summary>
        /// <value>How this medication was entered. This can be the ordering provider, a medication history download (express scripts, medco, etc),  ATHENA (which means it was entered manually), etc. </value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }

        /// <summary>
        /// The status of this medication. Medications in PEND status are associated with approved future orders and have not yet been submitted. 
        /// </summary>
        /// <value>The status of this medication. Medications in PEND status are associated with approved future orders and have not yet been submitted. </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// The organ class for this medication. This is equivalent to a medication class.
        /// </summary>
        /// <value>The organ class for this medication. This is equivalent to a medication class.</value>
        [DataMember(Name="organclass", EmitDefaultValue=false)]
        public string Organclass { get; set; }

        /// <summary>
        /// The therapeutic class for this medication. This is equivalent to a medication subclass.
        /// </summary>
        /// <value>The therapeutic class for this medication. This is equivalent to a medication subclass.</value>
        [DataMember(Name="therapeuticclass", EmitDefaultValue=false)]
        public string Therapeuticclass { get; set; }

        /// <summary>
        /// The date a medication will be submitted. Included if the medication is in PEND status and attached to a approved future order.
        /// </summary>
        /// <value>The date a medication will be submitted. Included if the medication is in PEND status and attached to a approved future order.</value>
        [DataMember(Name="futuresubmitdate", EmitDefaultValue=false)]
        public string Futuresubmitdate { get; set; }

        /// <summary>
        /// If this was a prescription, this contains the ID of the encounter where it was ordered or administered
        /// </summary>
        /// <value>If this was a prescription, this contains the ID of the encounter where it was ordered or administered</value>
        [DataMember(Name="encounterid", EmitDefaultValue=false)]
        public int? Encounterid { get; set; }

        /// <summary>
        /// The athenaNet username of the person who entered or ordered the medication. Downloaded medications have INTERFACE for this field. 
        /// </summary>
        /// <value>The athenaNet username of the person who entered or ordered the medication. Downloaded medications have INTERFACE for this field. </value>
        [DataMember(Name="createdby", EmitDefaultValue=false)]
        public string Createdby { get; set; }

        /// <summary>
        /// For clinical prescriptions, the athenaNet username of the person who approved this prescription.
        /// </summary>
        /// <value>For clinical prescriptions, the athenaNet username of the person who approved this prescription.</value>
        [DataMember(Name="approvedby", EmitDefaultValue=false)]
        public string Approvedby { get; set; }

        /// <summary>
        /// The billing NDC code for this medication.
        /// </summary>
        /// <value>The billing NDC code for this medication.</value>
        [DataMember(Name="billingndc", EmitDefaultValue=false)]
        public string Billingndc { get; set; }

        /// <summary>
        /// The ordering mode for prescriptions. Can be PRESCRIBE, DISPENSE, or ADMINISTER.
        /// </summary>
        /// <value>The ordering mode for prescriptions. Can be PRESCRIBE, DISPENSE, or ADMINISTER.</value>
        [DataMember(Name="orderingmode", EmitDefaultValue=false)]
        public string Orderingmode { get; set; }

        /// <summary>
        /// The total quantity prescribed, dispensed, administered. This is not currently available for historical (downloaded) medications.
        /// </summary>
        /// <value>The total quantity prescribed, dispensed, administered. This is not currently available for historical (downloaded) medications.</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// The unit of the quantity. Example: tablets, sprays, etc. 
        /// </summary>
        /// <value>The unit of the quantity. Example: tablets, sprays, etc. </value>
        [DataMember(Name="quantityunit", EmitDefaultValue=false)]
        public string Quantityunit { get; set; }

        /// <summary>
        /// The number of refills allowed when this medication was ordered.
        /// </summary>
        /// <value>The number of refills allowed when this medication was ordered.</value>
        [DataMember(Name="refillsallowed", EmitDefaultValue=false)]
        public int? Refillsallowed { get; set; }

        /// <summary>
        /// Is this medication safe to renew?
        /// </summary>
        /// <value>Is this medication safe to renew?</value>
        [DataMember(Name="issafetorenew", EmitDefaultValue=false)]
        public bool? Issafetorenew { get; set; }

        /// <summary>
        /// The reason why this medication was stopped.
        /// </summary>
        /// <value>The reason why this medication was stopped.</value>
        [DataMember(Name="stopreason", EmitDefaultValue=false)]
        public string Stopreason { get; set; }

        /// <summary>
        /// Non-patient facing note for ths prescription. Labeled \&quot;internal note\&quot; in the UI.
        /// </summary>
        /// <value>Non-patient facing note for ths prescription. Labeled \&quot;internal note\&quot; in the UI.</value>
        [DataMember(Name="providernote", EmitDefaultValue=false)]
        public string Providernote { get; set; }

        /// <summary>
        /// Patient-facing note for this prescription. Labeled \&quot;note\&quot; in the UI.
        /// </summary>
        /// <value>Patient-facing note for this prescription. Labeled \&quot;note\&quot; in the UI.</value>
        [DataMember(Name="patientnote", EmitDefaultValue=false)]
        public string Patientnote { get; set; }

        /// <summary>
        /// The name of the pharmacy where this medication was filled.
        /// </summary>
        /// <value>The name of the pharmacy where this medication was filled.</value>
        [DataMember(Name="pharmacy", EmitDefaultValue=false)]
        public string Pharmacy { get; set; }

        /// <summary>
        /// The NCPDP ID of the pharmacy for this medication.. See http://www.ncpdp.org/ for details.
        /// </summary>
        /// <value>The NCPDP ID of the pharmacy for this medication.. See http://www.ncpdp.org/ for details.</value>
        [DataMember(Name="pharmacyncpdpid", EmitDefaultValue=false)]
        public string Pharmacyncpdpid { get; set; }

        /// <summary>
        /// The user who prescribed this medication.
        /// </summary>
        /// <value>The user who prescribed this medication.</value>
        [DataMember(Name="prescribedby", EmitDefaultValue=false)]
        public string Prescribedby { get; set; }

        /// <summary>
        /// The list of NDC numbers that correspond to this medication.
        /// </summary>
        /// <value>The list of NDC numbers that correspond to this medication.</value>
        [DataMember(Name="ndcoptions", EmitDefaultValue=false)]
        public string Ndcoptions { get; set; }

        /// <summary>
        /// The list of RxNorm Identifiers that correspond to this medication. This list may contain both branded and generic identifiers
        /// </summary>
        /// <value>The list of RxNorm Identifiers that correspond to this medication. This list may contain both branded and generic identifiers</value>
        [DataMember(Name="rxnorm", EmitDefaultValue=false)]
        public List<string> Rxnorm { get; set; }

        /// <summary>
        /// The route for the prescription.
        /// </summary>
        /// <value>The route for the prescription.</value>
        [DataMember(Name="route", EmitDefaultValue=false)]
        public string Route { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Medication {\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  Structuredsig: ").Append(Structuredsig).Append("\n");
            sb.Append("  Medicationentryid: ").Append(Medicationentryid).Append("\n");
            sb.Append("  Medicationid: ").Append(Medicationid).Append("\n");
            sb.Append("  _Medication: ").Append(_Medication).Append("\n");
            sb.Append("  Isstructuredsig: ").Append(Isstructuredsig).Append("\n");
            sb.Append("  Unstructuredsig: ").Append(Unstructuredsig).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Organclass: ").Append(Organclass).Append("\n");
            sb.Append("  Therapeuticclass: ").Append(Therapeuticclass).Append("\n");
            sb.Append("  Futuresubmitdate: ").Append(Futuresubmitdate).Append("\n");
            sb.Append("  Encounterid: ").Append(Encounterid).Append("\n");
            sb.Append("  Createdby: ").Append(Createdby).Append("\n");
            sb.Append("  Approvedby: ").Append(Approvedby).Append("\n");
            sb.Append("  Billingndc: ").Append(Billingndc).Append("\n");
            sb.Append("  Orderingmode: ").Append(Orderingmode).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Quantityunit: ").Append(Quantityunit).Append("\n");
            sb.Append("  Refillsallowed: ").Append(Refillsallowed).Append("\n");
            sb.Append("  Issafetorenew: ").Append(Issafetorenew).Append("\n");
            sb.Append("  Stopreason: ").Append(Stopreason).Append("\n");
            sb.Append("  Providernote: ").Append(Providernote).Append("\n");
            sb.Append("  Patientnote: ").Append(Patientnote).Append("\n");
            sb.Append("  Pharmacy: ").Append(Pharmacy).Append("\n");
            sb.Append("  Pharmacyncpdpid: ").Append(Pharmacyncpdpid).Append("\n");
            sb.Append("  Prescribedby: ").Append(Prescribedby).Append("\n");
            sb.Append("  Ndcoptions: ").Append(Ndcoptions).Append("\n");
            sb.Append("  Rxnorm: ").Append(Rxnorm).Append("\n");
            sb.Append("  Route: ").Append(Route).Append("\n");
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
            return this.Equals(input as Medication);
        }

        /// <summary>
        /// Returns true if Medication instances are equal
        /// </summary>
        /// <param name="input">Instance of Medication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Medication input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Events == input.Events ||
                    this.Events != null &&
                    input.Events != null &&
                    this.Events.SequenceEqual(input.Events)
                ) && 
                (
                    this.Structuredsig == input.Structuredsig ||
                    (this.Structuredsig != null &&
                    this.Structuredsig.Equals(input.Structuredsig))
                ) && 
                (
                    this.Medicationentryid == input.Medicationentryid ||
                    (this.Medicationentryid != null &&
                    this.Medicationentryid.Equals(input.Medicationentryid))
                ) && 
                (
                    this.Medicationid == input.Medicationid ||
                    (this.Medicationid != null &&
                    this.Medicationid.Equals(input.Medicationid))
                ) && 
                (
                    this._Medication == input._Medication ||
                    (this._Medication != null &&
                    this._Medication.Equals(input._Medication))
                ) && 
                (
                    this.Isstructuredsig == input.Isstructuredsig ||
                    (this.Isstructuredsig != null &&
                    this.Isstructuredsig.Equals(input.Isstructuredsig))
                ) && 
                (
                    this.Unstructuredsig == input.Unstructuredsig ||
                    (this.Unstructuredsig != null &&
                    this.Unstructuredsig.Equals(input.Unstructuredsig))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Organclass == input.Organclass ||
                    (this.Organclass != null &&
                    this.Organclass.Equals(input.Organclass))
                ) && 
                (
                    this.Therapeuticclass == input.Therapeuticclass ||
                    (this.Therapeuticclass != null &&
                    this.Therapeuticclass.Equals(input.Therapeuticclass))
                ) && 
                (
                    this.Futuresubmitdate == input.Futuresubmitdate ||
                    (this.Futuresubmitdate != null &&
                    this.Futuresubmitdate.Equals(input.Futuresubmitdate))
                ) && 
                (
                    this.Encounterid == input.Encounterid ||
                    (this.Encounterid != null &&
                    this.Encounterid.Equals(input.Encounterid))
                ) && 
                (
                    this.Createdby == input.Createdby ||
                    (this.Createdby != null &&
                    this.Createdby.Equals(input.Createdby))
                ) && 
                (
                    this.Approvedby == input.Approvedby ||
                    (this.Approvedby != null &&
                    this.Approvedby.Equals(input.Approvedby))
                ) && 
                (
                    this.Billingndc == input.Billingndc ||
                    (this.Billingndc != null &&
                    this.Billingndc.Equals(input.Billingndc))
                ) && 
                (
                    this.Orderingmode == input.Orderingmode ||
                    (this.Orderingmode != null &&
                    this.Orderingmode.Equals(input.Orderingmode))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.Quantityunit == input.Quantityunit ||
                    (this.Quantityunit != null &&
                    this.Quantityunit.Equals(input.Quantityunit))
                ) && 
                (
                    this.Refillsallowed == input.Refillsallowed ||
                    (this.Refillsallowed != null &&
                    this.Refillsallowed.Equals(input.Refillsallowed))
                ) && 
                (
                    this.Issafetorenew == input.Issafetorenew ||
                    (this.Issafetorenew != null &&
                    this.Issafetorenew.Equals(input.Issafetorenew))
                ) && 
                (
                    this.Stopreason == input.Stopreason ||
                    (this.Stopreason != null &&
                    this.Stopreason.Equals(input.Stopreason))
                ) && 
                (
                    this.Providernote == input.Providernote ||
                    (this.Providernote != null &&
                    this.Providernote.Equals(input.Providernote))
                ) && 
                (
                    this.Patientnote == input.Patientnote ||
                    (this.Patientnote != null &&
                    this.Patientnote.Equals(input.Patientnote))
                ) && 
                (
                    this.Pharmacy == input.Pharmacy ||
                    (this.Pharmacy != null &&
                    this.Pharmacy.Equals(input.Pharmacy))
                ) && 
                (
                    this.Pharmacyncpdpid == input.Pharmacyncpdpid ||
                    (this.Pharmacyncpdpid != null &&
                    this.Pharmacyncpdpid.Equals(input.Pharmacyncpdpid))
                ) && 
                (
                    this.Prescribedby == input.Prescribedby ||
                    (this.Prescribedby != null &&
                    this.Prescribedby.Equals(input.Prescribedby))
                ) && 
                (
                    this.Ndcoptions == input.Ndcoptions ||
                    (this.Ndcoptions != null &&
                    this.Ndcoptions.Equals(input.Ndcoptions))
                ) && 
                (
                    this.Rxnorm == input.Rxnorm ||
                    this.Rxnorm != null &&
                    input.Rxnorm != null &&
                    this.Rxnorm.SequenceEqual(input.Rxnorm)
                ) && 
                (
                    this.Route == input.Route ||
                    (this.Route != null &&
                    this.Route.Equals(input.Route))
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
                if (this.Events != null)
                    hashCode = hashCode * 59 + this.Events.GetHashCode();
                if (this.Structuredsig != null)
                    hashCode = hashCode * 59 + this.Structuredsig.GetHashCode();
                if (this.Medicationentryid != null)
                    hashCode = hashCode * 59 + this.Medicationentryid.GetHashCode();
                if (this.Medicationid != null)
                    hashCode = hashCode * 59 + this.Medicationid.GetHashCode();
                if (this._Medication != null)
                    hashCode = hashCode * 59 + this._Medication.GetHashCode();
                if (this.Isstructuredsig != null)
                    hashCode = hashCode * 59 + this.Isstructuredsig.GetHashCode();
                if (this.Unstructuredsig != null)
                    hashCode = hashCode * 59 + this.Unstructuredsig.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Organclass != null)
                    hashCode = hashCode * 59 + this.Organclass.GetHashCode();
                if (this.Therapeuticclass != null)
                    hashCode = hashCode * 59 + this.Therapeuticclass.GetHashCode();
                if (this.Futuresubmitdate != null)
                    hashCode = hashCode * 59 + this.Futuresubmitdate.GetHashCode();
                if (this.Encounterid != null)
                    hashCode = hashCode * 59 + this.Encounterid.GetHashCode();
                if (this.Createdby != null)
                    hashCode = hashCode * 59 + this.Createdby.GetHashCode();
                if (this.Approvedby != null)
                    hashCode = hashCode * 59 + this.Approvedby.GetHashCode();
                if (this.Billingndc != null)
                    hashCode = hashCode * 59 + this.Billingndc.GetHashCode();
                if (this.Orderingmode != null)
                    hashCode = hashCode * 59 + this.Orderingmode.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.Quantityunit != null)
                    hashCode = hashCode * 59 + this.Quantityunit.GetHashCode();
                if (this.Refillsallowed != null)
                    hashCode = hashCode * 59 + this.Refillsallowed.GetHashCode();
                if (this.Issafetorenew != null)
                    hashCode = hashCode * 59 + this.Issafetorenew.GetHashCode();
                if (this.Stopreason != null)
                    hashCode = hashCode * 59 + this.Stopreason.GetHashCode();
                if (this.Providernote != null)
                    hashCode = hashCode * 59 + this.Providernote.GetHashCode();
                if (this.Patientnote != null)
                    hashCode = hashCode * 59 + this.Patientnote.GetHashCode();
                if (this.Pharmacy != null)
                    hashCode = hashCode * 59 + this.Pharmacy.GetHashCode();
                if (this.Pharmacyncpdpid != null)
                    hashCode = hashCode * 59 + this.Pharmacyncpdpid.GetHashCode();
                if (this.Prescribedby != null)
                    hashCode = hashCode * 59 + this.Prescribedby.GetHashCode();
                if (this.Ndcoptions != null)
                    hashCode = hashCode * 59 + this.Ndcoptions.GetHashCode();
                if (this.Rxnorm != null)
                    hashCode = hashCode * 59 + this.Rxnorm.GetHashCode();
                if (this.Route != null)
                    hashCode = hashCode * 59 + this.Route.GetHashCode();
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
