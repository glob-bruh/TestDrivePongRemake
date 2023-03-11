using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphics2
{
    internal class Paddle
    {
        static public Form1 mainForm;

        // private fields
        private int _x;
        private int _y;
        private int _width = 10;
        private int _height = 90;
        //private int _xSpeed = 15;
        private int _ySpeed = 20;
        private Color _color = Color.White;
        private Brush _brush;

        // constructor
        public Paddle(int x, int y)
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
            //_x += _xSpeed;
            //_y += _ySpeed;

            //if (_x + _width > mainForm.ClientSize.Width)
            //    _xSpeed *= -1;

            //if (_x <= 0)
            //    _xSpeed *= -1;

            //if (_y + _height > mainForm.ClientSize.Height)
            //    _ySpeed *= -1;

            //if (_y <= 0)
            //    _ySpeed *= -1;


            gr.FillRectangle(_brush, _x, _y, _width, _height);
        }

        public void MoveUp() {
            _y -= _ySpeed;
            if(_y <141) _y = 141;
        }
        public void MoveDown() {
            _y += _ySpeed;
            if (_y + _height > 516) {
                _y = 516 - _height;
            }
        }
    }
}
