// <copyright file="Position.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Web.Data;

/// <summary>
/// Es una clase para los posiciones.
/// </summary>
public class Position
{
    /// <summary>
    /// Gets or sets id.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets name.
    /// </summary>
    required public string Name { get; set; }

    /// <summary>
    /// Gets or sets PLayers.
    /// </summary>
    required public List<Player> Players { get; set; } = new();
}