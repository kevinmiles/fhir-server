﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using EnsureThat;

namespace Microsoft.Health.Fhir.Core.Messages.Export
{
    public class CreateExportResponse
    {
        public CreateExportResponse(string id, bool jobCreated)
        {
            EnsureArg.IsNotNullOrEmpty(id, nameof(id));

            Id = id;
            JobCreated = jobCreated;
        }

        public string Id { get; }

        public bool JobCreated { get; }
    }
}
