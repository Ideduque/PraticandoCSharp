using System;
class PraticaEstruturaCodicionais
{
    static void main(string[] args)
    {
        //Declaração das variáveis
        double salario;
        double aliquota;
        double deducao;
        double impostoMensal;
        double impostoAnual;

        //Obtenção dos valores (Entrada)
        Console.Write("Digite o salario bruto mensal: R$");
        salario = Convert.ToDouble(Console.ReadLine());

        //PROCESSAMENTO - cálculo do imposto
        if(salario > 4664.68) //faixa 5
        {
            aliquota = 27.5;
            deducao = 869.36;
        } else if(salario <= 4664.68 && salario >= 3751.6) //faixa 4
        {
            aliquota = 22.5;
            deducao = 636.13;
        } else if(salario <= 3751.05 && salario >= 2826.66) //faixa 3
        {
            aliquota = 15;
            deducao = 354.80;
        } else if(salario <= 2826.65 && salario >= 1903.99) //faixa 2
        {
            aliquota = 7.5;
            deducao = 142.80;
        } else  //faixa 1
        {
            aliquota = 0;
            deducao = 0
        }
        //Cálculo do imposto 
        impostoMensal = salario*(aliquota/100) - deducao;
        impostoAnual = impostoMensal*12;
        
        // Saída dos resultados
        Console.Write("\nSalario: R$" + salario);
        Console.Write("Aliquota: " + aliquota + "%");
        Console.Write("Imposto mensal: R$" + impostoMensal);
        Console.Write("Imposto anual: R$" + impostoAnual);

    }
}
