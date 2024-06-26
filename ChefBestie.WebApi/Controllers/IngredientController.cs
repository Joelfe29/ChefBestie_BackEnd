using ChefBestie.Domain;
using ChefBestie.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ChefBestie.WebApi.Controllers
{
    public class IngredientController : BaseController
    {
        private readonly IIngredientService _ingredientService;

        public IngredientController (IIngredientService ingredientService)
        {
            _ingredientService = ingredientService;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(_ingredientService.GetAll());
        }

        [HttpGet("by-id")]
        public ActionResult GetById(int id)
        {
            return Ok(_ingredientService.GetById(id));
        }

        [HttpPost]
        public ActionResult Post(Ingredient ingredient)
        {
            return Ok(_ingredientService.Post(ingredient));
        }

        [HttpDelete]
        public void Remove(int id)
        {
            _ingredientService.RemoveById(id);
        }


    }
}
