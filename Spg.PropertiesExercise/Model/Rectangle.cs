using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.PropertiesExercise.Model
{
    public class Rectangle
    {
		public int Width
		{
			get { return _width; }
			set 
			{
				_width = (value >= 0) ? value : throw new ArgumentException("");
			}
		}
        private int _width;

        public int Height
        {
            get { return _height; }
            set
            {
                _height = (value >= 0) ? value : throw new ArgumentException("");
            }
        }
        private int _height;

        public int Area 
            => Width * Height;

        public void Scale(int factor)
        {
            Width *= factor;
            Height *= factor;
        }
    }
}
