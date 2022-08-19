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
    /// Refs
    /// </summary>
    [DataContract]
    public partial class Refs :  IEquatable<Refs>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Refs" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Refs() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Refs" /> class.
        /// </summary>
        /// <param name="Jsonapi">Jsonapi.</param>
        /// <param name="Data">Data (required).</param>
        public Refs(JsonApiVersionJsonapi Jsonapi = null, List<RelRef> Data = null)
        {
            // to ensure "Data" is required (not null)
            if (Data == null)
            {
                throw new InvalidDataException("Data is a required property for Refs and cannot be null");
            }
            else
            {
                this.Data = Data;
            }
            this.Jsonapi = Jsonapi;
        }
        
        /// <summary>
        /// Gets or Sets Jsonapi
        /// </summary>
        [DataMember(Name="jsonapi", EmitDefaultValue=false)]
        public JsonApiVersionJsonapi Jsonapi { get; set; }
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<RelRef> Data { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Refs {\n");
            sb.Append("  Jsonapi: ").Append(Jsonapi).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(obj as Refs);
        }

        /// <summary>
        /// Returns true if Refs instances are equal
        /// </summary>
        /// <param name="other">Instance of Refs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Refs other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Jsonapi == other.Jsonapi ||
                    this.Jsonapi != null &&
                    this.Jsonapi.Equals(other.Jsonapi)
                ) && 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(other.Data)
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
                if (this.Jsonapi != null)
                    hash = hash * 59 + this.Jsonapi.GetHashCode();
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                return hash;
            }
        }
    }

}

