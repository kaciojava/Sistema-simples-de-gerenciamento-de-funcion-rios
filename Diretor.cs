using System;

namespace EMPRESA;

public sealed class Diretor : Fucionario{
    public override double CalcularSalario()
    {
        return SalarioBase + 5000;
    }
}