namespace Aspose.Words.Cloud.Sdk.Model 
{
  using System;  
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using System.Text;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// Request on changing of protection
  /// </summary>  
  public class ProtectionRequest 
  {                       
        /// <summary>
        /// Current password
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// New password
        /// </summary>  
        public string NewPassword { get; set; }

        /// <summary>
        /// New type of protection
        /// </summary>  
        public string ProtectionType { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ProtectionRequest {\n");
          sb.Append("  Password: ").Append(this.Password).Append("\n");
          sb.Append("  NewPassword: ").Append(this.NewPassword).Append("\n");
          sb.Append("  ProtectionType: ").Append(this.ProtectionType).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}