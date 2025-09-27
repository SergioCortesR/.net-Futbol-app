// <copyright file="Stadium.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Web.Data;

/// <summary>
/// Es una clase para los posiciones.
/// </summary>
public class Stadium
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
    /// Gets or sets name.
    /// </summary>
    required public int Capacity { get; set; }

    /// <summary>
    /// Gets or sets Teams.
    /// </summary>
    required public Team Team { get; set; }
}