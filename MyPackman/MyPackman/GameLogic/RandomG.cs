using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPackman.GameLogic
{
    internal class RandomG:Enemy
    {
        public GameDirection direction;

        public RandomG(Image img, GameCell start, int live) : base(img, start)
        {
            this.CurrentCell = start;
            this.lives = live;

        }
        private int lives;

        public int Lives { get => lives; set => lives = value; }

        public void setGhostDir()
        {
            int dir = randDir();
            if (dir == 0)
            {
                this.direction = GameDirection.Left;
            }
            if (dir == 1)
            {
                this.direction = GameDirection.Right;
            }
            if (dir == 2)
            {
                this.direction = GameDirection.Up;
            }
            if (dir == 3)
            {
                this.direction = GameDirection.Down;
            }
        }
        public override GameCell move(Player pc)
        {
            setGhostDir();
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);
            if (type == GameObjectType.REWARD)
            {
                this.CurrentCell.setGameObject(Game.getPalletGameObject());
            }
            else if (type == GameObjectType.NONE)
            {
                this.CurrentCell.setGameObject(Game.getBlankGameObject());
            }
            if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
            {
                if (pc.Score < 10)
                {
                    pc.Lives--;
                }
                if (pc.Score > 30)
                {
                    currentCell.setGameObject(Game.getBlankGameObject());
                    pc.Score = pc.Score - 30;
                    this.lives--;
                }
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
            if (direction == GameDirection.Left)
            {
                direction = GameDirection.Right;
            }
            else if (direction == GameDirection.Right)
            {
                direction = GameDirection.Left;
            }
            if (direction == GameDirection.Up)
            {
                direction = GameDirection.Down;
            }
            else if (direction == GameDirection.Down)
            {
                direction = GameDirection.Up;
            }
        }
        public int randDir()
        {
            Random r = new Random();
            int value = r.Next(4);
            return value;
        }
    }
}
