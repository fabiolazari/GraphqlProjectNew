using GraphQL;
using GraphQL.Types;
using GraphqlProject.Interfaces;
using GraphqlProject.Models;
using GraphqlProject.Type;

namespace GraphqlProject.Mutation
{
    public class ReservationMutation : ObjectGraphType
    {
        public ReservationMutation(IReservation reservationService)
        {
            Field<ReservationType>("createReservation",
                   arguments: new QueryArguments(new QueryArgument<ReservationInputType> { Name = "reservation" }),
                   resolve: context => { 
                       return reservationService.AddReservation(context.GetArgument<Reservation>("reservation")); 
                   });
        }
    }
}
