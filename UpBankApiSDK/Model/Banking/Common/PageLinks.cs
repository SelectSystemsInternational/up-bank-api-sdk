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
    /// PageLinks
    /// </summary>

    [DataContract]
    public partial class PageLinks :  IEquatable<PageLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageLinks" /> class.
        /// </summary>
        /// <param name="Prev">Prev.</param>
        /// <param name="Next">Next.</param>
        public PageLinks(string Prev = default, string Next = default)
        {
            this.Prev = Prev;
            this.Next = Next;         
        }
        
        /// <summary>
        /// Gets or Sets Previous Page Link
        /// </summary>
        [DataMember(Name="prev", EmitDefaultValue=false)]
        public string Prev { get; set; }
        /// <summary>
        /// Gets or Sets Previous Page Link
        /// </summary>
        [DataMember(Name = "next", EmitDefaultValue = false)]
        public string Next { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PageLinks {\n");
            sb.Append("  Prev: ").Append(Prev).Append("\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
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
            
            return this.Equals(obj as PageLinks);
        }

        /// <summary>
        /// Returns true if PageLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of PageLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PageLinks other)
        {
            
            if (other == null)
                return false;

            return 
                (
                    this.Prev == other.Prev ||
                    this.Prev != null &&
                    this.Prev.Equals(other.Prev) &&
                (
                    this.Next == other.Next ||
                    this.Next != null &&
                    this.Next.Equals(other.Next)
                )
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
                
                if (this.Prev != null)
                    hash = hash * 59 + this.Prev.GetHashCode();
                if (this.Next != null)
                    hash = hash * 59 + this.Next.GetHashCode(); 
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
