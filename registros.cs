namespace Practica_CajaRegistradora
{
    class Programa
    {
        static void Main(string[] args)
        {
            decimal Anillo = 1000;
            decimal Aretes = 699;
            decimal total_001 = 0;
            decimal total_002 = 0;
            decimal total_compras = 0;
            int cantidad_comprada001=0;
            int cantidad_comprada002=0;
            int c1=0;
            int c2=0;


            string[] productos = new string[]{"Anillo de plata","Aretes de oro"};

            while(true){
                Console.WriteLine("---Joyeria Ortega---");
                Console.WriteLine("Lista de productos:\nCodigo: 001 - Anillo - $1000\nCodigo: 002 - Aretes - $699");
                Console.WriteLine("Ingrese el codigo del producto");
                int codigo = int.Parse(Console.ReadLine());

                if(codigo == 001){
                Console.WriteLine("Ingrese la cantidad del producto seleccionado '{0}' a comprar",productos[0]);
                cantidad_comprada001 = int.Parse(Console.ReadLine());
                c1 = c1 + cantidad_comprada001;
                total_001 = c1 * Anillo;
                }

                else if(codigo == 002){
                    Console.WriteLine("Ingrese la cantidad del producto seleccionado '{0}' a comprar",productos[1]);
                    cantidad_comprada002 = int.Parse(Console.ReadLine());
                    c2 = c2 + cantidad_comprada002;
                    total_002 = c2 * Aretes;
                }

                else{
                    Console.WriteLine("Codigo Invalido");
                }

                total_compras = total_001 + total_002;

                Console.WriteLine("Codigo: 1 - Hacer otra compra\nCodigo: 2 - Pagar");
                Console.WriteLine("Usted elegio la opcion: ");

                int decision = int.Parse((Console.ReadLine()));
                if (decision == 2)
                {
                    Console.WriteLine("Total de su compra: ");
                    Console.WriteLine("Clave   | Producto       | Cantidad     | Precio    |Total");
                    Console.WriteLine("--------------------------------------------");
                    if(cantidad_comprada001 > 0)
                    {
                        Console.WriteLine("001      {0}       {1}         {2}        {3}",productos[0],c1,Anillo,total_001);
                    }
                    if(cantidad_comprada002 > 0)
                    {
                        Console.WriteLine("002      {0}          {1}         {2}        {3}",productos[1],c2,Aretes,total_002);
                    }
                    Console.WriteLine("Total a pagar:                                       {0}",total_compras);
                    break;
                }
            }
                try
                    {
                        StreamWriter sw = new StreamWriter("C:\\FilesC#\\Datos_Joyeria.txt");
                        sw.WriteLine("Total de su compra: ");
                        sw.WriteLine("Clave   | Producto       | Cantidad     | Precio    |Total");
                        sw.WriteLine("--------------------------------------------");
                        if (cantidad_comprada001 > 0)
                        {
                            sw.WriteLine("001      {0}       {1}         {2}        {3}",productos[0],c1,Anillo,total_001);
                        }
                        if (cantidad_comprada002 > 0)
                        {
                            sw.WriteLine("002      {0}          {1}         {2}        {3}",productos[1],c2,Aretes,total_002);
                        }
                        sw.WriteLine("Total a pagar:                                       {0}",total_compras);
                        sw.Close();
                    }
            catch(Exception e)
                    {
                        Console.WriteLine("Error: " + e.Message);
                    }
            finally
                    {
                        Console.WriteLine("El archivo se ha guardado con éxito");
                    }
        }
    }
}