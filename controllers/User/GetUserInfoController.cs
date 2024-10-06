using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

[ApiController]
[Route("api/[controller]")]
  public class GetUserInfoController : BaseController {
    public GetUserInfoController(MongoService mongoService) : base(mongoService){}

    [HttpGet]
      public IActionResult Get() {
          var result = new BsonDocument {
              {"id" , 1},
              {"name" , "lero leor"},
              {"identidade" , "dhbkasopdijqwiojdoqdj"}
          };

        // Console.WriteLine("Request: GET api/userinfo", result);
        _mongoService.PerformOperation<BsonDocument>("users", coll => coll.InsertOne(result));

        return Ok(result.ToJson());
      }
  }