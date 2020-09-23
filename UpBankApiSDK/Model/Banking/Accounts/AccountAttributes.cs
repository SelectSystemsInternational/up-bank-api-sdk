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
using Newtonsoft.Json.Converters;

namespace UpBankApi.Model
{
    /// <summary>
    /// AccountAttributes
    /// </summary>

    [DataContract]
    public partial class AccountAttributes : IEquatable<AccountAttributes>, IValidatableObject
    {
        /// <summary>
        /// The attributes Account Type
        /// </summary>
        /// <value>The attributes Account Type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountTypeEnum
        {
            /// <summary>
            /// Enum TRANSACTIONAL for "TRANSACTIONAL"
            /// </summary>
            [EnumMember(Value = "TRANSACTIONAL")]
            TRANSACTIONAL,

            /// <summary>
            /// Enum SAVER for "SAVER"
            /// </summary>
            [EnumMember(Value = "SAVER")]
            SAVER
        }

        /// <summary>
        /// The attributes Account Type
        /// </summary>
        /// <value>The attributes Account Type</value>
        [DataMember(Name = "accountType", EmitDefaultValue = false)]
        public AccountTypeEnum? AccountType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountAttributes() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes" /> class.
        /// </summary>
        /// <param name="DisplayName">DisplayName (required).</param>
        /// <param name="AccountType">AccountType (required).</param>
        /// <param name="Balance">Balance (required).</param>/// 
        /// <param name="CreatedAt">CreatedAt (required).</param>/// 
        public AccountAttributes(string DisplayName = default, AccountTypeEnum AccountType = default, MoneyObject Balance = default, DateTime CreatedAt = default)
        {
            // to ensure "Id" is required (not null)
            if (DisplayName == null)
            {
                throw new InvalidDataException("DisplayName is a required property for AccountAttributes and cannot be null");
            }
            else
            {
                this.DisplayName = DisplayName;
            }
            // to ensure "Id" is required (not null)
            if (Balance == null)
            {
                throw new InvalidDataException("Balance is a required property for AccountAttributes and cannot be null");
            }
            else
            {
                this.Balance = Balance;
            }
            // to ensure "Id" is required (not null)
            if (CreatedAt == null)
            {
                throw new InvalidDataException("CreatedAt is a required property for AccountAttributes and cannot be null");
            }
            else
            {
                this.CreatedAt = CreatedAt;
            }

            this.AccountType = AccountType;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name = "balance", EmitDefaultValue = false)]
        public MoneyObject Balance { get; set; }
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Attributes {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(obj as AccountAttributes);
        }

        /// <summary>
        /// Returns true if AccountAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountAttributes other)
        {
            
            if (other == null)
                return false;

            return
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) &&
                (
                    this.AccountType == other.AccountType ||
                    this.AccountType.Equals(other.AccountType)
                ) &&
                (
                    this.Balance == other.Balance ||
                    this.Balance.Equals(other.Balance)
                ) &&
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt.Equals(other.CreatedAt)
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
                
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.AccountType != 0)
                    hash = hash * 59 + this.AccountType.GetHashCode();
                if (this.Balance != null)
                    hash = hash * 59 + this.Balance.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
