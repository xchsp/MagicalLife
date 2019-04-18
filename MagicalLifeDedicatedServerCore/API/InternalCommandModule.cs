﻿using MagicalLifeAPI.Server;
using MagicalLifeDedicatedServer.API.Commands;
using MagicalLifeDedicatedServer.Properties;
using System.Collections.Generic;

namespace MagicalLifeDedicatedServer.API
{
    public class InternalCommandModule : ICommandModule
    {
        public List<ICommand> getCommands()
        {
            return new List<ICommand>()
            {
                new NewGame(),
                new StartGame(),
                new SaveGame()
            };
        }

        public string getCommandUsageName()
        {
            return "ml";
        }

        /// <summary>
        /// The display name of this command module.
        /// </summary>
        /// <returns></returns>
        public string getFullName()
        {
            return DedicatedServer.MagicalLife;
        }
    }
}