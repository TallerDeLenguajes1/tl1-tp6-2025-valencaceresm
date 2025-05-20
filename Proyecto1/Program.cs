// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;
a= 10;
b = a;

int eleccion;
int nEleccion;
float result;

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
Console.WriteLine("El numero invertido es:" + numeroInvertido);

do
{
    Console.WriteLine("Ingrese el primer numero con el que quiere trabajar");
    string y = Console.ReadLine();
    int numeroy;
    bool esNumeroy = int.TryParse(y, out numeroy);

    Console.WriteLine("Ingrese el segundo numero con el que quiera trabajar");
    string x = Console.ReadLine();
    int numerox;
    bool esNumerox = int.TryParse(x, out numerox);

    Console.WriteLine("Ingrese la operacion que quiere realizar:");
    Console.WriteLine("1) Suma");
    Console.WriteLine("2) Resta");
    Console.WriteLine("3) Multiplicacion");
    Console.WriteLine("4) Division");
    Console.WriteLine("0) Salir");
    string choice = Console.ReadLine();
    bool esNumeroEleccion = int.TryParse(choice, out eleccion);

    switch (eleccion)
    {
        case 1:
            result = numeroy + numerox;
            Console.WriteLine($"Resultado: {numeroy} + {numerox} = {result}");
            break;
        case 2:
            result = numeroy - numerox;
            Console.WriteLine($"Resultado: {numeroy} - {numerox} = {result}");
            break;
        case 3:
            result = numeroy * numerox;
            Console.WriteLine($"Resultado: {numeroy} x {numerox} = {result}");
            break;
        case 4:
            if (numerox == 0)
            {
                Console.WriteLine("Error: División por cero no permitida.");
            }
            else
            {
                result = numeroy / numerox;
                Console.WriteLine($"Resultado: {numeroy} / {x} = {result}");
            }
            break;
    }
    Console.WriteLine("Quiere seguir? 1)- Si 0)- No");
    choice = Console.ReadLine();
    bool nuevaEleccion = int.TryParse(choice, out nEleccion);
    eleccion = nEleccion;
} while (eleccion != 0);