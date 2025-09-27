// <copyright file="Nationality.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Web.Data;

/// <summary>
/// Es una clase para las nacionalidades.
/// </summary>
public class Nationality
{
    /// <summary>
    /// Gets or sets id.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets name.
    /// </summary>
    required public string Name { get; set; }
    /* Relationships */

    /// <summary>
    /// Gets or sets PLayers.
    /// </summary>
    required public List<Player> Players { get; set; } = new();
}