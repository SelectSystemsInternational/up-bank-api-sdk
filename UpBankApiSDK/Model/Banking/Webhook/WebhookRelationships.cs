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
    /// WebhookRelationships
    /// </summary>

    [DataContract]
    public partial class WebhookRelationships : IEquatable<WebhookRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRelationships" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookRelationships() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRelationships" /> class.
        /// </summary>
        /// <param name="webhook">Logs (required).</param>
        public WebhookRelationships(WebhookLogs Logs = default)
        {
            // to ensure "Logs" is required (not null)
            if (Logs == null)
            {
                throw new InvalidDataException("Logs is a required property for WebhookRelationships and cannot be null");
            }
            else
            {
                this.Logs = Logs;
            }
        }

        /// <summary>
        /// Gets or Sets Logs
        /// </summary>
        [DataMember(Name = "logs", EmitDefaultValue = false)]
        public WebhookLogs Logs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookRelationships {\n");
            sb.Append("  Logs: ").Append(Logs).Append("\n");
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
            
            return this.Equals(obj as WebhookRelationships);
        }

        /// <summary>
        /// Returns true if WebhookRelationships instances are equal
        /// </summary>
        /// <param name="other">Instance of WebhookRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookRelationships other)
        {
            
            if (other == null)
                return false;

            return
                (
                    this.Logs == other.Logs ||
                    this.Logs != null &&
                    this.Logs.Equals(other.Logs)
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
                
                if (this.Logs != null)
                    hash = hash * 59 + this.Logs.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
