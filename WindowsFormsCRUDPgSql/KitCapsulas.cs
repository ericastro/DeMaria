using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCRUDPgSql
{
    class KitCapsulas
    {
        public int KitSaborID { get; set; }
        public int KitCapsulaID { get; set; }
        public int Quantidade { get; set; }

        public KitCapsulas()  { }

        public DataTable ListarKitCapsulas()
        {
            DataTable dtKitCapsulas = new DataTable();
            ConnetionPostgres connectionPostgres = new ConnetionPostgres();
            NpgsqlConnection conn = new NpgsqlConnection(connectionPostgres.ConnString);

            string sql = "SELECT * FROM public.\"KitCapsulas\"";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
            conn.Open();
            NpgsqlDataReader reader = cmd.ExecuteReader();

            dtKitCapsulas.Load(reader);
            conn.Close();
            return dtKitCapsulas;
        }

        public string InserirCapuslaDeCafe(KitCapsulas kitCapsula)
        {
            string result = "ok";
            try
            {
                ConnetionPostgres connectionPostgres = new ConnetionPostgres();
                /* Insertion After Validations*/
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionPostgres.ConnString))
                {
                    conn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "Insert into public.\"KitCapsulas\" values(@KitCapulasID,@Quantidade,@KitSaborID)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@KitCapulasID", kitCapsula.KitCapsulaID));
                    cmd.Parameters.Add(new NpgsqlParameter("@Quantidade", kitCapsula.Quantidade));
                    cmd.Parameters.Add(new NpgsqlParameter("@KitSaborID", kitCapsula.KitSaborID));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                return "ERROR : " + ex.ToString();
            }
            return result;
        }
    }
}
