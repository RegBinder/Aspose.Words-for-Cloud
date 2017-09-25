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
    /// container class for details of encryption
    /// </summary>
    [DataContract]
    public partial class AsposeWordsCloudDTOSavingPdfEncryptionDetailsData :  IEquatable<AsposeWordsCloudDTOSavingPdfEncryptionDetailsData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AsposeWordsCloudDTOSavingPdfEncryptionDetailsData" /> class.
        /// </summary>
        /// <param name="EncryptionAlgorithm">Specifies the encryption algorithm to use.</param>
        /// <param name="OwnerPassword">Specifies the owner password for the encrypted PDF document.</param>
        /// <param name="Permissions">Specifies the operations that are allowed to a user on an encrypted PDF document.</param>
        /// <param name="UserPassword">Specifies the user password required for opening the encrypted PDF document.</param>
        public AsposeWordsCloudDTOSavingPdfEncryptionDetailsData(string EncryptionAlgorithm = default(string), string OwnerPassword = default(string), string Permissions = default(string), string UserPassword = default(string))
        {
            this.EncryptionAlgorithm = EncryptionAlgorithm;
            this.OwnerPassword = OwnerPassword;
            this.Permissions = Permissions;
            this.UserPassword = UserPassword;
        }
        
        /// <summary>
        /// Specifies the encryption algorithm to use
        /// </summary>
        /// <value>Specifies the encryption algorithm to use</value>
        [DataMember(Name="EncryptionAlgorithm", EmitDefaultValue=false)]
        public string EncryptionAlgorithm { get; set; }

        /// <summary>
        /// Specifies the owner password for the encrypted PDF document
        /// </summary>
        /// <value>Specifies the owner password for the encrypted PDF document</value>
        [DataMember(Name="OwnerPassword", EmitDefaultValue=false)]
        public string OwnerPassword { get; set; }

        /// <summary>
        /// Specifies the operations that are allowed to a user on an encrypted PDF document
        /// </summary>
        /// <value>Specifies the operations that are allowed to a user on an encrypted PDF document</value>
        [DataMember(Name="Permissions", EmitDefaultValue=false)]
        public string Permissions { get; set; }

        /// <summary>
        /// Specifies the user password required for opening the encrypted PDF document
        /// </summary>
        /// <value>Specifies the user password required for opening the encrypted PDF document</value>
        [DataMember(Name="UserPassword", EmitDefaultValue=false)]
        public string UserPassword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsposeWordsCloudDTOSavingPdfEncryptionDetailsData {\n");
            sb.Append("  EncryptionAlgorithm: ").Append(EncryptionAlgorithm).Append("\n");
            sb.Append("  OwnerPassword: ").Append(OwnerPassword).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  UserPassword: ").Append(UserPassword).Append("\n");
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
            return this.Equals(obj as AsposeWordsCloudDTOSavingPdfEncryptionDetailsData);
        }

        /// <summary>
        /// Returns true if AsposeWordsCloudDTOSavingPdfEncryptionDetailsData instances are equal
        /// </summary>
        /// <param name="other">Instance of AsposeWordsCloudDTOSavingPdfEncryptionDetailsData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AsposeWordsCloudDTOSavingPdfEncryptionDetailsData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EncryptionAlgorithm == other.EncryptionAlgorithm ||
                    this.EncryptionAlgorithm != null &&
                    this.EncryptionAlgorithm.Equals(other.EncryptionAlgorithm)
                ) && 
                (
                    this.OwnerPassword == other.OwnerPassword ||
                    this.OwnerPassword != null &&
                    this.OwnerPassword.Equals(other.OwnerPassword)
                ) && 
                (
                    this.Permissions == other.Permissions ||
                    this.Permissions != null &&
                    this.Permissions.Equals(other.Permissions)
                ) && 
                (
                    this.UserPassword == other.UserPassword ||
                    this.UserPassword != null &&
                    this.UserPassword.Equals(other.UserPassword)
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
                if (this.EncryptionAlgorithm != null)
                    hash = hash * 59 + this.EncryptionAlgorithm.GetHashCode();
                if (this.OwnerPassword != null)
                    hash = hash * 59 + this.OwnerPassword.GetHashCode();
                if (this.Permissions != null)
                    hash = hash * 59 + this.Permissions.GetHashCode();
                if (this.UserPassword != null)
                    hash = hash * 59 + this.UserPassword.GetHashCode();
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
