string tiempo;
int convertidor;

Console.WriteLine("Bienvenido");
Console.WriteLine("Cuantas horas estuvo en el centro comercial");
Console.WriteLine("Si estuvo 1 hora o menos = 0");
Console.WriteLine("Si estuvo menos de 2 horas = 1 ");
Console.WriteLine("Si estuvo mas de 2 horas = 2");
tiempo = Console.ReadLine();

convertidor= Convert.ToInt32(tiempo);

switch (convertidor)
{
    case 0:
        Console.WriteLine("Su monto a pagar es Q.5.00");
        break;
    case 1:
        Console.WriteLine("Su monto a pagar es Q.15.00");
        break;
    case 2:
        Console.WriteLine("Su monto a pagar es Q.40.00");
        break;
    default:
        Console.WriteLine("El valor ingresado es incorrecto");
        break;
}