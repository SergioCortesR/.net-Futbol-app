// <copyright file="Player.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Web.Data;

/// <summary>
/// Es una clase para los jugadores.
/// </summary>
public class Player
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
    /// Gets or sets BirthDate.
    /// </summary>
    required public DateTime BirthDate { get; set; }
    /* Relationships */

    /// <summary>
    /// Gets or sets NationalityId.
    /// </summary>
    required public Guid NationalityId { get; set; }

    /// <summary>
    /// Gets or sets Nationality Object.
    /// </summary>
    required public Nationality Nationality { get; set; }

    /// <summary>
    /// Gets or sets NationalityId.
    /// </summary>
    required public Guid PositionId { get; set; }

    /// <summary>
    /// Gets or sets Position.
    /// </summary>
    required public Position Position { get; set; }

    /// <summary>
    /// Gets or sets PlayerHistories.
    /// </summary>
    required public List<PlayerHistory> PlayerHistories { get; set; } = new();
}