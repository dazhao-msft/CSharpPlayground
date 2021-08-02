using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AspNetCorePlayground.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserProfileController : ControllerBase
    {
        private readonly ILogger<UserProfileController> _logger;

        public UserProfileController(ILogger<UserProfileController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<UserProfile> Get()
        {
            return new[]
            {
                new UserProfile { FirstName = "Weida", LastName = "Zhao" },
            };
        }
    }

    public record UserProfile
    {
        public string FirstName { get; init; }

        public string LastName { get; init; }
    }
}
