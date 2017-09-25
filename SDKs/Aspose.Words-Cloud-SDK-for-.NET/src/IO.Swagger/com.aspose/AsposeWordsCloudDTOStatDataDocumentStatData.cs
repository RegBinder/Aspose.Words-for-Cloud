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
    /// Container for the document&#39;s statistical data
    /// </summary>
    [DataContract]
    public partial class AsposeWordsCloudDTOStatDataDocumentStatData :  IEquatable<AsposeWordsCloudDTOStatDataDocumentStatData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AsposeWordsCloudDTOStatDataDocumentStatData" /> class.
        /// </summary>
        /// <param name="WordCount">Total count of words in the document.</param>
        /// <param name="ParagraphCount">Total count of paragraphs in the document.</param>
        /// <param name="PageCount">Total count of pages in the document.</param>
        /// <param name="FootnotesStatData">Detailed statistics of footnotes.</param>
        /// <param name="PageStatData">Detailed statistics of all pages.</param>
        public AsposeWordsCloudDTOStatDataDocumentStatData(int? WordCount = default(int?), int? ParagraphCount = default(int?), int? PageCount = default(int?), AsposeWordsCloudDTOStatDataFootnotesStatData FootnotesStatData = default(AsposeWordsCloudDTOStatDataFootnotesStatData), List<AsposeWordsCloudDTOStatDataPageStatData> PageStatData = default(List<AsposeWordsCloudDTOStatDataPageStatData>))
        {
            this.WordCount = WordCount;
            this.ParagraphCount = ParagraphCount;
            this.PageCount = PageCount;
            this.FootnotesStatData = FootnotesStatData;
            this.PageStatData = PageStatData;
        }
        
        /// <summary>
        /// Total count of words in the document
        /// </summary>
        /// <value>Total count of words in the document</value>
        [DataMember(Name="WordCount", EmitDefaultValue=false)]
        public int? WordCount { get; set; }

        /// <summary>
        /// Total count of paragraphs in the document
        /// </summary>
        /// <value>Total count of paragraphs in the document</value>
        [DataMember(Name="ParagraphCount", EmitDefaultValue=false)]
        public int? ParagraphCount { get; set; }

        /// <summary>
        /// Total count of pages in the document
        /// </summary>
        /// <value>Total count of pages in the document</value>
        [DataMember(Name="PageCount", EmitDefaultValue=false)]
        public int? PageCount { get; set; }

        /// <summary>
        /// Detailed statistics of footnotes
        /// </summary>
        /// <value>Detailed statistics of footnotes</value>
        [DataMember(Name="FootnotesStatData", EmitDefaultValue=false)]
        public AsposeWordsCloudDTOStatDataFootnotesStatData FootnotesStatData { get; set; }

        /// <summary>
        /// Detailed statistics of all pages
        /// </summary>
        /// <value>Detailed statistics of all pages</value>
        [DataMember(Name="PageStatData", EmitDefaultValue=false)]
        public List<AsposeWordsCloudDTOStatDataPageStatData> PageStatData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsposeWordsCloudDTOStatDataDocumentStatData {\n");
            sb.Append("  WordCount: ").Append(WordCount).Append("\n");
            sb.Append("  ParagraphCount: ").Append(ParagraphCount).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
            sb.Append("  FootnotesStatData: ").Append(FootnotesStatData).Append("\n");
            sb.Append("  PageStatData: ").Append(PageStatData).Append("\n");
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
            return this.Equals(obj as AsposeWordsCloudDTOStatDataDocumentStatData);
        }

        /// <summary>
        /// Returns true if AsposeWordsCloudDTOStatDataDocumentStatData instances are equal
        /// </summary>
        /// <param name="other">Instance of AsposeWordsCloudDTOStatDataDocumentStatData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AsposeWordsCloudDTOStatDataDocumentStatData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.WordCount == other.WordCount ||
                    this.WordCount != null &&
                    this.WordCount.Equals(other.WordCount)
                ) && 
                (
                    this.ParagraphCount == other.ParagraphCount ||
                    this.ParagraphCount != null &&
                    this.ParagraphCount.Equals(other.ParagraphCount)
                ) && 
                (
                    this.PageCount == other.PageCount ||
                    this.PageCount != null &&
                    this.PageCount.Equals(other.PageCount)
                ) && 
                (
                    this.FootnotesStatData == other.FootnotesStatData ||
                    this.FootnotesStatData != null &&
                    this.FootnotesStatData.Equals(other.FootnotesStatData)
                ) && 
                (
                    this.PageStatData == other.PageStatData ||
                    this.PageStatData != null &&
                    this.PageStatData.SequenceEqual(other.PageStatData)
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
                if (this.WordCount != null)
                    hash = hash * 59 + this.WordCount.GetHashCode();
                if (this.ParagraphCount != null)
                    hash = hash * 59 + this.ParagraphCount.GetHashCode();
                if (this.PageCount != null)
                    hash = hash * 59 + this.PageCount.GetHashCode();
                if (this.FootnotesStatData != null)
                    hash = hash * 59 + this.FootnotesStatData.GetHashCode();
                if (this.PageStatData != null)
                    hash = hash * 59 + this.PageStatData.GetHashCode();
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
