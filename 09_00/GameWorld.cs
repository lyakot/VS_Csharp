using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_00
{
    internal class GameWorld
    {
        private Graphics graphics;
        private Color backgroundColor;
        private Size worldSize;
        private GameObject gameObject;
        private GameObject test;

        public GameWorld(Size worldSize, Graphics graphics)
        {
            this.worldSize = worldSize;
            this.graphics = graphics;
            backgroundColor = ColorTranslator.FromHtml("#000c41");
            //Point position = new Point(DisplayRectangle.Width / 2, DisplayRectangle.Height);

            gameObject = new GameObject(graphics, new Point(worldSize.Width / 2, worldSize.Height));
            test = new GameObject(graphics, new Point(100,100));
        }

        public void Update()
        {
            gameObject.Update(); 
            test.Update();
        }


    }
}
