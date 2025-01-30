using System;
using System.Collections.Generic;

class Nodo
{
    public int Valor;
    public Nodo Siguiente;

    public Nodo(int valor)
    {
        Valor = valor;
        Siguiente = null;
    }
}

class ListaEnlazada
{
    private Nodo cabeza;

    public void Agregar(int valor)
    {
        Nodo nuevo = new Nodo(valor);
        if (cabeza == null)
        {
            cabeza = nuevo;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
    }

    public void EliminarFueraDeRango(int min, int max)
    {
        while (cabeza != null && (cabeza.Valor < min || cabeza.Valor > max))
        {
            cabeza = cabeza.Siguiente;
        }

        Nodo actual = cabeza;
        while (actual != null && actual.Siguiente != null)
        {
            if (actual.Siguiente.Valor < min || actual.Siguiente.Valor > max)
            {
                actual.Siguiente = actual.Siguiente.Siguiente;
            }
            else
            {
                actual = actual.Siguiente;
            }
        }
    }

    public void Imprimir()
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.Valor + " -> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }
}

class ejercicio_1
{
    static void Main()
    {
        Random rand = new Random();
        ListaEnlazada lista = new ListaEnlazada();

        for (int i = 0; i < 50; i++)
        {
            lista.Agregar(rand.Next(1, 1000));
        }

        Console.WriteLine("Lista generada:");
        lista.Imprimir();

        Console.Write("Ingrese el valor mínimo del rango: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el valor máximo del rango: ");
        int max = int.Parse(Console.ReadLine());

        lista.EliminarFueraDeRango(min, max);

        Console.WriteLine("Lista después de eliminar los valores fuera del rango:");
        lista.Imprimir();
    }
}

