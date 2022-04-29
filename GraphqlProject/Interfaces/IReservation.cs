using GraphqlProject.Models;
using System.Collections.Generic;

namespace GraphqlProject.Interfaces
{
    public interface IReservation
    {
        List<Reservation> GetReservations();
        Reservation AddReservation(Reservation reservation);
    }
}
