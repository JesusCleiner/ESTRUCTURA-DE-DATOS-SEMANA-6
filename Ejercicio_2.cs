using System;

class Nodo
{
    public int Dato;
    public Nodo Siguiente;

    public Nodo(int dato)
    {
        Dato = dato;
        Siguiente = null;
    }
}

class ListaEnlazada
{
    private Nodo cabeza;

    public ListaEnlazada()
    {
        cabeza = null;
    }

    // Método para agregar un elemento al final de la lista
    public void Agregar(int dato)
    {
        Nodo nuevoNodo = new Nodo(dato);
        if (cabeza == null)
        {
            cabeza = nuevoNodo;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoNodo;
        }
    }

    // Método para mostrar los elementos de la lista
    public void Mostrar()
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.Dato + " -> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }

    // Método para buscar un dato en la lista
    public int Buscar(int valor)
    {
        int contador = 0;
        Nodo actual = cabeza;

        while (actual != null)
        {
            if (actual.Dato == valor)
            {
                contador++;
            }
            actual = actual.Siguiente;
        }

        if (contador == 0)
        {
            Console.WriteLine($"El dato {valor} no fue encontrado en la lista.");
        }

        return contador;
    }
}

class Program
{
    static void Main(string[] args)
    {
        ListaEnlazada lista = new ListaEnlazada();

        Console.WriteLine("Ingrese la cantidad de elementos de la lista:");
        int cantidad = int.Parse(Console.ReadLine());

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Ingrese el elemento {i + 1}: ");
            int dato = int.Parse(Console.ReadLine());
            lista.Agregar(dato);
        }

        Console.WriteLine("\nLista ingresada:");
        lista.Mostrar();

        Console.Write("\nIngrese el valor que desea buscar: ");
        int valorBuscar = int.Parse(Console.ReadLine());

        int veces = lista.Buscar(valorBuscar);

        if (veces > 0)
        {
            Console.WriteLine($"El dato {valorBuscar} se encuentra {veces} veces en la lista.");
        }
    }
}

