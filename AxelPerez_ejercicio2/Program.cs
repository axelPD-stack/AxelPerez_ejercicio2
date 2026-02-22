Console.WriteLine("Rol:");
Console.WriteLine("1 Estudiante");
Console.WriteLine("2 Docente");
Console.WriteLine("3 Técnico IT");
Console.WriteLine("4 Visitante");
int rol = int.Parse(Console.ReadLine());

Console.WriteLine("Hora (0-23):");
int hora = int.Parse(Console.ReadLine());

Console.WriteLine("Día (1-7):");
int dia = int.Parse(Console.ReadLine());

Console.WriteLine("Carnet vigente (S/N):");
string carnet = Console.ReadLine();

Console.WriteLine("Autorización escrita (S/N):");
string autorizacion = Console.ReadLine();

Console.WriteLine("¿Trae USB? (S/N):");
string usb = Console.ReadLine();

string acompanado;
int acceso;
string nivel;

if (usb == "S")
{
    Console.WriteLine("¿Está acompañado? (S/N):");
    acompanado = Console.ReadLine();
}
else
{
    acompanado = "N";
}
if (hora < 0 || hora > 23)
{
    Console.WriteLine("Hora inválida");
    return;
}
else if (dia < 1 || dia > 7)
{
    Console.WriteLine("Día inválido");
    return;
}

acceso = 0;
nivel = "Sin permiso";

