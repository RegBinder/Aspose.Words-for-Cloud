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
  /// Represents Drawing Object DTO.
  /// </summary>  
  public class DrawingObject 
  {                       
        /// <summary>
        /// Specifies where the distance to the image is measured from.
        /// </summary>
        /// <value>Specifies where the distance to the image is measured from.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RelativeHorizontalPositionEnum
        {
            
            /// <summary>
            /// Enum Margin for "Margin"
            /// </summary>            
            Margin,
            
            /// <summary>
            /// Enum Page for "Page"
            /// </summary>            
            Page,
            
            /// <summary>
            /// Enum Column for "Column"
            /// </summary>            
            Column,
            
            /// <summary>
            /// Enum Character for "Character"
            /// </summary>            
            Character,
            
            /// <summary>
            /// Enum LeftMargin for "LeftMargin"
            /// </summary>            
            LeftMargin,
            
            /// <summary>
            /// Enum RightMargin for "RightMargin"
            /// </summary>            
            RightMargin,
            
            /// <summary>
            /// Enum InsideMargin for "InsideMargin"
            /// </summary>            
            InsideMargin,
            
            /// <summary>
            /// Enum OutsideMargin for "OutsideMargin"
            /// </summary>            
            OutsideMargin,
            
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>            
            Default
        }

        /// <summary>
        /// Specifies where the distance to the image measured from.
        /// </summary>
        /// <value>Specifies where the distance to the image measured from.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RelativeVerticalPositionEnum
        {
            
            /// <summary>
            /// Enum Margin for "Margin"
            /// </summary>            
            Margin,
            
            /// <summary>
            /// Enum Page for "Page"
            /// </summary>            
            Page,
            
            /// <summary>
            /// Enum Paragraph for "Paragraph"
            /// </summary>            
            Paragraph,
            
            /// <summary>
            /// Enum Line for "Line"
            /// </summary>            
            Line,
            
            /// <summary>
            /// Enum TopMargin for "TopMargin"
            /// </summary>            
            TopMargin,
            
            /// <summary>
            /// Enum BottomMargin for "BottomMargin"
            /// </summary>            
            BottomMargin,
            
            /// <summary>
            /// Enum InsideMargin for "InsideMargin"
            /// </summary>            
            InsideMargin,
            
            /// <summary>
            /// Enum OutsideMargin for "OutsideMargin"
            /// </summary>            
            OutsideMargin,
            
            /// <summary>
            /// Enum TableDefault for "TableDefault"
            /// </summary>            
            TableDefault,
            
            /// <summary>
            /// Enum TextFrameDefault for "TextFrameDefault"
            /// </summary>            
            TextFrameDefault
        }

        /// <summary>
        /// Specifies how to wrap text around the image.
        /// </summary>
        /// <value>Specifies how to wrap text around the image.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WrapTypeEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum Inline for "Inline"
            /// </summary>            
            Inline,
            
            /// <summary>
            /// Enum TopBottom for "TopBottom"
            /// </summary>            
            TopBottom,
            
            /// <summary>
            /// Enum Square for "Square"
            /// </summary>            
            Square,
            
            /// <summary>
            /// Enum Tight for "Tight"
            /// </summary>            
            Tight,
            
            /// <summary>
            /// Enum Through for "Through"
            /// </summary>            
            Through
        }

        /// <summary>
        /// Specifies where the distance to the image is measured from.
        /// </summary>
        /// <value>Specifies where the distance to the image is measured from.</value>
        public RelativeHorizontalPositionEnum? RelativeHorizontalPosition { get; set; }

        /// <summary>
        /// Specifies where the distance to the image measured from.
        /// </summary>
        /// <value>Specifies where the distance to the image measured from.</value>
        public RelativeVerticalPositionEnum? RelativeVerticalPosition { get; set; }

        /// <summary>
        /// Specifies how to wrap text around the image.
        /// </summary>
        /// <value>Specifies how to wrap text around the image.</value>
        public WrapTypeEnum? WrapType { get; set; }

        /// <summary>
        /// A list of links that originate from this {Aspose.Words.Cloud.DTO.DocumentElements.DrawingObjects.DrawingObjectDto}.
        /// </summary>  
        public List<WordsApiLink> RenderLinks { get; set; }

        /// <summary>
        /// Width of the drawing objects in points.
        /// </summary>  
        public double? Width { get; set; }

        /// <summary>
        /// Height of the drawing object in points.
        /// </summary>  
        public double? Height { get; set; }

        /// <summary>
        /// Link to ole object. Can be null if shape does not have ole data.
        /// </summary>  
        public WordsApiLink OleDataLink { get; set; }

        /// <summary>
        /// Link to image data. Can be null if shape does not have an image.
        /// </summary>  
        public WordsApiLink ImageDataLink { get; set; }

        /// <summary>
        /// Distance in points from the origin to the left side of the image.
        /// </summary>  
        public double? Left { get; set; }

        /// <summary>
        /// Distance in points from the origin to the top side of the image.
        /// </summary>  
        public double? Top { get; set; }

        /// <summary>
        /// Node id
        /// </summary>  
        public string NodeId { get; set; }

        /// <summary>
        /// Link to the document.
        /// </summary>  
        public WordsApiLink Link { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class DrawingObject {\n");
          sb.Append("  RenderLinks: ").Append(this.RenderLinks).Append("\n");
          sb.Append("  Width: ").Append(this.Width).Append("\n");
          sb.Append("  Height: ").Append(this.Height).Append("\n");
          sb.Append("  OleDataLink: ").Append(this.OleDataLink).Append("\n");
          sb.Append("  ImageDataLink: ").Append(this.ImageDataLink).Append("\n");
          sb.Append("  RelativeHorizontalPosition: ").Append(this.RelativeHorizontalPosition).Append("\n");
          sb.Append("  Left: ").Append(this.Left).Append("\n");
          sb.Append("  RelativeVerticalPosition: ").Append(this.RelativeVerticalPosition).Append("\n");
          sb.Append("  Top: ").Append(this.Top).Append("\n");
          sb.Append("  WrapType: ").Append(this.WrapType).Append("\n");
          sb.Append("  NodeId: ").Append(this.NodeId).Append("\n");
          sb.Append("  Link: ").Append(this.Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}