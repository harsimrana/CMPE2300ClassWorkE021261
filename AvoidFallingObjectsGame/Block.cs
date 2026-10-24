using GDIDrawer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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


        //STATIC Members
        private static int _blockCount;
         static Random _rand;

         static int _canvasWidth;
         static int _canvasHeight;


        //PROPERTIES

        public static int BlockCount
        { 
            get { return _blockCount; }

            // Read only property
        }

        public static int CanvasWidth
        { 
            get { return _canvasWidth; }
            set {  
                if(value > 100 && value <= 1000)
                    _canvasWidth = value; 
            }

        }

        public static int CanvasHeight
        {
            get { return _canvasHeight; }
            set
            {
                if (value > 100 && value <= 1000)
                    _canvasHeight = value;
            }

        }


        // CTOR
        // Default CTOR
        //public Block()
        //{
        //    _x = 100;
        //    _y = 20;
        //    _width = 50;
        //    _height = 30;
        //    _speed = 5;
        //    _color = Color.Red;


        //}

        // Custom CTOR
        public Block(int x, int y, int width, int height, Color color, int speed)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
            _speed = speed;
            _color = color;

            _blockCount++;

        }

        // CTOR Chaining 
        public Block():this(100,20,50,30,Color.Red, 5)
        {

        } 

        // STATIC CTOR
        static Block()
        {
            _blockCount = 0;
            _canvasHeight = 500;
            _canvasWidth = 600;
            _rand= new Random();

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


        // Static Methods
        public static int GetBlockCount()
        {
            return _blockCount;
        }

        public static int RandomIntValue(int min, int max)
        {
            return _rand.Next(min, max + 1);
        }

        public override string ToString()
        {
            return $" Block XY {X} : {Y} : {Color} : {Speed}";
        }

    }
}
