using _09_00.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _09_00
{
    internal class Player : Component
    {
        private SpriteRenderer spriteRenderer;
        public override void Awake()
        {
            spriteRenderer = (SpriteRenderer)GameObject.GetComponent("SpriteRenderer");
            spriteRenderer.SetSprite("player");
            GameObject.Transform.Position = new Vector2((GameWorld.WorldSize.Width / 2) - (spriteRenderer.Rectangle.Width / 2), (GameWorld.WorldSize.Height) - (spriteRenderer.Rectangle.Height));
        }


        public override string ToString()
        {
            return "Player";
        }

    }
}
