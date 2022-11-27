using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ValidacionVacio
    {
        public bool CampoVacio (string TXTvacio)
        {
            if (TXTvacio == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
