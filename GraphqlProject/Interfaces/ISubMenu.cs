using GraphqlProject.Models;
using System.Collections.Generic;

namespace GraphqlProject.Interfaces
{
    public interface ISubMenu
    {
        List<SubMenu> GetSubMenus();
        List<SubMenu> GetSubMenus(int menuId);
        SubMenu AddSubMenu(SubMenu subMenu);
    }
}
