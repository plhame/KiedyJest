namespace KiedyJestWeb.Models.Holidays
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents a single holiday definition.
    /// </summary>
    public class Holiday
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public HolidayType HolidayType { get; set; }

        public string HolidaySubType { get; set; }

        public HashSet<HolidayDate> HolidayDates { get; set; }  
    }
}