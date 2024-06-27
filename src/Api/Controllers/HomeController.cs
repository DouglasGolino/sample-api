using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var data = new
            {
                Name = "GitHub",
                Description = "Plataforma de hospedagem de código-fonte e arquivos com controle de versão usando o Git"
            };

            return Json(data);
        }

        [HttpGet]
        public IActionResult Docker()
        {
            var data = new
            {
                Name = "Docker",
                Description = "Conjunto de produtos de plataforma como serviço que usam virtualização de nível de sistema operacional para entregar software em pacotes chamados contêineres. "
            };

            return Json(data);
        }
    }
}