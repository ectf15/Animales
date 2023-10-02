namespace Animales;

class Reptiles : Animal, IGrupo, IMoverse
{
    public string Desplazamiento { get; set; }
    public string Piel { get; set; }
    public int CantidadDePatas { get; set; }


    public void ControlDeTemperatura()
    {
        Console.WriteLine("Los reptiles pueden controlar su temperatura corporal");
    }

    public void Grupo()
    {
        Console.WriteLine("Los reptiles son animales vertebrados");
    }

    public void Moverse()
    {
        Console.WriteLine("Los reptiles se caracterizan por desplazarse reptando. Es decir, arrastrándose por el suelo, como la serpiente, el cocodrilo, el lagarto o la tortuga.");
    }
}