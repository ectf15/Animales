namespace Animales;
class Mamiferos : Animal, IGrupo, IReproduccion
{
    public string Nombre { get; set; }

    public string TipoDePelo { get; set; }


    public void Amamantar()
    {
        Console.WriteLine("Los mamíferos nacen del vientre materno y alimentan a sus crias con leche por medio de glándulas mamarias.");
    }

    public void Grupo()
    {
        Console.WriteLine("Los mamíferos pertenecen al grupo de los vertebrados.");
    }

    public void Reproduccion()
    {
        Console.WriteLine("Los mamíferos se reproducen sexualmente.");
    }
}