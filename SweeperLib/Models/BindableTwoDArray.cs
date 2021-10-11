using System;
using System.Collections.Generic;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace SweeperLib.Models
{
    /// <summary>
    /// This class is a bindable encapsulation of a 2D array.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BindableTwoDArray<T> : ObservableObject
    {
        private readonly T[,] _data;
        
        public int Rows { get; private set; }
        
        public int Cols { get; private set; }

        public List<T> GetNeighbors(int r, int c)
        {
            int lbRow = Math.Max(r - 1, 0);
            int ubRow = Math.Min(r + 1, Rows);
            int lbCol = Math.Max(c - 1, 0);
            int ubCol = Math.Min(c + 1, Cols);

            var lst = new List<T>();
            for (int row = lbRow; row <= ubRow; row++)
                for (int col = lbCol; col <= ubCol; col++)
                    lst.Add(this[row,col]);
            return lst;
        }

        protected BindableTwoDArray()
        {
            _data = new T[0, 0];
        }
        public BindableTwoDArray(T[,] data)
        {
            _data = data;
        }
        public BindableTwoDArray(int size1, int size2)
        {
            _data = new T[size1, size2];
        }
        
        public T this[int c1, int c2]
        {
            get => _data[c1, c2];
            set => SetProperty( ref _data[c1,c2], value, GetStringIndex(c1, c2));
        }

        public string GetStringIndex(int c1, int c2)
        {
            return c1.ToString() + "-" + c2.ToString();
        }

        private void SplitIndex(string index, out int c1, out int c2)
        {
            var parts = index.Split('-');
            if (parts.Length != 2)
                throw new ArgumentException("The provided index is not valid");

            c1 = int.Parse(parts[0]);
            c2 = int.Parse(parts[1]);
        }

        public T this[string index]
        {
            get
            {
                int c1, c2;
                SplitIndex(index, out c1, out c2);
                return _data[c1, c2]; 
            }
            set
            {
                SplitIndex(index, out var c1, out var c2);
                SetProperty(ref _data[c1, c2], value, GetStringIndex(c1,c2));
            }
        }
        
        public static implicit operator T[,](BindableTwoDArray<T> a)
        {
            return a._data;
        }
    }
}