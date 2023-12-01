using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.gameLogics
{
    internal class chasing:Enemy
    {
        public GameDirections direction = GameDirections.Up;
        public GameObject player;
        GameGrid grid;
        public chasing(Image img, GameCell start, GameObject player, ProgressBar lives,GameGrid grid) : base(img, start)
        {
            this.CurrentCell = start;
            this.player = player;
            this.Lives = lives;
            this.grid = grid;   
        }
        private ProgressBar lives;

        public ProgressBar Lives { get => lives; set => lives = value; }

        public override GameCell move(PlayerRobot pc)
        {
            setDistanceValue();
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);
            int x = currentCell.X;
            int z = currentCell.Y - 1;
            GameCell left = grid.getCell(x, z);
            if (type == GameObjectType.REWARD)
            {
                this.CurrentCell.setGameObject(GameWork.getPalletGameObject());
            }
            else if (type == GameObjectType.NONE)
            {
                this.CurrentCell.setGameObject(GameWork.getBlankGameObject());
            }
            if (left.CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
            {
                if (pc.Lives.Value <= 15)
                {
                    pc.Lives.Value+=10;
                    this.lives.Value -= 5;
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
                currentCell.setGameObject(GameWork.getPalletGameObject());

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
            if (direction == GameDirections.Up)
            {
                direction = GameDirections.Down;
            }
            else if (direction == GameDirections.Down)
            {
                direction = GameDirections.Up;
            }
        }
        public double calcDistance(GameCell nextCell)
        {
            return Math.Sqrt(Math.Pow((player.CurrentCell.X - nextCell.X), 2) + Math.Pow((player.CurrentCell.Y - nextCell.Y), 2));
        }
        public void setDistanceValue()
        {
            double[] distance = new double[4] { 1000000, 1000000, 1000000, 1000000 };
            if (this.CurrentCell.nextCell(GameDirections.Up).CurrentGameObject.GameObjectType == GameObjectType.NONE ||
                this.CurrentCell.nextCell(GameDirections.Up).CurrentGameObject.GameObjectType == GameObjectType.REWARD)
            {
                distance[0] = calcDistance(this.CurrentCell.nextCell(GameDirections.Up));
            }
            if (this.CurrentCell.nextCell(GameDirections.Down).CurrentGameObject.GameObjectType == GameObjectType.NONE ||
                 this.CurrentCell.nextCell(GameDirections.Down).CurrentGameObject.GameObjectType == GameObjectType.REWARD)
            {
                distance[1] = calcDistance(this.CurrentCell.nextCell(GameDirections.Down));
            }
            if (this.CurrentCell.nextCell(GameDirections.Left).CurrentGameObject.GameObjectType == GameObjectType.NONE ||
                 this.CurrentCell.nextCell(GameDirections.Left).CurrentGameObject.GameObjectType == GameObjectType.REWARD)
            {
                distance[2] = calcDistance(this.CurrentCell.nextCell(GameDirections.Left));
            }
            if (this.CurrentCell.nextCell(GameDirections.Right).CurrentGameObject.GameObjectType == GameObjectType.NONE ||
                 this.CurrentCell.nextCell(GameDirections.Right).CurrentGameObject.GameObjectType == GameObjectType.REWARD)
            {
                distance[3] = calcDistance(this.CurrentCell.nextCell(GameDirections.Right));
            }

            if (distance[0] <= distance[1] && distance[0] <= distance[2] && distance[0] <= distance[3])
            {
                this.direction = GameDirections.Up;

            }
            else if (distance[1] <= distance[0] && distance[1] <= distance[2] && distance[1] <= distance[3])
            {
                this.direction = GameDirections.Down;
            }
            else if (distance[2] <= distance[0] && distance[2] <= distance[1] && distance[2] <= distance[3])
            {
                this.direction = GameDirections.Left;
            }
            else
            {
                this.direction = GameDirections.Right;
            }

        }
    }
}
