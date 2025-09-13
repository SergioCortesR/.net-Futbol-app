// <copyright file="PlayersController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Web.Controllers;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

[Route("[controller]")]
[ApiController]
#pragma warning disable SA1600 // Elements should be documented
public class PlayersController : ControllerBase
#pragma warning restore SA1600 // Elements should be documented
{
    [HttpGet]
#pragma warning disable SA1600 // Elements should be documented
    public IActionResult Saludar()
#pragma warning restore SA1600 // Elements should be documented
    {
        return this.Ok("Hola jugadores");
    }
}