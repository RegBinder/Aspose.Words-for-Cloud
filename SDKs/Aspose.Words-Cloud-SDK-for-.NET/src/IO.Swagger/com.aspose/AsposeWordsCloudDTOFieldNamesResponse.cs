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
    /// AsposeWordsCloudDTOFieldNamesResponse
    /// </summary>
    [DataContract]
    public partial class AsposeWordsCloudDTOFieldNamesResponse :  IEquatable<AsposeWordsCloudDTOFieldNamesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AsposeWordsCloudDTOFieldNamesResponse" /> class.
        /// </summary>
        /// <param name="FieldNames">FieldNames.</param>
        public AsposeWordsCloudDTOFieldNamesResponse(AsposeWordsCloudDTOFieldNames FieldNames = default(AsposeWordsCloudDTOFieldNames))
        {
            this.FieldNames = FieldNames;
        }
        
        /// <summary>
        /// Gets or Sets FieldNames
        /// </summary>
        [DataMember(Name="FieldNames", EmitDefaultValue=false)]
        public AsposeWordsCloudDTOFieldNames FieldNames { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsposeWordsCloudDTOFieldNamesResponse {\n");
            sb.Append("  FieldNames: ").Append(FieldNames).Append("\n");
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
            return this.Equals(obj as AsposeWordsCloudDTOFieldNamesResponse);
        }

        /// <summary>
        /// Returns true if AsposeWordsCloudDTOFieldNamesResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AsposeWordsCloudDTOFieldNamesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AsposeWordsCloudDTOFieldNamesResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FieldNames == other.FieldNames ||
                    this.FieldNames != null &&
                    this.FieldNames.Equals(other.FieldNames)
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
                if (this.FieldNames != null)
                    hash = hash * 59 + this.FieldNames.GetHashCode();
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
