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
    /// Meta
    /// </summary>

    [DataContract]
    public partial class Meta : IEquatable<Meta>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Meta" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="StatusEmoji">StatusEmoji (required).</param>
        [JsonConstructorAttribute]
        public Meta(string Id = default(string), string StatusEmoji = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for Meta and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "StatusEmoji" is required (not null)
            if (StatusEmoji == null)
            {
                throw new InvalidDataException("StatusEmoji is a required property for Meta and cannot be null");
            }
            else
            {
                this.StatusEmoji = StatusEmoji;
            }
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "statusEmoji", EmitDefaultValue = false)]
        public string StatusEmoji { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Meta {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StatusEmoji: ").Append(StatusEmoji).Append("\n");
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
            
            return this.Equals(obj as Meta);
        }

        /// <summary>
        /// Returns true if Meta instances are equal
        /// </summary>
        /// <param name="other">Instance of Meta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Meta other)
        {
            
            if (other == null)
                return false;

            return false;
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
