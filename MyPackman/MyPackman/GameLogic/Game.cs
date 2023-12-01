using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPackman.GameLogic
{
    internal class Game
    {
        public static GameObject getBlankGameObject()
        {
            GameObject blankGameObject = new GameObject(GameObjectType.NONE, MyPackman.Properties.Resources.simplebox);
            return blankGameObject;
        }
        public static GameObject getPalletGameObject()
        {
            GameObject palletGameObject = new GameObject(GameObjectType.REWARD, MyPackman.Properties.Resources.pallet);
            return palletGameObject;
        }
        public static Image getGameObjectImage(char displayCharacter)
        {
            Image img = MyPackman.Properties.Resources.simplebox;
            if (displayCharacter == '|' || displayCharacter == '%')
            {
                img = MyPackman.Properties.Resources.vertical;
            }

            if (displayCharacter == '#')
            {
                img = MyPackman.Properties.Resources.horizontal;
            }

            if (displayCharacter == '.')
            {
                img = MyPackman.Properties.Resources.pallet;
            }
            if (displayCharacter == 'P' || displayCharacter == 'p')
            {
                img = MyPackman.Properties.Resources.pacman_open;
            }
            if (displayCharacter == 'R' || displayCharacter == 'r')
            {
                img = MyPackman.Properties.Resources.ghost_pink;//R
            }
            if (displayCharacter == 'H' || displayCharacter == 'h') //H
            {
                img = MyPackman.Properties.Resources.ghost_blue;
            }
            if (displayCharacter == 'V' || displayCharacter == 'v')
            {
                img = MyPackman.Properties.Resources.ghost_orange;//v
            }
            if (displayCharacter == 'C' || displayCharacter == 'c')
            {
                img = MyPackman.Properties.Resources.ghost_red;//C
            }

            return img;
        }
    }
}
