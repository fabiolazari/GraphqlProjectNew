using GraphQL;
using GraphQL.Types;
using GraphqlProject.Interfaces;
using GraphqlProject.Type;

namespace GraphqlProject.Query
{
    public class SubMenuQuery : ObjectGraphType
    {
        public SubMenuQuery(ISubMenu subMenuService)
        {
            Field<ListGraphType<MenuType>>("subMenus", resolve: context => { return subMenuService.GetSubMenus(); });

            Field<ListGraphType<MenuType>>("subMenuById",
               arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
               resolve: context => { return subMenuService.GetSubMenus(context.GetArgument<int>("id")); });
        }
    }
}
