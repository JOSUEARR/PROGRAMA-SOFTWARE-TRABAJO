using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMACION_LISTA_CLASE_MODELADO_DE_BD
{
    internal class Program
    {
      
       
    static List<Clientes> listaClientes = new List<Clientes>();

    static void Main()
    {
        // Menú principal
        int opcion;
        do
        {
            Console.WriteLine("1. Agregar Cliente");
            Console.WriteLine("2. Mostrar Clientes");
            Console.WriteLine("3. Actualizar Cliente");
            Console.WriteLine("4. Eliminar Cliente");
            Console.WriteLine("5. Salir");
            Console.Write("Selecciona una opción: ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        AgregarCliente();
                        break;
                    case 2:
                        MostrarClientes();
                        break;
                    case 3:
                        ActualizarCliente();
                        break;
                    case 4:
                        EliminarCliente();
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Introduce un número.");
            }

        } while (opcion != 5);
    }

    static void AgregarCliente()
    {
        Clientes nuevoCliente = new Clientes();

        Console.Write("Código del Cliente: ");
        nuevoCliente.Codigo_cliente = int.Parse(Console.ReadLine());

        Console.Write("Nombre del Cliente: ");
        nuevoCliente.Nombre_cliente = Console.ReadLine();

        Console.Write("Apellido del Cliente: ");
        nuevoCliente.Apellido_cliente = Console.ReadLine();

        Console.Write("Fecha de Nacimiento del Cliente: ");
        nuevoCliente.Fechanacimiento_cliente = Console.ReadLine();

        Console.Write("Teléfono del Cliente: ");
        nuevoCliente.Telefono_cliente = int.Parse(Console.ReadLine());

        Console.Write("Sexo del Cliente: ");
        nuevoCliente.Sexo_clientes = Console.ReadLine();

        Console.Write("Domicilio del Cliente: ");
        nuevoCliente.Domicilio_clientes = Console.ReadLine();

        Console.Write("Pago del Cliente: ");
        nuevoCliente.Pago_Cliente = int.Parse(Console.ReadLine());

        listaClientes.Add(nuevoCliente);

        Console.WriteLine("Cliente agregado correctamente.");
    }

    static void MostrarClientes()
    {
        if (listaClientes.Count > 0)
        {
            foreach (var cliente in listaClientes)
            {
                cliente.Informacion();
                Console.WriteLine("--------------");
            }
        }
        else
        {
            Console.WriteLine("No hay clientes registrados.");
        }
    }

    static void ActualizarCliente()
    {
        Console.Write("Introduce el código del cliente a actualizar: ");
        int codigoActualizar = int.Parse(Console.ReadLine());

        Clientes clienteActualizar = listaClientes.Find(c => c.Codigo_cliente == codigoActualizar);

        if (clienteActualizar != null)
        {
            Console.WriteLine("Ingrese los nuevos datos del cliente:");

            Console.Write("Nombre del Cliente: ");
            clienteActualizar.Nombre_cliente = Console.ReadLine();

            Console.Write("Apellido del Cliente: ");
            clienteActualizar.Apellido_cliente = Console.ReadLine();

            Console.Write("Fecha de Nacimiento del Cliente: ");
            clienteActualizar.Fechanacimiento_cliente = Console.ReadLine();

            Console.Write("Teléfono del Cliente: ");
            clienteActualizar.Telefono_cliente = int.Parse(Console.ReadLine());

            Console.Write("Sexo del Cliente: ");
            clienteActualizar.Sexo_clientes = Console.ReadLine();

            Console.Write("Domicilio del Cliente: ");
            clienteActualizar.Domicilio_clientes = Console.ReadLine();

            Console.Write("Pago del Cliente: ");
            clienteActualizar.Pago_Cliente = int.Parse(Console.ReadLine());

            Console.WriteLine("Cliente actualizado correctamente.");
        }
        else
        {
            Console.WriteLine("Cliente no encontrado.");
        }
    }

    static void EliminarCliente()
    {
        Console.Write("Introduce el código del cliente a eliminar: ");
        int codigoEliminar = int.Parse(Console.ReadLine());

        Clientes clienteEliminar = listaClientes.Find(c => c.Codigo_cliente == codigoEliminar);

        if (clienteEliminar != null)
        {
            listaClientes.Remove(clienteEliminar);
            Console.WriteLine("Cliente eliminado correctamente.");
        }
        else
        {
            Console.WriteLine("Cliente no encontrado.");
        }
    }
}

class Clientes
{
    public int Codigo_cliente { get; set; }
    public string Nombre_cliente { get; set; }
    public string Apellido_cliente { get; set; }
    public string Fechanacimiento_cliente { get; set; }
    public int Telefono_cliente { get; set; }
    public string Sexo_clientes { get; set; }
    public string Domicilio_clientes { get; set; }
    public int Pago_Cliente { get; set; }

    public void Datosdelcliente()
    {
        Console.WriteLine("Datos del Cliente");
        Console.WriteLine(Codigo_cliente);
        Console.WriteLine(Nombre_cliente);
        Console.WriteLine(Apellido_cliente);
        Console.WriteLine(Fechanacimiento_cliente);
        Console.WriteLine(Telefono_cliente);
        Console.WriteLine(Sexo_clientes);
        Console.WriteLine(Domicilio_clientes);
        Console.WriteLine(Pago_Cliente);
    }

    public void Direccion()
    {
        Console.WriteLine(Domicilio_clientes);
    }

    public void Informacion()
    {
        Console.WriteLine("Código: {Codigo_cliente}");
        Console.WriteLine("Nombre: {Nombre_cliente} {Apellido_cliente}");
        Console.WriteLine("Teléfono: {Telefono_cliente}");
        Console.WriteLine("Domicilio: {Domicilio_clientes}");
        Console.WriteLine("Pago: {Pago_Cliente}");
    }


}
}


