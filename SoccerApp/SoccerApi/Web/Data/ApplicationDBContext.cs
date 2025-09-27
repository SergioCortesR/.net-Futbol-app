// <copyright file="ApplicationDBContext.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Web;

using Microsoft.EntityFrameworkCore;
using Web.Data;

/// <summary>
/// Contexto para la base de datos.
/// </summary>
public class ApplicationDBContext(DbContextOptions options) : DbContext(options)
{
    /// <summary>
    /// Gets or sets players.
    /// </summary>
    public DbSet<Player> Players { get; set; }

    /// <summary>
    /// Gets or sets positions.
    /// </summary>
    public DbSet<Player> Positions { get; set; }

    /// <summary>
    /// Gets or sets Teams.
    /// </summary>
    public DbSet<Player> Teams { get; set; }

    /// <summary>
    /// Gets or sets Seasons.
    /// </summary>
    public DbSet<Player> Seasons { get; set; }

    /// <summary>
    /// Gets or sets Nationalities.
    /// </summary>
    public DbSet<Player> Nationalities { get; set; }

    /// <summary>
    /// Gets or sets Stadiums.
    /// </summary>
    public DbSet<Player> Stadiums { get; set; }

    /// <summary>
    /// Gets or sets PlayerHistories.
    /// </summary>
    public DbSet<Player> PlayerHistories { get; set; }
}