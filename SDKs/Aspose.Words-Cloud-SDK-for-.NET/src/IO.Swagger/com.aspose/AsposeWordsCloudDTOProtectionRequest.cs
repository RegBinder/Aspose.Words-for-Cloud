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
    /// Request on changing of protection
    /// </summary>
    [DataContract]
    public partial class AsposeWordsCloudDTOProtectionRequest :  IEquatable<AsposeWordsCloudDTOProtectionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AsposeWordsCloudDTOProtectionRequest" /> class.
        /// </summary>
        /// <param name="Password">Current password.</param>
        /// <param name="NewPassword">New password.</param>
        /// <param name="ProtectionType">New type of protection.</param>
        public AsposeWordsCloudDTOProtectionRequest(string Password = default(string), string NewPassword = default(string), string ProtectionType = default(string))
        {
            this.Password = Password;
            this.NewPassword = NewPassword;
            this.ProtectionType = ProtectionType;
        }
        
        /// <summary>
        /// Current password
        /// </summary>
        /// <value>Current password</value>
        [DataMember(Name="Password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// New password
        /// </summary>
        /// <value>New password</value>
        [DataMember(Name="NewPassword", EmitDefaultValue=false)]
        public string NewPassword { get; set; }

        /// <summary>
        /// New type of protection
        /// </summary>
        /// <value>New type of protection</value>
        [DataMember(Name="ProtectionType", EmitDefaultValue=false)]
        public string ProtectionType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsposeWordsCloudDTOProtectionRequest {\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  NewPassword: ").Append(NewPassword).Append("\n");
            sb.Append("  ProtectionType: ").Append(ProtectionType).Append("\n");
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
            return this.Equals(obj as AsposeWordsCloudDTOProtectionRequest);
        }

        /// <summary>
        /// Returns true if AsposeWordsCloudDTOProtectionRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of AsposeWordsCloudDTOProtectionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AsposeWordsCloudDTOProtectionRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.NewPassword == other.NewPassword ||
                    this.NewPassword != null &&
                    this.NewPassword.Equals(other.NewPassword)
                ) && 
                (
                    this.ProtectionType == other.ProtectionType ||
                    this.ProtectionType != null &&
                    this.ProtectionType.Equals(other.ProtectionType)
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
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                if (this.NewPassword != null)
                    hash = hash * 59 + this.NewPassword.GetHashCode();
                if (this.ProtectionType != null)
                    hash = hash * 59 + this.ProtectionType.GetHashCode();
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