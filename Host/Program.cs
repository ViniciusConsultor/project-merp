﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Description;
using System.Text;
using System.ServiceModel;
using BL;
using BL.Service;
using BL.Service.Stammdaten.User;


namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
  

            ServiceHost MERPService = new ServiceHost(typeof(MerpService));
           /* MERPService.AddServiceEndpoint(
                typeof(IMERPService),
                new NetTcpBinding(),
                "MERPService");
   */


            ServiceHost shUserService = new ServiceHost(typeof (UserService));
            


            Console.Write("MerpService wird gestartet...  :D :D :D\n");
            MERPService.Open();
            Console.Write("MerpService wurde gestartet buh buh buh\n");
            Console.Write("UserService wurde gestartet\n");
            shUserService.Open();
            Console.Write("UserService wurde gestartet\n");
            Console.Write("Drücken Sie eine Taste um zu beenden\n");
            Console.Read();
            MERPService.Close();
            shUserService.Close();
                       
        }
    }
}
