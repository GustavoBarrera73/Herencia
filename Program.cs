using App.Clase_Hijo;
using Herencia.Clase_Hijo;

Nintendo nintendo = new Nintendo();
nintendo.anioLanzaminto = 2017;
nintendo.esPortable = true;
nintendo.Marca = "Switch";
Console.WriteLine(nintendo.MostrarDetalleNintendo());

PlayStation ps = new PlayStation();
ps.Marca = "PlayStation 1";
ps.anioLanzaminto = 1994;
ps.ModeloControlador = "DualSense";
Console.WriteLine($"{ps.MostrarDetallePlay()}");

Xbox xn = new Xbox();
xn.Marca = "XBOX";
xn.anioLanzaminto = "2017";
xn.Xboxnormal = true;
Console.WriteLine(xn.MostrarDetalleXbox();