using CommandSystem;
using Exiled.API.Features;
using Exiled.Permissions.Extensions;
using System;
using System.Linq;
using System.Text;
namespace FunTestingStuff.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    [CommandHandler(typeof(GameConsoleCommandHandler))]
    public class Jail : ParentCommand
    {
        public string Command { get; } = "gettime";
        public string[] Aliases { get; } = new string[] { "atime" };
        public string Description { get; } = "Get your current AntiSurfaceCamp time.";
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            response = null;
        }
    }
}