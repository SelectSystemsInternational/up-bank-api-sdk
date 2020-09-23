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
    /// AccountObject
    /// </summary>

    [DataContract]
    public partial class AccountObject : IEquatable<AccountObject>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountObject() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountObject" /> class.
        /// </summary>
        /// <param name="Account">Account (required).</param>
        public AccountObject(DataObject Account = default)
        {
            // to ensure "Account" is required (not null)
            if (Account == null)
            {
                throw new InvalidDataException("Account is a required property for AccountObject and cannot be null");
            }
            else
            {
                this.Account = Account;
            }
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public DataObject Account { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountObject {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
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
            return this.Equals(obj as AccountObject);
        }

        /// <summary>
        /// Returns true if AccountObject instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountObject other)
        {
            
            if (other == null)
                return false;

            return
                (
                    this.Account == other.Account ||
                    this.Account.Equals(other.Account)
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

                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
