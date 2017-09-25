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
    /// FormField text input element
    /// </summary>
    [DataContract]
    public partial class AsposeWordsCloudDTODocumentElementsFormFieldsFormFieldTextInput :  IEquatable<AsposeWordsCloudDTODocumentElementsFormFieldsFormFieldTextInput>, IValidatableObject
    {
        /// <summary>
        /// Gets or sets the type of a text form field.
        /// </summary>
        /// <value>Gets or sets the type of a text form field.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TextInputTypeEnum
        {
            
            /// <summary>
            /// Enum Regular for "Regular"
            /// </summary>
            [EnumMember(Value = "Regular")]
            Regular,
            
            /// <summary>
            /// Enum Number for "Number"
            /// </summary>
            [EnumMember(Value = "Number")]
            Number,
            
            /// <summary>
            /// Enum Date for "Date"
            /// </summary>
            [EnumMember(Value = "Date")]
            Date,
            
            /// <summary>
            /// Enum CurrentDate for "CurrentDate"
            /// </summary>
            [EnumMember(Value = "CurrentDate")]
            CurrentDate,
            
            /// <summary>
            /// Enum CurrentTime for "CurrentTime"
            /// </summary>
            [EnumMember(Value = "CurrentTime")]
            CurrentTime,
            
            /// <summary>
            /// Enum Calculated for "Calculated"
            /// </summary>
            [EnumMember(Value = "Calculated")]
            Calculated
        }

        /// <summary>
        /// Gets or sets the type of a text form field.
        /// </summary>
        /// <value>Gets or sets the type of a text form field.</value>
        [DataMember(Name="TextInputType", EmitDefaultValue=false)]
        public TextInputTypeEnum? TextInputType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AsposeWordsCloudDTODocumentElementsFormFieldsFormFieldTextInput" /> class.
        /// </summary>
        /// <param name="TextInputFormat">Returns or sets the text formatting for a text form field..</param>
        /// <param name="TextInputType">Gets or sets the type of a text form field..</param>
        /// <param name="TextInputDefault">Gets or sets the default string or a calculation expression of a text form field..</param>
        /// <param name="MaxLength">Maximum length for the text field. Zero when the length is not limited..</param>
        public AsposeWordsCloudDTODocumentElementsFormFieldsFormFieldTextInput(string TextInputFormat = default(string), TextInputTypeEnum? TextInputType = default(TextInputTypeEnum?), string TextInputDefault = default(string), int? MaxLength = default(int?))
        {
            this.TextInputFormat = TextInputFormat;
            this.TextInputType = TextInputType;
            this.TextInputDefault = TextInputDefault;
            this.MaxLength = MaxLength;
        }
        
        /// <summary>
        /// Returns or sets the text formatting for a text form field.
        /// </summary>
        /// <value>Returns or sets the text formatting for a text form field.</value>
        [DataMember(Name="TextInputFormat", EmitDefaultValue=false)]
        public string TextInputFormat { get; set; }


        /// <summary>
        /// Gets or sets the default string or a calculation expression of a text form field.
        /// </summary>
        /// <value>Gets or sets the default string or a calculation expression of a text form field.</value>
        [DataMember(Name="TextInputDefault", EmitDefaultValue=false)]
        public string TextInputDefault { get; set; }

        /// <summary>
        /// Maximum length for the text field. Zero when the length is not limited.
        /// </summary>
        /// <value>Maximum length for the text field. Zero when the length is not limited.</value>
        [DataMember(Name="MaxLength", EmitDefaultValue=false)]
        public int? MaxLength { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsposeWordsCloudDTODocumentElementsFormFieldsFormFieldTextInput {\n");
            sb.Append("  TextInputFormat: ").Append(TextInputFormat).Append("\n");
            sb.Append("  TextInputType: ").Append(TextInputType).Append("\n");
            sb.Append("  TextInputDefault: ").Append(TextInputDefault).Append("\n");
            sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
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
            return this.Equals(obj as AsposeWordsCloudDTODocumentElementsFormFieldsFormFieldTextInput);
        }

        /// <summary>
        /// Returns true if AsposeWordsCloudDTODocumentElementsFormFieldsFormFieldTextInput instances are equal
        /// </summary>
        /// <param name="other">Instance of AsposeWordsCloudDTODocumentElementsFormFieldsFormFieldTextInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AsposeWordsCloudDTODocumentElementsFormFieldsFormFieldTextInput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TextInputFormat == other.TextInputFormat ||
                    this.TextInputFormat != null &&
                    this.TextInputFormat.Equals(other.TextInputFormat)
                ) && 
                (
                    this.TextInputType == other.TextInputType ||
                    this.TextInputType != null &&
                    this.TextInputType.Equals(other.TextInputType)
                ) && 
                (
                    this.TextInputDefault == other.TextInputDefault ||
                    this.TextInputDefault != null &&
                    this.TextInputDefault.Equals(other.TextInputDefault)
                ) && 
                (
                    this.MaxLength == other.MaxLength ||
                    this.MaxLength != null &&
                    this.MaxLength.Equals(other.MaxLength)
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
                if (this.TextInputFormat != null)
                    hash = hash * 59 + this.TextInputFormat.GetHashCode();
                if (this.TextInputType != null)
                    hash = hash * 59 + this.TextInputType.GetHashCode();
                if (this.TextInputDefault != null)
                    hash = hash * 59 + this.TextInputDefault.GetHashCode();
                if (this.MaxLength != null)
                    hash = hash * 59 + this.MaxLength.GetHashCode();
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