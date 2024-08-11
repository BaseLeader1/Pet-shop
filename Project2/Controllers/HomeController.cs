using Microsoft.AspNetCore.Mvc;
using PetShop.Models;
using PetShop.Repositories;

namespace PetShop.Controllers
{
    public class HomeController : Controller
    {
        private IRepositoryAnimal _Animalrepository;
        public HomeController(IRepositoryAnimal repositoryAnimal)
        {
            _Animalrepository = repositoryAnimal;
        }

        public IActionResult Index()
        {
            IEnumerable<Animal> animals = _Animalrepository.GetAnimal();
            var sortedAnimals = animals.OrderByDescending(a => a.Comment?.Count ?? 0);
            var firstTwoAnimals = sortedAnimals?.Take(2);
            return View(firstTwoAnimals);
        }
    }
}
