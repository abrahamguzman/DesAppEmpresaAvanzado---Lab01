// See https://aka.ms/new-console-template for more information

using Lab01;


Automovil automovil = new Automovil(
    "Nissan", "FAST06", 2023, "100"
    );


Camion camion = new Camion(
    "CAT", "Grande", 2001, 5.25
    );

Flota flota = new Flota(new List<Vehiculo> { automovil, camion});




Console.WriteLine("Ingrese Una de las opciones");

Console.WriteLine("A: Mostrar información de vehículos");
Console.WriteLine("B: Calcular Costo");
Console.WriteLine("S: Salir ");

string Opcion;



while ((Opcion = Console.ReadLine()) != "S") { 
    if (Opcion == "A")
    {
        flota.MostrarFlota();
    } else if (Opcion == "B")
    {
        Console.WriteLine("Escoge un vehículo y una distancia");
        Console.WriteLine("Vehículo: ");
        string VehiculoOpcion = Console.ReadLine();
        Console.WriteLine("Distancia: ");
        string DistanciaOpcion = Console.ReadLine();
        Console.WriteLine($"Pagarás por la distancia descrita de {DistanciaOpcion} ");

    }
}

Console.WriteLine("GRACIAS, VUELVA PRONTO ");

