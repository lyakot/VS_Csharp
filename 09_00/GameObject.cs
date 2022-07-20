using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _09_00.Components;

namespace _09_00
{
    internal class GameObject
    {

        private Image sprite;

        private Graphics graphics;



        private Transform transform;

        private Dictionary<string, Component> components = new Dictionary<string, Component>();

        public GameObject(Graphics graphics)
        {
            this.transform = new Transform();
            this.sprite = Image.FromFile(@"Sprite/player.png");
            this.graphics = graphics;

            transform.Position = new Vector2(GameWorld.WorldSize.Width / 2 - sprite.Width / 2, GameWorld.WorldSize.Height - sprite.Height);
            


                }

        public void AddComponent(Component component)
        {
            components.Add(component.ToString(), component);    
        }

        public void Update()
        {

            //if (Keyboard.IsKeyDown(Keys.D))
            //{
            //    position.X += 1;
            //}
            //if (Keyboard.IsKeyDown(Keys.A))
            //{
            //    position.X -= 1;
            //}
            //if (Keyboard.IsKeyDown(Keys.S))
            //{
            //    position.Y += 1;
            //}
            //if (Keyboard.IsKeyDown(Keys.W))
            //{
            //    position.Y -= 1;
            //}
            foreach (Component component in components.Values)
            {
                component.Update();
            }
            graphics.DrawImage(sprite, transform.Position.X, transform.Position.Y);
            
        }

       


    }
}
