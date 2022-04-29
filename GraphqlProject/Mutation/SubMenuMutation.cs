using GraphQL;
using GraphQL.Types;
using GraphqlProject.Interfaces;
using GraphqlProject.Models;
using GraphqlProject.Type;

namespace GraphqlProject.Mutation
{
    public class SubMenuMutation : ObjectGraphType
    {
        public SubMenuMutation(ISubMenu subMenuService)
        {
            Field<SubMenuType>("createSubMenu",
                   arguments: new QueryArguments(new QueryArgument<SubMenuInputType> { Name = "subMenu" }),
                   resolve: context => { 
                       return subMenuService.AddSubMenu(context.GetArgument<SubMenu>("subMenu")); 
                   });
        }
    }
}
