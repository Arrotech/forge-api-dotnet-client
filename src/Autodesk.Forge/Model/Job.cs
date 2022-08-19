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
    /// Job
    /// </summary>
    [DataContract]
    public partial class Job :  IEquatable<Job>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Job" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Job() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Job" /> class.
        /// </summary>
        /// <param name="Result">reporting success status (required).</param>
        /// <param name="Urn">the urn identifier of the source file (required).</param>
        /// <param name="AcceptedJobs">AcceptedJobs.</param>
        public Job(string Result = null, string Urn = null, JobAcceptedJobs AcceptedJobs = null)
        {
            // to ensure "Result" is required (not null)
            if (Result == null)
            {
                throw new InvalidDataException("Result is a required property for Job and cannot be null");
            }
            else
            {
                this.Result = Result;
            }
            // to ensure "Urn" is required (not null)
            if (Urn == null)
            {
                throw new InvalidDataException("Urn is a required property for Job and cannot be null");
            }
            else
            {
                this.Urn = Urn;
            }
            this.AcceptedJobs = AcceptedJobs;
        }
        
        /// <summary>
        /// reporting success status
        /// </summary>
        /// <value>reporting success status</value>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public string Result { get; set; }
        /// <summary>
        /// the urn identifier of the source file
        /// </summary>
        /// <value>the urn identifier of the source file</value>
        [DataMember(Name="urn", EmitDefaultValue=false)]
        public string Urn { get; set; }
        /// <summary>
        /// Gets or Sets AcceptedJobs
        /// </summary>
        [DataMember(Name="acceptedJobs", EmitDefaultValue=false)]
        public JobAcceptedJobs AcceptedJobs { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Job {\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  Urn: ").Append(Urn).Append("\n");
            sb.Append("  AcceptedJobs: ").Append(AcceptedJobs).Append("\n");
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
            return this.Equals(obj as Job);
        }

        /// <summary>
        /// Returns true if Job instances are equal
        /// </summary>
        /// <param name="other">Instance of Job to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Job other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Result == other.Result ||
                    this.Result != null &&
                    this.Result.Equals(other.Result)
                ) && 
                (
                    this.Urn == other.Urn ||
                    this.Urn != null &&
                    this.Urn.Equals(other.Urn)
                ) && 
                (
                    this.AcceptedJobs == other.AcceptedJobs ||
                    this.AcceptedJobs != null &&
                    this.AcceptedJobs.Equals(other.AcceptedJobs)
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
                if (this.Result != null)
                    hash = hash * 59 + this.Result.GetHashCode();
                if (this.Urn != null)
                    hash = hash * 59 + this.Urn.GetHashCode();
                if (this.AcceptedJobs != null)
                    hash = hash * 59 + this.AcceptedJobs.GetHashCode();
                return hash;
            }
        }
    }

}

