using System;

namespace Lab1_FileManager.Models
{
    public class CursorEventArgs : EventArgs
    {
        public int Xcoordinate { get; set; }
        public int Ycoordinate { get; set; }
    }
}
