using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    public class Validador
    {
        public static bool Validar(int numero, int maximoPermitido, int minimoPermitido)
        {
            if(numero < minimoPermitido || numero > maximoPermitido)
            {
                return false;
            }else
            {
                return true;
            }
        }
    }
}
