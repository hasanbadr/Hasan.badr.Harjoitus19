namespace Hasan.badr.Harjoitus19
{
    public partial class RuokalistaForm : Form
    {
        public RuokalistaForm()
        {
            InitializeComponent();
            MeistaPL.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VasenPL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RuokalistaForm_Load(object sender, EventArgs e)
        {
            MeistaLB.Text = "keudan oppilaskunnan kahvila palvelee luokassa 320 välituntisin \n";
            MeistaLB.Text += "9:00 - 14:30 joka päivä maanantaista torstaisin ja perjantaisin\n";
            MeistaLB.Text += "9:00 - 12:30 \n\n keuda oppilaskunnan kahvilasta saa lämpimien \n";
            MeistaLB.Text += "juomien lisäksi virvokkeeita sekä pientä purtavaa sekä makeisia\n";
            MeistaLB.Text += "Tervetuloa tutustumaan!";
            MeistaLB.Text = new Font("Arial", 12);
        }

        private void MeistaBT_Click(object sender, EventArgs e)
        {
            MeistaPL.Visible = true;
            RuoatPL.Visible = false;
            JuomatPL.Visible = false;
            HerkutPL.Visible = false;
            KoriPL.Visible = false;
        }

        private void RuoatBT_Click(object sender, EventArgs e)
        {
            MeistaPL.Visible = false;
            RuoatPL.Visible = true;
            JuomatPL.Visible = false;
            HerkutPL.Visible = false;
            KoriPL.Visible = false;
        }

        private void JuomatBT_Click(object sender, EventArgs e)
        {
            MeistaPL.Visible = false;
            RuoatPL.Visible = false;
            JuomatPL.Visible = true;
            HerkutPL.Visible = false;
            KoriPL.Visible = false;
        }

        private void HerkutBT_Click(object sender, EventArgs e)
        {
            MeistaPL.Visible = false;
            RuoatPL.Visible = false;
            JuomatPL.Visible = false;
            HerkutPL.Visible = true;
            KoriPL.Visible = false;
        }

        private void KoriBT_Click(object sender, EventArgs e)
        {
            MeistaPL.Visible = false;
            RuoatPL.Visible = false;
            JuomatPL.Visible = false;
            HerkutPL.Visible = false;
            KoriPL.Visible = true;
        }

        private void Exitbt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}