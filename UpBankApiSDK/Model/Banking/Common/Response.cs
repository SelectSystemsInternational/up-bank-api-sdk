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

namespace UpBankApi.Model
{
    /// <summary>
    /// Response
    /// </summary>

    [DataContract]
    public partial class Response : IEquatable<Response>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Response() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response" /> class.
        /// </summary>
        /// <param name="Body">Body (required).</param>
        public Response(int StatusCode = default, string Body = default)
        {
            this.StatusCode = StatusCode;
            this.Body = Body;
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "statusCode", EmitDefaultValue = false)]
        public int StatusCode { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "body", EmitDefaultValue = false)]
        public string Body { get; set; }
 
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Records {\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
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
            return this.Equals(obj as Response);
        }

        /// <summary>
        /// Returns true if Response instances are equal
        /// </summary>
        /// <param name="other">Instance of Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Response other)
        {          
            if (other == null)
                return false;

            return
                (
                    this.StatusCode == other.StatusCode ||
                    this.StatusCode.Equals(other.StatusCode)
                ) &&
                (
                    this.Body == other.Body ||
                    this.Body != null &&
                    this.Body.Equals(other.Body)
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
                
                if (this.Body != null)
                    hash = hash * 59 + this.Body.GetHashCode();

                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
