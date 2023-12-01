using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPackman.GameLogic
{

    internal class ChasingG : Enemy
    {
        public GameDirection direction = GameDirection.Up;
        public GameObject player;
        public ChasingG(Image img, GameCell start, GameObject player, int lives) : base(img, start)
        {
            this.CurrentCell = start;
            this.player = player;
            this.Lives = lives;
        }
        private int lives;

        public int Lives { get => lives; set => lives = value; }

        public override GameCell move(Player pc)
        {
            setDistanceValue();
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
            if (currentCell != nextCell && nextCell.CurrentGameObject.GameObjectType == GameObjectType.REWARD)
            {
                currentCell.setGameObject(Game.getPalletGameObject());

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
        public double calcDistance(GameCell nextCell)
        {
            return Math.Sqrt(Math.Pow((player.CurrentCell.X - nextCell.X), 2) + Math.Pow((player.CurrentCell.Y - nextCell.Y), 2));
        }
        public void setDistanceValue()
        {
            double[] distance = new double[4] { 1000000, 1000000, 1000000, 1000000 };
            if (this.CurrentCell.nextCell(GameDirection.Up).CurrentGameObject.GameObjectType == GameObjectType.NONE ||
                this.CurrentCell.nextCell(GameDirection.Up).CurrentGameObject.GameObjectType == GameObjectType.REWARD)
            {
                distance[0] = calcDistance(this.CurrentCell.nextCell(GameDirection.Up));
            }
            if (this.CurrentCell.nextCell(GameDirection.Down).CurrentGameObject.GameObjectType == GameObjectType.NONE ||
                 this.CurrentCell.nextCell(GameDirection.Down).CurrentGameObject.GameObjectType == GameObjectType.REWARD)
            {
                distance[1] = calcDistance(this.CurrentCell.nextCell(GameDirection.Down));
            }
            if (this.CurrentCell.nextCell(GameDirection.Left).CurrentGameObject.GameObjectType == GameObjectType.NONE ||
                 this.CurrentCell.nextCell(GameDirection.Left).CurrentGameObject.GameObjectType == GameObjectType.REWARD)
            {
                distance[2] = calcDistance(this.CurrentCell.nextCell(GameDirection.Left));
            }
            if (this.CurrentCell.nextCell(GameDirection.Right).CurrentGameObject.GameObjectType == GameObjectType.NONE ||
                 this.CurrentCell.nextCell(GameDirection.Right).CurrentGameObject.GameObjectType == GameObjectType.REWARD)
            {
                distance[3] = calcDistance(this.CurrentCell.nextCell(GameDirection.Right));
            }

            if (distance[0] <= distance[1] && distance[0] <= distance[2] && distance[0] <= distance[3])
            {
                this.direction = GameDirection.Up;

            }
            else if (distance[1] <= distance[0] && distance[1] <= distance[2] && distance[1] <= distance[3])
            {
                this.direction = GameDirection.Down;
            }
            else if (distance[2] <= distance[0] && distance[2] <= distance[1] && distance[2] <= distance[3])
            {
                this.direction = GameDirection.Left;
            }
            else
            {
                this.direction = GameDirection.Right;
            }

        }
    }
        
}
