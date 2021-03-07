using System;

namespace EmployeeNS
{
    public struct HiringDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public HiringDate(int _Day, int _Month, int _Year)
        {
            Day = _Day;
            Month = _Month;
            Year = _Year;
        }
        public override string ToString()
        {
            return $"{Day}/ {Month}/ {Year}";
        }

    }
}
