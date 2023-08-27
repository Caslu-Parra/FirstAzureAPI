using Microsoft.AspNetCore.Mvc;

namespace HelloWorldAzureAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class SaudacoesController : ControllerBase
{
    private readonly ILogger<SaudacoesController> _logger;

    public SaudacoesController(ILogger<SaudacoesController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public ActionResult<Saudacao> Get(string? pNome)
    {
        _logger.LogInformation($"Paramêtro passado = {pNome}");
        if (string.IsNullOrWhiteSpace(pNome))
            return this.BadRequest();
        else
            return new Saudacao() { Mensagem = $"Olá {pNome}!!" };
    }
}
