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
    /// Container class for Downsample options
    /// </summary>
    [DataContract]
    public partial class AsposeWordsCloudDTOSavingDownsampleOptionsData :  IEquatable<AsposeWordsCloudDTOSavingDownsampleOptionsData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AsposeWordsCloudDTOSavingDownsampleOptionsData" /> class.
        /// </summary>
        /// <param name="DownsampleImages">Specifies whether images should be downsampled..</param>
        /// <param name="Resolution">Specifies the resolution in pixels per inch which the images should be downsampled to..</param>
        /// <param name="ResolutionThreshold">Specifies the threshold resolution in pixels per inch.  If resolution of an image in the document is less than threshold value,   the downsampling algorithm will not be applied.  A value of 0 means the threshold check is not used and all images that can be reduced in size are downsampled..</param>
        public AsposeWordsCloudDTOSavingDownsampleOptionsData(bool? DownsampleImages = default(bool?), int? Resolution = default(int?), int? ResolutionThreshold = default(int?))
        {
            this.DownsampleImages = DownsampleImages;
            this.Resolution = Resolution;
            this.ResolutionThreshold = ResolutionThreshold;
        }
        
        /// <summary>
        /// Specifies whether images should be downsampled.
        /// </summary>
        /// <value>Specifies whether images should be downsampled.</value>
        [DataMember(Name="DownsampleImages", EmitDefaultValue=false)]
        public bool? DownsampleImages { get; set; }

        /// <summary>
        /// Specifies the resolution in pixels per inch which the images should be downsampled to.
        /// </summary>
        /// <value>Specifies the resolution in pixels per inch which the images should be downsampled to.</value>
        [DataMember(Name="Resolution", EmitDefaultValue=false)]
        public int? Resolution { get; set; }

        /// <summary>
        /// Specifies the threshold resolution in pixels per inch.  If resolution of an image in the document is less than threshold value,   the downsampling algorithm will not be applied.  A value of 0 means the threshold check is not used and all images that can be reduced in size are downsampled.
        /// </summary>
        /// <value>Specifies the threshold resolution in pixels per inch.  If resolution of an image in the document is less than threshold value,   the downsampling algorithm will not be applied.  A value of 0 means the threshold check is not used and all images that can be reduced in size are downsampled.</value>
        [DataMember(Name="ResolutionThreshold", EmitDefaultValue=false)]
        public int? ResolutionThreshold { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsposeWordsCloudDTOSavingDownsampleOptionsData {\n");
            sb.Append("  DownsampleImages: ").Append(DownsampleImages).Append("\n");
            sb.Append("  Resolution: ").Append(Resolution).Append("\n");
            sb.Append("  ResolutionThreshold: ").Append(ResolutionThreshold).Append("\n");
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
            return this.Equals(obj as AsposeWordsCloudDTOSavingDownsampleOptionsData);
        }

        /// <summary>
        /// Returns true if AsposeWordsCloudDTOSavingDownsampleOptionsData instances are equal
        /// </summary>
        /// <param name="other">Instance of AsposeWordsCloudDTOSavingDownsampleOptionsData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AsposeWordsCloudDTOSavingDownsampleOptionsData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DownsampleImages == other.DownsampleImages ||
                    this.DownsampleImages != null &&
                    this.DownsampleImages.Equals(other.DownsampleImages)
                ) && 
                (
                    this.Resolution == other.Resolution ||
                    this.Resolution != null &&
                    this.Resolution.Equals(other.Resolution)
                ) && 
                (
                    this.ResolutionThreshold == other.ResolutionThreshold ||
                    this.ResolutionThreshold != null &&
                    this.ResolutionThreshold.Equals(other.ResolutionThreshold)
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
                if (this.DownsampleImages != null)
                    hash = hash * 59 + this.DownsampleImages.GetHashCode();
                if (this.Resolution != null)
                    hash = hash * 59 + this.Resolution.GetHashCode();
                if (this.ResolutionThreshold != null)
                    hash = hash * 59 + this.ResolutionThreshold.GetHashCode();
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