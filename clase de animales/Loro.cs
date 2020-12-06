using System;

public class Loro: Aves
{
    public string Orden { get; set; }
    public string Familia { get; set; }

    public void Hablan()
    {
        Console.WriteLine("se comunican con los demá, imitando todos los sonidos que escucha");
    }

    public void Pico()
    {
        DescribirPico();
    }

    private void DescribirPico()
    {
        Console.WriteLine("posee una curvatura y duro, Las aves no tienen dientes, así que tragan su alimento entero");

    }

 }