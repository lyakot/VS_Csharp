using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_00
{
    public partial class Form1 : Form
    {
        private GameWorld gameWorld;
        
        public Form1()
        {
            InitializeComponent();

            gameWorld = new GameWorld(DisplayRectangle.Size, CreateGraphics());
                      
        }

        private void GameLoop_Tick(object sender, EventArgs e)
        {
            gameWorld.Update();
        }
    }
}