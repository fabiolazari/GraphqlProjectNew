using GraphQL.Types;
using GraphqlProject.Interfaces;
using GraphqlProject.Models;

namespace GraphqlProject.Type
{
    public class MenuType : ObjectGraphType<Menu>
    {
        public MenuType(ISubMenu subMenuService)
        {
            Field(m => m.Id); 
            Field(m => m.Name);
            Field(m => m.ImageUrl);
            Field<ListGraphType<MenuType>>("subMenus", resolve: context => { return subMenuService.GetSubMenus(context.Source.Id); });
        }
    }
}
