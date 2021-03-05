using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Octokit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HenryMigo.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GitHubController : ControllerBase
    {
        private readonly ILogger<GitHubController> _logger;

        public GitHubController(ILogger<GitHubController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IReadOnlyList<Repository>> Get()
        {
            var client = new GitHubClient(new ProductHeaderValue("HenryMigo.dev"));
            var auth = new Credentials("e8dcb5236e8bf6c5de38d5365f64daecea8b65cd");
            client.Credentials = auth;

            var repos = await client.Repository.GetAllForUser("HenryMigo");
            
            return repos;
        }
    }
}
