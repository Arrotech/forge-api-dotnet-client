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
    /// a link that leads to further details about this particular occurrence of the problem
    /// </summary>
    [DataContract]
    public partial class JsonApiErrorLinks :  IEquatable<JsonApiErrorLinks>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonApiErrorLinks" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JsonApiErrorLinks() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonApiErrorLinks" /> class.
        /// </summary>
        /// <param name="About">About (required).</param>
        public JsonApiErrorLinks(JsonApiLink About = null)
        {
            // to ensure "About" is required (not null)
            if (About == null)
            {
                throw new InvalidDataException("About is a required property for JsonApiErrorLinks and cannot be null");
            }
            else
            {
                this.About = About;
            }
        }
        
        /// <summary>
        /// Gets or Sets About
        /// </summary>
        [DataMember(Name="about", EmitDefaultValue=false)]
        public JsonApiLink About { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonApiErrorLinks {\n");
            sb.Append("  About: ").Append(About).Append("\n");
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
            return this.Equals(obj as JsonApiErrorLinks);
        }

        /// <summary>
        /// Returns true if JsonApiErrorLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of JsonApiErrorLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonApiErrorLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.About == other.About ||
                    this.About != null &&
                    this.About.Equals(other.About)
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
                if (this.About != null)
                    hash = hash * 59 + this.About.GetHashCode();
                return hash;
            }
        }
    }

}

