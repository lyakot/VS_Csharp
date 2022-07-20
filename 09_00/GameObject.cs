using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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

            if (Keyboard.IsKeyDown(Keys.D))
            {
                position.X += 1;
            }
            if (Keyboard.IsKeyDown(Keys.A))
            {
                position.X -= 1;
            }
            if (Keyboard.IsKeyDown(Keys.S))
            {
                position.Y += 1;
            }
            if (Keyboard.IsKeyDown(Keys.W))
            {
                position.Y -= 1;
            }

            graphics.DrawImage(sprite, position);
            
        }

       


    }
}
