using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCRUDPgSql
{
    class KitSabor
    {
        public int KitSaborID { get; set; }
        public string Descricao { get; set; }

        public KitSabor() { }

        public DataTable ListarKitSabor()
        {
            DataTable dtKitSabor = new DataTable();
            ConnetionPostgres connectionPostgres = new ConnetionPostgres();
            NpgsqlConnection conn = new NpgsqlConnection(connectionPostgres.ConnString);

            string sql = "SELECT * FROM public.\"KitSabor\"";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
            conn.Open();
            NpgsqlDataReader reader = cmd.ExecuteReader();

            dtKitSabor.Load(reader);
            conn.Close();
            return dtKitSabor;
        }


        public string InserirKitSabor(KitSabor kitSabor)
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
                    cmd.CommandText = "Insert into public.\"KitSabor\" values(@Descricao)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@Descricao", kitSabor.Descricao));
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
