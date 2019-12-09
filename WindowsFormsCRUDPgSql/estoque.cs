using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCRUDPgSql
{
    class Estoque
    {
        public int CapsulasID { get; set; }
        public int Quantidade { get; set; }

        public Estoque(int capsulasID, int quantidade)
        {
            CapsulasID = capsulasID;
            Quantidade = quantidade;
        }
    }
}
