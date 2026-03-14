namespace Modul3_103022400112
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (cbSuhuAwal.SelectedItem == null|| cbSuhuAkhir.SelectedItem == null)
            {
                MessageBox.Show("Pilih satuan terlebih dahulu!");
                return;
            }
            string suhuAwal = cbSuhuAwal.SelectedItem.ToString();
            string suhuAkhir = cbSuhuAkhir.SelectedItem.ToString();

            if (tfSuhuAwal.Text == "")
            {
                MessageBox.Show("Masukkan angka yang valid!");
                return;
            }
            int suhuInput = Convert.ToInt32(tfSuhuAwal.Text);

            if (suhuAwal == "Celsius" && suhuAkhir == "Fahrenheit")
            {
                int hasil = (suhuInput * 9 / 5) + 32;
                tfSuhuAkhir.Text = hasil.ToString();
            }
            else if (suhuAwal == "Celsius" && suhuAkhir == "Kelvin")
            {
                int hasil = suhuInput + 273;
                tfSuhuAkhir.Text = hasil.ToString();
            }
            else if (suhuAwal == "Fahrenheit" && suhuAkhir == "Celsius")
            {
                int hasil = (suhuInput - 32) * 5 / 9;
                tfSuhuAkhir.Text = hasil.ToString();
            }
            else if (suhuAwal == "Fahrenheit" && suhuAkhir == "Kelvin")
            {
                int hasil = ((suhuInput - 32) * 5 / 9) + 273;
                tfSuhuAkhir.Text = hasil.ToString();
            }
            else if (suhuAwal == "Kelvin" && suhuAkhir == "Celsius")
            {
                int hasil = suhuInput - 273;
                tfSuhuAkhir.Text = hasil.ToString();
            }
            else if (suhuAwal == "Kelvin" && suhuAkhir == "Fahrenheit")
            {
                int hasil = ((suhuInput - 273) * 9 / 5) + 32;
                tfSuhuAkhir.Text = hasil.ToString();
            }

        }
    }
}
