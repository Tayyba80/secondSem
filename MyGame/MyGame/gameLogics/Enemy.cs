using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.gameLogics
{
    abstract class Enemy : GameObject
    {
        protected GameObjectType type = GameObjectType.NONE;
        public abstract GameCell move(PlayerRobot pc);
        public abstract void checkDir();
        public Enemy(Image img, GameCell startCell) : base(GameObjectType.ENEMY, img)
        {
            this.CurrentCell = startCell;
            //bulletE=new List<bullet>(); 
        }
    }
}
