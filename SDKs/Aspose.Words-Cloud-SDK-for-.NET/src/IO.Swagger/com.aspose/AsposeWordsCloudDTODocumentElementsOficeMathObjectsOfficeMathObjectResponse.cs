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
    /// This resonse should be returned by the service when handling:  GET http://api.aspose.com/v1.1/words/Test.doc/officeMathObjects/0
    /// </summary>
    [DataContract]
    public partial class AsposeWordsCloudDTODocumentElementsOficeMathObjectsOfficeMathObjectResponse :  IEquatable<AsposeWordsCloudDTODocumentElementsOficeMathObjectsOfficeMathObjectResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AsposeWordsCloudDTODocumentElementsOficeMathObjectsOfficeMathObjectResponse" /> class.
        /// </summary>
        /// <param name="OfficeMathObject">OfficeMathObject information.</param>
        public AsposeWordsCloudDTODocumentElementsOficeMathObjectsOfficeMathObjectResponse(AsposeWordsCloudDTODocumentElementsOficeMathObjectsOfficeMathObjectDto OfficeMathObject = default(AsposeWordsCloudDTODocumentElementsOficeMathObjectsOfficeMathObjectDto))
        {
            this.OfficeMathObject = OfficeMathObject;
        }
        
        /// <summary>
        /// OfficeMathObject information
        /// </summary>
        /// <value>OfficeMathObject information</value>
        [DataMember(Name="OfficeMathObject", EmitDefaultValue=false)]
        public AsposeWordsCloudDTODocumentElementsOficeMathObjectsOfficeMathObjectDto OfficeMathObject { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsposeWordsCloudDTODocumentElementsOficeMathObjectsOfficeMathObjectResponse {\n");
            sb.Append("  OfficeMathObject: ").Append(OfficeMathObject).Append("\n");
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
            return this.Equals(obj as AsposeWordsCloudDTODocumentElementsOficeMathObjectsOfficeMathObjectResponse);
        }

        /// <summary>
        /// Returns true if AsposeWordsCloudDTODocumentElementsOficeMathObjectsOfficeMathObjectResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AsposeWordsCloudDTODocumentElementsOficeMathObjectsOfficeMathObjectResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AsposeWordsCloudDTODocumentElementsOficeMathObjectsOfficeMathObjectResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OfficeMathObject == other.OfficeMathObject ||
                    this.OfficeMathObject != null &&
                    this.OfficeMathObject.Equals(other.OfficeMathObject)
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
                if (this.OfficeMathObject != null)
                    hash = hash * 59 + this.OfficeMathObject.GetHashCode();
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