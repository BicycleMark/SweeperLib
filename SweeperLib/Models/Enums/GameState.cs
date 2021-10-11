namespace SweeperLib.Enums
{
    public enum GameState
    {
        /// <summary>
        /// Ready for Play indicates game is ready for Play.
        /// No Piece has been selected
        /// </summary>
        ReadyForPlay,

        /// <summary>
        /// The Game is in Play. Neither Won or Lost.
        /// </summary>
        InPlay,

        /// <summary>
        /// The Mouse is Pressed and the Piece is in Selection.
        /// </summary>
        InPieceSelection,

        /// <summary>
        /// You Lost the Game
        /// </summary>
        Lost,

        /// <summary>
        /// You won the Game!
        /// </summary>
        Won,
        
        /// <summary>
        /// Loading Game from Data Source
        /// </summary>
        Loading
    }
}