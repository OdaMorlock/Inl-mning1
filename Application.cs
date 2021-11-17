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

        public Application(IMenu menu)
        {
            this.menu = menu;
        }

       
        // Runs the Main Menu
        public void Run()
        {
            menu.MainMenu();
        }
    }
}
