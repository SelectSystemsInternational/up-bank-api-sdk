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
    /// WebhookAttributes
    /// </summary>

    [DataContract]
    public partial class WebhookAttributes : IEquatable<WebhookAttributes>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookAttributes() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes" /> class.
        /// </summary>
        /// <param name="Url">Url (required).</param>
        /// <param name="Description">Description (required).</param>
        /// <param name="SecretKey">SecretKey (required).</param>/// 
        /// <param name="CreatedAt">CreatedAt (required).</param>/// 
        public WebhookAttributes(string Url = default, string Description = default, string SecretKey = default, DateTime CreatedAt = default)
        {
            // to ensure "Url" is required (not null)
            if (Url == null)
            {
                throw new InvalidDataException("Url is a required property for WebhookAttributes and cannot be null");
            }
            else
            {
                this.Url = Url;
            }
            // to ensure "Description" is required (not null)
            if (Description == null)
            {
                throw new InvalidDataException("Description is a required property for WebhookAttributes and cannot be null");
            }
            else
            {
                this.Description = Description;
            }
            // to ensure "SecretKey" is required (not null)
            if (SecretKey == null)
            {
                throw new InvalidDataException("SecretKey is a required property for WebhookAttributes and cannot be null");
            }
            else
            {
                this.SecretKey = SecretKey;
            }
            // to ensure "Id" is required (not null)
            if (CreatedAt == null)
            {
                throw new InvalidDataException("CreatedAt is a required property for WebhookAttributes and cannot be null");
            }
            else
            {
                this.CreatedAt = CreatedAt;
            }
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }
        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name = "secretKey", EmitDefaultValue = false)]
        public string SecretKey { get; set; }
        /// <summary>
        /// Gets or Sets Amount
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
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SecretKey: ").Append(SecretKey).Append("\n");
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
            return this.Equals(obj as WebhookAttributes);
        }

        /// <summary>
        /// Returns true if WebhookAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of WebhookAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookAttributes other)
        {
            
            if (other == null)
                return false;

            return
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.SecretKey == other.SecretKey ||
                    this.SecretKey != null &&
                    this.SecretKey.Equals(other.SecretKey)
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
                
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.SecretKey != null)
                    hash = hash * 59 + this.SecretKey.GetHashCode();
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
