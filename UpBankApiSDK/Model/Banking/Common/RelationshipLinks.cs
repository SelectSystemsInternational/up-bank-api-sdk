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
    /// RelationshipLinks
    /// </summary>

    [DataContract]
    public partial class RelationshipLinks :  IEquatable<RelationshipLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RelationshipLinks" /> class.
        /// </summary>
        /// <param name="Related">Related.</param>
        public RelationshipLinks(string Related = default)
        {
            this.Related = Related;
        }
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="related", EmitDefaultValue=false)]
        public string Related { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Links {\n");
            sb.Append("  Related: ").Append(Related).Append("\n");
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
            return this.Equals(obj as RelationshipLinks);
        }

        /// <summary>
        /// Returns true if Links instances are equal
        /// </summary>
        /// <param name="other">Instance of Links to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RelationshipLinks other)
        {
            
            if (other == null)
                return false;

            return 
                (
                    this.Related == other.Related ||
                    this.Related != null &&
                    this.Related.Equals(other.Related)
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
                
                if (this.Related != null)
                    hash = hash * 59 + this.Related.GetHashCode();

                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
