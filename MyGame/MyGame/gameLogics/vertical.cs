using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame.gameLogics
{
    internal class vertical:Enemy
    {
        public GameDirections direction = GameDirections.Down;
        GameGrid grid;
        public vertical(Image img, GameCell start, ProgressBar lives,int bullTime,GameGrid grid) : base(img, start)
        {
            this.CurrentCell = start;
            this.lives = lives;
            this.BullTime = bullTime;
            this.grid = grid;
        }
        private ProgressBar lives;
        private int bullTime;
        public int BullTime { get => bullTime; set => bullTime = value; }

        public void generateBullet()
        {
            if (BullTime == 3)
            {
                Image bulletP = GameWork.getGameObjectImage('b');
                int x = CurrentCell.X;
                int y = CurrentCell.Y + 1;
                GameCell bullStart = grid.getCell(x, y);
                if(bullStart.CurrentGameObject.GameObjectType!= GameObjectType.WALL) 
                {
                    bullet bullE = new bullet(bulletP, bullStart);
                    bulletDL.EnemyBullets.Add(bullE);
                }
                    BullTime = 0;
            }
            BullTime++;
        }
        

        public override GameCell move(PlayerRobot pc)
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);
            int x = currentCell.X;
            int z = currentCell.Y - 1;
            GameCell left=grid.getCell(x, z);

            if (type == GameObjectType.REWARD)
            {
                this.CurrentCell.setGameObject(GameWork.getPalletGameObject());
            }
            else if (type == GameObjectType.NONE)
            {
                this.CurrentCell.setGameObject(GameWork.getBlankGameObject());
            }
            if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
            {
                if (pc.Score <= 10)
                {
                    pc.Lives.Value -= 2;
                }
                if (pc.Score >= 25)
                {
                    currentCell.setGameObject(GameWork.getBlankGameObject());
                    pc.Score = pc.Score - 25;
                    this.lives.Value-=2;
                }
            }
            if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.BulletP)
            {
                this.lives.Value -= 5;
            }
           
            else if (left.CurrentGameObject.GameObjectType == GameObjectType.BulletP)
            {
                this.lives.Value -= 5;
            }
            if (currentCell != nextCell && nextCell.CurrentGameObject.GameObjectType == GameObjectType.REWARD)
            {
                type = GameObjectType.REWARD;
            }
            if (currentCell != nextCell && nextCell.CurrentGameObject.GameObjectType == GameObjectType.NONE)
            {
                type = GameObjectType.NONE;
            }

            this.CurrentCell = nextCell;
            if (currentCell == nextCell)
            {
                checkDir();
            }
            return nextCell;
        }
        public override void checkDir()
        {
            if (direction == GameDirections.Up)
            {
                direction = GameDirections.Down;
            }
            else if (direction == GameDirections.Down)
            {
                direction = GameDirections.Up;
            }
        }
    }
}

