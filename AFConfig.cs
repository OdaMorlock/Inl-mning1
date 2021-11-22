using Autofac;
using Inlämning1.Class;
using Inlämning1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning1
{
    public static class AFConfig
    {
        public static IContainer Configure()
        
        {

            var builder = new ContainerBuilder();
            // Main Applcation
            builder.RegisterType<Application>().As<IApplication>();

            //Secondary needed for Application
            builder.RegisterType<Menu>().As<IMenu>();

            builder.RegisterType<Customer>().As<ICustomer>();
            builder.RegisterType<Dog>().As<IDog>();
            builder.RegisterType<Animal>().As<IAnimal>();

            builder.RegisterType<CustomerMananger>().As<ICustomerManager>();
            builder.RegisterType<DogManager>().As<IDogManager>();

            builder.RegisterType<KennelServices>().As<IKennelServices>();
    
            builder.RegisterType<ChecksAndControlls>().As<IChecksAndControlls>();

            return builder.Build();


            //builder.RegisterType<>().As<>();
        }
 
        
    }
}
