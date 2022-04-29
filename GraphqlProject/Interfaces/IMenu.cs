using GraphqlProject.Models;
using System.Collections.Generic;

namespace GraphqlProject.Interfaces
{
    public interface IMenu
    {
        List<Menu> GetMenus();
        Menu AddMenu(Menu menu);
    }
}
