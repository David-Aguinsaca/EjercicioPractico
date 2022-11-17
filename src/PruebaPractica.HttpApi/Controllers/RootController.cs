using Microsoft.AspNetCore.Mvc;
using PruebaPractica.Application.controller;

namespace PruebaPractica.HttpApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RootController : ControllerBase
{
    private readonly RootAppServiceController rootAppServiceController;

    public RootController(RootAppServiceController rootAppServiceController )
    {
        this.rootAppServiceController = rootAppServiceController;
    }

    [HttpGet("cgarcia_api_net")]
    public ICollection<List<Root>> GetAll()
    {
        return rootAppServiceController.MetodoGet();
    }
}
