using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace _09_00
{
    internal class GameObject
    {

        private Image sprite;

        private Graphics graphics;

        private Point position;

        public GameObject(Graphics graphics, Point position)
        {
            this.sprite = Image.FromFile(@"Sprite/player.png");
            this.graphics = graphics;
            this.position = position;
            this.position.Y -= sprite.Height;
            this.position.X -= sprite.Width/2;


                }

        public void Update()
        {
            graphics.DrawImage(sprite, position);
            
        }

       


    }
}
