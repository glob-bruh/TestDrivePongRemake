using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphics2 {
    internal class Ball
    {
        static public Form1 mainForm;

        // CONST
        private const int YBASESPEED = 20;

        // private fields
        private int _x;
        private int _y;
        private int _width = 10;
        private int _height = 10;
        private int _xSpeed = -10; // ball speed
        private int _ySpeed = 0;
        private Color _color = Color.White;
        private Brush _brush;

        // constructor
        public Ball(int x,int y)
        {
            _x = x;
            _y = y;
            _brush = new SolidBrush(_color);

        }
        //public properties
        public int X { get { return _x; } }
        public int Y { get { return _y; } }
        public int Width { get { return _width; } }
        public int Height { get { return _height; } }

        // public methods
        public void Draw(Graphics gr)
        {
            _x += _xSpeed;
            _y += _ySpeed;

            if (_x+_width > mainForm.ClientSize.Width)
                _xSpeed *= -1;

            if (_x <=0)
                _xSpeed *= -1;

            if (_y + _height > 516) // change this to match gray play area
                _ySpeed *= -1;

            if (_y <= 141)
                _ySpeed *= -1;

            gr.FillRectangle(_brush, _x, _y, _width, _height);
        }
        public void Reverse()
        {
            _xSpeed *= -1;
        }

        public void ChangeDirection(double slice) {
            _xSpeed *= -1;
            _ySpeed = Convert.ToInt32(YBASESPEED * slice);
        }

        public void WinReset() {
            if (_y < 156 || _y > 501) {
                _y = 328;
            }
            _x = mainForm.ClientSize.Width / 2; // Y is not reset as this is the behavoiur in the game itself.
            _ySpeed = 0;
        }
    }
}
