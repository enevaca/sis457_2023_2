// See https://aka.ms/new-console-template for more information

using DemoConsolaAvanzado;

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
