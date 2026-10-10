using GDIDrawer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvoidFallingObjectsGame
{
    internal class Block
    {
        // Data Members
        private int _x;

        private int _y;
        private int _width;
        private int _height;
        private Color _color;
        private int _speed;


        // Properties
        public int X
        {
            get
            {
                return _x;
            }
            set
            { //validation 
                if (value >= 0)
                    _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
            set
            { //validation 
                if (value >= 0)
                    _y = value;
            }
        }

        public int Width
        {
            get
            {
                return _width;
            }
            set
            { //validation 
                if (value >= 0)
                    _width = value;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            { //validation 
                if (value >= 0)
                    _height = value;
            }
        }

        public int Speed
        {  
            get
            {
                return _speed;
            }
            set
            {
                if (value > 0)
                { 
                    _speed = value;
                }
            }

        }

        public Color Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        // CTOR
        // Default CTOR
        public Block()
        {
            _x = 100;
            _y = 20;
            _width = 50;
            _height = 30;
            _speed = 5;
            _color = Color.Red;

        }

        // Custom CTOR
        public Block(int x, int y, int width, int height, Color color, int speed)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
            _speed = speed;
            _color = color;

        }

        // Methods

        public void DrawBlock(CDrawer c)
        {
            c.AddRectangle(_x, _y, _width, _height, _color);
        }

        public void MoveDown()
        {
            // Moving the block in down direction
            _y = _y + _speed;
        }

        public void Reset()
        {
            _y = 0;
        }
    }
}
