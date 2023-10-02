using Animales;

Animal animalMamifero1 = new Mamiferos();
animalMamifero1.Clasificacion = "Vertebrados";
animalMamifero1.Comer();

Aves animalAve1 = new Aves();
animalAve1.Moverse();

//Polimorfismo

IGrupo grupoReptiles = new Reptiles();
grupoReptiles.Grupo();

Reptiles grupoRep =  new Reptiles();
grupoRep.Grupo();