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
    /// TransactionAttributes
    /// </summary>

    [DataContract]
    public partial class TransactionAttributes : IEquatable<TransactionAttributes>, IValidatableObject
    {
        /// <summary>
        /// The attributes Account Type
        /// </summary>
        /// <value>The attributes Account Type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TransactionStatusEnum
        {
            /// <summary>
            /// Enum TRANSACTIONAL for "HELD"
            /// </summary>
            [EnumMember(Value = "HELD")]
            HELD,

            /// <summary>
            /// Enum SAVER for "SETTLED"
            /// </summary>
            [EnumMember(Value = "SETTLED")]
            SETTLED
        }

        /// <summary>
        /// The attributes Account Type
        /// </summary>
        /// <value>The attributes Account Type</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public TransactionStatusEnum? Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionAttributes() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes" /> class.
        /// </summary>
        /// <param name="Status">RawText (required).</param>
        /// <param name="RawText">RawText (required).</param>
        /// <param name="Description">Description (required).</param>        
        /// <param name="Message">Description (required).</param>
        /// <param name="HoldInfo">HoldInfo (required).</param>/// 
        /// <param name="RoundUp">RoundUp (required).</param>/// 
        /// <param name="Cashback">Cashback (required).</param>/// 
        /// <param name="Amount">Amount (required).</param>///
        /// <param name="ForeignAmount">ForeignAmount (required).</param>/// /// 
        /// <param name="SettledAt">SettledAt (required).</param>/// 
        /// <param name="CreatedAt">CreatedAt (required).</param>///
        public TransactionAttributes(TransactionStatusEnum Status = default, string RawText = default, string Description = default, string Message = default,
                HoldInfoObject HoldInfo = default, RoundUpObject RoundUp = default, CashbackObject Cashback = default, MoneyObject Amount = default, 
                MoneyObject ForeignAmount = default, DateTime SettledAt = default, DateTime CreatedAt = default)
        {
            // to ensure "Id" is required (not null)
            if (RawText == null)
            {
                throw new InvalidDataException("RawText is a required property for TransactionAttributes and cannot be null");
            }
            else
            {
                this.RawText = RawText;
            }
            // to ensure "Id" is required (not null)
            if (Description == null)
            {
                throw new InvalidDataException("Description is a required property for TransactionAttributes and cannot be null");
            }
            else
            {
                this.Description = Description;
            }
            // to ensure "Message" is required (not null)
            if (Message == null)
            {
                throw new InvalidDataException("Message is a required property for TransactionAttributes and cannot be null");
            }
            else
            {
                this.Message = Message;
            }

            this.Status = Status;
            this.HoldInfo = HoldInfo;
            this.RoundUp = RoundUp;
            this.Cashback = Cashback;
            this.Amount = Amount;
            this.ForeignAmount = ForeignAmount;
            this.SettledAt = SettledAt;
            this.CreatedAt = CreatedAt;
        }

        /// <summary>
        /// Gets or Sets RawText
        /// </summary>
        [DataMember(Name = "rawText", EmitDefaultValue = false)]
        public string RawText { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Messaged
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name = "holdInfo", EmitDefaultValue = false)]
        public HoldInfoObject HoldInfo { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name = "roundUp", EmitDefaultValue = false)]
        public RoundUpObject RoundUp { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name = "cashback", EmitDefaultValue = false)]
        public CashbackObject Cashback { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public MoneyObject Amount { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name = "foreignAmount", EmitDefaultValue = false)]
        public MoneyObject ForeignAmount { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "settledAt", EmitDefaultValue = false)]
        public DateTime? SettledAt { get; set; }

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
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  RawText: ").Append(RawText).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  HoldInfo: ").Append(HoldInfo).Append("\n");
            sb.Append("  RoundUp: ").Append(RoundUp).Append("\n");
            sb.Append("  Cashback: ").Append(Cashback).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ForeignAmount: ").Append(ForeignAmount).Append("\n");
            sb.Append("  SettledAt: ").Append(SettledAt).Append("\n");
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
            return this.Equals(obj as TransactionAttributes);
        }

        /// <summary>
        /// Returns true if TransactionAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of TransactionAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionAttributes other)
        {
            
            if (other == null)
                return false;

            return
                (
                    this.Status == other.Status ||
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.RawText == other.RawText ||
                    this.RawText != null &&
                    this.RawText.Equals(other.RawText)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) &&
                (
                    this.HoldInfo == other.HoldInfo ||
                    this.HoldInfo.Equals(other.HoldInfo)
                ) &&
                (
                    this.RoundUp == other.RoundUp ||
                    this.RoundUp.Equals(other.RoundUp)
                ) &&
                (
                    this.Cashback == other.Cashback ||
                    this.Cashback.Equals(other.Cashback)
                ) &&
                (
                    this.Amount == other.Amount ||
                    this.Amount.Equals(other.Amount)
                ) &&
                (
                    this.ForeignAmount == other.ForeignAmount ||
                    this.ForeignAmount.Equals(other.ForeignAmount)
                ) &&
                (
                    this.SettledAt == other.SettledAt ||
                    this.SettledAt.Equals(other.SettledAt)
                )&&
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
                
                hash = hash * 59 + this.Status.GetHashCode();
                if (this.RawText != null)
                    hash = hash * 59 + this.RawText.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.HoldInfo != null)
                    hash = hash * 59 + this.HoldInfo.GetHashCode();
                if (this.RoundUp != null)
                    hash = hash * 59 + this.RoundUp.GetHashCode();
                if (this.Cashback != null)
                    hash = hash * 59 + this.Cashback.GetHashCode();
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.ForeignAmount != null)
                    hash = hash * 59 + this.ForeignAmount.GetHashCode();
                if (this.SettledAt != null)
                    hash = hash * 59 + this.SettledAt.GetHashCode();
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
