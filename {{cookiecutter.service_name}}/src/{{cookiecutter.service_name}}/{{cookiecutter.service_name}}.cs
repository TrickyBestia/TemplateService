// -----------------------------------------------------------------------
// <copyright file="{{cookiecutter.service_name}}.cs" company="{{cookiecutter.author}}">
// Copyright (c) {{cookiecutter.author}}. All rights reserved.
// Licensed under the CC BY-ND 4.0 license.
// </copyright>
// -----------------------------------------------------------------------

using System.Reflection;
using System.Threading.Tasks;

using TrickyBot.API.Abstract;
using TrickyBot.API.Features;

namespace {{cookiecutter.service_name}}
{
    /// <summary>
    /// Шаблон класса сервиса.
    /// </summary>
    public class {{cookiecutter.service_name}} : ServiceBase<{{cookiecutter.service_name}}Config>
    {
        /// <inheritdoc/>
        public override ServiceInfo Info { get; } = new ServiceInfo
        {
            Name = nameof({{cookiecutter.service_name}}),
            Author = "{{cookiecutter.author}}",
            Version = Assembly.GetExecutingAssembly().GetName().Version,
            GithubRepositoryUrl = "https://github.com/{{cookiecutter.author}}/{{cookiecutter.service_name}}",
        };

        /// <inheritdoc/>
        protected override Task OnStart() => Task.CompletedTask;

        /// <inheritdoc/>
        protected override Task OnStop() => Task.CompletedTask;
    }
}