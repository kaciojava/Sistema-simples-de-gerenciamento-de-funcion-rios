using System;

namespace EMPRESA;

public interface PagamentoService{
    void RealizarPagamento(Fucionario f);
}

public class FolhaDePagamento : PagamentoService{
    public void RealizarPagamento(Fucionario f){
        double valorCalculado = f.CalcularSalario();
        Console.WriteLine($"Processando Pagamento Para {f.Name}");
        Console.WriteLine($"Valor Depositado: R${valorCalculado:F2}");
        Console.WriteLine("------------------------------------");
    }
}