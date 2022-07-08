namespace _09_00
{
    public partial class Form1 : Form
    {
        private GameObject gameObject;
        public Form1()
        {
            InitializeComponent();
            Point position = new Point(DisplayRectangle.Width / 2, DisplayRectangle.Height);
            
            gameObject = new GameObject(CreateGraphics(), position);
        }


        protected override void OnPaint(PaintEventArgs e)
        {
           gameObject.Update();
        }

    }
}