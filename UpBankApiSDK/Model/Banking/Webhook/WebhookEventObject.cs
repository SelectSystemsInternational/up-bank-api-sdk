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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace UpBankApi.Model
{
    /// <summary>
    /// WebhookEventObject
    /// </summary>

    [DataContract]
    public partial class WebhookEventObject : IEquatable<WebhookEventObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEventObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookEventObject() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEventObject" /> class.
        /// </summary>
        /// <param name="Webhook">Webhook (required).</param>
        public WebhookEventObject(DataObject Webhook = default, RelationshipLinks Links = default)
        {
            this.Webhook = Webhook;
            this.Links = Links;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public DataObject Webhook { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public RelationshipLinks Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookEventObject {\n");
            sb.Append("  Webhook: ").Append(Webhook).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(obj as WebhookEventObject);
        }

        /// <summary>
        /// Returns true if WebhookEventObject instances are equal
        /// </summary>
        /// <param name="other">Instance of WebhookEventObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookEventObject other)
        {
            
            if (other == null)
                return false;

            return
                (
                    this.Webhook == other.Webhook ||
                    this.Webhook.Equals(other.Webhook)
                ) &&
                (
                    this.Links == other.Links ||
                    this.Links.Equals(other.Links)
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
                
                if (this.Webhook != null)
                    hash = hash * 59 + this.Webhook.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();

                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
