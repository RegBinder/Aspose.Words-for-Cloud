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
    /// Preferred width.
    /// </summary>
    [DataContract]
    public partial class AsposeWordsCloudDTODocumentElementsTablesPreferredWidthDto :  IEquatable<AsposeWordsCloudDTODocumentElementsTablesPreferredWidthDto>, IValidatableObject
    {
        /// <summary>
        /// Gets the unit of measure used for this preferred width value.
        /// </summary>
        /// <value>Gets the unit of measure used for this preferred width value.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Auto for "Auto"
            /// </summary>
            [EnumMember(Value = "Auto")]
            Auto,
            
            /// <summary>
            /// Enum Percent for "Percent"
            /// </summary>
            [EnumMember(Value = "Percent")]
            Percent,
            
            /// <summary>
            /// Enum Points for "Points"
            /// </summary>
            [EnumMember(Value = "Points")]
            Points
        }

        /// <summary>
        /// Gets the unit of measure used for this preferred width value.
        /// </summary>
        /// <value>Gets the unit of measure used for this preferred width value.</value>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AsposeWordsCloudDTODocumentElementsTablesPreferredWidthDto" /> class.
        /// </summary>
        /// <param name="Type">Gets the unit of measure used for this preferred width value..</param>
        /// <param name="Value">Gets or sets the preferred width value. The unit of measure is specified in the {Aspose.Words.Cloud.DTO.DocumentElements.Tables.PreferredWidthDto.Type} property..</param>
        public AsposeWordsCloudDTODocumentElementsTablesPreferredWidthDto(TypeEnum? Type = default(TypeEnum?), double? Value = default(double?))
        {
            this.Type = Type;
            this.Value = Value;
        }
        

        /// <summary>
        /// Gets or sets the preferred width value. The unit of measure is specified in the {Aspose.Words.Cloud.DTO.DocumentElements.Tables.PreferredWidthDto.Type} property.
        /// </summary>
        /// <value>Gets or sets the preferred width value. The unit of measure is specified in the {Aspose.Words.Cloud.DTO.DocumentElements.Tables.PreferredWidthDto.Type} property.</value>
        [DataMember(Name="Value", EmitDefaultValue=false)]
        public double? Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsposeWordsCloudDTODocumentElementsTablesPreferredWidthDto {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(obj as AsposeWordsCloudDTODocumentElementsTablesPreferredWidthDto);
        }

        /// <summary>
        /// Returns true if AsposeWordsCloudDTODocumentElementsTablesPreferredWidthDto instances are equal
        /// </summary>
        /// <param name="other">Instance of AsposeWordsCloudDTODocumentElementsTablesPreferredWidthDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AsposeWordsCloudDTODocumentElementsTablesPreferredWidthDto other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
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
