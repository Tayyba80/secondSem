using System.Numerics;
using System;
using MyGame.gameLogics;
using EZInput;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace MyGame
{
    public partial class Form1 : Form
    {
        PlayerRobot pacman;
        horizontal Hghost;
        vertical Vghost;
        random Rghost;
        chasing Cghost;
        GameGrid grid;
        List<bullet> bullets = new List<bullet>();
        List<bullet> bullets2 = new List<bullet>();
        List<pallet> pallets = new List<pallet>();
        int PalletTimmer = 0;
        int count = 0;

        public Form1()
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
        private void Form1_Load(object sender, EventArgs e)
        {
            grid = new GameGrid("maze2.txt", 28, 48);
            Image pacManImage = GameWork.getGameObjectImage('P');
            GameCell startCell = grid.getCell(8, 10);
            pbPlayer.Value = 50;
            pacman = new PlayerRobot(pacManImage, startCell, pbPlayer, 0);


            ////////////////////////////////////////////////////////////////////////////////

            Image HghostImg = GameWork.getGameObjectImage('H');
            GameCell startCellH = grid.getCell(10, 10);
            pbScorpious.Value = 40;
            Hghost = new horizontal(HghostImg, startCellH, pbScorpious, 0, grid);

            Image VghostImg = GameWork.getGameObjectImage('V');
            GameCell startCellV = grid.getCell(25, 40);
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
                if (Keyboard.IsKeyPressed(Key.V))
                {
                    Image bulletP = GameWork.getGameObjectImage('b');
                    int x = pacman.CurrentCell.X;
                    int y = pacman.CurrentCell.Y - 1;
                    GameCell bullStart = grid.getCell(x, y);
                    if (bullStart.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        bullet bullP = new bullet(bullStart, bulletP);
                        bullets2.Add(bullP);
                    }
                }
            }
            foreach (bullet bullet in bullets)
            {
                bullet.moveBulet(GameDirections.Right, pbPlayer);
            }
            foreach (bullet bullet in bullets2)
            {
                bullet.moveBulet(GameDirections.Left, pbPlayer);
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
            foreach (bullet bullet in bulletDL.EnemyBullets)
            {
                bullet.moveBulet(GameDirections.Right, pbPlayer);
            }
            if (pbPlayer.Value <= 0 && (pbMech.Value > 0 || pbRavan.Value > 0 || pbScorpious.Value > 0 || pbSniper.Value > 0))
            {
                timer1.Stop();
                loseGame obj = new loseGame();
                this.Close();
                obj.Show();
            }
            if (pbMech.Value <= 0 && pbRavan.Value <= 0 && pbScorpious.Value <= 0 && pbSniper.Value > 0)
            {
                timer1.Stop();
                Win obj = new Win();
                this.Close();
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