namespace FileManagerTest.Models
{
    public static class CursorState
    {
        public static int X { get; set; }
        public static int Y { get; set; }

        public static int MinY { get; set; }
        public static int _maxY { get; set; }

        public static int MaxY
        {
            get { return _maxY; }
            set
            {
                _maxY = value + 6;
            }
        }

        public static int PrevX { get; set; } = X;
        public static int PrevY { get; set; }

        public static void ResetCursorState()
        {
            X = 0;
            Y = 7;
            MinY = 7;
            _maxY = 6;
        }
    }
}
