using EZInput;
using MyGame.gameLogics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame
{
    public partial class round2 : Form
    {
        PlayerRobot pacman;
        horizontal Hghost;
        vertical Vghost;
        random Rghost;
        chasing Cghost;
        horizontal terminusG;
        GameGrid grid;
        List<bullet> bullets = new List<bullet>();
        List<pallet> pallets = new List<pallet>();
        int PalletTimmer = 0;
        int count = 0;
        public round2()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        private void round2_Load(object sender, EventArgs e)
        {
            grid = new GameGrid("maze.txt", 28, 48);
            Image pacManImage = GameWork.getGameObjectImage('P');
            GameCell startCell = grid.getCell(8, 10);
            pbPlayer.Value = 50;
            pacman = new PlayerRobot(pacManImage, startCell, pbPlayer, 0);

            ////////////////////////////////////////////////////////////////////////////////

            Image HghostImg = GameWork.getGameObjectImage('H');
            GameCell startCellH = grid.getCell(15, 10);
            pbScorpious.Value = 40;
            Hghost = new horizontal(HghostImg, startCellH, pbScorpious, 0, grid);

            Image VghostImg = GameWork.getGameObjectImage('V');
            GameCell startCellV = grid.getCell(16, 38);
            pbSniper.Value = 40;
            Vghost = new vertical(VghostImg, startCellV, pbSniper, 0, grid);

            Image RghostImg = GameWork.getGameObjectImage('R');
            GameCell startCellR = grid.getCell(12, 32);
            pbMech.Value = 50;
            Rghost = new random(RghostImg, startCellR, pbMech, 0, grid);

            Image CghostImg = GameWork.getGameObjectImage('C');
            GameCell startCellC = grid.getCell(19, 25);
            pbRavan.Value = 10;
            Cghost = new chasing(CghostImg, startCellC, pacman, pbRavan, grid);

            Image hgi = GameWork.getGameObjectImage('T');
            GameCell HGS = grid.getCell(23, 10);
            pbterminus.Value = 40;
            terminusG = new horizontal(hgi, HGS, pbterminus, 0, grid);

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
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbPlayer.Value > 0)
            {
                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    pacman.move(GameDirections.Left);
                }
                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    pacman.move(GameDirections.Right);
                }
                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    pacman.move(GameDirections.Up);
                }
                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    pacman.move(GameDirections.Down);
                }
                if (Keyboard.IsKeyPressed(Key.B))
                {
                    Image bulletP = GameWork.getGameObjectImage('b');
                    int x = pacman.CurrentCell.X;
                    int y = pacman.CurrentCell.Y + 1;
                    GameCell bullStart = grid.getCell(x, y);
                    if (bullStart.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        bullet bullP = new bullet(bullStart, bulletP);
                        bullets.Add(bullP);
                    }
                }
            }
            foreach (bullet bullet in bullets)
            {
                bullet.moveBulet(GameDirections.Right, pbPlayer);
            }

            lblScore.Text = "Score:" + pacman.Score.ToString();
            if (pbRavan.Value > 0)
            {
                Cghost.move(pacman);
            }
            if (pbMech.Value > 0)
            {
                Rghost.move(pacman);
                Rghost.generateBullet();
            }
            if (pbScorpious.Value > 0)
            {
                Hghost.move(pacman);
                Hghost.generateBullet();

            }
            if (pbSniper.Value > 0)
            {
                Vghost.move(pacman);
                Vghost.generateBullet();

            }
            if (pbterminus.Value > 0)
            {
                terminusG.move(pacman);
                terminusG.generateBullet();

            }
            foreach (bullet bullet in bulletDL.EnemyBullets)
            {
                bullet.moveBulet(GameDirections.Right, pbPlayer);
            }
            if (pbPlayer.Value <= 0 && (pbMech.Value > 0 || pbRavan.Value > 0 || pbScorpious.Value > 0 || pbSniper.Value > 0 || pbterminus.Value > 0))
            {
                timer1.Stop();
                loseGame obj = new loseGame();
                obj.Show();
            }
            if (pbMech.Value <= 0 && pbRavan.Value <= 0 && pbScorpious.Value <= 0 && pbSniper.Value <= 0 && pbterminus.Value <= 0)
            {
                timer1.Stop();
                Win obj = new Win();
                obj.Show();
            }

            if (PalletTimmer == 20)
            {
                if (count <= 10)
                {
                    Random rand = new Random();
                    int x = rand.Next(1, 28 - 1);
                    int y = rand.Next(1, 48 - 1);
                    Image palletE = GameWork.getGameObjectImage('.');
                    GameCell palletxy = grid.getCell(x, y);
                    if (palletxy.CurrentGameObject.GameObjectType == GameObjectType.NONE)
                    {
                        pallet p = new pallet(palletE, palletxy);
                        pallets.Add(p);
                        count++;
                    }
                }
                PalletTimmer = 0;
            }
            PalletTimmer++;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }

}
