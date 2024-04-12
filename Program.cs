int numero;

Console.WriteLine("Digite um número: ");
numero = Convert.ToInt32(Console.ReadLine());

if(numero >= 0) // se o numero for zero ou maior
{ // faça isso
Console.ForegroundColor = ConsoleColor.Green; //somente se positivo ou zero
}

else // senão
{ // faça isso
Console.ForegroundColor = ConsoleColor.Red; //somente se negativo   
}

Console.WriteLine($"O numero digitado é  {numero}."); 
Console.ResetColor();