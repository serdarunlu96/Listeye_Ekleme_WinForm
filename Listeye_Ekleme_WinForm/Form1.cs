namespace Listeye_Ekleme_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KisiListBox.Items.Add("Serdar Unlu Ankara");
        }

        private void KisiListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenIsim = KisiListBox.Text;
            var bilgiler = secilenIsim.Split(" ");
            txtAd.Text = bilgiler[0];
            txtSoyad.Text = bilgiler[1];
            txtSehir.Text = bilgiler[2];
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            KisiListBox.Items.Add(txtAd.Text + " " + txtSoyad.Text + " " + txtSehir.Text);
            txtAd.Clear();
            txtSoyad.Clear();
            txtSehir.Clear();
        }
    }
}