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
    /// TagRelationships
    /// </summary>

    [DataContract]
    public partial class TagRelationships : IEquatable<TagRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagRelationships" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TagRelationships() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagRelationships" /> class.
        /// </summary>
        /// <param name="Transactions">Transactions (required).</param>
        public TagRelationships(RelationshipTransactions Transactions = default)
        {
            // to ensure "Transactions" is required (not null)
            if (Transactions == null)
            {
                throw new InvalidDataException("Transactions is a required property for TagRelationships and cannot be null");
            }
            else
            {
                this.Transactions = Transactions;
            }
        }

        /// <summary>
        /// Gets or Sets Transactions
        /// </summary>
        [DataMember(Name = "transactions", EmitDefaultValue = false)]
        public RelationshipTransactions Transactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TagRelationships {\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
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
            return this.Equals(obj as TagRelationships);
        }

        /// <summary>
        /// Returns true if TagRelationships instances are equal
        /// </summary>
        /// <param name="other">Instance of TagRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TagRelationships other)
        {

            if (other == null)
                return false;

            return
                (
                    this.Transactions == other.Transactions ||
                    this.Transactions != null &&
                    this.Transactions.Equals(other.Transactions)
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

                if (this.Transactions != null)
                    hash = hash * 59 + this.Transactions.GetHashCode();

                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
