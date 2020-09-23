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
    /// MoneyObject
    /// </summary>

    [DataContract]
    public partial class MoneyObject : IEquatable<MoneyObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MoneyObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MoneyObject() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MoneyObject" /> class.
        /// </summary>
        /// <param name="CurrencyCode">CurrencyCode (required).</param>
        /// <param name="Value">Value (required).</param>
        /// <param name="ValueInBaseUnits">ValueInBaseUnits (required).</param>/// 
        public MoneyObject(string CurrencyCode = default(string), decimal Value = default(decimal), int ValueInBaseUnits = default(int))
        {
            // to ensure "CurrencyCode" is required (not null)
            if (CurrencyCode == null)
            {
                throw new InvalidDataException("CurrencyCode is a required property for MoneyObject and cannot be null");
            }
            else
            {
                this.CurrencyCode = CurrencyCode;
            }

            this.Value = Value;
            this.ValueInBaseUnits = ValueInBaseUnits;           
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "currencyCode", EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }
        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public decimal Value { get; set; }
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "valueInBaseUnits", EmitDefaultValue = false)]
        public int ValueInBaseUnits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MoneyObject {\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ValueInBaseUnits: ").Append(ValueInBaseUnits).Append("\n");
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
            return this.Equals(obj as MoneyObject);
        }

        /// <summary>
        /// Returns true if MoneyObject instances are equal
        /// </summary>
        /// <param name="other">Instance of MoneyObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MoneyObject other)
        {
            
            if (other == null)
                return false;

            return
                (
                    this.CurrencyCode == other.CurrencyCode ||
                    this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(other.CurrencyCode)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.ValueInBaseUnits == other.ValueInBaseUnits ||
                    this.ValueInBaseUnits.Equals(other.ValueInBaseUnits)
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
                
                if (this.CurrencyCode != null)
                    hash = hash * 59 + this.CurrencyCode.GetHashCode();
                if (this.Value != 0)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this.ValueInBaseUnits != 0)
                    hash = hash * 59 + this.ValueInBaseUnits.GetHashCode();

                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // CapturedAmount (decimal?) minimum
            if (this.Value < (decimal?)0)
            {
                yield return new ValidationResult("Invalid value for Value, must be a value greater than or equal to 0.", new[] { "Value" });
            }

            // RefundedAmount (decimal?) minimum
            if (this.ValueInBaseUnits < (int?)0)
            {
                yield return new ValidationResult("Invalid value for ValueInBaseUnits, must be a value greater than or equal to 0.", new[] { "ValueInBaseUnits" });
            }

            yield break;
        }
    }

}
