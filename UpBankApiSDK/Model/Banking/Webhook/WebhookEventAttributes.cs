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
    /// WebhookEventAttributes
    /// </summary>

    [DataContract]
    public partial class WebhookEventAttributes : IEquatable<WebhookEventAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookEventAttributes() { }

        public enum WebhookEventTypeEnum
        {
            /// <summary>
            /// Enum TRANSACTION_CREATED for "TRANSACTION_CREATED"
            /// </summary>
            [EnumMember(Value = "TRANSACTION_CREATED")]
            TRANSACTION_CREATED,

            /// <summary>
            /// Enum TRANSACTION_SETTLED for "TRANSACTION_SETTLED"
            /// </summary>
            [EnumMember(Value = "TRANSACTION_SETTLED")]
            TRANSACTION_SETTLED,

            /// <summary>
            /// Enum TRANSACTION_DELETED for "TRANSACTION_DELETED"
            /// </summary>
            [EnumMember(Value = "TRANSACTION_DELETED")]
            TRANSACTION_DELETED,

            /// <summary>
            /// Enum PING for "PING"
            /// </summary>
            [EnumMember(Value = "PING")]
            PING
        }

        /// <summary>
        /// The attributes Account Type
        /// </summary>
        /// <value>The attributes Account Type</value>
        [DataMember(Name = "eventType", EmitDefaultValue = false)]
        public WebhookEventTypeEnum? EventType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes" /> class.
        /// </summary>
        /// <param name="EventType">Url (required).</param>
        /// <param name="CreatedAt">CreatedAt (required).</param>
        public WebhookEventAttributes(WebhookEventTypeEnum EventType = default, DateTime CreatedAt = default)
        {
            this.EventType = EventType;
            this.CreatedAt = CreatedAt;
        }

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
            sb.Append("  EventType: ").Append(EventType).Append("\n");
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
            return this.Equals(obj as WebhookEventAttributes);
        }

        /// <summary>
        /// Returns true if WebhookEventAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of WebhookEventAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookEventAttributes other)
        {

            if (other == null)
                return false;

            return
                (
                    this.EventType == other.EventType ||
                    this.EventType != null &&
                    this.EventType.Equals(other.EventType)
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

                if (this.EventType != null)
                    hash = hash * 59 + this.EventType.GetHashCode();
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
