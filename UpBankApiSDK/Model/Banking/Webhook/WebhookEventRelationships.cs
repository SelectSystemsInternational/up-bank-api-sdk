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
    /// WebhookEventRelationships
    /// </summary>

    [DataContract]
    public partial class WebhookEventRelationships : IEquatable<WebhookEventRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEventRelationships" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookEventRelationships() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEventRelationships" /> class.
        /// </summary>
        /// <param name="Webhook">Webhook (required).</param>
        public WebhookEventRelationships(WebhookEventObject Webhook = default, TransactionObject Transaction = default)
        {
            this.Webhook = Webhook;
            this.Transaction = Transaction;
        }

        /// <summary>
        /// Gets or Sets Webhook
        /// </summary>
        [DataMember(Name = "webhook", EmitDefaultValue = false)]
        public WebhookEventObject Webhook { get; set; }

        /// <summary>
        /// Gets or Sets Logs
        /// </summary>
        [DataMember(Name = "transaction", EmitDefaultValue = false)]
        public TransactionObject Transaction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookEventRelationships {\n");
            sb.Append("  Webhook: ").Append(Webhook).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
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
            return this.Equals(obj as WebhookEventRelationships);
        }

        /// <summary>
        /// Returns true if WebhookEventRelationships instances are equal
        /// </summary>
        /// <param name="other">Instance of WebhookEventRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookEventRelationships other)
        {
            
            if (other == null)
                return false;

            return
                (
                    this.Webhook == other.Webhook ||
                    this.Webhook.Equals(other.Webhook)
                ) &&
                (
                    this.Transaction == other.Transaction ||
                    this.Transaction.Equals(other.Transaction)
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
                if (this.Transaction != null)
                    hash = hash * 59 + this.Transaction.GetHashCode();

                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
