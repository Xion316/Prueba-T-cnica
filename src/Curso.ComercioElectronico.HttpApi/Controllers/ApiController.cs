namespace Curso.ComercioElectronico.HttpApi.Controllers;

using Curso.ComercioElectronico.Application;
using Curso.ComercioElectronico.Domain;
using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly RootAppService rootAppService;

    public ApiController(RootAppService rootAppService)
    {
        this.rootAppService = rootAppService;
    }

    [HttpGet("danbuitr_api_net")]
    public ICollection<Root> GetAll()
    {
        return rootAppService.MetodoGet();
    }
    }
