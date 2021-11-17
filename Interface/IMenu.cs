using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning1.Interface
{
    interface IMenu
    {
        void MainMenu(List<ICustomer> customers,List<IDog> dogs);
        void AddMenu(List<ICustomer> customers, List<IDog> dogs);
        void KennelServicesMenu(List<ICustomer> customers, List<IDog> dogs);
        void ViewListMenu(List<ICustomer> customers, List<IDog> dogs);

    }
}
