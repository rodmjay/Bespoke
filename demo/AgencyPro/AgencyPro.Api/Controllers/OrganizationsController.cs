using AgencyPro.Services.Organizations.Interfaces;
using AgencyPro.Shared.Extensions;
using AgencyPro.Shared.Models;
using AgencyPro.Shared.Options;
using Bespoke.Rest.Bases;
using Microsoft.AspNetCore.Mvc;

namespace AgencyPro.Api.Controllers
{
    public class OrganizationsController : BaseController
    {
        private readonly IOrganizationService _service;
        public OrganizationsController(IServiceProvider serviceProvider, IOrganizationService service) : base(serviceProvider)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult<OrganizationDto>> Create([FromBody] OrganizationOptions options)
        {
            var result = await _service.CreateOrganizationAsync(new UserInfo(), options)
                .ConfigureAwait(false);
            if (result.IsT0) return Ok(result.AsT0);

            return BadRequest(result.AsT1);
        }
    }
}
