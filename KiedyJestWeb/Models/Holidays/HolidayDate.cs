using System;

namespace KiedyJestWeb.Models.Holidays
{
    /// <summary>
    /// Represents a single holiday date
    /// </summary>
    public class HolidayDate
    {
        /// <summary>
        /// Gets or sets the day of the holiday
        /// </summary>
        public int Day { get; set; }

        /// <summary>
        /// Gets or sets the month of the holiday
        /// </summary>
        public int Month { get; set; }

        /// <summary>
        /// Gets or sets the year of the holiday. If set to null, it represents a recurring holiday.
        /// </summary>
        public int? Year { get; set; }

        /// <summary>
        /// Gets a datetime object for this HolidayDate object if it exists for the current year.
        /// </summary>
        /// <returns>A datetime</returns>
        public DateTime? GetDateForCurrentYear()
        {
            return this.GetDateForYear(DateTime.Now.Year);
        }

        /// <summary>
        /// Gets a datetime object for this HolidayDate object if it exists for the given year.
        /// </summary>
        /// <param name="year">a requested holiday year</param>
        /// <returns>A datetime</returns>
        public DateTime? GetDateForYear(int year)
        {
            try
            {
                if (this.Year.HasValue)
                {
                    return this.Year == year ? new DateTime(this.Year.Value, this.Month, this.Day) : (DateTime?) null;
                }
                return new DateTime(year, this.Month, this.Day);
            }
            catch (ArgumentOutOfRangeException e)
            {
                // TODO: log this
                return null;
            }
        }
    }
}