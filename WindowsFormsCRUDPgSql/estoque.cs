using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCRUDPgSql
{
    class Estoque
    {
        public int CapsulasID { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public DateTime Validade { get; set; }
        public int Quantidade { get; set; }

        public Estoque()
        {

        }

        public string IncluirCapsulasNoEstoque(Estoque estoque)
        {
            string result = "ok";
            int quantidade = estoque.Quantidade;
            int iterator = 0;

            for (iterator = 0; iterator < quantidade; iterator++)
            {
                try
                {
                    ConnetionPostgres connectionPostgres = new ConnetionPostgres();
                    /* Insertion After Validations*/
                    using (NpgsqlConnection conn = new NpgsqlConnection(connectionPostgres.ConnString))
                    {
                        conn.Open();
                        NpgsqlCommand cmd = new NpgsqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = "Insert into public.\"Estoque\" values(@validade,@dataEntrada,@capsulasID)";
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add(new NpgsqlParameter("@validade", estoque.Validade));
                        cmd.Parameters.Add(new NpgsqlParameter("@dataEntrada", estoque.DataEntrada));
                        cmd.Parameters.Add(new NpgsqlParameter("@capsulasID", estoque.CapsulasID));
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    return "ERROR : " + ex.ToString();
                }
            }
            return result;
        }

        public bool VerificarEstoqueDeCapsulas(int capsulaID, int quantidade)
        {
            bool result = true;
            int quantidadeDisponivel = 0;

            if( quantidadeDisponivel < quantidade )
            {
                result = false;
            }

            return result;
        }
    }
}

