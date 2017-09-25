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
    /// This resonse should be returned by the service when handling:  GET http://api.aspose.com/v1.1/words/Test.doc/search
    /// </summary>
    [DataContract]
    public partial class AsposeWordsCloudDTOSearchSearchResponse :  IEquatable<AsposeWordsCloudDTOSearchSearchResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AsposeWordsCloudDTOSearchSearchResponse" /> class.
        /// </summary>
        /// <param name="SearchingPattern">A regular expression pattern used to find matches..</param>
        /// <param name="SearchResults">Collection of search results..</param>
        public AsposeWordsCloudDTOSearchSearchResponse(string SearchingPattern = default(string), AsposeWordsCloudDTOSearchSearchResultsCollection SearchResults = default(AsposeWordsCloudDTOSearchSearchResultsCollection))
        {
            this.SearchingPattern = SearchingPattern;
            this.SearchResults = SearchResults;
        }
        
        /// <summary>
        /// A regular expression pattern used to find matches.
        /// </summary>
        /// <value>A regular expression pattern used to find matches.</value>
        [DataMember(Name="SearchingPattern", EmitDefaultValue=false)]
        public string SearchingPattern { get; set; }

        /// <summary>
        /// Collection of search results.
        /// </summary>
        /// <value>Collection of search results.</value>
        [DataMember(Name="SearchResults", EmitDefaultValue=false)]
        public AsposeWordsCloudDTOSearchSearchResultsCollection SearchResults { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsposeWordsCloudDTOSearchSearchResponse {\n");
            sb.Append("  SearchingPattern: ").Append(SearchingPattern).Append("\n");
            sb.Append("  SearchResults: ").Append(SearchResults).Append("\n");
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
            return this.Equals(obj as AsposeWordsCloudDTOSearchSearchResponse);
        }

        /// <summary>
        /// Returns true if AsposeWordsCloudDTOSearchSearchResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AsposeWordsCloudDTOSearchSearchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AsposeWordsCloudDTOSearchSearchResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SearchingPattern == other.SearchingPattern ||
                    this.SearchingPattern != null &&
                    this.SearchingPattern.Equals(other.SearchingPattern)
                ) && 
                (
                    this.SearchResults == other.SearchResults ||
                    this.SearchResults != null &&
                    this.SearchResults.Equals(other.SearchResults)
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
                if (this.SearchingPattern != null)
                    hash = hash * 59 + this.SearchingPattern.GetHashCode();
                if (this.SearchResults != null)
                    hash = hash * 59 + this.SearchResults.GetHashCode();
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
