﻿// ---------------------------------------------------------------
// Copyright (c) Hassan Habib All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using YamlDotNet.Serialization;

namespace ADotNet.Models.Pipelines.GithubPipelines.DotNets.Tasks
{
    public class DotNetBuildTask : GithubTask
    {
        [YamlMember(Order = 1)]
        public string Run = "dotnet build --no-restore";
    }
}
