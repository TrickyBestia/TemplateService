// -----------------------------------------------------------------------
// <copyright file="TemplateConsoleCommand.cs" company="{{cookiecutter.author}}">
// Copyright (c) {{cookiecutter.author}}. All rights reserved.
// Licensed under the CC BY-ND 4.0 license.
// </copyright>
// -----------------------------------------------------------------------

using System.Threading.Tasks;

using TrickyBot.Services.ConsoleCommandService.API.Features;
using TrickyBot.Services.ConsoleCommandService.API.Interfaces;

namespace {{cookiecutter.service_name}}.ConsoleCommands
{
    internal class TemplateConsoleCommand : IConsoleCommand
    {
        public string Name { get; } = "template";

        public ConsoleCommandRunMode RunMode { get; } = ConsoleCommandRunMode.Sync;

        public Task ExecuteAsync(string parameter) => Task.CompletedTask;
    }
}