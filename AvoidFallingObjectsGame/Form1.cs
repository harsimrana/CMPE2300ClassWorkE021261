using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace AvoidFallingObjectsGame
{
    public partial class Form1 : Form
    {

        /* Classes: Player, Block
         * 
         * 
         */

        private Player _player;

        CDrawer _gameBoard = null;

        public Form1()
        {
            InitializeComponent();

            KeyPreview = true;

            // Creating my player object
            _player = new Player();

            _gameBoard = new CDrawer(600, 500);

            // draw my player on this gameboard please
            _player.DrawPlayer(_gameBoard);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("Key Down ");

            if (e.KeyCode == Keys.Left)
            {
                Console.WriteLine($"Left arrow key pressed  {_player.X}");
                _player.MoveLeft();

                RedrawGameBoard();
            }

            if (e.KeyCode == Keys.Right)
            {
                _player.MoveRight();
                RedrawGameBoard();
            }
        }

        private void RedrawGameBoard()
        {
            _gameBoard.Clear();
            _player.DrawPlayer(_gameBoard);
        }

    }
}
