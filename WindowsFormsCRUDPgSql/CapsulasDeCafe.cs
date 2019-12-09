using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;

namespace WindowsFormsCRUDPgSql
{
    class CapsulasDeCafe
    {

        public int CapsulasID { get; set; }
        public string Descricao { get; set; }
        public int Forca { get; set; }

        public CapsulasDeCafe() { }

        public DataTable ListarCapsulas()
        {
            DataTable dtCapsulas = new DataTable();
            ConnetionPostgres connectionPostgres = new ConnetionPostgres();
            NpgsqlConnection conn = new NpgsqlConnection(connectionPostgres.ConnString);

            string sql = "SELECT * FROM public.\"Capsulas\"";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
            conn.Open();
            NpgsqlDataReader reader = cmd.ExecuteReader();

            dtCapsulas.Load(reader);
            conn.Close();
            return dtCapsulas;
        }

        public string InserirCapuslaDeCafe(CapsulasDeCafe capsula)
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
                    cmd.CommandText = "Insert into public.\"Capsulas\" values(@Descricao,@Forca)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@Descricao", capsula.Descricao));
                    cmd.Parameters.Add(new NpgsqlParameter("@Forca", capsula.Forca));
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
