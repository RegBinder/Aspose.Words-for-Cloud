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
    /// This response should be returned by the service when handling:  GET http://api.aspose.com/v1.1/words/Test.doc/OfficeMathObjects
    /// </summary>
    [DataContract]
    public partial class AsposeWordsCloudDTODocumentElementsOficeMathObjectsOfficeMathObjectsResponse :  IEquatable<AsposeWordsCloudDTODocumentElementsOficeMathObjectsOfficeMathObjectsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AsposeWordsCloudDTODocumentElementsOficeMathObjectsOfficeMathObjectsResponse" /> class.
        /// </summary>
        /// <param name="OfficeMathObjects">Collection of OfficeMath objects..</param>
        public AsposeWordsCloudDTODocumentElementsOficeMathObjectsOfficeMathObjectsResponse(AsposeWordsCloudDTODocumentElementsOficeMathObjectsOfficeMathObjectsCollectionDto OfficeMathObjects = default(AsposeWordsCloudDTODocumentElementsOficeMathObjectsOfficeMathObjectsCollectionDto))
        {
            this.OfficeMathObjects = OfficeMathObjects;
        }
        
        /// <summary>
        /// Collection of OfficeMath objects.
        /// </summary>
        /// <value>Collection of OfficeMath objects.</value>
        [DataMember(Name="OfficeMathObjects", EmitDefaultValue=false)]
        public AsposeWordsCloudDTODocumentElementsOficeMathObjectsOfficeMathObjectsCollectionDto OfficeMathObjects { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsposeWordsCloudDTODocumentElementsOficeMathObjectsOfficeMathObjectsResponse {\n");
            sb.Append("  OfficeMathObjects: ").Append(OfficeMathObjects).Append("\n");
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
            return this.Equals(obj as AsposeWordsCloudDTODocumentElementsOficeMathObjectsOfficeMathObjectsResponse);
        }

        /// <summary>
        /// Returns true if AsposeWordsCloudDTODocumentElementsOficeMathObjectsOfficeMathObjectsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AsposeWordsCloudDTODocumentElementsOficeMathObjectsOfficeMathObjectsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AsposeWordsCloudDTODocumentElementsOficeMathObjectsOfficeMathObjectsResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OfficeMathObjects == other.OfficeMathObjects ||
                    this.OfficeMathObjects != null &&
                    this.OfficeMathObjects.Equals(other.OfficeMathObjects)
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
                if (this.OfficeMathObjects != null)
                    hash = hash * 59 + this.OfficeMathObjects.GetHashCode();
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
