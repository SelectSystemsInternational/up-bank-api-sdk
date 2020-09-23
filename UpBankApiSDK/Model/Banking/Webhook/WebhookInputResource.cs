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
    /// WebhookInputResource
    /// </summary>

    [DataContract]
    public partial class WebhookInputResource : IEquatable<WebhookInputResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookInputResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookInputResource() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookInputResource" /> class.
        /// </summary>
        /// <param name="Attributes">Attributes (required).</param> 
        public WebhookInputResource(WebhookInputAttributes Attributes = default)
        {
            this.Attributes = Attributes;
        }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name = "attributes", EmitDefaultValue = false)]
        public WebhookInputAttributes Attributes { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Records {\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
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
            return this.Equals(obj as WebhookInputResource);
        }

        /// <summary>
        /// Returns true if WebhookInputResource instances are equal
        /// </summary>
        /// <param name="other">Instance of WebhookInputResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookInputResource other)
        {
            
            if (other == null)
                return false;

            return
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes.Equals(other.Attributes)
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

                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();

                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
