string sexo;
double altura, resultado;
Console.Clear();
Console.WriteLine("Escolha M para masculio F para feminino");
sexo = Console.ReadLine()!.ToUpper();
Console.WriteLine("qual sua Altura");
altura = Convert.ToDouble(Console.ReadLine()!);
if (sexo == "M")
{
    resultado = (altura * 72.7) - 58.0;
    Console.WriteLine($@"Seu Peso ideal {resultado :N2}");


}

else if (sexo == "F")
{
    resultado = (altura * 62.1) - 44.7;
    Console.WriteLine($@"Seu Peso ideal {resultado:N2}");

}
else
{

    Console.WriteLine("ERRO");
}
