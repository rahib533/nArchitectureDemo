using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.Brands.Commands.Create;
using Microsoft.AspNetCore.Mvc;


namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BrandsController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add(CreateBrandCommand createBrandComand)
    {
        return Ok(await Mediator.Send(createBrandComand));
    }
}

