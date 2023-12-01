using Microsoft.VisualBasic.Devices;
using MyPackman.GameLogic;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using EZInput;
using System.Drawing;
using System.Windows.Forms;


namespace MyPackman
{
    public partial class Form1 : Form
    {
        Player pacman;
        Horizontal Hghost;
        Vertical Vghost;
        RandomG Rghost;
        ChasingG Cghost;
        Form2 restart = new Form2();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
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
        private void gameLoop_Tick_1(object sender, EventArgs e)
        {

            if (EZInput.Keyboard.IsKeyPressed(Key.LeftArrow))
            {

                pacman.move(GameDirection.Left);
            }
            if (EZInput.Keyboard.IsKeyPressed(Key.RightArrow))
            {
                pacman.move(GameDirection.Right);
            }
            if (EZInput.Keyboard.IsKeyPressed(Key.UpArrow))
            {
                pacman.move(GameDirection.Up);
            }
            if (EZInput.Keyboard.IsKeyPressed(Key.DownArrow))
            {
                pacman.move(GameDirection.Down);
            }
            lblLives.Text = "Lives:" + pacman.Lives.ToString();
            if (pacman.Lives <= 0)
            {
                gameLoop.Enabled = false;
                this.Hide();
                restart.Show();
            }
            lblScore.Text = "Score:" + pacman.Score.ToString();
            // lableScore.Text = "Hlives:" + Hghost.Elive1.ToString();
            if (Vghost.Lives == 1)
            {
                Vghost.move(pacman);
            }
            if (Hghost.Elive1 == 1)
            {
                Hghost.move(pacman);
            }
            if (Rghost.Lives == 1)
            {
                Rghost.move(pacman);
            }
            if (Rghost.Lives == 1)
            {
                Cghost.move(pacman);
            }
        }


    }
}