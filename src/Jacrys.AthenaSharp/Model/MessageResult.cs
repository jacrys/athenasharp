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
    /// MessageResult
    /// </summary>
    [DataContract]
        public partial class MessageResult :  IEquatable<MessageResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageResult" /> class.
        /// </summary>
        /// <param name="messagetype">The type of message that was attempted..</param>
        /// <param name="calltime">Date and time of the call attempt..</param>
        /// <param name="messageresultid">Id of the message attempt..</param>
        /// <param name="result">A description of what happened during the call attempt..</param>
        public MessageResult(string messagetype = default(string), string calltime = default(string), int? messageresultid = default(int?), string result = default(string))
        {
            this.Messagetype = messagetype;
            this.Calltime = calltime;
            this.Messageresultid = messageresultid;
            this.Result = result;
        }
        
        /// <summary>
        /// The type of message that was attempted.
        /// </summary>
        /// <value>The type of message that was attempted.</value>
        [DataMember(Name="messagetype", EmitDefaultValue=false)]
        public string Messagetype { get; set; }

        /// <summary>
        /// Date and time of the call attempt.
        /// </summary>
        /// <value>Date and time of the call attempt.</value>
        [DataMember(Name="calltime", EmitDefaultValue=false)]
        public string Calltime { get; set; }

        /// <summary>
        /// Id of the message attempt.
        /// </summary>
        /// <value>Id of the message attempt.</value>
        [DataMember(Name="messageresultid", EmitDefaultValue=false)]
        public int? Messageresultid { get; set; }

        /// <summary>
        /// A description of what happened during the call attempt.
        /// </summary>
        /// <value>A description of what happened during the call attempt.</value>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public string Result { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageResult {\n");
            sb.Append("  Messagetype: ").Append(Messagetype).Append("\n");
            sb.Append("  Calltime: ").Append(Calltime).Append("\n");
            sb.Append("  Messageresultid: ").Append(Messageresultid).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
            return this.Equals(input as MessageResult);
        }

        /// <summary>
        /// Returns true if MessageResult instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Messagetype == input.Messagetype ||
                    (this.Messagetype != null &&
                    this.Messagetype.Equals(input.Messagetype))
                ) && 
                (
                    this.Calltime == input.Calltime ||
                    (this.Calltime != null &&
                    this.Calltime.Equals(input.Calltime))
                ) && 
                (
                    this.Messageresultid == input.Messageresultid ||
                    (this.Messageresultid != null &&
                    this.Messageresultid.Equals(input.Messageresultid))
                ) && 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
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
                if (this.Messagetype != null)
                    hashCode = hashCode * 59 + this.Messagetype.GetHashCode();
                if (this.Calltime != null)
                    hashCode = hashCode * 59 + this.Calltime.GetHashCode();
                if (this.Messageresultid != null)
                    hashCode = hashCode * 59 + this.Messageresultid.GetHashCode();
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
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
