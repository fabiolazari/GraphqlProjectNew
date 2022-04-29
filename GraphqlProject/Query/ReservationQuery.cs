using GraphQL.Types;
using GraphqlProject.Interfaces;
using GraphqlProject.Type;

namespace GraphqlProject.Query
{
    public class ReservationQuery : ObjectGraphType
    {
        public ReservationQuery(IReservation reservationService)
        {
            Field<ListGraphType<ReservationType>>("reservations", resolve: context => { return reservationService.GetReservations(); });
        }
    }
}
