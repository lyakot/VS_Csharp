namespace _09_00
{
    public partial class Form1 : Form
    {
        private Image sprite;
        public Form1()
        {
            InitializeComponent();
            sprite = Image.FromFile(@"Sprite/player.png");
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.DrawImage(sprite, 110, 220);
        }

    }
}