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
using System.ComponentModel;

using Newtonsoft.Json;

namespace UpBankApi.Model
{
    /// <summary>
    /// TransactionRelationships
    /// </summary>

    [DataContract]
    public partial class TransactionRelationships : IEquatable<TransactionRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionRelationships" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionRelationships() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionRelationships" /> class.
        /// </summary>
        /// <param name="Transactions">Transactions (required).</param>
        public TransactionRelationships(AccountObject Account = default, CategoryObject Category = default, ParentCategoryObject ParentCategory = default, TagObject Tag = default)
        {
            this.Account = Account;
            this.Category = Category;
            this.ParentCategory = ParentCategory;
            this.Tag = Tag;
        }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name = "account", EmitDefaultValue = false)]
        public AccountObject Account { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public CategoryObject Category { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name = "parentCategory", EmitDefaultValue = false)]
        public ParentCategoryObject ParentCategory { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public TagObject Tag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionRelationships {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  ParentCategory: ").Append(ParentCategory).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
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
            return this.Equals(obj as TransactionRelationships);
        }

        /// <summary>
        /// Returns true if TransactionRelationships instances are equal
        /// </summary>
        /// <param name="other">Instance of TransactionRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionRelationships other)
        {
            
            if (other == null)
                return false;

            return
                (
                    this.Account == other.Account ||
                    this.Account.Equals(other.Account)
                ) &&
                (
                    this.Category == other.Category ||
                    this.Category.Equals(other.Category)
                ) &&
                (
                    this.ParentCategory == other.ParentCategory ||
                    this.ParentCategory.Equals(other.ParentCategory)
                ) &&
                (
                    this.Tag == other.Tag ||
                    this.Tag.Equals(other.Tag)
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
                
                if (this.Account != null)
                    hash = hash * 59 + this.Account.GetHashCode();
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                if (this.ParentCategory != null)
                    hash = hash * 59 + this.ParentCategory.GetHashCode();
                if (this.Tag != null)
                    hash = hash * 59 + this.Tag.GetHashCode();

                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
