using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace entrega_lp
{
    public class Tartaruga : Animal, ISom
{

    public string SomEmitido()
    {
        return "Tartaruga emitindo som";
    }

    public override string ToString()
    {
        return $"Tartaruga{{tipo='{Tipo}', nome='{Nome}'}}";
    }
}
}