﻿// ---------------------------------------------------------------
// Copyright (c) Hassan Habib All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using Xeptions;

namespace ADotNet.Models.Foundations.Files.Exceptions
{
    public class FileValidationException : Xeption
    {
        public FileValidationException(Xeption innerException)
            : base(message: "File validation error occurred, fix the errors and try again.",
                innerException: innerException)
        { }
        
        public FileValidationException(string message, Xeption innerException)
            : base(message, innerException)
        { }
    }
}