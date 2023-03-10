using System;

namespace Presentation.Models.Games;

public record CreateGameModel(Guid PlayerOneId, Guid PlayerTwoId);
