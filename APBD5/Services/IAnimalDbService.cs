using APBD5.Models;

namespace APBD5.Services;
using System.Collections.Generic;

public interface IAnimalDbService
{

    public List<Animal> GetAnimal(string orderBy);
    void UpdateAnimal(string idAnimal, Animal animal);
    void DeleteAnimal(string idAnimal);
    void AddAnimal(Animal animal);
}