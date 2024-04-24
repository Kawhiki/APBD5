using APBD5.Models;
using APBD5.Services;
using Microsoft.AspNetCore.Mvc;


namespace APBD5.Controllers;


    [ApiController]
    [Route("api/animals")]

    public class AnimalController : Controller
    {
        private readonly IAnimalDbService _animalDbService;
        public AnimalController(IAnimalDbService dbService)
        {
            _animalDbService = dbService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAnimal([FromQuery] string orderBy)
        {
            return Ok(_animalDbService.GetAnimal(orderBy));
        }

        [HttpPost]
        public async Task<IAsyncResult> UpdateAnimal([FromBody] Animal animal)
        {
            _animalDbService.AddAnimal(animal);
            return null;
        }

        [HttpPut("{idAnimal}")]
        public async Task<IActionResult> PutAnimalById([FromRoute]string idAnimal, [FromBody]Animal animal)
        {
            _animalDbService.UpdateAnimal(idAnimal, animal);
            return Ok();
        }

        [HttpDelete("{idAnimal}")]
        public async Task<IActionResult> DeleteAnimal([FromRoute]string idAnimal)
        {
            _animalDbService.DeleteAnimal(idAnimal);
            return Ok();
        }

        
    }
