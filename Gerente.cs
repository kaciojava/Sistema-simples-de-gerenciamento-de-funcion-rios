using System;

namespace EMPRESA;

public class Gerente : Fucionario{
    public override double CalcularSalario()
    {
        return SalarioBase + (SalarioBase *0.20);
    }
}