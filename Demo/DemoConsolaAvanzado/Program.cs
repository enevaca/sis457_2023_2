// See https://aka.ms/new-console-template for more information

using DemoBiblioteca;
using DemoConsolaAvanzado;

// Biblioteca de Clases
//var calculadora = new Calculadora();
int suma = Calculadora.sumar(2, 7);
int resta = Calculadora.restar(9, 3);
Console.WriteLine($"Valores: {suma}, {resta}");

// Delegados
static string revertirCadena(string cadena)
{
    return new string(cadena.Reverse().ToArray());
}
revertir rev = revertirCadena;
Console.WriteLine(rev("Hola Mundo"));

void imprimir(string valor)
{
    Console.WriteLine($"Valor {valor} para delegado Action<T>");
}
Action<string> imp = imprimir;
imp("SIS457");

int multiplicarOld(int v1, int v2)
{
    return v1 * v2;
}
Func<int, int, int> multiplicar = (v1, v2) => v1 * v2;
Console.WriteLine($"El resultado es: {multiplicar(3,2)}");

bool mayorEdadOld(int e)
{
    //if (e >= 18) return true;
    //else return false;
    return e >= 18;
}
Predicate<int> mayorEdad = e => e >= 18;
Console.WriteLine($"Es mayor de edad: {mayorEdad(10)}");


// Genéricos
Generico<string, Coche> generico = new Generico<string, Coche>();
generico.campo = "Hola Genérico";
generico.campo2 = new Coche();
Console.WriteLine($"Genéricos: {generico.campo}");
generico.campo2.girar(30);
generico.impresion("Imprimiendo...");

var generico2 = new Generico<bool, List<Cuadrado>>();
generico2.campo = true;
generico2.campo2 = new List<Cuadrado>();
generico2.campo2.Add(new Cuadrado(5));
Console.WriteLine($"Área con genéricos: {generico2.campo2[0].area()}");

// Interfaces
// var vehiculo = new IVehiculo(); // No se puede instanciar una interface
var coche = new Coche();
coche.acelerar(40);

// Clases Abstractas
// var figura = new FiguraGeometrica(); // No se puede instanciar
var cuadrado = new Cuadrado(6);
Console.WriteLine("El área es: " + cuadrado.area());

// Try / Catch / Finally
int a, b, division;
try
{
    Console.WriteLine("Introduzca valor de a: ");
    a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Introduzca valor de b: ");
    b = Convert.ToInt32(Console.ReadLine());

    division = a / b;
    Console.WriteLine($"La división entre {a} y {b} es: {division}");
}
catch(DivideByZeroException ex)
{
    Console.WriteLine("No es posible dividir por 0. " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Excepción no controlada. " + ex.Message);
}
finally
{
    division = 0;
    Console.WriteLine("Finalización");
}

// Async / Await
testAsyncAwaitMethod();
Console.WriteLine("Presione cualquier tecla para salir");
Console.ReadLine();

static async void testAsyncAwaitMethod()
{
    await longRunningMethod();
}

static async Task<int> longRunningMethod()
{
    Console.WriteLine("Iniciando método de larga duración");
    await Task.Delay(1000);
    Console.WriteLine("Fin del método de larga duración");
    return 1;
}

// Inmutabilidad
var inmutable = new Inmutable(2023);
