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
    /// FromField
    /// </summary>
    [DataContract]
    public partial class AsposeWordsCloudDTODocumentElementsFormFieldsFormField :  IEquatable<AsposeWordsCloudDTODocumentElementsFormFieldsFormField>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AsposeWordsCloudDTODocumentElementsFormFieldsFormField" /> class.
        /// </summary>
        /// <param name="NodeId">Node id.</param>
        /// <param name="Name">Gets or sets the form field name..</param>
        /// <param name="Enabled">True if a form field is enabled..</param>
        /// <param name="StatusText">Returns or sets the text that&#39;s displayed in the status bar when a form field has the focus..</param>
        /// <param name="OwnStatus">Specifies the source of the text that&#39;s displayed in the status bar when a form field has the focus..</param>
        /// <param name="HelpText">Returns or sets the text that&#39;s displayed in a message box when the form field has the focus and the user presses F1..</param>
        /// <param name="OwnHelp">Specifies the source of the text that&#39;s displayed in a message box when a form field has the focus and the user presses F1..</param>
        /// <param name="CalculateOnExit">True if references to the specified form field are automatically updated whenever the field is exited..</param>
        /// <param name="EntryMacro">Returns or sets an entry macro name for the form field..</param>
        /// <param name="ExitMacro">Returns or sets an exit macro name for the form field..</param>
        /// <param name="Link">Link to the document..</param>
        public AsposeWordsCloudDTODocumentElementsFormFieldsFormField(string NodeId = default(string), string Name = default(string), bool? Enabled = default(bool?), string StatusText = default(string), bool? OwnStatus = default(bool?), string HelpText = default(string), bool? OwnHelp = default(bool?), bool? CalculateOnExit = default(bool?), string EntryMacro = default(string), string ExitMacro = default(string), AsposeWordsCloudDTOCommonWordsApiLink Link = default(AsposeWordsCloudDTOCommonWordsApiLink))
        {
            this.NodeId = NodeId;
            this.Name = Name;
            this.Enabled = Enabled;
            this.StatusText = StatusText;
            this.OwnStatus = OwnStatus;
            this.HelpText = HelpText;
            this.OwnHelp = OwnHelp;
            this.CalculateOnExit = CalculateOnExit;
            this.EntryMacro = EntryMacro;
            this.ExitMacro = ExitMacro;
            this.Link = Link;
        }
        
        /// <summary>
        /// Node id
        /// </summary>
        /// <value>Node id</value>
        [DataMember(Name="NodeId", EmitDefaultValue=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// Gets or sets the form field name.
        /// </summary>
        /// <value>Gets or sets the form field name.</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// True if a form field is enabled.
        /// </summary>
        /// <value>True if a form field is enabled.</value>
        [DataMember(Name="Enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Returns or sets the text that&#39;s displayed in the status bar when a form field has the focus.
        /// </summary>
        /// <value>Returns or sets the text that&#39;s displayed in the status bar when a form field has the focus.</value>
        [DataMember(Name="StatusText", EmitDefaultValue=false)]
        public string StatusText { get; set; }

        /// <summary>
        /// Specifies the source of the text that&#39;s displayed in the status bar when a form field has the focus.
        /// </summary>
        /// <value>Specifies the source of the text that&#39;s displayed in the status bar when a form field has the focus.</value>
        [DataMember(Name="OwnStatus", EmitDefaultValue=false)]
        public bool? OwnStatus { get; set; }

        /// <summary>
        /// Returns or sets the text that&#39;s displayed in a message box when the form field has the focus and the user presses F1.
        /// </summary>
        /// <value>Returns or sets the text that&#39;s displayed in a message box when the form field has the focus and the user presses F1.</value>
        [DataMember(Name="HelpText", EmitDefaultValue=false)]
        public string HelpText { get; set; }

        /// <summary>
        /// Specifies the source of the text that&#39;s displayed in a message box when a form field has the focus and the user presses F1.
        /// </summary>
        /// <value>Specifies the source of the text that&#39;s displayed in a message box when a form field has the focus and the user presses F1.</value>
        [DataMember(Name="OwnHelp", EmitDefaultValue=false)]
        public bool? OwnHelp { get; set; }

        /// <summary>
        /// True if references to the specified form field are automatically updated whenever the field is exited.
        /// </summary>
        /// <value>True if references to the specified form field are automatically updated whenever the field is exited.</value>
        [DataMember(Name="CalculateOnExit", EmitDefaultValue=false)]
        public bool? CalculateOnExit { get; set; }

        /// <summary>
        /// Returns or sets an entry macro name for the form field.
        /// </summary>
        /// <value>Returns or sets an entry macro name for the form field.</value>
        [DataMember(Name="EntryMacro", EmitDefaultValue=false)]
        public string EntryMacro { get; set; }

        /// <summary>
        /// Returns or sets an exit macro name for the form field.
        /// </summary>
        /// <value>Returns or sets an exit macro name for the form field.</value>
        [DataMember(Name="ExitMacro", EmitDefaultValue=false)]
        public string ExitMacro { get; set; }

        /// <summary>
        /// Link to the document.
        /// </summary>
        /// <value>Link to the document.</value>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public AsposeWordsCloudDTOCommonWordsApiLink Link { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsposeWordsCloudDTODocumentElementsFormFieldsFormField {\n");
            sb.Append("  NodeId: ").Append(NodeId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  StatusText: ").Append(StatusText).Append("\n");
            sb.Append("  OwnStatus: ").Append(OwnStatus).Append("\n");
            sb.Append("  HelpText: ").Append(HelpText).Append("\n");
            sb.Append("  OwnHelp: ").Append(OwnHelp).Append("\n");
            sb.Append("  CalculateOnExit: ").Append(CalculateOnExit).Append("\n");
            sb.Append("  EntryMacro: ").Append(EntryMacro).Append("\n");
            sb.Append("  ExitMacro: ").Append(ExitMacro).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
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
            return this.Equals(obj as AsposeWordsCloudDTODocumentElementsFormFieldsFormField);
        }

        /// <summary>
        /// Returns true if AsposeWordsCloudDTODocumentElementsFormFieldsFormField instances are equal
        /// </summary>
        /// <param name="other">Instance of AsposeWordsCloudDTODocumentElementsFormFieldsFormField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AsposeWordsCloudDTODocumentElementsFormFieldsFormField other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NodeId == other.NodeId ||
                    this.NodeId != null &&
                    this.NodeId.Equals(other.NodeId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) && 
                (
                    this.StatusText == other.StatusText ||
                    this.StatusText != null &&
                    this.StatusText.Equals(other.StatusText)
                ) && 
                (
                    this.OwnStatus == other.OwnStatus ||
                    this.OwnStatus != null &&
                    this.OwnStatus.Equals(other.OwnStatus)
                ) && 
                (
                    this.HelpText == other.HelpText ||
                    this.HelpText != null &&
                    this.HelpText.Equals(other.HelpText)
                ) && 
                (
                    this.OwnHelp == other.OwnHelp ||
                    this.OwnHelp != null &&
                    this.OwnHelp.Equals(other.OwnHelp)
                ) && 
                (
                    this.CalculateOnExit == other.CalculateOnExit ||
                    this.CalculateOnExit != null &&
                    this.CalculateOnExit.Equals(other.CalculateOnExit)
                ) && 
                (
                    this.EntryMacro == other.EntryMacro ||
                    this.EntryMacro != null &&
                    this.EntryMacro.Equals(other.EntryMacro)
                ) && 
                (
                    this.ExitMacro == other.ExitMacro ||
                    this.ExitMacro != null &&
                    this.ExitMacro.Equals(other.ExitMacro)
                ) && 
                (
                    this.Link == other.Link ||
                    this.Link != null &&
                    this.Link.Equals(other.Link)
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
                if (this.NodeId != null)
                    hash = hash * 59 + this.NodeId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                if (this.StatusText != null)
                    hash = hash * 59 + this.StatusText.GetHashCode();
                if (this.OwnStatus != null)
                    hash = hash * 59 + this.OwnStatus.GetHashCode();
                if (this.HelpText != null)
                    hash = hash * 59 + this.HelpText.GetHashCode();
                if (this.OwnHelp != null)
                    hash = hash * 59 + this.OwnHelp.GetHashCode();
                if (this.CalculateOnExit != null)
                    hash = hash * 59 + this.CalculateOnExit.GetHashCode();
                if (this.EntryMacro != null)
                    hash = hash * 59 + this.EntryMacro.GetHashCode();
                if (this.ExitMacro != null)
                    hash = hash * 59 + this.ExitMacro.GetHashCode();
                if (this.Link != null)
                    hash = hash * 59 + this.Link.GetHashCode();
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