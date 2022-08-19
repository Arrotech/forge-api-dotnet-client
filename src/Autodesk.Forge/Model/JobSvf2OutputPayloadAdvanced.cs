/* 
 * Forge SDK
 *
 * The Forge Platform contains an expanding collection of web service components that can be used with Autodesk cloud-based products or your own technologies. Take advantage of Autodesk’s expertise in design and engineering.
 *

 * Contact: forge.help@autodesk.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Autodesk.Forge.Model
{
    /// <summary>
    /// Advanced options for &#x60;thumbnail&#x60; type.
    /// </summary>
    [DataContract]
    public partial class JobSvf2OutputPayloadAdvanced : IEquatable<JobSvf2OutputPayloadAdvanced>, IJobPayloadItemAdvanced
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobSvf2OutputPayloadAdvanced" /> class.
        /// </summary>
        public JobSvf2OutputPayloadAdvanced(
            ConversionMethodEnum? conversionMethod = null, IfcOptionsEnum? buildingStoreys = null, IfcOptionsEnum? spaces = null,
            IfcOptionsEnum? openingElements = null, bool? generateMasterViews = null, string materialMode = null,
            bool? hiddenObjects = false, bool? basicMaterialProperties = null, bool? autodeskMaterialProperties = false, bool? timelinerProperties = false
        )
        {
            this.ConversionMethod = conversionMethod;
            this.BuildingStoreys = buildingStoreys;
            this.Spaces = spaces;
            this.OpeningElements = openingElements;
            this.GenerateMasterViews = generateMasterViews;
            this.MaterialMode = materialMode;
            this.HiddenObjects = hiddenObjects;
            this.BasicMaterialProperties = basicMaterialProperties;
            this.AutodeskMaterialProperties = autodeskMaterialProperties;
            this.TimelinerProperties = timelinerProperties;
        }

        /// <summary>
        /// An option to be specified when the input file type is IFC.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConversionMethodEnum
        {
            /// <summary>
            /// Enum Legacy for "legacy"
            /// </summary>
            [EnumMember(Value = "legacy")]
            Legacy,
            /// <summary>
            /// Enum Modern for "modern"
            /// </summary>
            [EnumMember(Value = "modern")]
            Modern
        }

        /// <summary>
        /// An option to be specified when the input file type is IFC.
        /// </summary>
        [DataMember(Name = "conversionMethod", EmitDefaultValue = false)]
        public ConversionMethodEnum? ConversionMethod { get; set; }

        /// <summary>
        /// An option to be specified when the input file type is IFC.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IfcOptionsEnum
        {
            /// <summary>
            /// Enum Hide for "hide"
            /// </summary>
            [EnumMember(Value = "hide")]
            Hide,
            /// <summary>
            /// Enum Show for "show"
            /// </summary>
            [EnumMember(Value = "show")]
            Show,
            /// <summary>
            /// Enum Skip for "skip"
            /// </summary>
            [EnumMember(Value = "skip")]
            Skip
        }

        /// <summary>
        /// An option to be specified when the input file type is IFC.
        /// </summary>
        [DataMember(Name = "buildingStoreys", EmitDefaultValue = false)]
        public IfcOptionsEnum? BuildingStoreys { get; set; }

        /// <summary>
        /// An option to be specified when the input file type is IFC.
        /// </summary>
        [DataMember(Name = "spaces", EmitDefaultValue = false)]
        public IfcOptionsEnum? Spaces { get; set; }

        /// <summary>
        /// An option to be specified when the input file type is IFC.
        /// </summary>
        [DataMember(Name = "openingElements", EmitDefaultValue = false)]
        public IfcOptionsEnum? OpeningElements { get; set; }

        /// <summary>
        /// An option to be specified when the input file type is Revit.
        /// </summary>
        [DataMember(Name = "generateMasterViews", EmitDefaultValue = false)]
        public bool? GenerateMasterViews { get; set; }

        /// <summary>
        /// An option to be specified when the input file type is Revit.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MaterialModeEnum
        {
            /// <summary>
            /// Enum Auto for "auto"
            /// </summary>
            [EnumMember(Value = "auto")]
            Auto,
            /// <summary>
            /// Enum Basic for "basic"
            /// </summary>
            [EnumMember(Value = "basic")]
            Basic,
            /// <summary>
            /// Enum Autodesk for "auto     [EnumMember(Value = "autodesk")]
            Autodesk
        }

        /// <summary>
        /// An option to be specified when the input file type is Revit.
        /// </summary>
        [DataMember(Name = "materialMode", EmitDefaultValue = false)]
        public string MaterialMode { get; set; }

        /// <summary>
        /// An option to be specified when the input file type is Navisworks.
        /// </summary>
        [DataMember(Name = "hiddenObjects", EmitDefaultValue = false)]
        public bool? HiddenObjects { get; set; }

        /// <summary>
        /// An option to be specified when the input file type is Navisworks.
        /// </summary>
        [DataMember(Name = "basicMaterialProperties", EmitDefaultValue = false)]
        public bool? BasicMaterialProperties { get; set; }

        /// <summary>
        /// An option to be specified when the input file type is Navisworks.
        /// </summary>
        [DataMember(Name = "autodeskMaterialProperties", EmitDefaultValue = false)]
        public bool? AutodeskMaterialProperties { get; set; }

        /// <summary>
        /// An option to be specified when the input file type is Navisworks.
        /// </summary>
        [DataMember(Name = "timelinerProperties", EmitDefaultValue = false)]
        public bool? TimelinerProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobSvf2OutputPayloadAdvanced {\n");
            sb.Append("  ConversionMethod: ").Append(ConversionMethod).Append("\n");
            sb.Append("  BuildingStoreys: ").Append(BuildingStoreys).Append("\n");
            sb.Append("  Spaces: ").Append(Spaces).Append("\n");
            sb.Append("  OpeningElements: ").Append(OpeningElements).Append("\n");
            sb.Append("  GenerateMasterViews: ").Append(GenerateMasterViews).Append("\n");
            sb.Append("  MaterialMode: ").Append(MaterialMode).Append("\n");
            sb.Append("  HiddenObjects: ").Append(HiddenObjects).Append("\n");
            sb.Append("  BasicMaterialProperties: ").Append(BasicMaterialProperties).Append("\n");
            sb.Append("  AutodeskMaterialProperties: ").Append(AutodeskMaterialProperties).Append("\n");
            sb.Append("  TimelinerProperties: ").Append(TimelinerProperties).Append("\n");
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
            return this.Equals(obj as JobSvf2OutputPayloadAdvanced);
        }

        /// <summary>
        /// Returns true if JobThumbnailOutputPayloadAdvanced instances are equal
        /// </summary>
        /// <param name="other">Instance of JobThumbnailOutputPayloadAdvanced to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobSvf2OutputPayloadAdvanced other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.ConversionMethod == other.ConversionMethod ||
                    this.ConversionMethod != null &&
                    this.ConversionMethod.Equals(other.ConversionMethod)
                ) &&
                (
                    this.BuildingStoreys == other.BuildingStoreys ||
                    this.BuildingStoreys != null &&
                    this.BuildingStoreys.Equals(other.BuildingStoreys)
                ) &&
                (
                    this.Spaces == other.Spaces ||
                    this.Spaces != null &&
                    this.Spaces.Equals(other.Spaces)
                ) &&
                (
                    this.OpeningElements == other.OpeningElements ||
                    this.OpeningElements != null &&
                    this.OpeningElements.Equals(other.OpeningElements)
                ) &&
                (
                    this.GenerateMasterViews == other.GenerateMasterViews ||
                    this.GenerateMasterViews != null &&
                    this.GenerateMasterViews.Equals(other.GenerateMasterViews)
                ) &&
                (
                    this.MaterialMode == other.MaterialMode ||
                    this.MaterialMode != null &&
                    this.MaterialMode.Equals(other.MaterialMode)
                ) &&
                (
                    this.HiddenObjects == other.HiddenObjects ||
                    this.HiddenObjects != null &&
                    this.HiddenObjects.Equals(other.HiddenObjects)
                ) &&
                (
                    this.BasicMaterialProperties == other.BasicMaterialProperties ||
                    this.BasicMaterialProperties != null &&
                    this.BasicMaterialProperties.Equals(other.BasicMaterialProperties)
                ) &&
                (
                    this.AutodeskMaterialProperties == other.AutodeskMaterialProperties ||
                    this.AutodeskMaterialProperties != null &&
                    this.AutodeskMaterialProperties.Equals(other.AutodeskMaterialProperties)
                ) &&
                (
                    this.TimelinerProperties == other.TimelinerProperties ||
                    this.TimelinerProperties != null &&
                    this.TimelinerProperties.Equals(other.TimelinerProperties)
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
                if (this.ConversionMethod != null)
                    hash = hash * 59 + this.ConversionMethod.GetHashCode();
                if (this.BuildingStoreys != null)
                    hash = hash * 59 + this.BuildingStoreys.GetHashCode();
                if (this.Spaces != null)
                    hash = hash * 59 + this.Spaces.GetHashCode();
                if (this.OpeningElements != null)
                    hash = hash * 59 + this.OpeningElements.GetHashCode();
                if (this.GenerateMasterViews != null)
                    hash = hash * 59 + this.GenerateMasterViews.GetHashCode();
                if (this.MaterialMode != null)
                    hash = hash * 59 + this.MaterialMode.GetHashCode();
                if (this.HiddenObjects != null)
                    hash = hash * 59 + this.HiddenObjects.GetHashCode();
                if (this.BasicMaterialProperties != null)
                    hash = hash * 59 + this.BasicMaterialProperties.GetHashCode();
                if (this.AutodeskMaterialProperties != null)
                    hash = hash * 59 + this.AutodeskMaterialProperties.GetHashCode();
                if (this.TimelinerProperties != null)
                    hash = hash * 59 + this.TimelinerProperties.GetHashCode();
                return hash;
            }
        }
    }

}
