using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaNico
{
    public class ValidadorMinMax
    {

        public static bool Validar(float numero, int maximoPermitido, int minimoPermitido)
        {
            if (numero < minimoPermitido || numero > maximoPermitido)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }   
}
