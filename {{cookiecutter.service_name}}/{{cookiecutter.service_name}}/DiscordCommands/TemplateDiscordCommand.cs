// -----------------------------------------------------------------------
// <copyright file="TemplateDiscordCommand.cs" company="{{cookiecutter.author}}">
// Copyright (c) {{cookiecutter.author}}. All rights reserved.
// Licensed under the CC BY-ND 4.0 license.
// </copyright>
// -----------------------------------------------------------------------

using System.Threading.Tasks;

using Discord;
using TrickyBot.Services.DiscordCommandService.API.Abstract;
using TrickyBot.Services.DiscordCommandService.API.Features;
using TrickyBot.Services.DiscordCommandService.API.Features.Conditions;

namespace {{cookiecutter.service_name}}.DiscordCommands
{
    internal class TemplateDiscordCommand : ConditionDiscordCommand
    {
        public TemplateDiscordCommand()
        {
            this.Conditions.Add(new DiscordCommandPermissionCondition("template"));
        }

        public override string Name { get; } = "template";

        public override DiscordCommandRunMode RunMode { get; } = DiscordCommandRunMode.Sync;

        protected override Task Execute(IMessage message, string parameter) => Task.CompletedTask;
    }
}