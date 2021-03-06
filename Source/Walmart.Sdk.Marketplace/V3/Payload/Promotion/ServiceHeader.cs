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
namespace Walmart.Sdk.Marketplace.V3.Payload.Promotion
{
    using System;
    using System.Xml.Serialization;
    using Walmart.Sdk.Base.Primitive;
    using System.Collections.Generic;

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.4.0.7")]
    [Serializable]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRootAttribute("ServiceHeader")]
    public class ServiceHeader : BasePayload
    {
            [XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
            [XmlArrayItemAttribute("entry", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false, ElementName="headerAttributes")]
            public List<ServiceHeaderEntry> HeaderAttributes { get; set; }
    
        /// <summary>
        /// ServiceHeader class constructor
        /// </summary>
        public ServiceHeader()
        {
            HeaderAttributes = new List<ServiceHeaderEntry>();
        }
    }
}
