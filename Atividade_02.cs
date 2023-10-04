using System;

 
class Atividades_02
{
  
static void Main () 
  {
    
double[] numeros = new double[10];
    
for (int i = 0; i < 10; i++)
      
      {
	
Console.Write ("Digite o " + (i + 1) + "B: numero: ");
	
numeros[i] = Convert.ToDouble (Console.ReadLine ());
      
} 
 
Console.
      WriteLine ("\nOs nC:meros digitados na ordem inversa são:");
    
for (int i = 9; i >= 0; i--)
      
      {
	
Console.WriteLine (numeros[i]);

} 
} 
} 