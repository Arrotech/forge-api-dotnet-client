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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Autodesk.Forge.Client;
using Autodesk.Forge;
using Autodesk.Forge.Model;

namespace Autodesk.Forge.Test
{
    /// <summary>
    ///  Class for testing ObjectsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ObjectsApiTests
    {
        private ObjectsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ObjectsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ObjectsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ObjectsApi
            //Assert.IsInstanceOfType(typeof(ObjectsApi), instance, "instance is a ObjectsApi");
        }

        
        /// <summary>
        /// Test CopyTo
        /// </summary>
        [Test]
        public void CopyToTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string bucketKey = null;
            //string objectName = null;
            //string newObjName = null;
            //var response = instance.CopyTo(bucketKey, objectName, newObjName);
            //Assert.IsInstanceOf<ObjectDetails> (response, "response is ObjectDetails");
        }
        
        /// <summary>
        /// Test CreateSignedResource
        /// </summary>
        [Test]
        public void CreateSignedResourceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string bucketKey = null;
            //string objectName = null;
            //PostBucketsSigned postBucketsSigned = null;
            //string access = null;
            //var response = instance.CreateSignedResource(bucketKey, objectName, postBucketsSigned, access);
            //Assert.IsInstanceOf<PostObjectSigned> (response, "response is PostObjectSigned");
        }
        
        /// <summary>
        /// Test DeleteObject
        /// </summary>
        [Test]
        public void DeleteObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string bucketKey = null;
            //string objectName = null;
            //instance.DeleteObject(bucketKey, objectName);
            
        }
        
        /// <summary>
        /// Test DeleteSignedResource
        /// </summary>
        [Test]
        public void DeleteSignedResourceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string region = null;
            //instance.DeleteSignedResource(id, region);
            
        }
        
        /// <summary>
        /// Test GetObject
        /// </summary>
        [Test]
        public void GetObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string bucketKey = null;
            //string objectName = null;
            //string range = null;
            //string ifNoneMatch = null;
            //DateTime? ifModifiedSince = null;
            //string acceptEncoding = null;
            //var response = instance.GetObject(bucketKey, objectName, range, ifNoneMatch, ifModifiedSince, acceptEncoding);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test GetObjectDetails
        /// </summary>
        [Test]
        public void GetObjectDetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string bucketKey = null;
            //string objectName = null;
            //DateTime? ifModifiedSince = null;
            //string with = null;
            //var response = instance.GetObjectDetails(bucketKey, objectName, ifModifiedSince, with);
            //Assert.IsInstanceOf<ObjectFullDetails> (response, "response is ObjectFullDetails");
        }
        
        /// <summary>
        /// Test GetObjects
        /// </summary>
        [Test]
        public void GetObjectsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string bucketKey = null;
            //int? limit = null;
            //string beginsWith = null;
            //string startAt = null;
            //var response = instance.GetObjects(bucketKey, limit, beginsWith, startAt);
            //Assert.IsInstanceOf<BucketObjects> (response, "response is BucketObjects");
        }
        
        /// <summary>
        /// Test GetSignedResource
        /// </summary>
        [Test]
        public void GetSignedResourceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string range = null;
            //string ifNoneMatch = null;
            //DateTime? ifModifiedSince = null;
            //string acceptEncoding = null;
            //string region = null;
            //var response = instance.GetSignedResource(id, range, ifNoneMatch, ifModifiedSince, acceptEncoding, region);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test GetStatusBySessionId
        /// </summary>
        [Test]
        public void GetStatusBySessionIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string bucketKey = null;
            //string objectName = null;
            //string sessionId = null;
            //instance.GetStatusBySessionId(bucketKey, objectName, sessionId);
            
        }
        
        /// <summary>
        /// Test UploadChunk
        /// </summary>
        [Test]
        public void UploadChunkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string bucketKey = null;
            //string objectName = null;
            //int? contentLength = null;
            //string contentRange = null;
            //string sessionId = null;
            //System.IO.Stream body = null;
            //string contentDisposition = null;
            //string ifMatch = null;
            //var response = instance.UploadChunk(bucketKey, objectName, contentLength, contentRange, sessionId, body, contentDisposition, ifMatch);
            //Assert.IsInstanceOf<ObjectDetails> (response, "response is ObjectDetails");
        }
        
        /// <summary>
        /// Test UploadObject
        /// </summary>
        [Test]
        public void UploadObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string bucketKey = null;
            //string objectName = null;
            //int? contentLength = null;
            //System.IO.Stream body = null;
            //string contentDisposition = null;
            //string ifMatch = null;
            //var response = instance.UploadObject(bucketKey, objectName, contentLength, body, contentDisposition, ifMatch);
            //Assert.IsInstanceOf<ObjectDetails> (response, "response is ObjectDetails");
        }
        
        /// <summary>
        /// Test UploadSignedResource
        /// </summary>
        [Test]
        public void UploadSignedResourceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //int? contentLength = null;
            //System.IO.Stream body = null;
            //string contentDisposition = null;
            //string xAdsRegion = null;
            //string ifMatch = null;
            //var response = instance.UploadSignedResource(id, contentLength, body, contentDisposition, xAdsRegion, ifMatch);
            //Assert.IsInstanceOf<ObjectDetails> (response, "response is ObjectDetails");
        }
        
        /// <summary>
        /// Test UploadSignedResourcesChunk
        /// </summary>
        [Test]
        public void UploadSignedResourcesChunkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string contentRange = null;
            //string sessionId = null;
            //System.IO.Stream body = null;
            //string contentDisposition = null;
            //string xAdsRegion = null;
            //var response = instance.UploadSignedResourcesChunk(id, contentRange, sessionId, body, contentDisposition, xAdsRegion);
            //Assert.IsInstanceOf<ObjectDetails> (response, "response is ObjectDetails");
        }
        
    }

}
