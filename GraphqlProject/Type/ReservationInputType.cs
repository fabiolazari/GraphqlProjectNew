using GraphQL.Types;

namespace GraphqlProject.Type
{
    public class ReservationInputType : InputObjectGraphType
    {
        public ReservationInputType()
        {
            Field<IntGraphType>("Id");
            Field<StringGraphType>("Name");
            Field<StringGraphType>("Phone");
            Field<IntGraphType>("TotalPeople");
            Field<StringGraphType>("Email");
            Field<StringGraphType>("Date");
            Field<StringGraphType>("Time");
        }
    }
}
