using System;
using DarkRift;
using DarkRift.Server;

namespace ServerRSA
{
    public class UserManager : Plugin
    {
        public override bool ThreadSafe => false;

        public override Version Version => new Version(1, 0, 0);

        public UserManager(PluginLoadData pluginLoadData) : base(pluginLoadData)
        {

        }
    }
}
