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
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

using Newtonsoft.Json;

namespace UpBankApi.Model
{
    /// <summary>
    /// RoundUpObject
    /// </summary>

    [DataContract]
    public partial class RoundUpObject : IEquatable<RoundUpObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoundUpObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RoundUpObject() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoundUpObject" /> class.
        /// </summary>
        /// <param name="Amount">Amount (required).</param>
        /// <param name="BoostPortion">BoostPortion (required).</param>
        public RoundUpObject(MoneyObject Amount = default, MoneyObject BoostPortion = default)
        {
            this.Amount = Amount;
            this.BoostPortion = BoostPortion;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public MoneyObject Amount { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name = "boostPortion", EmitDefaultValue = false)]
        public MoneyObject BoostPortion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoundUpObject {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BoostPortion: ").Append(BoostPortion).Append("\n");
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
            return this.Equals(obj as RoundUpObject);
        }

        /// <summary>
        /// Returns true if RoundUpObject instances are equal
        /// </summary>
        /// <param name="other">Instance of RoundUpObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoundUpObject other)
        {
            
            if (other == null)
                return false;

            return
                (
                    this.Amount == other.Amount ||
                    this.Amount.Equals(other.Amount)
                ) &&
                (
                    this.BoostPortion == other.BoostPortion ||
                    this.BoostPortion.Equals(other.BoostPortion)
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

                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.BoostPortion != null)
                    hash = hash * 59 + this.BoostPortion.GetHashCode();

                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
