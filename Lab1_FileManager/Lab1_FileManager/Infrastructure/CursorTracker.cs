using Lab1_FileManager.Models;
using System;

namespace Lab1_FileManager.Infrastructure
{
    public class CursorTracker
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int MinY { get; set; }
        public int MaxY { get; set; }

        public delegate void CursorMoveEventHadler(object source, CursorEventArgs e);

        public event CursorMoveEventHadler CursorMoved;

        //private readonly int minY;
        //private readonly int maxY;

        public CursorTracker()
        {
            MinY = 3;
            MaxY = 10;

            X = 0;
            Y = MinY;
        }

        public void TrackCursor(ConsoleKeyInfo consoleKeyInfo)
        {
            if (consoleKeyInfo.Key == ConsoleKey.UpArrow)
            {
                MoveUp();
            }
            if (consoleKeyInfo.Key == ConsoleKey.DownArrow)
            {
                MoveDown();
            }
        }

        private void MoveDown()
        {
            if (Y < MaxY)
            {
                Y++;
                CursorMoved?.Invoke(this, new CursorEventArgs() { Ycoordinate = Y });
            }
        }

        private void MoveUp()
        {
            if (Y > MinY)
            {
                Y--;
                CursorMoved?.Invoke(this, new CursorEventArgs() { Ycoordinate = Y });
            }
        }

    }
}
