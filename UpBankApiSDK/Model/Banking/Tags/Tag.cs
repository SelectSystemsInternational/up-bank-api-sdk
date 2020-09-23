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
using System.Diagnostics.CodeAnalysis;

using Newtonsoft.Json;

namespace UpBankApi.Model
{
    /// <summary>
    /// Tag 
    /// </summary>

    [DataContract]
    public partial class Tag : IEquatable<Tag>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tag" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Tag() { }

        public Tag(TagResource Data = default(TagResource))
        {
            // to ensure "Data" is required (not null)
            if (Data == null)
            {
                throw new InvalidDataException("Data is a required property for Tag and cannot be null");
            }
            else
            {
                this.Data = Data;
            }
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public TagResource Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Data {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(obj as Tag);
        }

        /// <summary>
        /// Returns true if TagsList instances are equal
        /// </summary>
        /// <param name="other">Instance of TagsList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals([AllowNull] Tag other)
        {
            if (other == null)
                return false;
            return
            (
                this.Data == other.Data
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

                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
