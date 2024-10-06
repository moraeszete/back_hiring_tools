using Microsoft.AspNetCore.Mvc;

public class BaseController : ControllerBase
{
  protected readonly MongoService _mongoService;

  public BaseController(MongoService mongoService)
  {
    _mongoService = mongoService;
  } 
}