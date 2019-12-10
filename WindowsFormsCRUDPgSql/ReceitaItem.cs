using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCRUDPgSql
{
    class ReceitaItem
    {
        public int ReceitaID { get; set; }
        public int KitSaborID { get; set; }

        public ReceitaItem() { }

        public string IncluirItensDaReceita(ReceitaItem receitaItem)
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
                    cmd.CommandText = "Insert into public.\"ReceitaItem\" values(@ReceitaID,@KitSaborID)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@ReceitaID", receitaItem.ReceitaID));
                    cmd.Parameters.Add(new NpgsqlParameter("@KitSaborID", receitaItem.KitSaborID));
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
