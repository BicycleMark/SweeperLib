public struct BoardDimension
{
    public BoardDimension(int rows, int cols)
    {
        Rows = rows;
        Columns = cols;

    }
    public int Rows { get; private set; }
    public int Columns { get; private set; }

    public static BoardDimension Beginner = new BoardDimension(rows: 10, cols: 10);
    public static BoardDimension Intermediate = new BoardDimension(rows: 15, cols: 15);
    public static BoardDimension Advanced = new BoardDimension(rows: 15, cols: 15);
    
}

