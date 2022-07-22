using _09_00.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_00
{
    internal class SpriteRenderer : Component
    {
        private Graphics graphics;

        private Image sprite;

        public RectangleF Rectangle
        {
            get 
            
            {
                return new RectangleF(GameObject.Transform.Position.X, GameObject.Transform.Position.Y, sprite.Width, sprite.Height);
            
            }

        }

        public SpriteRenderer()
        {
            this.graphics = GameWorld.Graphics;
        }


        public void SetSprite(string spriteName)
        {
        this.sprite = Image.FromFile($@"Sprite/{spriteName}.png");
        }

        public override void Update()
        {
            graphics.DrawImage(sprite, Rectangle);
        }

        public override string ToString()
        {
            return "SpriteRenderer";
        }
    }
}
