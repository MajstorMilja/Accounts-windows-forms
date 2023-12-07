using Dapper;
using System.Data;


namespace Nemam_Pojma_vise
{
    public class DataAcess
    {
        //public string connectionString = @"Data Source=DESKTOP-C70UD3Q\SQLEXPRESS;Initial Catalog=Racuni;Integrated Security=True;Encrypt=false";

        public List<Proizvodi> GetProizvod()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(HelpMePlease.CnnRac("Racuni")))
            {
                var output = connection.Query<Proizvodi>($"SviProizvodi").ToList();
                return output;
            }
        }


        public List<StatusRacuna> GetStatus()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(HelpMePlease.CnnRac("Racuni")))
            {
                var output = connection.Query<StatusRacuna>($"StatusR").ToList();
                return output;
            }
        }
        public List<Stavke> GetStavke()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(HelpMePlease.CnnRac("Racuni")))
            {
                var output = connection.Query<Stavke>($"SveStavke").ToList();
                return output;
            }
        }
        public List<Racuni> getRacun()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(HelpMePlease.CnnRac("Racuni")))
            {
                var output = connection.Query<Racuni>($"SviRacuni").ToList();
                return output;
            }
        }


        public List<Stavke> GetStavkeRacun(int racun)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(HelpMePlease.CnnRac("Racuni")))
            {
                var output = connection.Query<Stavke>($"select * from stavke where RacunId = {racun}").ToList();
                return output;
            }
        }
        public List<Racuni> DodajRacun()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(HelpMePlease.CnnRac("Racuni")))
            {
                var output = connection.Query<Racuni>($"").ToList();
                return output;
            }
        }
        public void  SendData(DataTable myList, int RacunId, DateTime Datum, int UkupnaCena)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(HelpMePlease.CnnRac("Racuni")))
            {
                connection.Execute("InsertUpdateDelete @UserStavke, @RacunId, @Datum, @UkupnaCena", myList);
            }
        }
    }
}
