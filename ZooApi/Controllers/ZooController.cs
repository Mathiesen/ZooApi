using Microsoft.AspNetCore.Mvc;

namespace ZooApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ZooController : ControllerBase
{
    private readonly AnimalService _animalService;
    
    public ZooController(AnimalService animalService)
    {
        _animalService = animalService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_animalService.GetAnimals());
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        return Ok(_animalService.GetAnimal(id));
    }

    [HttpPost]
    public IActionResult Post(AnimalModel model) 
    {
        _animalService.InsertAnimal(model.Id, model.Animal);
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _animalService.RemoveAnimal(id);
        return Ok();
    }
}