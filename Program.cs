﻿using EMPRESA;

class Program{
    static void Main(string[] args){
        PagamentoService rh = new FolhaDePagamento();
        List<Fucionario> listaColaboradores = new List<Fucionario>();

        listaColaboradores.Add(new Gerente { Name = "Sebastiao (Gerente)", SalarioBase = 5000 });
        listaColaboradores.Add(new Desenvolvedor { Name = "Bruno (Dev)", SalarioBase = 4000 });
        listaColaboradores.Add(new Diretor { Name = "Marcos (Diretor)", SalarioBase = 10000 });

        Console.WriteLine("=== SISTEMA DE PAGAMENTO ===\n");
        foreach (var func in listaColaboradores)
        {
            rh.RealizarPagamento(func);
        }
    }
}