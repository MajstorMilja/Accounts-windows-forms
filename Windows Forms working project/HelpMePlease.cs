
using System.Configuration;


namespace Nemam_Pojma_vise
{
    public static class HelpMePlease
    {
        public static string CnnRac(string Name)
        {
            return ConfigurationManager.ConnectionStrings[Name].ConnectionString;
        }
    }
}
