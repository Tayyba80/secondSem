using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MyGame.gameLogics
{
    internal class bullet: GameObject
    {
       private GameObjectType type = GameObjectType.NONE;
        public bullet(System.Drawing.Image img, GameCell start):base(GameObjectType.Bullet,img)
        {
            this.CurrentCell = start;
        }
        public bullet(GameCell start,System.Drawing.Image img) : base(GameObjectType.BulletP, img)
        {
            this.CurrentCell = start;
        }
        public  GameCell moveBulet(GameDirections direction,ProgressBar pc)
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

            if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.ENEMY )
            {
                currentCell.setGameObject(GameWork.getBlankGameObject());

            }
            if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
            {
                currentCell.setGameObject(GameWork.getBlankGameObject());
                pc.Value -= 2;
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
                currentCell.setGameObject(GameWork.getBlankGameObject());
            }
            
            return nextCell;
        }
    }
}
