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
            var auth = new Credentials("f8eb5e5cd7861837b4f7bf08d84245841216a6fe");
            client.Credentials = auth;

            var repos = await client.Repository.GetAllForUser("HenryMigo");
            
            return repos;
        }
    }
}
