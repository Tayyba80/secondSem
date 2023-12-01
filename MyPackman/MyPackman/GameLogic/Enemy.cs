using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPackman.GameLogic
{
    abstract class Enemy : GameObject
    {
        protected GameObjectType type = GameObjectType.NONE;
        public abstract GameCell move(Player pc);
        public abstract void checkDir();
        public Enemy(Image img, GameCell startCell) : base(GameObjectType.ENEMY, img)
        {
            this.CurrentCell = startCell;
        }
    }
}
