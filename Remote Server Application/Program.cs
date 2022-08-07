using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using PTSProjectLibrary;

namespace Remote_Server_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpChannel channel = new HttpChannel(50000);
            ChannelServices.RegisterChannel(channel, false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(PTSProjectLibrary.PTSAdminFacade), "PTSAdminFacade", WellKnownObjectMode.Singleton);
            Console.WriteLine("Press the Enter Key to terminate server");
            Console.ReadLine();
        }
    }
}
