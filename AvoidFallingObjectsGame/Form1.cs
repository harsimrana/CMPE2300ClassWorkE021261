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

        // I don't need one block, I need a lot of them
        private Block _block;
        
        List<Block> listOfBlock = new List<Block>();

        CDrawer _gameBoard = null;

        public Form1()
        {
            InitializeComponent();
            // _gameBoard = new CDrawer(600, 500);

            _gameBoard = new CDrawer(Block.CanvasWidth, Block.CanvasHeight);

            KeyPreview = true;

            // Creating my player object
            _player = new Player();

            // Block object now
            //_block = new Block();
            // Create all my block
            
            //Instead your own Randow object, use the one provided by the class
            //Random rand = new Random();


            for (int i = 1; i <= 10; ++i)
            { 
                _block = new Block(i * 50, 20, 40, 20, Color.Yellow, Block.RandomIntValue(5,10));
                
                listOfBlock.Add(_block);

                _block.DrawBlock(_gameBoard);

                // Update the block count on label
                // using method
                UI_BlockCountLbl.Text = Block.GetBlockCount().ToString();
                // Using Property
                UI_BlockCountLbl.Text = $"Block Count : {Block.BlockCount}";
            }

            

            // draw my player on this gameboard please
            _player.DrawPlayer(_gameBoard);

            //_block.DrawBlock(_gameBoard);

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
            // Clearing the game board
            _gameBoard.Clear();

            // Displaying player and block 
            _player.DrawPlayer(_gameBoard);
            //_block.DrawBlock( _gameBoard);

            foreach (Block b in listOfBlock)
            { 
                b.DrawBlock(_gameBoard);
            }
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            foreach (Block b in listOfBlock)
            {
                b.MoveDown();

                // Collision Detection logic
                if (b.Y + b.Height == 450 && (b.X >= _player.X && b.X <= _player.X + _player.Width)) // There is an issue with this logic- FIX it
                {
                    timerGame.Enabled = false;

                    MessageBox.Show("Game Ends There is a collision");
                 
                }

                // If it is going past the lower end, reset it
                if (b.Y > 500)
                {
                    b.Reset();
                    _player.ScoreBoard++;
                    UI_PlayerScore_Lbl.Text = $"Player_Score : {_player.ScoreBoard}";
                }
                Console.WriteLine(b.ToString());  

            }
            RedrawGameBoard();
        }
    }
}
