using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoExcecoesPersonalizadas.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    
        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn,DateTime checkOut)
        {
            if(checkIn > CheckIn && checkOut > checkIn)
            {
                CheckIn = checkIn;
                CheckOut = checkOut;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public override string ToString()
        {
            return $"Reservation: Room {RoomNumber}, check-in: {CheckIn.ToString("dd/MM/yyy")}, check-out: {CheckOut.ToString("dd/MM/yyy")}, {Duration()} nights";
        }
    }
}
