// -----------------------------------------------------------------------
// <copyright file="{{cookiecutter.service_name}}Config.cs" company="{{cookiecutter.author}}">
// Copyright (c) {{cookiecutter.author}}. All rights reserved.
// Licensed under the CC BY-ND 4.0 license.
// </copyright>
// -----------------------------------------------------------------------

using TrickyBot.API.Interfaces;

namespace {{cookiecutter.service_name}}
{
    /// <summary>
    /// Конфиг <see cref="{{cookiecutter.service_name}}"/>.
    /// </summary>
    public class {{cookiecutter.service_name}}Config : IConfig
    {
        /// <inheritdoc/>
        public bool IsEnabled { get; set; } = false;
    }
}