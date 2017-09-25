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
    /// Field
    /// </summary>
    [DataContract]
    public partial class AsposeWordsCloudDTODocumentElementsFieldsFieldDto :  IEquatable<AsposeWordsCloudDTODocumentElementsFieldsFieldDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AsposeWordsCloudDTODocumentElementsFieldsFieldDto" /> class.
        /// </summary>
        /// <param name="Result">Field result.</param>
        /// <param name="LocaleId">Gets or sets LCID of the field..</param>
        /// <param name="FieldCode">Field code.</param>
        /// <param name="NodeId">Node id.</param>
        /// <param name="Link">Link to the document..</param>
        public AsposeWordsCloudDTODocumentElementsFieldsFieldDto(string Result = default(string), string LocaleId = default(string), string FieldCode = default(string), string NodeId = default(string), AsposeWordsCloudDTOCommonWordsApiLink Link = default(AsposeWordsCloudDTOCommonWordsApiLink))
        {
            this.Result = Result;
            this.LocaleId = LocaleId;
            this.FieldCode = FieldCode;
            this.NodeId = NodeId;
            this.Link = Link;
        }
        
        /// <summary>
        /// Field result
        /// </summary>
        /// <value>Field result</value>
        [DataMember(Name="Result", EmitDefaultValue=false)]
        public string Result { get; set; }

        /// <summary>
        /// Gets or sets LCID of the field.
        /// </summary>
        /// <value>Gets or sets LCID of the field.</value>
        [DataMember(Name="LocaleId", EmitDefaultValue=false)]
        public string LocaleId { get; set; }

        /// <summary>
        /// Field code
        /// </summary>
        /// <value>Field code</value>
        [DataMember(Name="FieldCode", EmitDefaultValue=false)]
        public string FieldCode { get; set; }

        /// <summary>
        /// Node id
        /// </summary>
        /// <value>Node id</value>
        [DataMember(Name="NodeId", EmitDefaultValue=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// Link to the document.
        /// </summary>
        /// <value>Link to the document.</value>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public AsposeWordsCloudDTOCommonWordsApiLink Link { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsposeWordsCloudDTODocumentElementsFieldsFieldDto {\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  LocaleId: ").Append(LocaleId).Append("\n");
            sb.Append("  FieldCode: ").Append(FieldCode).Append("\n");
            sb.Append("  NodeId: ").Append(NodeId).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
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
            return this.Equals(obj as AsposeWordsCloudDTODocumentElementsFieldsFieldDto);
        }

        /// <summary>
        /// Returns true if AsposeWordsCloudDTODocumentElementsFieldsFieldDto instances are equal
        /// </summary>
        /// <param name="other">Instance of AsposeWordsCloudDTODocumentElementsFieldsFieldDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AsposeWordsCloudDTODocumentElementsFieldsFieldDto other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Result == other.Result ||
                    this.Result != null &&
                    this.Result.Equals(other.Result)
                ) && 
                (
                    this.LocaleId == other.LocaleId ||
                    this.LocaleId != null &&
                    this.LocaleId.Equals(other.LocaleId)
                ) && 
                (
                    this.FieldCode == other.FieldCode ||
                    this.FieldCode != null &&
                    this.FieldCode.Equals(other.FieldCode)
                ) && 
                (
                    this.NodeId == other.NodeId ||
                    this.NodeId != null &&
                    this.NodeId.Equals(other.NodeId)
                ) && 
                (
                    this.Link == other.Link ||
                    this.Link != null &&
                    this.Link.Equals(other.Link)
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
                if (this.Result != null)
                    hash = hash * 59 + this.Result.GetHashCode();
                if (this.LocaleId != null)
                    hash = hash * 59 + this.LocaleId.GetHashCode();
                if (this.FieldCode != null)
                    hash = hash * 59 + this.FieldCode.GetHashCode();
                if (this.NodeId != null)
                    hash = hash * 59 + this.NodeId.GetHashCode();
                if (this.Link != null)
                    hash = hash * 59 + this.Link.GetHashCode();
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