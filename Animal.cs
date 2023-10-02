namespace Animales;
class Animal
{
    public string Color { get; set; }
    public string Clasificacion { get; set; }

    public void Dormir()
    {
        Console.WriteLine("Todos los animales duermen");
    }

    public void Comer()
    {
        Console.WriteLine("Todos los animales se alimentan");
    }
}