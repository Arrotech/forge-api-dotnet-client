﻿/* 
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
    /// JobSvfOutputPayload
    /// </summary>
    [DataContract]
    public partial class JobDwgOutputPayload :  IEquatable<JobDwgOutputPayload>
    {
        /// <summary>
        /// The requested output types. Possible values include `svf`, `svf2`, `thumbnail`, `stl`, `step`, `iges`, `obj`, `ifc` or `dwg`. For a list of supported types, call the [GET formats](https://developer.autodesk.com/en/docs/model-derivative/v2/reference/http/formats-GET) endpoint.
        /// </summary>
        /// <value>The requested output types. Possible values include `svf`, `svf2`, `thumbnail`, `stl`, `step`, `iges`, `obj`, `ifc` or `dwg`. For a list of supported types, call the [GET formats](https://developer.autodesk.com/en/docs/model-derivative/v2/reference/http/formats-GET) endpoint.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Svf for "svf"
            /// </summary>
            [EnumMember(Value = "svf")]
            Svf,

            /// <summary>
            /// Enum Svf2 for "svf2"
            /// </summary>
            [EnumMember(Value = "svf2")]
            Svf2,

            /// <summary>
            /// Enum Thumbnail for "thumbnail"
            /// </summary>
            [EnumMember(Value = "thumbnail")]
            Thumbnail,
            
            /// <summary>
            /// Enum Stl for "stl"
            /// </summary>
            [EnumMember(Value = "stl")]
            Stl,
            
            /// <summary>
            /// Enum Step for "step"
            /// </summary>
            [EnumMember(Value = "step")]
            Step,
            
            /// <summary>
            /// Enum Iges for "iges"
            /// </summary>
            [EnumMember(Value = "iges")]
            Iges,
            
            /// <summary>
            /// Enum Obj for "obj"
            /// </summary>
            [EnumMember(Value = "obj")]
            Obj,

            /// <summary>
            /// Enum Ifc for "ifc"
            /// </summary>
            [EnumMember(Value = "ifc")]
            Ifc,

            /// <summary>
            /// Enum Dwg for "dwg"
            /// </summary>
            [EnumMember(Value = "dwg")]
            Dwg
        }

        /// <summary>
        /// The requested output types. Possible values include `svf`, `svf2`, `thumbnail`, `stl`, `step`, `iges`, `obj`, `ifc` or `dwg`. For a list of supported types, call the [GET formats](https://developer.autodesk.com/en/docs/model-derivative/v2/reference/http/formats-GET) endpoint.
        /// </summary>
        /// <value>The requested output types. Possible values include `svf`, `svf2`, `thumbnail`, `stl`, `step`, `iges`, `obj`, `ifc` or `dwg`. For a list of supported types, call the [GET formats](https://developer.autodesk.com/en/docs/model-derivative/v2/reference/http/formats-GET) endpoint.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Gets or Sets Advanced
        /// </summary>
        [DataMember(Name = "advanced", EmitDefaultValue = false)]
        public JobDwgOutputPayloadAdvanced Advanced { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobDwgOutputPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JobDwgOutputPayload() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobDwgOutputPayload" /> class.
        /// </summary>
        /// <param name="Type">The requested output types. Possible values include &#x60;svf&#x60;, &#x60;thumbnai&#x60;, &#x60;stl&#x60;, &#x60;step&#x60;, &#x60;iges&#x60;, or &#x60;obj&#x60;. For a list of supported types, call the [GET formats](https://developer.autodesk.com/en/docs/model-derivative/v2/reference/http/formats-GET) endpoint. (required).</param>
        /// <param name="Views">Views.</param>
        public JobDwgOutputPayload(TypeEnum? Type = null, JobDwgOutputPayloadAdvanced advanced = null)
        {
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for JobSvfOutputPayload and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.Advanced = advanced;
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobSvfOutputPayload {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Advanced: ").Append(Advanced).Append("\n");
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
            return this.Equals(obj as JobDwgOutputPayload);
        }

        /// <summary>
        /// Returns true if JobSvfOutputPayload instances are equal
        /// </summary>
        /// <param name="other">Instance of JobSvfOutputPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobDwgOutputPayload other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Advanced == other.Advanced ||
                    this.Advanced != null &&
                    this.Advanced.Equals(other.Advanced)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Advanced != null)
                    hash = hash * 59 + this.Advanced.GetHashCode();
                return hash;
            }
        }
    }

}

