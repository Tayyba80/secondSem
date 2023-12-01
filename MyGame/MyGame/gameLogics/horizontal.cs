using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.gameLogics
{
    internal class horizontal:Enemy
    {
        public GameDirections direction = GameDirections.Left;
        GameGrid grid;
        public horizontal(Image img, GameCell start, ProgressBar Elive,int bullTime, GameGrid grid) : base(img, start)
        {
            this.CurrentCell = start;
            this.Elive = Elive;
            this.bullTime = bullTime;
            this.grid = grid;
        }
        private ProgressBar Elive;
        private int bullTime;
        
        public int BullTime{ get => bullTime; set => bullTime = value; }

        public void generateBullet()
        {
            if (BullTime == 4)
            {
                Image bulletP = GameWork.getGameObjectImage('b');
                int x = CurrentCell.X;
                int y = CurrentCell.Y + 1;
                GameCell bullStart = grid.getCell(x, y);
                if (bullStart.CurrentGameObject.GameObjectType != GameObjectType.WALL)
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
                    pc.Lives.Value -=2;
                }
                if (pc.Score >= 25)
                {
                    currentCell.setGameObject(GameWork.getBlankGameObject());
                    pc.Score = pc.Score - 25;
                    this.Elive.Value-=2;
                }
            }
            if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.BulletP)
            {
                this.Elive.Value -= 5;
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
            if (direction == GameDirections.Left)
            {
                direction = GameDirections.Right;
            }
            else if (direction == GameDirections.Right)
            {
                direction = GameDirections.Left;
            }
        }

    }
}
