// <copyright file="PlayersController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Web.Controllers;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

/// <summary>
/// Es un controlador de los jugadores.
/// </summary>
[Route("[controller]")]
[ApiController]
public class PlayersController : ControllerBase
{
    /// <summary>
    /// Función para saludar.
    /// </summary>
    /// <returns>Regresa un saludo.</returns>
    [HttpGet]
    public IActionResult Saludar()
    {
        Console.WriteLine("Hola jugadores desde la terminal");
        return this.Ok("Hola jugadores con watch");
    }
}