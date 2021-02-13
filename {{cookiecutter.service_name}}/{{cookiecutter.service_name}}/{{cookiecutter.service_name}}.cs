// -----------------------------------------------------------------------
// <copyright file="{{cookiecutter.service_name}}.cs" company="{{cookiecutter.author}}">
// Copyright (c) {{cookiecutter.author}}. All rights reserved.
// Licensed under the CC BY-ND 4.0 license.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Threading.Tasks;

using TrickyBot.API.Abstract;
using TrickyBot.API.Features;

namespace {{cookiecutter.service_name}}
{
    public class {{cookiecutter.service_name}} : ServiceBase<{{cookiecutter.service_name}}Config>
    {
        public override ServiceInfo Info { get; } = new ServiceInfo()
        {
            Author = "{{cookiecutter.author}}",
            Name = "{{cookiecutter.service_name}}",
            Version = new Version(1, 0, 0, 0),

            // GithubRepositoryUrl = "https://github.com/{{cookiecutter.author}}/{{cookiecutter.service_name}}",
        };

        protected override Task OnStart() => Task.CompletedTask;

        protected override Task OnStop() => Task.CompletedTask;
    }
}