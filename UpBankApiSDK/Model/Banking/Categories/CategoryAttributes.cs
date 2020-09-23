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
    /// CategoryAttributes
    /// </summary>

    [DataContract]
    public partial class CategoryAttributes : IEquatable<CategoryAttributes>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CategoryAttributes() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes" /> class.
        /// </summary>
        /// <param name="Name">Name (required).</param>
        public CategoryAttributes(string Name = default)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for CategoryAttributes and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Attributes {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as CategoryAttributes);
        }

        /// <summary>
        /// Returns true if Charge instances are equal
        /// </summary>
        /// <param name="other">Instance of CategoryAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CategoryAttributes other)
        {        
            if (other == null)
                return false;

            return
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
