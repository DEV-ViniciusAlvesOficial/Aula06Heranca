using System;

namespace Aula06Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
        CPF cpf = new CPF(); //cpf refere-se ao CPF (classe)
        cpf.nome = "Klebinho";
        Console.WriteLine(cpf.Saudar());

        cpf.cpf = "2348957"; 
        Console.WriteLine(cpf.validarCPF());

        CNPJ cnpj = new CNPJ();
        cnpj.nome = "Zeros e um";
        cnpj.cnpj = "11985539240";
        Console.WriteLine(cnpj.validarCNPJ()); 
        
        }
    }
}
