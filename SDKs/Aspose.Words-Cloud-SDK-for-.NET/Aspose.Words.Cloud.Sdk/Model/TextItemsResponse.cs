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
  /// 
  /// </summary>  
  public class TextItemsResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Gets or sets TextItems
        /// </summary>  
        public TextItems TextItems { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class TextItemsResponse {\n");
          sb.Append("  TextItems: ").Append(this.TextItems).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}