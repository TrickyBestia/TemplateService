// -----------------------------------------------------------------------
// <copyright file="TemplateServiceConfig.cs" company="AuthorName">
// Copyright (c) AuthorName. All rights reserved.
// Licensed under the CC BY-ND 4.0 license.
// </copyright>
// -----------------------------------------------------------------------

using TrickyBot.API.Interfaces;

namespace TemplateService
{
    /// <summary>
    /// Конфиг <see cref="TemplateService"/>.
    /// </summary>
    public class TemplateServiceConfig : IConfig
    {
        /// <inheritdoc/>
        public bool IsEnabled { get; set; } = false;
    }
}