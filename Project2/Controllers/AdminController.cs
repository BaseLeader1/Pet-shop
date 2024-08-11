using Microsoft.AspNetCore.Mvc;
using PetShop.Models;
using PetShop.Repositories;

namespace PetShop.Controllers
{
    public class AdminController : Controller
    {
        private IRepositoryCategorie _repositoryCategorie;
        private IRepositoryAnimal _animalRepository;
        private IRepositoryComment _commentRepository;
        public AdminController(IRepositoryCategorie repositoryCategorie, IRepositoryAnimal repositoryAnimal, IRepositoryComment commentRepository)
        {
            _repositoryCategorie = repositoryCategorie;
            _animalRepository = repositoryAnimal;
            _commentRepository = commentRepository;

        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.animals = _animalRepository.GetAnimal();
            return View(_repositoryCategorie.GetCategorie());
        }
        [HttpPost]
        public IActionResult Index(int _categoryId)
        {
            if (_categoryId == 0)
            {
                ViewBag.animals = _animalRepository.GetAnimal();
            }
            else
            {
                ViewBag.animals = _animalRepository.GetAnimal().Where(a => a.CategoryId == _categoryId);
            }
            return View(_repositoryCategorie.GetCategorie());
        }
        [HttpGet]
        public IActionResult Insert()
        {
            ViewBag.CategoryList = _repositoryCategorie.GetCategorie();
            return View();
        }
        [HttpPost]
        public IActionResult Insert(Animal animal)
        {
            var _animal= new Animal{
                
            };
            _animalRepository.InsertAnimals(animal);
            return View("Index");
        }
        [HttpGet]
        public IActionResult UpdateAnimal(int _animalId)
        {
            ViewBag.CategoryList = _repositoryCategorie.GetCategorie();
            return View(_animalRepository.GetAnimal().Where(a => a.AnimalId == _animalId).FirstOrDefault());
        }
        [HttpPost]
        public IActionResult UpdateAnimal(int animalId, string AnimalName,int AnimalAge,int CategoryId, string DescriptionText, string PictureName)
        {
            var animalToUpdate = _animalRepository.GetAnimalById(animalId);
            if (animalToUpdate != null)
            {
                var _animal = new Animal
                {
                    AnimalId = animalId,
                    Name = AnimalName,
                    Age=AnimalAge,
                    PictureName = PictureName,
                    Description = DescriptionText,
                    CategoryId = CategoryId
                };
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult DeleteAnimal(int _animalId)
        {
            _commentRepository.DeleteComment(_animalId);
            _animalRepository.DeleteAnimals(_animalId);
            return RedirectToAction("Index");
        }
    }
}
