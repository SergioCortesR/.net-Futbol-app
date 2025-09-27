// <copyright file="Season.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Web.Data;

/// <summary>
/// Es una clase para los posiciones.
/// </summary>
public class Season
{
    /// <summary>
    /// Gets or sets id.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets StartDate.
    /// </summary>
    required public DateTime StartDate { get; set; }

    /// <summary>
    /// Gets or sets EndDate.
    /// </summary>
    required public DateTime EndDate { get; set; }

    /// <summary>
    /// Gets or sets PlayerHistories.
    /// </summary>
    required public List<PlayerHistory> PlayerHistories { get; set; } = new();
}