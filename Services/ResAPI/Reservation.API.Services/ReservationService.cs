using Reservation.API.Infrastructure;
using Reservation.API.Models;
using System;

namespace Reservation.API.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationDTO GetReservationByBkgNumber(int bkgNumber)
        {
            return new ReservationDTO()
            {
                Id = (new Random()).Next(100),
                BkgNumber = bkgNumber,
                Amount = (new Random()).Next(5000, 10000),
                BkgDate = DateTime.Now,
                CheckinDate = DateTime.Now.Date.AddDays(30),
                CheckoutDate = DateTime.Now.Date.AddDays(37)
            };
        }
    }
}
