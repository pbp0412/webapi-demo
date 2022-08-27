using Microsoft.AspNetCore.Mvc;
using webapi.Models;

namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    [HttpPost("endpoint1")]
    public string TestEndpoint(TestEndpointModel model)
    {
        var username = model.Username;
        return "Your username is: " + username + " and input 1 was " + model.InputField1;
    }
}
