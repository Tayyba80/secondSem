using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.gameLogics
{
    internal class PlayerRobot : GameObject
    {
        public PlayerRobot(Image image, GameCell startCell, ProgressBar live, int score) : base(GameObjectType.PLAYER, image)
        {
            this.CurrentCell = startCell;
            this.Lives = live;
            this.Score = score;
        }
        private ProgressBar lives;
        private int score;

        public ProgressBar Lives { get => lives; set => lives = value; }
        public int Score { get => score; set => score = value; }

        public GameCell move(GameDirections direction)
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);

            if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.REWARD)
            {
                this.score = this.score + 20;
            }

            this.CurrentCell = nextCell;
            if (currentCell != nextCell)
            {
                currentCell.setGameObject(GameWork.getBlankGameObject());

            }
            return nextCell;
        }
    }
}

