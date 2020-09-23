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
    /// CashbackObject
    /// </summary>

    [DataContract]
    public partial class CashbackObject : IEquatable<CashbackObject>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CashbackObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CashbackObject() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="CashbackObject" /> class.
        /// </summary>
        /// <param name="Amount">Amount (required).</param>
        /// <param name="BoostPortion">BoostPortion (required).</param>
        public CashbackObject(string Description = default, MoneyObject Amount = default)
        {
            // to ensure "Data" is required (not null)
            if (Description == null)
            {
                throw new InvalidDataException("Description is a required property for CashbackObject and cannot be null");
            }
            else
            {
                this.Description = Description;
            }

            this.Amount = Amount;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public MoneyObject Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CashbackObject {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
            return this.Equals(obj as CashbackObject);
        }

        /// <summary>
        /// Returns true if CashbackObject instances are equal
        /// </summary>
        /// <param name="other">Instance of CashbackObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CashbackObject other)
        {
            
            if (other == null)
                return false;

            return
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Amount == other.Amount ||
                    this.Amount.Equals(other.Amount)
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

                if (Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();

                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
