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

        public Transform Transform { get; private set; }

        private Dictionary<string, Component> components = new Dictionary<string, Component>();

        public GameObject()
        {
            this.Transform = new Transform();
                  
        }

        public void AddComponent(Component component)
        {
            components.Add(component.ToString(), component); 
            component.GameObject = this;
        }

        public Component GetComponent(string component)
        {
            return components[component];
        }
        public void Awake()
        {
            foreach (Component component in components.Values)
            {
                component.Awake();
            }

        }
        public void Start()
        {
            foreach (Component component in components.Values)
            {
                if (component.IsEnabled)
                {
                    component.Start();
                }
                
            }
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

                if (component.IsEnabled)
                {
                    component.Update();
                }
            }

            
        }

       


    }
}
