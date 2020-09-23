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
    /// WebhookLogs
    /// </summary>

    [DataContract]
    public partial class WebhookLogs : IEquatable<WebhookLogs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Logs" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookLogs() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Logs" /> class.
        /// </summary>
        /// <param name="Logs">Logs (required).</param>
        public WebhookLogs(RelationshipLinks Links = default)
        {
            // to ensure "Links" is required (not null)
            if (Links == null)
            {
                throw new InvalidDataException("Links is a required property for WebhookLogs and cannot be null");
            }
            else
            {
                this.Links = Links;
            }
        }

        /// <summary>
        /// Gets or Sets Id
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
            sb.Append("class Logs {\n");
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
            return this.Equals(obj as WebhookLogs);
        }

        /// <summary>
        /// Returns true if WebhookLogs instances are equal
        /// </summary>
        /// <param name="other">Instance of WebhookLogs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookLogs other)
        {
            
            if (other == null)
                return false;

            return
                (
                    this.Links == other.Links ||
                    this.Links != null &&
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
