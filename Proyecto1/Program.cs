// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;
a= 10;
b = a;
int numeroInvertido = 0;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:" + b);

Console.WriteLine("Ingrese un numero que quiera invertir");
string entrada = Console.ReadLine();
int numero;
bool esNumero = int.TryParse(entrada, out numero);
if (esNumero)
{
    Console.WriteLine($"El número ingresado es: {numero}");
    while (numero > 0) {
        int digito = numero % 10;
        numeroInvertido = (numeroInvertido * 10) + digito;
        numero /= 10;
    }
}
else
{
    Console.WriteLine("La entrada no es un número entero válido.");
}
Console.WriteLine("El numero invertido es:"+numeroInvertido);