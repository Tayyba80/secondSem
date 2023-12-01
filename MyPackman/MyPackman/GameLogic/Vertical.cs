using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPackman.GameLogic
{
    internal class Vertical:Enemy
    {
        public GameDirection direction = GameDirection.Down;
        public Vertical(Image img, GameCell start, int lives) : base(img, start)
        {
            this.CurrentCell = start;
            this.lives = lives;
        }
        private int lives;

        public int Lives { get => lives; set => lives = value; }

        public override GameCell move(Player pc)
        {
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
           /* if (currentCell != nextCell)
            {
                currentCell.setGameObject(Game.getBlankGameObject());

            }*/

            return nextCell;
        }
        public override void checkDir()
        {
            if (direction == GameDirection.Up)
            {
                direction = GameDirection.Down;
            }
            else if (direction == GameDirection.Down)
            {
                direction = GameDirection.Up;
            }
        }
    }
}
