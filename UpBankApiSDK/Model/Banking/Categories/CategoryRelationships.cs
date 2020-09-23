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
    /// CategoryRelationships
    /// </summary>

    [DataContract]
    public partial class CategoryRelationships : IEquatable<CategoryRelationships>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryRelationships" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CategoryRelationships() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryRelationships" /> class.
        /// </summary>
        /// <param name="Parent">Parent (required).</param>
        /// <param name="Children">Children (required).</param>
        public CategoryRelationships(ParentObject Parent = default, ChildrenObject Children = default)
        {
            this.Parent = Parent;
            this.Children = Children;
        }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name = "parent", EmitDefaultValue = false)]
        public ParentObject Parent { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name = "children", EmitDefaultValue = false)]
        ChildrenObject Children { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CategoryRelationships {\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
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
            
            return this.Equals(obj as CategoryRelationships);
        }

        /// <summary>
        /// Returns true if Charge instances are equal
        /// </summary>
        /// <param name="other">Instance of Charge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CategoryRelationships other)
        {
            
            if (other == null)
                return false;

            return
                (
                    this.Parent == other.Parent ||
                    this.Parent.Equals(other.Parent)
                ) &&
                (
                    this.Children == other.Children ||
                    this.Children.Equals(other.Children)
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
                
                if (this.Parent != null)
                    hash = hash * 59 + this.Parent.GetHashCode();

                if (this.Children != null)
                    hash = hash * 59 + this.Children.GetHashCode();

                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
