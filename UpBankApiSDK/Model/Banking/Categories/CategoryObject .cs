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
    /// CategoryObject
    /// </summary>

    [DataContract]
    public partial class CategoryObject : IEquatable<CategoryObject>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CategoryObject() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryObject" /> class.
        /// </summary>
        /// <param name="Category">Category (required).</param>
        public CategoryObject(DataObject Category = default)
        {
            // to ensure "Data" is required (not null)
            if (Category == null)
            {
                throw new InvalidDataException("Category is a required property for CategoryObject and cannot be null");
            }
            else
            {
                this.Category = Category;
            }
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public DataObject Category { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CategoryObject {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
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
            return this.Equals(obj as CategoryObject);
        }

        /// <summary>
        /// Returns true if CategoryObject instances are equal
        /// </summary>
        /// <param name="other">Instance of CategoryObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CategoryObject other)
        {
            
            if (other == null)
                return false;

            return
                (
                    this.Category == other.Category ||
                    this.Category.Equals(other.Category)
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
                
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();

                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
