namespace Animales;
class Aves : Animal, IMoverse, IReproduccion
{
    public string Especie { get; set; }
    public string TipoDePlumaje { get; set; }

    public void Volar()
    {
        Console.WriteLine("Las aves vuelan");
    }

    public void Reproduccion()
    {
        Console.WriteLine("Las aves se reproducen sexualmente. En la mayoría de las especies, los padres también cuidan sus huevos y crías.");
    }

    public void Moverse()
    {
        Console.WriteLine("Las aves usan sus fuertes músculos pectorales para mover sus alas y desarrollar el empuje para moverse a través del aire y volar.");
    }
}