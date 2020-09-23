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
    /// HoldInfoObject
    /// </summary>

    [DataContract]
    public partial class HoldInfoObject : IEquatable<HoldInfoObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HoldInfoObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HoldInfoObject() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="HoldInfoObject" /> class.
        /// </summary>
        /// <param name="Amount">Amount (required).</param>
        /// <param name="Value">Value (required).</param>
        /// <param name="ValueInBaseUnits">ValueInBaseUnits (required).</param>/// 

        public HoldInfoObject(MoneyObject Amount = default, MoneyObject ForeignAmount = default)
        {
            this.Amount = Amount;
            this.ForeignAmount = ForeignAmount;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public MoneyObject Amount { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name = "foreignAmount", EmitDefaultValue = false)]
        public MoneyObject ForeignAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HoldInfoObject {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ForeignAmount: ").Append(ForeignAmount).Append("\n");
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
            return this.Equals(obj as HoldInfoObject);
        }

        /// <summary>
        /// Returns true if HoldInfoObject instances are equal
        /// </summary>
        /// <param name="other">Instance of HoldInfoObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HoldInfoObject other)
        {
            
            if (other == null)
                return false;

            return
                (
                    this.Amount == other.Amount ||
                    this.Amount.Equals(other.Amount)
                ) &&
                (
                    this.ForeignAmount == other.ForeignAmount ||
                    this.ForeignAmount.Equals(other.ForeignAmount)
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
                if (this.ForeignAmount != null)
                    hash = hash * 59 + this.ForeignAmount.GetHashCode();

                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
