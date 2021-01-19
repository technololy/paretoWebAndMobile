using System;
namespace Pareto.Services
{
    public static class Settings
    {


        public static class AppSettings
        {
            public const string ParetoBaseURL = "https://odeltech.com/ippis_rest/api/create_loan.php";

            internal static TimeSpan MaximumConnection => new TimeSpan(0, 2, 0);

        }
    }
}
