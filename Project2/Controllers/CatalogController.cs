using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PetShop.Repositories;

namespace PetShop.Controllers
{
    public class CatalogController : Controller
    {
        private IRepositoryCategorie _repositoryCategorie;
        private IRepositoryAnimal _animalRepository;
        private IRepositoryComment _commentRepository;
        public CatalogController(IRepositoryCategorie repositoryCategorie, IRepositoryAnimal repositoryAnimal, IRepositoryComment commentRepository)
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
        public IActionResult Details(int _animalId)
        {
            ViewBag.comments = _commentRepository;
            return View(_animalRepository.GetAnimal().Where(a => a.AnimalId == _animalId).FirstOrDefault());
        }
        [HttpPost]
        public IActionResult InsertComment(string CommentText, int animalId)
        {
            var _comment = new Comment
            {
                AnimalId = animalId,
                CommentText = CommentText
            };
            _commentRepository.InsertComment(_comment);
            
            return RedirectToAction("Details",new { _animalId = animalId });
        }
    }
}
