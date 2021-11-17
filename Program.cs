using Autofac;
using Autofac.Core;
using System;

namespace Inlämning1
{
    class Program
    {
        static void Main(string[] args)
        {
             IContainer container = AFConfig.Configure();

            using (ILifetimeScope scope = container.BeginLifetimeScope()) 
            {
                IApplication app = scope.Resolve<IApplication>();

                app.Run();
            }
        }


    }
}
