// See https://aka.ms/new-console-template for more information
/* Este es un comentario 
 en múltiples líneas */
// Console.WriteLine("Hello, World!");
using DemoConsola;

// Variables
var variable = "Cualquier valor";
bool esActivo = false;
int entero = 9;
double real = 8.7;
decimal real2 = 49.8M;
float real3 = 6.8f;
char caracter = 'A';
string cadena = "Esto es una cadena   ";
Int32 entero2 = 65;
Int64 enteroLargo = 54564656666555;
DateTime fecha = DateTime.Now;

// Constantes
const double PI = 3.1416;
const string SIGLA_MATERIA = "SIS457";

// Operadores y Expresiones
entero = 10;
entero += 5;
entero2 %= 2;
bool esPar = entero % 2 == 0;
int a = 2 * 2 + 2;
int b = 2 * (2 + 2);

// Conversiones y cadenas
string conversionCadena = Convert.ToString(5);
int conversionEntero = Convert.ToInt32(real2); // (int) variable
bool conversionBool = Convert.ToBoolean("true");

string materia = "Fundamentos de la Programación";
string mayuscula = materia.ToUpper();
string minuscula = materia.ToLower();
string[] separar = materia.Split(' ');
string reemplazo = materia.Replace(" ", "%");
int cantidadCaracteres = materia.Length;
string concatenar = materia + " - SIS457";
string concatenar2 = $"{materia} - {SIGLA_MATERIA}";
string quitarEspaciosExtremos = cadena.Trim() + materia;
string subcadena = materia.Substring(0, 10).ToUpper().Trim();

// Estructuras de control
bool esMayorCero;
if (cadena.Length > 0) esMayorCero = true;
else esMayorCero = false;
bool esMayorCero2 = cadena.Length > 0 ? true : false;
bool esMayorCero3 = cadena.Length > 0; // sin if

string evaluacion;
switch (materia) 
{
    case "SIS457": evaluacion = "SIGLA"; break;
    case "Fundamentos de la Programación": evaluacion = "DESCRIP."; break;
    default: evaluacion = "NO ESPECIFICADO"; break;
}

int datoTeclado = 0;
while (datoTeclado >= 0)
{
    Console.WriteLine("Introduzca un número negativo: ");
    datoTeclado = -1; //Convert.ToInt32(Console.ReadLine());
}

int variableDoWhile = 5;
do {
    Console.WriteLine(variableDoWhile);
    variableDoWhile--;
} while (variableDoWhile > 0);

List<string> lista = new List<string>();
for (int i = 0; i < separar.Length; i++)
{
    Console.WriteLine($"{separar[i]}");
    lista.Add(separar[i]);
}

foreach (string s in lista) Console.WriteLine(s);

// Métodos o funciones
string saludar(string nombre)
{
    return $"Hola {nombre} desde una función";
}

//string saludo = saludar("SIS457");
Console.WriteLine(saludar("SIS457"));

// POO
Persona persona = new Persona();
persona.cedulaIdentidad = "123456-1O";
persona.nombres = "Juan";
persona.primerApellido = "Pérez";
persona.segundoApellido = "Suárez";
persona.fechaNacimiento = DateTime.Parse("1999-08-06");
persona.celular = 76767676;
persona.saludar();
Console.WriteLine("Edad: " + persona.edad());

Estudiante estudiante = new Estudiante();
estudiante.cedulaIdentidad = "865245";
estudiante.nombres = "Rubén";
estudiante.primerApellido = "Arteaga";
estudiante.segundoApellido = "Cierra";
estudiante.fechaNacimiento = DateTime.Parse("1983-08-06");
estudiante.celular = 74747474;
estudiante.carnetUniversitario = "26-1234";
estudiante.saludar();

List<Persona> personas = new List<Persona>();
//Persona[] people = new Persona[3];
for (int i = 0; i < 3; i++) // i < people.lenght
{
    var person = new Persona();
    Console.WriteLine($"Introduzca CI de la persona {(i+1)}:");
    person.cedulaIdentidad = Console.ReadLine().Trim();

    Console.WriteLine($"Introduzca el nombre de la persona {(i + 1)}:");
    person.nombres = Console.ReadLine().Trim();

    Console.WriteLine($"Introduzca el primer apellido de la persona {(i + 1)}:");
    person.primerApellido = Console.ReadLine().Trim();
    personas.Add(person);
    //people[i] = person;
}

foreach (var person in personas) person.saludar();
