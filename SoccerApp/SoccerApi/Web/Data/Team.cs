// <copyright file="Team.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Web.Data;

/// <summary>
/// Es una clase para los equipos.
/// </summary>
public class Team
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
    /// Gets or sets founded.
    /// </summary>
    required public DateTime Founded { get; set; }

    /// <summary>
    /// Gets or sets Budget.
    /// </summary>
    required public double Budget { get; set; }

    /* Relationships */

    /// <summary>
    /// Gets or sets StadiumId.
    /// </summary>
    required public Guid StadiumId { get; set; }

    /// <summary>
    /// Gets or sets Stadium.
    /// </summary>
    required public Stadium Stadium { get; set; }

    /// <summary>
    /// Gets or sets TeamsChilds.
    /// </summary>
    required public List<Team> TeamsChilds { get; set; } = new();

    /// <summary>
    /// Gets or sets ParentTeam.
    /// </summary>
    required public Team ParentTeam { get; set; }

    /// <summary>
    /// Gets or sets ParentTeamId.
    /// </summary>
    required public Team ParentTeamId { get; set; }

    /// <summary>
    /// Gets or sets PlayerHistories.
    /// </summary>
    required public List<PlayerHistory> PlayerHistories { get; set; } = new();
}