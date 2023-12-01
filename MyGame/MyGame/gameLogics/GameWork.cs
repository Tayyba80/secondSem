using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.gameLogics
{
    public class GameWork
    {
        public static GameObject getBlankGameObject()
        {
            GameObject blankGameObject = new GameObject(GameObjectType.NONE, MyGame.Properties.Resources.backBox);
            return blankGameObject;
        }
        public static GameObject getPalletGameObject()
        {
            GameObject palletGameObject = new GameObject(GameObjectType.REWARD, MyGame.Properties.Resources.battery);
            return palletGameObject;
        }
        public static Image getGameObjectImage(char displayCharacter)
        {
            Image img = MyGame.Properties.Resources.backBox;
            if (displayCharacter == '|' || displayCharacter == '%')
            {
                img = MyGame.Properties.Resources.vertical;
            }

            if (displayCharacter == '#')
            {
                img = MyGame.Properties.Resources.horizontal;
            }

            if (displayCharacter == '.')
            {
                img = MyGame.Properties.Resources.battery;
            }
            if (displayCharacter == 'P' || displayCharacter == 'p')
            {
                img = MyGame.Properties.Resources.players;
            }
            if (displayCharacter == 'R' || displayCharacter == 'r')
            {
                img = MyGame.Properties.Resources.BigShotRobos1;//R
            }
            if (displayCharacter == 'H' || displayCharacter == 'h') //H
            {
                img = MyGame.Properties.Resources.legFourRobo;
            }
            if (displayCharacter == 'V' || displayCharacter == 'v')
            {
                img = MyGame.Properties.Resources.grayRobos;//v
            }
            if (displayCharacter == 'C' || displayCharacter == 'c')
            {
                img = MyGame.Properties.Resources.chasingRobos;//C
            }
            if (displayCharacter == 'B' || displayCharacter == 'b')
            {
                img = MyGame.Properties.Resources.bullett;//C
            }
            if (displayCharacter == 'F' || displayCharacter == 'f')
            {
                img = MyGame.Properties.Resources.fire;//C
            }
            if (displayCharacter == 'T' || displayCharacter == 't')
            {
                img = MyGame.Properties.Resources.terminus;//C
            }

            return img;
        }
    }
}

