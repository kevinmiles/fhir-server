﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System.IO;
using System.Reflection;

namespace Microsoft.Health.Fhir.Tests.Common
{
    public static class EmbeddedResourceManager
    {
        public static string GetStringContent(string embeddedResourceSubNamespace, string fileName, string extension)
        {
            string resourceName = $"{typeof(Samples).Namespace}.{embeddedResourceSubNamespace}.{fileName}.{extension}";
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                using (var reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
