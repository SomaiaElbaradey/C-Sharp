using System;
using System.Linq;

namespace duration
{
    internal class Duration
    {
        public int Hours { set; get; }
        public int Minutes { set; get; }
        public int Seconds { set; get; }
        public Duration() { }
        public Duration(int _Hours, int _Minutes, int _Seconds)
        {
            if (_Hours > 0) Hours = _Hours;
            if (Enumerable.Range(0, 59).Contains(_Minutes)) Minutes = _Minutes;
            else if (_Minutes > 59 && Enumerable.Range(0, 59).Contains(_Seconds))
            {
                Hours += _Minutes / 60;
                Minutes = _Minutes % 60;
            };
            if (Enumerable.Range(0, 59).Contains(_Seconds)) Seconds = _Seconds;
            else if (_Minutes > 59 && _Seconds > 59)
            {
                Seconds = _Seconds % 60;
                Minutes = _Minutes;
                Minutes += _Seconds / 60;
                Hours += Minutes / 60;
                Minutes = Minutes % 60;
            }
            else if (_Seconds > 59)
            {
                Minutes += _Seconds / 60;
                Seconds = _Seconds % 60;
                Hours += Minutes / 60;
                Minutes = Minutes % 60;
            };
        }
        public Duration(int _Seconds)
        {
            fromSecondsToHours(_Seconds);
        }
        void fromSecondsToHours(int _Seconds)
        {
            Hours = _Seconds / 3600;
            Minutes = (_Seconds % 3600) / 60;
            Seconds = _Seconds % 3600 % 60 % 60;
        }
        public override string ToString()
        {
            Hours = Hours > 0 ? Hours : 0;
            Minutes = Minutes > 0 ? Minutes : 0;
            if (Hours == 0 && Minutes == 0) return $"Seconds: {Seconds}";
            if (Hours == 0) return $"Minutes: {Minutes}, Seconds: {Seconds}";
            return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
        }
        public override int GetHashCode()
        {
            return new { Hours, Minutes, Seconds }.GetHashCode();
        }
        private static int toSeconds(Duration duration)
        {
            return (duration.Hours * 3600) + (duration.Minutes * 60) + duration.Seconds;
        }
        public static Duration operator +(Duration left, Duration right)
        {
            return new Duration
            {
                Seconds = right.Seconds + left.Seconds,
                Minutes = right.Minutes + left.Minutes,
                Hours = right.Hours + left.Hours
            };
        }
        public static Duration operator -(Duration left, Duration right)
        {
            if (toSeconds(left) <= toSeconds(right)) return new Duration(0);
            return new Duration(toSeconds(left) - toSeconds(right));
        }
        public static Duration operator ++(Duration left)
        {
            return new Duration
            {
                Hours = left.Hours,
                Minutes = left.Minutes + 1,
                Seconds = left.Seconds
            };
        }
        public static Duration operator --(Duration left)
        {
            int newMinutes;
            int newHours;
            if (left.Minutes < 1 && left.Hours > 1)
            {
                newHours = left.Hours - 1;
                newMinutes = 59;
                return new Duration
                {
                    Hours = newHours,
                    Minutes = newMinutes,
                    Seconds = left.Seconds
                };
            }
            else
            {
                return new Duration
                {
                    Hours = left.Hours,
                    Minutes = left.Minutes - 1,
                    Seconds = left.Seconds
                };
            }
        }
        public static Duration operator +(Duration left, int val)
        {
            return new Duration
            {
                Hours = left.Hours + (val / 3600),
                Minutes = left.Minutes + (val % 3600) / 60,
                Seconds = left.Seconds + val % 3600 % 60 % 60
            };
        }
        public static Duration operator +(int val, Duration right)
        {
            return new Duration
            {
                Hours = right.Hours + (val / 3600),
                Minutes = right.Minutes + (val % 3600) / 60,
                Seconds = right.Seconds + val % 3600 % 60 % 60
            };
        }
        public static bool operator >(Duration left, Duration right)
        {
            return (toSeconds(left) > toSeconds(right));
        }
        public static bool operator <(Duration left, Duration right)
        {
            return (toSeconds(left) < toSeconds(right));
        }
        public static bool operator <=(Duration left, Duration right)
        {
            int leftSeconds = toSeconds(left);
            int rightSeconds = toSeconds(right);
            return (leftSeconds < rightSeconds) || (leftSeconds == rightSeconds);
        }
        public static bool operator >=(Duration left, Duration right)
        {
            int leftSeconds = toSeconds(left);
            int rightSeconds = toSeconds(right);
            return (leftSeconds > rightSeconds) || (leftSeconds == rightSeconds);
        }

        public static explicit operator DateTime(Duration duration)
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, duration.Hours, duration.Minutes, duration.Seconds);
        }
        public override bool Equals(object obj)
        {
            if (obj is Duration right)
            {
                if (object.ReferenceEquals(this, right)) return true;
                if (this.GetType() != right.GetType()) return false;
                return toSeconds(this) == toSeconds(right);
            }
            return false;
        }

        public static implicit operator string(Duration duration)
        {
            return duration.ToString();
        }
        public static implicit operator double(Duration duration)
        {
            return Math.Sqrt(duration.Hours * duration.Hours);
        }
    }
}