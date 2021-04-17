// -----------------------------------------------------------------------
// <copyright file="TemplateService.cs" company="AuthorName">
// Copyright (c) AuthorName. All rights reserved.
// Licensed under the CC BY-ND 4.0 license.
// </copyright>
// -----------------------------------------------------------------------

using System.Reflection;
using System.Threading.Tasks;

using TrickyBot.API.Abstract;
using TrickyBot.API.Features;

namespace TemplateService
{
    /// <summary>
    /// Шаблон класса сервиса.
    /// </summary>
    public class TemplateService : ServiceBase<TemplateServiceConfig>
    {
        /// <inheritdoc/>
        public override ServiceInfo Info { get; } = new ServiceInfo
        {
            Name = nameof(TemplateService),
            Author = "AuthorName",
            Version = Assembly.GetExecutingAssembly().GetName().Version,
            GithubRepositoryUrl = "https://github.com/AuthorName/TemplateService",
        };

        /// <inheritdoc/>
        protected override Task OnStart() => Task.CompletedTask;

        /// <inheritdoc/>
        protected override Task OnStop() => Task.CompletedTask;
    }
}