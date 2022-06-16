namespace TARGET_MiDOC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1, "Partitura");
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button3, "Livros");
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button4, "Audio");
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button5, "Outros");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var m = new Partituras();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var m = new Livros();
            m.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var m = new Audio();
            m.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var m = new Outros();
            m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}