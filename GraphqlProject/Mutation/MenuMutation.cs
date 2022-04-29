using GraphQL;
using GraphQL.Types;
using GraphqlProject.Interfaces;
using GraphqlProject.Models;
using GraphqlProject.Type;

namespace GraphqlProject.Mutation
{
    public class MenuMutation : ObjectGraphType
    {
        public MenuMutation(IMenu menuService)
        {
            Field<MenuType>("createMenu",
                   arguments: new QueryArguments(new QueryArgument<MenuInputType> { Name = "menu" }),
                   resolve: context => { 
                       return menuService.AddMenu(context.GetArgument<Menu>("menu")); 
                   });
        }
    }
}
