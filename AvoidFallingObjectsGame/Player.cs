using GDIDrawer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvoidFallingObjectsGame
{
    internal class Player
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
            get {
                return _x;
            }
            set
            { //validation 
                if(value >= 0)
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
        {  // Read only property 
            get
            {
                return _speed;
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

        // Calculated Read Only Property

        public string Description
        {  // Read only 
            get
            {
                return $"Player at {_x}, {_y} ";
            }
        }

        // CTOR
        // Default CTOR
        public Player()
        {
            _x = 300;
            _y = 450;
            _width= 100;
            _height= 40;
            _speed = 10;
            _color = Color.SkyBlue;

        }

        // Custom CTOR
        public Player(int x, int y, int width, int height, Color color, int speed)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
            _speed = speed;
            _color = color;

        }

        // Methods

        public void DrawPlayer(CDrawer c)
        {
            c.AddRectangle(_x, _y, _width, _height, _color);
        }

        public void MoveLeft()
        { 
            _x = _x - _speed;

            if(_x< 0)  // Left wall found
            {
                _x= 0;
            }
        }

        public void MoveRight()
        {
            _x = _x + _speed;

            if(_x + _width > 600)  // Right Wall found
                _x = 600-_width;
        }
    }
}
