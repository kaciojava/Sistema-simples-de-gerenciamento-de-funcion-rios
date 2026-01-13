using System;

namespace EMPRESA;

public abstract class Fucionario{
    private string name;
    private double salarioBase;

    public string Name{
        get{ return name; }
        set{ name = value; }
    }

    public double SalarioBase{
        get{ return salarioBase; }
        set{ salarioBase = value; }
    }

    public abstract double CalcularSalario();
}