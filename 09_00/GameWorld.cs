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
       public static Graphics Graphics { get; private set; }
        public static Size WorldSize { get; private set; }

        private GameObject gameObject;

        
        private BufferedGraphics backBuffer;

        public GameWorld(Rectangle displayRectangle, Graphics graphics)
        {


            WorldSize = displayRectangle.Size;
            
            backgroundColor = ColorTranslator.FromHtml("#000c41");
            this.backBuffer = BufferedGraphicsManager.Current.Allocate(graphics, displayRectangle);
            Graphics = backBuffer.Graphics;
            //Point position = new Point(DisplayRectangle.Width / 2, DisplayRectangle.Height);
            Initialize();
            
        }


        private void Initialize()
        {

            gameObject = new GameObject();
            Player p = new Player();
            SpriteRenderer sr = new SpriteRenderer();

            gameObject.AddComponent(p);
            gameObject.AddComponent(sr);

        Awake();
        Start();
        }
        private void Awake()
        {
            gameObject.Awake();
            
        }

        private void Start()
        {

        }

        public void Update()
        {
            MyTime.CalaDeltaTime();
            Graphics.Clear(backgroundColor);
            gameObject.Update();
            backBuffer.Render();
        }


    }
}
