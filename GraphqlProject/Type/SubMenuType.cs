using GraphQL.Types;
using GraphqlProject.Models;

namespace GraphqlProject.Type
{
    public class SubMenuType : ObjectGraphType<SubMenu>
    {
        public SubMenuType()
        {
            Field(s => s.Id);
            Field(s => s.Name);
            Field(s => s.Description);
            Field(s => s.ImageUrl);
            Field(s => s.Price);
            Field(s => s.MenuId);
        }
    }
}
