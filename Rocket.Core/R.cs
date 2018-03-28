﻿using Rocket.Core;
using Rocket.IOC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rocket
{
    public static class R
    {
        private static DependencyContainer container;
        public static void Bootstrap()
        {
            container = new DependencyContainer();
            container.RegisterSingletonType<ILog, ConsoleLogger>();
            container.Activate(typeof(Initializer));
        }

        public static IServiceLocator ServiceLocator
        {
            get { return container.ServiceLocator; }
        }
    }
}
