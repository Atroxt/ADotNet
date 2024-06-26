﻿// ---------------------------------------------------------------------------
// Copyright (c) Hassan Habib & Shri Humrudha Jagathisun All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------------------

using System;
using Xeptions;

namespace ADotNet.Models.Pipelines.AdoPipelines.Exceptions
{
    public class NullPipelineException : Xeption
    {
        public NullPipelineException(string message)
            : base(message)
        { }
    }
}