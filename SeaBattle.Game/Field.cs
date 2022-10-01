using System;

namespace SeaBattle.Game
{
    public class Field
    {
        private byte[,] cells, SetCell;
        public byte GetCellsValue(byte x, byte y)
        {
            return cells[x, y];
        }
        public bool SetCellsValue(byte x, byte y, byte z)
        {
            if (cells[x, y] != 0)
            {
                return false;
            }
            cells[x, y] = z;
            return true;
        }
        public Field(int sizex) : this(sizex, sizex)
        {

        }
        public Field(int sizex, int sizey)
        {
            cells = new byte[sizex, sizey];

        }
        public Field() : this(10)
        {

        }
        public bool CrashValue(byte x, byte y)
        {
            if (cells[x, y] == 0)
            {
                return false;
            }
            return true;
        }
    }
}