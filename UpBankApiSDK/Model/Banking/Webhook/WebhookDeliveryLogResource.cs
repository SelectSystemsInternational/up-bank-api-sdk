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

namespace UpBankApi.Model
{
    /// <summary>
    /// WebhookDeliveryLogResource
    /// </summary>

    [DataContract]
    public partial class WebhookDeliveryLogResource : IEquatable<WebhookDeliveryLogResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeliveryLogResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookDeliveryLogResource() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeliveryLogResource" /> class.
        /// </summary>
        /// <param name="Type">Type (required).</param>
        /// <param name="Id">WebhookEventType (required).</param>
        /// <param name="Attributes">Attributes (required).</param> 
        /// <param name="Relationships">Relationships (required).</param> 
        /// <param name="Links">Links (required).</param> 
        /// 
        public WebhookDeliveryLogResource(string Type = default, string Id = default, WebhookDeliveryLogAttributes Attributes = default, WebhookDeliveryLogRelationships Relationships = default)
        {
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for WebhookDeliveryLogResource and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Type is a required property for WebhookDeliveryLogResource and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            this.Attributes = Attributes;
            this.Relationships = Relationships;
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name = "attributes", EmitDefaultValue = false)]
        public WebhookDeliveryLogAttributes Attributes { get; set; }

        /// <summary>
        /// Gets or Sets Relationships
        /// </summary>
        [DataMember(Name = "relationships", EmitDefaultValue = false)]
        public WebhookDeliveryLogRelationships Relationships { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Records {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Relationships: ").Append(Relationships).Append("\n");
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
            return this.Equals(obj as WebhookDeliveryLogResource);
        }

        /// <summary>
        /// Returns true if WebhookDeliveryLogResource instances are equal
        /// </summary>
        /// <param name="other">Instance of WebhookDeliveryLogResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookDeliveryLogResource other)
        {

            if (other == null)
                return false;

            return
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes.Equals(other.Attributes)
                ) &&
                (
                    this.Relationships == other.Relationships ||
                    this.Relationships.Equals(other.Relationships)
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

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();
                if (this.Relationships != null)
                    hash = hash * 59 + this.Relationships.GetHashCode();

                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
