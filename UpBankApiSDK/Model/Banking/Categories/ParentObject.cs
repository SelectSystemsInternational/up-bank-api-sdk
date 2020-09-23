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
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace UpBankApi.Model
{
    /// <summary>
    /// ParentObject
    /// </summary>

    [DataContract]
    public partial class ParentObject : IEquatable<ParentObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParentObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ParentObject() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParentObject" /> class.
        /// </summary>
        /// <param name="Data">CurrencyCode (required).</param>
        /// <param name="Links">CurrencyCode (required).</param>
        public ParentObject(DataObject Parent = default, RelationshipLinks Links = default)
        {
            this.Parent = Parent;
            this.Links = Links;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public DataObject Parent { get; set; }
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
            sb.Append("class ParentObject {\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
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
            return this.Equals(obj as ParentObject);
        }

        /// <summary>
        /// Returns true if ParentObject instances are equal
        /// </summary>
        /// <param name="other">Instance of ParentObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParentObject other)
        {

            if (other == null)
                return false;

            return
                (
                    this.Parent == other.Parent ||
                    this.Parent.Equals(other.Parent)
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

                if (this.Parent != null)
                    hash = hash * 59 + this.Parent.GetHashCode();
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
