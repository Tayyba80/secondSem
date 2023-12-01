using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.gameLogics
{
    internal class pallet: GameObject
    {
        private GameObjectType type = GameObjectType.NONE;
        public pallet(System.Drawing.Image img, GameCell start) : base(GameObjectType.REWARD, img)
        {
            this.CurrentCell = start;
            
        }
        

       
    }
}
