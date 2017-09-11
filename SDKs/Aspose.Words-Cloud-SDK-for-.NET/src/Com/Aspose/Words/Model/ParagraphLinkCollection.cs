using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Com.Aspose.Words.Model 
{
  /// <summary>
  /// Collection of links to paragraphs
  /// </summary>  
  public class ParagraphLinkCollection 
  {                       
        /// <summary>
        /// Collection of paragraph's links
        /// </summary>
        /// <value>Collection of paragraph's links</value>    
        public List<ParagraphLink> ParagraphLinkList { get; set; }

        /// <summary>
        /// Link to the document.
        /// </summary>
        /// <value>Link to the document.</value>    
        public WordsApiLink Link { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ParagraphLinkCollection {\n");
          sb.Append("  ParagraphLinkList: ").Append(ParagraphLinkList).Append("\n");
          sb.Append("  Link: ").Append(Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
