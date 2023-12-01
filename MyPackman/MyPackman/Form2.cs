using MyPackman.GameLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPackman
{
    public partial class Form2 : Form
    {
        Player pacman;
        Horizontal Hghost;
        Vertical Vghost;
        RandomG Rghost;
        ChasingG Cghost;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            Form1 frm = new Form1();
            frm.Show();
            GameGrid grid = new GameGrid("maze.txt", 31, 54);
            Image pacManImage = Game.getGameObjectImage('P');
            GameCell startCell = grid.getCell(8, 10);
            pacman = new Player(pacManImage, startCell, 4, 0);

            Image HghostImg = Game.getGameObjectImage('H');
            GameCell startCellH = grid.getCell(10, 5);
            Hghost = new Horizontal(HghostImg, startCellH, 1);

            Image VghostImg = Game.getGameObjectImage('V');
            GameCell startCellV = grid.getCell(25, 40);
            Vghost = new Vertical(VghostImg, startCellV, 1);

            Image RghostImg = Game.getGameObjectImage('R');
            GameCell startCellR = grid.getCell(12, 32);
            Rghost = new RandomG(RghostImg, startCellR, 1);

            Image CghostImg = Game.getGameObjectImage('C');
            GameCell startCellC = grid.getCell(19, 25);
            Cghost = new ChasingG(CghostImg, startCellC, pacman, 1);

            printMaze(grid);
        }


        void printMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.Rows; x++)
            {

                for (int y = 0; y < grid.Cols; y++)
                {
                    GameCell cell = grid.getCell(x, y);
                    this.Controls.Add(cell.PictureBox);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
