int numeroDigitado;

Console.WriteLine("Digite um número:");
numeroDigitado = Convert.ToInt32(Console.ReadLine());
if (numeroDigitado < 0)
{
    Console.WriteLine("Você digitou um número negativo.");
}
else
{
    Console.WriteLine("Nada a exibir.");
}
