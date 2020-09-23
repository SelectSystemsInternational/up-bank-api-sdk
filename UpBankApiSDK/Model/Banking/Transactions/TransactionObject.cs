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
    /// TransactionObject
    /// </summary>

    [DataContract]
    public partial class TransactionObject : IEquatable<TransactionObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionObject() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionObject" /> class.
        /// </summary>
        /// <param name="Data">Data (required).</param>
        public TransactionObject(DataObject Data = default, RelationshipLinks Links = default)
        {
            this.Data = Data;
            this.Links = Links;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "transaction", EmitDefaultValue = false)]
        public DataObject Data { get; set; }

        /// <summary>
        /// Gets or Sets Data
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
            sb.Append("class TransactionObject {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(obj as TransactionObject);
        }

        /// <summary>
        /// Returns true if TransactionObject instances are equal
        /// </summary>
        /// <param name="other">Instance of TransactionObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionObject other)
        {

            if (other == null)
                return false;

            return
                (
                    this.Data == other.Data ||
                    this.Data.Equals(other.Data)
                ) &&
                (
                    this.Links == other.Links ||
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

                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
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
