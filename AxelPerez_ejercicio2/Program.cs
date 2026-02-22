using System.Threading.Channels;

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
switch (rol)
{
    case 1:
        if (carnet == "S")
        {
            if (dia >= 1 && dia <= 5 && hora >= 7 && hora <= 18)
            {
                acceso = 1;
                nivel = "Acceso estudiante";
            }
        }
        break;
    case 2:
        if (carnet == "S")
        {
            acceso = 1;
            nivel = "Acceso docente";
        }
        break;

    case 3:
        if (carnet == "S")
        {
            if (hora >= 7 && hora <= 18)
            {
                acceso = 1;
                nivel = "Acceso técnico";
            }
            else if (autorizacion == "S")
            {
                acceso = 1;
                nivel = "Técnico fuera de horario";
            }
        }
        break;

    case 4:
        if (autorizacion == "S")
        {
            if (acompanado == "S")
            {
                acceso = 1;
                nivel = "Visitante supervisado";
            }
        }
        break;

    default:
        Console.WriteLine("Rol inválido");
        return;

}
if (usb == "S")
{
    if (!(autorizacion == "S" && acompanado == "S"))
    {
        acceso = 0;
        nivel = "USB no permitido";
    }
}

if (acceso == 1)
    Console.WriteLine("Acceso: PERMITIDO");
else
    Console.WriteLine("Acceso: DENEGADO");

Console.WriteLine("Nivel de permiso: " + nivel);




