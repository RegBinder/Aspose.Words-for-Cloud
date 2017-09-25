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
    /// container class for odt/ott save options
    /// </summary>
    [DataContract]
    public partial class AsposeWordsCloudDTOSavingOdtSaveOptionsData :  IEquatable<AsposeWordsCloudDTOSavingOdtSaveOptionsData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AsposeWordsCloudDTOSavingOdtSaveOptionsData" /> class.
        /// </summary>
        /// <param name="PrettyFormat">Specifies whether or not use pretty formats output.</param>
        /// <param name="IsStrictSchema11">Specifies whether export should correspond to ODT specification 1.1 strictly.</param>
        public AsposeWordsCloudDTOSavingOdtSaveOptionsData(bool? PrettyFormat = default(bool?), bool? IsStrictSchema11 = default(bool?))
        {
            this.PrettyFormat = PrettyFormat;
            this.IsStrictSchema11 = IsStrictSchema11;
        }
        
        /// <summary>
        /// Specifies whether or not use pretty formats output
        /// </summary>
        /// <value>Specifies whether or not use pretty formats output</value>
        [DataMember(Name="PrettyFormat", EmitDefaultValue=false)]
        public bool? PrettyFormat { get; set; }

        /// <summary>
        /// Specifies whether export should correspond to ODT specification 1.1 strictly
        /// </summary>
        /// <value>Specifies whether export should correspond to ODT specification 1.1 strictly</value>
        [DataMember(Name="IsStrictSchema11", EmitDefaultValue=false)]
        public bool? IsStrictSchema11 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsposeWordsCloudDTOSavingOdtSaveOptionsData {\n");
            sb.Append("  PrettyFormat: ").Append(PrettyFormat).Append("\n");
            sb.Append("  IsStrictSchema11: ").Append(IsStrictSchema11).Append("\n");
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
            return this.Equals(obj as AsposeWordsCloudDTOSavingOdtSaveOptionsData);
        }

        /// <summary>
        /// Returns true if AsposeWordsCloudDTOSavingOdtSaveOptionsData instances are equal
        /// </summary>
        /// <param name="other">Instance of AsposeWordsCloudDTOSavingOdtSaveOptionsData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AsposeWordsCloudDTOSavingOdtSaveOptionsData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PrettyFormat == other.PrettyFormat ||
                    this.PrettyFormat != null &&
                    this.PrettyFormat.Equals(other.PrettyFormat)
                ) && 
                (
                    this.IsStrictSchema11 == other.IsStrictSchema11 ||
                    this.IsStrictSchema11 != null &&
                    this.IsStrictSchema11.Equals(other.IsStrictSchema11)
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
                if (this.PrettyFormat != null)
                    hash = hash * 59 + this.PrettyFormat.GetHashCode();
                if (this.IsStrictSchema11 != null)
                    hash = hash * 59 + this.IsStrictSchema11.GetHashCode();
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