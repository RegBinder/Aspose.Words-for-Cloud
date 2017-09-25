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
    /// Table cell element
    /// </summary>
    [DataContract]
    public partial class AsposeWordsCloudDTODocumentElementsTablesTableCellInsertDto :  IEquatable<AsposeWordsCloudDTODocumentElementsTablesTableCellInsertDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AsposeWordsCloudDTODocumentElementsTablesTableCellInsertDto" /> class.
        /// </summary>
        /// <param name="InsertAfter">Table cell will be inserted after cell with specified 0-based index..</param>
        public AsposeWordsCloudDTODocumentElementsTablesTableCellInsertDto(int? InsertAfter = default(int?))
        {
            this.InsertAfter = InsertAfter;
        }
        
        /// <summary>
        /// Table cell will be inserted after cell with specified 0-based index.
        /// </summary>
        /// <value>Table cell will be inserted after cell with specified 0-based index.</value>
        [DataMember(Name="InsertAfter", EmitDefaultValue=false)]
        public int? InsertAfter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsposeWordsCloudDTODocumentElementsTablesTableCellInsertDto {\n");
            sb.Append("  InsertAfter: ").Append(InsertAfter).Append("\n");
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
            return this.Equals(obj as AsposeWordsCloudDTODocumentElementsTablesTableCellInsertDto);
        }

        /// <summary>
        /// Returns true if AsposeWordsCloudDTODocumentElementsTablesTableCellInsertDto instances are equal
        /// </summary>
        /// <param name="other">Instance of AsposeWordsCloudDTODocumentElementsTablesTableCellInsertDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AsposeWordsCloudDTODocumentElementsTablesTableCellInsertDto other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.InsertAfter == other.InsertAfter ||
                    this.InsertAfter != null &&
                    this.InsertAfter.Equals(other.InsertAfter)
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
                if (this.InsertAfter != null)
                    hash = hash * 59 + this.InsertAfter.GetHashCode();
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
