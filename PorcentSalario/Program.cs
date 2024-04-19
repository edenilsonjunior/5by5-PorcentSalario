// 5- Faça um programa que leia o valor atual do salario de uma pessoa e o
// valor com acréscimo e informe a porcentagem de acréscimo que foi dado (conferir se o proximo valor é maior)
double salarioAntigo = 0, salarioNovo = 0;
double resultado = 0;
Console.WriteLine("=====Calcular porcentagem=====");

do
{
    Console.Write("Digite o salario antigo: ");
    salarioAntigo = double.Parse(Console.ReadLine());

    if(salarioAntigo <= 0) Console.WriteLine("Valor invalido!");

} while (salarioAntigo <= 0);
Console.WriteLine("=============================");
do
{
    Console.Write("Digite o salario novo: ");   
    salarioNovo = double.Parse(Console.ReadLine());

    if (salarioNovo < salarioAntigo) Console.WriteLine("Salario novo menor que o antigo!");

} while (salarioNovo < salarioAntigo);

resultado = (salarioAntigo / salarioNovo) * 100;

Console.WriteLine("=============================");
Console.WriteLine($"O aumento foi de {resultado}%");
Console.WriteLine("=============================");



Console.Write("\nDigite qualquer tecla para sair: ");
Console.ReadKey();
