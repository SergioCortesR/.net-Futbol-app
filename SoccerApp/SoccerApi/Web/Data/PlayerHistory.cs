// <copyright file="PlayerHistory.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Web.Data;

/// <summary>
/// Es una clase para los posiciones.
/// </summary>
public class PlayerHistory
{
    /// <summary>
    /// Gets or sets PlayerId.
    /// </summary>
    public Guid PlayerId { get; set; }

    /// <summary>
    /// Gets or sets TeamId.
    /// </summary>
    public Guid TeamId { get; set; }

    /// <summary>
    /// Gets or sets SeasonId.
    /// </summary>
    public Guid SeasonId { get; set; }

    /// <summary>
    /// Gets or sets shirtNumber.
    /// </summary>
    required public int ShirtNumber { get; set; }

    /// <summary>
    /// Gets or sets MatchesPlayed.
    /// </summary>
    required public int MatchesPlayed { get; set; }

    /// <summary>
    /// Gets or sets GoalsScored.
    /// </summary>
    required public int GoalsScored { get; set; }

    /// <summary>
    /// Gets or sets Season Object.
    /// </summary>
    required public Season Season { get; set; }

    /// <summary>
    /// Gets or sets Team Object.
    /// </summary>
    required public Team Team { get; set; }

    /// <summary>
    /// Gets or sets Player Object.
    /// </summary>
    required public Player Player { get; set; }
}