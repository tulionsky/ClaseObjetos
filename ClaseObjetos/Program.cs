using ClaseObjetos.Clases;

carro carrito = new carro("Toyota", 2024, "automatica", "Camry", 5, 80);
carro car2 = new carro("Nissan", 2005, "automatica", "Altima", 5, 80);

carrito.Color = "rojo";
carrito.Owner = "Juan";

Console.WriteLine("Marca: " + carrito.Marca);
Console.WriteLine("Marca del 2do carro: " + car2.Marca);

Console.WriteLine("Quieres encender el carro?\nPresiona:\n1.SI\n2.NO");
string dec = Console.ReadLine();

if (dec == "1")
{
    car2.encender();
}


//car2.apagar();

if (car2.encendido== 0)
{
    Console.WriteLine("Prende el carro pa");
}
else
{
    //Console.WriteLine(car2.acelerar() + "/KPH");
    //Console.WriteLine(car2.acelerar() + "/KPH");
    //Console.WriteLine(car2.acelerar() + "/KPH");
    //Console.WriteLine(car2.acelerar() + "/KPH");

    Console.WriteLine(car2.desacelerar() + "/KPH");
    Console.WriteLine(car2.acelerar() + "/KPH");
    Console.WriteLine(car2.frenar()+ "/KPH");
}

 void Caja_de_Cambios()
{
    Console.Write("SELECCIONA QUE CAMBIO HACER\nP=Parking\nR=Reverse\nN=Neutro\nD=Drive\n");
    string cambio= Console.ReadLine().ToUpper();
    car2.CajaCambios(cambio);
    
        
}
