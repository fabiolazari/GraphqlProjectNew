using GraphQL.Types;

namespace GraphqlProject.Type
{
    public class SubMenuInputType : InputObjectGraphType
    {
        public SubMenuInputType()
        {
            Field<IntGraphType>("Id");
            Field<StringGraphType>("Name");
            Field<StringGraphType>("Description");
            Field<StringGraphType>("ImageUrl");
            Field<FloatGraphType>("Price");
            Field<IntGraphType>("MenuId");
        }
    }
}
