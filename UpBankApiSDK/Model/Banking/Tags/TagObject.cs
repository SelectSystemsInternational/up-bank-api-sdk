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
    /// TagObject
    /// </summary>

    [DataContract]
    public partial class TagObject : IEquatable<TagObject>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="TagObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TagObject() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagObject" /> class.
        /// </summary>
        /// <param name="Tag">Tag (required).</param>
        public TagObject(List<DataObject> Tag = default(List<DataObject>))
        {
            this.Tag = Tag;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public List<DataObject> Tag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TagObject {\n");
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
            return this.Equals(obj as TagObject);
        }

        /// <summary>
        /// Returns true if TagObject instances are equal
        /// </summary>
        /// <param name="other">Instance of TagObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TagObject other)
        {
            
            if (other == null)
                return false;

            return
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
