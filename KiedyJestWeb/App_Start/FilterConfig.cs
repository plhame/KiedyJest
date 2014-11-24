namespace KiedyJestWeb
{
    using System.Web.Mvc;

    /// <summary>
    /// A configuration class for setting up middleware/filters.
    /// </summary>
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
