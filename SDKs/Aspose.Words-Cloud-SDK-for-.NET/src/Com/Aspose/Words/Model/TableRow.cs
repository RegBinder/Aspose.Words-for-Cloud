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
  /// Table row element.
  /// </summary>  
  public class TableRow 
  {                       
        /// <summary>
        /// Collection of table's rows.
        /// </summary>
        /// <value>Collection of table's rows.</value>    
        public List<TableCell> TableCellList { get; set; }

        /// <summary>
        /// Provides access to the formatting properties of the row.
        /// </summary>
        /// <value>Provides access to the formatting properties of the row.</value>    
        public TableRowFormat RowFormat { get; set; }

        /// <summary>
        /// Node id
        /// </summary>
        /// <value>Node id</value>    
        public string NodeId { get; set; }

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
          sb.Append("class TableRow {\n");
          sb.Append("  TableCellList: ").Append(TableCellList).Append("\n");
          sb.Append("  RowFormat: ").Append(RowFormat).Append("\n");
          sb.Append("  NodeId: ").Append(NodeId).Append("\n");
          sb.Append("  Link: ").Append(Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
