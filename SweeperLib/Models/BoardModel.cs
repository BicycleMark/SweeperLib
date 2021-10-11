using Microsoft.Toolkit.Mvvm.ComponentModel;
using SweeperLib.Enums;

namespace SweeperLib.Models
{
    public class BoardModel : BindableTwoDArray<GamePieceModel>
    {
        private GameState _gameState = GameState.Loading;

        public BoardModel(BoardDimension dimension) 
            : base(dimension.Rows, dimension.Columns)
        {
            
        }
        // ReSharper disable once MemberCanBePrivate.Global
        public GameState GameState
        {
            get => _gameState;
        }

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
        /// Proposed Randomization is 
        /// </summary>
        /// <returns></returns>
        public BoardModel PropsedRandomization(int r, int c)
        {
            // TODO
            return null!;
        }
    }
}