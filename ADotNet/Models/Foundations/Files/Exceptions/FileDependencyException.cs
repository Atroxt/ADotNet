﻿// ---------------------------------------------------------------
// Copyright (c) Hassan Habib All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using Xeptions;

namespace ADotNet.Models.Foundations.Files.Exceptions
{
    public class FileDependencyException : Xeption
    {
        public FileDependencyException(Xeption innerException)
            : base(message: "File dependency error occurred, contact support.",
                innerException: innerException)
        { }
        
        public FileDependencyException(string message, Xeption innerException)
            : base(message, innerException)
        { }
    }
}