using GraphQL.Types;

namespace GraphqlProject.Type
{
    public class MenuInputType : InputObjectGraphType
    {
        public MenuInputType()
        {
            Field<IntGraphType>("Id");
            Field<StringGraphType>("Name");
            Field<StringGraphType>("ImageUrl");
        }
    }
}
