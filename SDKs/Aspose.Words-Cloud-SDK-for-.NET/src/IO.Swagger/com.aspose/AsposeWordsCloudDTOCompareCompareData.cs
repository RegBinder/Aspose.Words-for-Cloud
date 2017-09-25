/* 
 * Aspose Words for Cloud Web API
 *
 * Version of Aspose.Words: 17.9.0.0 <br/>                                                      Version of Aspose.Words.Cloud: 17.8.0.0 <br/>                                                      Build number: 1
 *
 * OpenAPI spec version: v1.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.com.aspose
{
    /// <summary>
    /// Container class for compare documents
    /// </summary>
    [DataContract]
    public partial class AsposeWordsCloudDTOCompareCompareData :  IEquatable<AsposeWordsCloudDTOCompareCompareData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AsposeWordsCloudDTOCompareCompareData" /> class.
        /// </summary>
        /// <param name="ComparingWithDocument">Path to document to compare at the server..</param>
        /// <param name="Author">Initials of the author to use for revisions..</param>
        /// <param name="DateTime">The date and time to use for revisions..</param>
        public AsposeWordsCloudDTOCompareCompareData(string ComparingWithDocument = default(string), string Author = default(string), DateTime? DateTime = default(DateTime?))
        {
            this.ComparingWithDocument = ComparingWithDocument;
            this.Author = Author;
            this.DateTime = DateTime;
        }
        
        /// <summary>
        /// Path to document to compare at the server.
        /// </summary>
        /// <value>Path to document to compare at the server.</value>
        [DataMember(Name="ComparingWithDocument", EmitDefaultValue=false)]
        public string ComparingWithDocument { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.
        /// </summary>
        /// <value>Initials of the author to use for revisions.</value>
        [DataMember(Name="Author", EmitDefaultValue=false)]
        public string Author { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>
        /// <value>The date and time to use for revisions.</value>
        [DataMember(Name="DateTime", EmitDefaultValue=false)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsposeWordsCloudDTOCompareCompareData {\n");
            sb.Append("  ComparingWithDocument: ").Append(ComparingWithDocument).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
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
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as AsposeWordsCloudDTOCompareCompareData);
        }

        /// <summary>
        /// Returns true if AsposeWordsCloudDTOCompareCompareData instances are equal
        /// </summary>
        /// <param name="other">Instance of AsposeWordsCloudDTOCompareCompareData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AsposeWordsCloudDTOCompareCompareData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ComparingWithDocument == other.ComparingWithDocument ||
                    this.ComparingWithDocument != null &&
                    this.ComparingWithDocument.Equals(other.ComparingWithDocument)
                ) && 
                (
                    this.Author == other.Author ||
                    this.Author != null &&
                    this.Author.Equals(other.Author)
                ) && 
                (
                    this.DateTime == other.DateTime ||
                    this.DateTime != null &&
                    this.DateTime.Equals(other.DateTime)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ComparingWithDocument != null)
                    hash = hash * 59 + this.ComparingWithDocument.GetHashCode();
                if (this.Author != null)
                    hash = hash * 59 + this.Author.GetHashCode();
                if (this.DateTime != null)
                    hash = hash * 59 + this.DateTime.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
