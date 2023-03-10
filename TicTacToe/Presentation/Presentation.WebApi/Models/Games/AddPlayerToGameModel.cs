using System;

namespace Presentation.Models.Games;

public record AddPlayerToGameModel(Guid PlayerId, Guid GameId);