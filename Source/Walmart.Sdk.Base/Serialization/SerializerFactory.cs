﻿/**
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

using System;
using System.Collections.Generic;
using System.Text;
using Walmart.Sdk.Base.Primitive;

namespace Walmart.Sdk.Base.Serialization
{
    public class SerializerFactory: ISerializerFactory
    {
        private static Serialization.JsonSerializer jsonSerializer;
        private static Serialization.XmlSerializer xmlSerializer;

        static SerializerFactory()
        {
            jsonSerializer = new Serialization.JsonSerializer();
            xmlSerializer = new Serialization.XmlSerializer();
        }

        public ISerializer GetSerializer(ApiFormat format)
        {
            switch (format)
            {
                case ApiFormat.JSON:
                    return jsonSerializer;
                default:
                case ApiFormat.XML:
                    return xmlSerializer;
            }
        }
    }
}
