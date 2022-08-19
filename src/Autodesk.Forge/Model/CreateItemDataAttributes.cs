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
    /// CreateItemDataAttributes
    /// </summary>
    [DataContract]
    public partial class CreateItemDataAttributes :  IEquatable<CreateItemDataAttributes>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateItemDataAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateItemDataAttributes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateItemDataAttributes" /> class.
        /// </summary>
        /// <param name="DisplayName">DisplayName (required).</param>
        /// <param name="Extension">Extension (required).</param>
        public CreateItemDataAttributes(string DisplayName = null, BaseAttributesExtensionObject Extension = null)
        {
            // to ensure "DisplayName" is required (not null)
            if (DisplayName == null)
            {
                throw new InvalidDataException("DisplayName is a required property for CreateItemDataAttributes and cannot be null");
            }
            else
            {
                this.DisplayName = DisplayName;
            }
            // to ensure "Extension" is required (not null)
            if (Extension == null)
            {
                throw new InvalidDataException("Extension is a required property for CreateItemDataAttributes and cannot be null");
            }
            else
            {
                this.Extension = Extension;
            }
        }
        
        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or Sets Extension
        /// </summary>
        [DataMember(Name="extension", EmitDefaultValue=false)]
        public BaseAttributesExtensionObject Extension { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateItemDataAttributes {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
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
            return this.Equals(obj as CreateItemDataAttributes);
        }

        /// <summary>
        /// Returns true if CreateItemDataAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateItemDataAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateItemDataAttributes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    this.Extension == other.Extension ||
                    this.Extension != null &&
                    this.Extension.Equals(other.Extension)
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
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.Extension != null)
                    hash = hash * 59 + this.Extension.GetHashCode();
                return hash;
            }
        }
    }

}

