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
        public List<int> ListaKitSaborID { get; set; }

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

                    foreach(var kitSaborID in ListaKitSaborID)
                    {
                        cmd.CommandText = "Insert into public.\"KitSabor\" values(@Descricao,@KitSaborID)";
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add(new NpgsqlParameter("@Descricao", receita.Descricao));
                        cmd.Parameters.Add(new NpgsqlParameter("@Forca", kitSaborID));
                        cmd.ExecuteNonQuery();
                    }

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
