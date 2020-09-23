/* 
 * Up Bank API
 *
 * OpenAPI spec version
 *
 * Initial build - : 2020-09-20
 * 
 * Select Systems International : http://selectsystems.com.au
 * 
 */

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace UpBankApi.Model
{
    /// <summary>
    /// WebhookDeliveryLogAttributes
    /// </summary>

    [DataContract]
    public partial class WebhookDeliveryLogAttributes : IEquatable<WebhookDeliveryLogAttributes>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookDeliveryLogAttributes() { }

        public enum WebhookDeliveryStatusEnum
        {
            /// <summary>
            /// Enum DELIVERED for "DELIVERED"
            /// </summary>
            [EnumMember(Value = "DELIVERED")]
            DELIVERED,

            /// <summary>
            /// Enum UNDELIVERABLE for "UNDELIVERABLE"
            /// </summary>
            [EnumMember(Value = "UNDELIVERABLE")]
            UNDELIVERABLE,

            /// <summary>
            /// Enum BAD_RESPONSE_CODE for "BAD_RESPONSE_CODE"
            /// </summary>
            [EnumMember(Value = "BAD_RESPONSE_CODE")]
            BAD_RESPONSE_CODE
        }

        /// <summary>
        /// The attributes Account Type
        /// </summary>
        /// <value>The attributes Account Type</value>
        [DataMember(Name = "eventType", EmitDefaultValue = false)]
        public WebhookDeliveryStatusEnum? DeliveryStatus { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes" /> class.
        /// </summary>
        /// <param name="Request">Request (required).</param>
        /// <param name="CreatedAt">CreatedAt (required).</param>
        public WebhookDeliveryLogAttributes(Request Request = default, Response Response = default, WebhookDeliveryStatusEnum DeliveryStatus = default, DateTime CreatedAt = default)
        {
            this.Request = Request;
            this.Response = Response;
            this.DeliveryStatus = DeliveryStatus;
            this.CreatedAt = CreatedAt;
        }

        /// <summary>
        /// Gets or Sets Request
        /// </summary>
        [DataMember(Name = "request", EmitDefaultValue = false)]
        public Request Request { get; set; }

        /// <summary>
        /// Gets or Sets Response
        /// </summary>
        [DataMember(Name = "Response", EmitDefaultValue = false)]
        public Response Response { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Attributes {\n");
            sb.Append("  Request: ").Append(Request).Append("\n");
            sb.Append("  Response: ").Append(Response).Append("\n");
            sb.Append("  DeliveryStatus: ").Append(DeliveryStatus).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            return this.Equals(obj as WebhookDeliveryLogAttributes);
        }

        /// <summary>
        /// Returns true if WebhookDeliveryLogAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance WebhookDeliveryLogAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookDeliveryLogAttributes other)
        {

            if (other == null)
                return false;

            return
                (
                    this.Request == other.Request ||
                    this.Request.Equals(other.Request)
                ) &&
                (
                    this.Response == other.Response ||
                    this.Response.Equals(other.Response)
                ) &&
                (
                    this.DeliveryStatus == other.DeliveryStatus ||
                    this.DeliveryStatus.Equals(other.DeliveryStatus)
                ) &&
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt.Equals(other.CreatedAt)
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
                int hash = 41;
                if (this.Request != null)
                    hash = hash * 59 + this.Request.GetHashCode();
                if (this.DeliveryStatus != null)
                    hash = hash * 59 + this.DeliveryStatus.GetHashCode();
                if (this.Response != null)
                    hash = hash * 59 + this.Response.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();

                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
