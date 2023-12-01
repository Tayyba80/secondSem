using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPackman.GameLogic
{
    internal class Horizontal:Enemy
    {
        public GameDirection direction = GameDirection.Left;
        public Horizontal(Image img, GameCell start, int ELive) : base(img, start)
        {
            this.CurrentCell = start;
            this.Elive = ELive;
        }
        private int Elive;

        public int Elive1 { get => Elive; set => Elive = value; }

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
                    this.Elive--;
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
        }
    }
}
