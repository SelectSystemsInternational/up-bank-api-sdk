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
    /// ParentCategoryObject
    /// </summary>

    [DataContract]
    public partial class ParentCategoryObject : IEquatable<ParentCategoryObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParentCategoryObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ParentCategoryObject() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParentCategoryObject" /> class.
        /// </summary>
        /// <param name="ParentCategory">ParentCategory (required).</param>
        public ParentCategoryObject(DataObject ParentCategory = default)
        {
            // to ensure "Data" is required (not null)
            if (ParentCategory == null)
            {
                throw new InvalidDataException("ParentCategory is a required property for ParentCategoryObject and cannot be null");
            }
            else
            {
                this.ParentCategory = ParentCategory;
            }
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public DataObject ParentCategory { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParentCategoryObject {\n");
            sb.Append("  ParentCategory: ").Append(ParentCategory).Append("\n");
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
            
            return this.Equals(obj as ParentCategoryObject);
        }

        /// <summary>
        /// Returns true if ParentCategoryObject instances are equal
        /// </summary>
        /// <param name="other">Instance of Charge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParentCategoryObject other)
        {
            
            if (other == null)
                return false;

            return
                (
                    this.ParentCategory == other.ParentCategory ||
                    this.ParentCategory.Equals(other.ParentCategory)
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
                
                if (this.ParentCategory != null)
                    hash = hash * 59 + this.ParentCategory.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
