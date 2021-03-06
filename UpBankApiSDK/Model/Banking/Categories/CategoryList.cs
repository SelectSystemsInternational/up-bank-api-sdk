﻿/* 
 * Merchant API
 *
  * Up Bank API Initial build
 *
 * OpenAPI spec version: 2020-09-20
 * 
 * 
 */

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace UpBankApi.Model
{
    /// <summary>
    /// AccountsList
    /// </summary>
    [DataContract]
    public partial class CategoryList : IEquatable<CategoryList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CategoryList() { }

        public CategoryList(List<CategoryResource> Data = default, PageLinks Links = default)
        {
            // to ensure "Data" is required (not null)
            if (Data == null)
            {
                throw new InvalidDataException("Data is a required property for AccountsList and cannot be null");
            }
            else
            {
                this.Data = Data;
            }
            // to ensure "Data" is required (not null)
            if (Links == null)
            {
                throw new InvalidDataException("Links is a required property for AccountsList and cannot be null");
            }
            else
            {
                this.Links = Links;
            }
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public List<CategoryResource> Data { get; set; }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public PageLinks Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Data {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            
            return this.Equals(obj as CategoryList);
        }

        /// <summary>
        /// Returns true if AccountsList instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountsList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals([AllowNull] CategoryList other)
        {
            if (other == null)
                return false;
            return
                (
                    this.Data == other.Data ||
                    this.Data.Equals(other.Data)
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

                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
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
