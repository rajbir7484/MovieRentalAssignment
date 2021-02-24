using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalAssignment.Utility
{
    public class CalculateDays
    {
        //Claculate Total Days
        public int GetTotalDays(string issueDate, string returnDate)
        {
            int totalDays = 0;
            totalDays = Convert.ToInt32((DateTime.Parse(returnDate) - DateTime.Parse(issueDate)).TotalDays);
            return totalDays;
        }
    }
}
