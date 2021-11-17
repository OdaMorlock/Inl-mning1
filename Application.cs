using Inlämning1.Class;
using Inlämning1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning1
{
    class Application : IApplication
    {
        IMenu menu;
        //Would have been API and not List if i had the time
        List<ICustomer> Customers = new List<ICustomer>();
        List<IDog> Dogs = new List<IDog>();
        public Application(IMenu menu)
        {
            this.menu = menu;
        }

       
        // Runs the Main Menu
        public void Run()
        {
            menu.MainMenu(Customers,Dogs);
        }
    }
}
