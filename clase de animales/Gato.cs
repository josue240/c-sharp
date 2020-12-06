using System;
public class Gato: Mamifero
{
    public string Pelaje { get; set; }
    public string Raza { get; set; }
    public bool EsEnojado { get; set; }

    public Gato() // Polimorfismo
    {
       EsEnojado= true;
    }

    public Gato(bool  esEnojado) // Polimorfismo
    {
        EsEnojado = esEnojado;
    }
    public void Maullar()
    {
        Console.WriteLine("Miau miau miau");

    }

}