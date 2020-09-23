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
    /// WebhookDeliveryLogRelationships
    /// </summary>

    [DataContract]
    public partial class WebhookDeliveryLogRelationships : IEquatable<WebhookDeliveryLogRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeliveryLogRelationships" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookDeliveryLogRelationships() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeliveryLogRelationships" /> class.
        /// </summary>
        /// <param name="WebhookEvent">WebhookEvent (required).</param>
        public WebhookDeliveryLogRelationships(DataObject WebhookEvent = default)
        {
            this.WebhookEvent = WebhookEvent;
        }

        /// <summary>
        /// Gets or Sets Webhook
        /// </summary>
        [DataMember(Name = "webhookEvent", EmitDefaultValue = false)]
        public DataObject WebhookEvent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookDeliveryLogRelationships {\n");
            sb.Append("  WebhookEvent: ").Append(WebhookEvent).Append("\n");
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
            return this.Equals(obj as WebhookDeliveryLogRelationships);
        }

        /// <summary>
        /// Returns true if WebhookDeliveryLogRelationships instances are equal
        /// </summary>
        /// <param name="other">Instance of WebhookDeliveryLogRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookDeliveryLogRelationships other)
        {
            
            if (other == null)
                return false;

            return
                (
                    this.WebhookEvent == other.WebhookEvent ||
                    this.WebhookEvent.Equals(other.WebhookEvent)
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
                
                if (this.WebhookEvent != null)
                    hash = hash * 59 + this.WebhookEvent.GetHashCode();

                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
