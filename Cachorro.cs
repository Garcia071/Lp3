using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace entrega_lp
{
    public class Cachorro : Animal, ISom, Ipular
{
    public string SomEmitido()
    {
        return "Cachorro Latindo";
    }

    public string Pular()
    {
        return "Cachorro pulando";
    }

    public override string ToString()
    {
        return $"Cachorro{{tipo='{Tipo}', nome='{Nome}'}}";
    }
}

}
