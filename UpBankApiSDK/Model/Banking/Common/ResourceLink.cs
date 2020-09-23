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
using System.Text;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

using Newtonsoft.Json;

namespace UpBankApi.Model
{
    /// <summary>
    /// ResourceLinks
    /// </summary>

    [DataContract]
    public partial class ResourceLinks :  IEquatable<ResourceLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceLinks" /> class.
        /// </summary>
        /// <param name="Self">Self.</param>
        public ResourceLinks(string Self = default)
        {
            this.Self = Self;
        }
        
        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public string Self { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Links {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
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
            return this.Equals(obj as ResourceLinks);
        }

        /// <summary>
        /// Returns true if ResourceLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of ResourceLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourceLinks other)
        {
           
            if (other == null)
                return false;

            return 
                (
                    this.Self == other.Self ||
                    this.Self != null &&
                    this.Self.Equals(other.Self)
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
                
                if (this.Self != null)
                    hash = hash * 59 + this.Self.GetHashCode();

                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
