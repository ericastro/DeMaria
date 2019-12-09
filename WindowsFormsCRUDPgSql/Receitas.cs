using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCRUDPgSql
{
    class Receitas
    {
        public int ReceitaID { get; set; }
        public string Descricao { get; set; }
        public int LastInsertID { get; set; }

        public Receitas() { }

        public string InserirReceitas(Receitas receita)
        {
            string result = "ok";
            try
            {
                ConnetionPostgres connectionPostgres = new ConnetionPostgres();

                using (NpgsqlConnection conn = new NpgsqlConnection(connectionPostgres.ConnString))
                {
                    conn.Open();

                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "Insert into public.\"KitSabor\" values(@Descricao)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@Descricao", receita.Descricao));
                    cmd.ExecuteNonQuery();
                    //RETORNA ULTIMO ID
                    cmd.CommandText = "select \"kitSaborID\" from public.\"KitSabor\" ORDER BY \"kitSaborID\" DESC LIMIT 1";
                    cmd.CommandType = CommandType.Text;
                    LastInsertID = Convert.ToInt32(cmd.ExecuteScalar());
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
