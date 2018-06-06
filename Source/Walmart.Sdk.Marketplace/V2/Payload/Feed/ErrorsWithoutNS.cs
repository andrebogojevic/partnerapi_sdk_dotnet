/*
Copyright (c) 2018-present, Walmart Inc.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

//  ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.4.0.7
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace Walmart.Sdk.Marketplace.V2.Payload.Feed
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;
    using Walmart.Sdk.Base.Primitive;

    // this class exists as a temporary solution for the issue with API
    // right now it can return error payload with or without ns2 (http://walmart.com) namespace
    [Serializable, XmlRoot(ElementName = "error")]
    public class ErrorWithoutNS : BasePayload
    {
        [XmlElement("code")]
        public string Code { get; set; }
        [XmlElement("field")]
        public string Field { get; set; }
        [XmlElement("description")]
        public string Description { get; set; }
        [XmlElement("info")]
        public string Info { get; set; }
        [XmlElement("severity")]
        public ErrorSeverity Severity { get; set; }
        [XmlElement("category")]
        public ErrorCategory Category { get; set; }
        [XmlArrayItemAttribute("cause", IsNullable = false)]
        [XmlArray("causes")]
        public List<Cause> Causes { get; set; }
        [XmlElement("errorIdentifiers")]
        public object ErrorIdentifiers { get; set; }
    }

    [XmlRoot(ElementName = "errors")]
    public class ErrorsWithoutNS : BasePayload, IErrorsPayload
    {
        public string RenderErrors()
        {
            var exceptionMessage = "";
            foreach (var error in Error)
            {
                var errorMessage = string.Format("[{0}] - {1}; {2}", error.Severity, error.Code, error.Description);
                exceptionMessage += Environment.NewLine + errorMessage;
            }

            return exceptionMessage;
        }

        [XmlElement("error", ElementName = "error")]
        public List<ErrorWithoutNS> Error { get; set; }
    }
}
