using Microsoft.Toolkit.Mvvm.ComponentModel;
using SweeperLib.Enums;

namespace SweeperLib.Models
{
    public class BoardModel : BindableTwoDArray<GamePieceModel>
    {
        public BoardModel(BoardDimension dimension) 
            : base(dimension.Rows, dimension.Columns)
        {
            
        }
        // ReSharper disable once MemberCanBePrivate.Global
        public GameState GameState { get; } = GameState.Loading;

        public BoardDimension BoardDimension { get; } = BoardDimension.Beginner;

        public GameState Play(int r, int c)
        {
            return GameState;
        }

        public ShownValue Flag(int r, int c)
        {
            return ShownValue.Flag;
        }

        /// <summary>
        /// Proposed Randomization 
        /// </summary>
        /// <returns></returns>
        public BoardModel ProposedRandomization(int r, int c)
        {
            // TODO
            return null!;
        }
    }
}