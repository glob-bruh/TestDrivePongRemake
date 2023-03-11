using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphics2 {
    internal class Scoreboard {

        static public Form1 mainForm;
        private int _x;
        private int _y;
        private int _width;
        private int _height;
        private Pen _penNull;
        private Pen _penDraw;

        public Scoreboard(int x, int y, int wid, int hgt) {
            _x = x;
            _y = y;
            _width = wid;
            _height = hgt;
            _penNull = new Pen(Color.FromArgb(31, 31, 31), 3);
            _penDraw = new Pen(Color.FromArgb(128, 128, 128), 3);
        }

        public int X { get { return _x; } }
        public int Y { get { return _y; } }
        public int Width { get { return _width; } }
        public int Height { get { return _height; } }

        public void Draw(Graphics gr, int score) {

            // COLORS: 
            // null - rgb(31, 31, 31)
            // drawd - rgb(128, 128, 128)

            // null draw
            gr.DrawLine(_penNull, X, Y, X, Y + (Height / 2));
            gr.DrawLine(_penNull, X, Y + (Height / 2), X, Y + Height); // left vert

            gr.DrawLine(_penNull, X + Width, Y, X + Width, Y + (Height / 2));
            gr.DrawLine(_penNull, X + Width, Y + (Height / 2), X + Width, Y + Height); // right vert

            gr.DrawLine(_penNull, X, Y, X + Width, Y);
            gr.DrawLine(_penNull, X, Y + Height / 2, X + Width, Y + Height / 2); // horiz
            gr.DrawLine(_penNull, X, Y + Height, X + Width, Y + Height);

            // ==============
            // SCORE DRAWS:
            // All sections go from top down
            // ==============

            // Horizontal
            switch(score) {
                case 0:
                case 2:
                case 3:
                case 5:
                case 7:
                case 8:
                case 9:
                    gr.DrawLine(_penDraw, X, Y, X + Width, Y);
                    break;
            }
            switch(score) {
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 8:
                case 9:
                    gr.DrawLine(_penDraw, X, Y + Height / 2, X + Width, Y + Height / 2);
                    break;
            }
            switch(score) {
                case 0:
                case 2:
                case 3:
                case 5:
                case 6:
                case 8:
                    gr.DrawLine(_penDraw, X, Y + Height, X + Width, Y + Height);
                    break;
            }

            // Left Vert
            switch(score) { // top
                case 0:
                case 4:
                case 5:
                case 6:
                case 8:
                case 9:
                    gr.DrawLine(_penDraw, X, Y, X, Y + (Height / 2));
                    break;
            }
            switch (score) { // bottom
                case 0:
                case 2:
                case 6:
                case 8:
                    gr.DrawLine(_penDraw, X, Y + (Height / 2), X, Y + Height);
                    break;
            }

            // Right Vert
            switch (score) { // top
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 7:
                case 8:
                case 9:
                    gr.DrawLine(_penDraw, X + Width, Y, X + Width, Y + (Height / 2));
                    break;
            }
            switch (score) { // bottom
                case 0:
                case 1:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    gr.DrawLine(_penDraw, X + Width, Y + (Height / 2), X + Width, Y + Height);
                    break;
            }
            // ============== 

        }
    }
}
