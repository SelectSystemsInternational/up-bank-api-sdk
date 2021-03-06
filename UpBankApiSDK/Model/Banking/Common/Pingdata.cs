﻿/* 
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
using System.Diagnostics.CodeAnalysis;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace UpBankApi.Model
{
    /// <summary>
    /// Pingdata 
    /// </summary>

    [DataContract]
    public partial class Pingdata : IEquatable<Pingdata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Pingdata(Meta Data = default(Meta))
        {
            // to ensure "Id" is required (not null)
            if (Data == null)
            {
                throw new InvalidDataException("Id is a required property for Pingdata and cannot be null");
            }
            else
            {
                this.Data = Data;
            }
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "meta", EmitDefaultValue = false)]
        public Meta Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Meta {\n");
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
        public bool Equals([AllowNull] Pingdata other)
        {
            if (other == null)
                return false;
            return
            (
                this.Data.Id == other.Data.Id &&
                this.Data.StatusEmoji == other.Data.StatusEmoji
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
