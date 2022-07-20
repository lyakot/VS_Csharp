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

        private Graphics dc;
        private BufferedGraphics backBuffer;

        public GameWorld(Rectangle displayRectangle, Graphics graphics)
        {


            this.worldSize = displayRectangle.Size;
            
            backgroundColor = ColorTranslator.FromHtml("#000c41");
            this.backBuffer = BufferedGraphicsManager.Current.Allocate(graphics, displayRectangle);
            this.dc = backBuffer.Graphics;
            //Point position = new Point(DisplayRectangle.Width / 2, DisplayRectangle.Height);

            gameObject = new GameObject(dc, new Point(worldSize.Width / 2, worldSize.Height));
           
        }

        public void Update()
        {
            dc.Clear(backgroundColor);
            gameObject.Update();
            backBuffer.Render();
        }


    }
}
