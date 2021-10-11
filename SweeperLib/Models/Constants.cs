using System.Collections.Generic;
using SweeperLib.Enums;

namespace SweeperLib.Models
{
    public static class Constants
    {
        public static IReadOnlyDictionary<GameType, BoardDimension> GameBoardDimensions =
            new Dictionary<GameType, BoardDimension>()
            {
                {GameType.Beginner, BoardDimension.Beginner},
                {GameType.Intermediate, BoardDimension.Intermediate},
                {GameType.Advanced, BoardDimension.Advanced}
            };
    }
}