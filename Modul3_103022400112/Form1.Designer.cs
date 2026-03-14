namespace Modul3_103022400112
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            satuanAwal = new Label();
            cbSuhuAwal = new ComboBox();
            nilaiAwal = new Label();
            tfSuhuAwal = new TextBox();
            tfSuhuAkhir = new TextBox();
            nilaiAkhir = new Label();
            btnConvert = new Button();
            cbSuhuAkhir = new ComboBox();
            satuanAkhir = new Label();
            SuspendLayout();
            // 
            // satuanAwal
            // 
            satuanAwal.AutoSize = true;
            satuanAwal.Location = new Point(39, 53);
            satuanAwal.Name = "satuanAwal";
            satuanAwal.Size = new Size(109, 25);
            satuanAwal.TabIndex = 0;
            satuanAwal.Text = "Satuan Awal";
            // 
            // cbSuhuAwal
            // 
            cbSuhuAwal.FormattingEnabled = true;
            cbSuhuAwal.Items.AddRange(new object[] { "Celsius", "Fahrenheit", "Kelvin", "Reamur" });
            cbSuhuAwal.Location = new Point(39, 93);
            cbSuhuAwal.Name = "cbSuhuAwal";
            cbSuhuAwal.Size = new Size(182, 33);
            cbSuhuAwal.TabIndex = 1;
            // 
            // nilaiAwal
            // 
            nilaiAwal.AutoSize = true;
            nilaiAwal.Location = new Point(316, 53);
            nilaiAwal.Name = "nilaiAwal";
            nilaiAwal.Size = new Size(89, 25);
            nilaiAwal.TabIndex = 2;
            nilaiAwal.Text = "Nilai Awal";
            // 
            // tfSuhuAwal
            // 
            tfSuhuAwal.Location = new Point(316, 94);
            tfSuhuAwal.Name = "tfSuhuAwal";
            tfSuhuAwal.Size = new Size(150, 31);
            tfSuhuAwal.TabIndex = 3;
            // 
            // tfSuhuAkhir
            // 
            tfSuhuAkhir.Location = new Point(316, 176);
            tfSuhuAkhir.Name = "tfSuhuAkhir";
            tfSuhuAkhir.ReadOnly = true;
            tfSuhuAkhir.Size = new Size(150, 31);
            tfSuhuAkhir.TabIndex = 4;
            // 
            // nilaiAkhir
            // 
            nilaiAkhir.AutoSize = true;
            nilaiAkhir.Location = new Point(316, 148);
            nilaiAkhir.Name = "nilaiAkhir";
            nilaiAkhir.Size = new Size(92, 25);
            nilaiAkhir.TabIndex = 5;
            nilaiAkhir.Text = "Nilai Akhir";
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(546, 91);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(112, 34);
            btnConvert.TabIndex = 6;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // cbSuhuAkhir
            // 
            cbSuhuAkhir.FormattingEnabled = true;
            cbSuhuAkhir.Items.AddRange(new object[] { "Celsius", "Fahrenheit", "Kelvin", "Reamur" });
            cbSuhuAkhir.Location = new Point(39, 174);
            cbSuhuAkhir.Name = "cbSuhuAkhir";
            cbSuhuAkhir.Size = new Size(182, 33);
            cbSuhuAkhir.TabIndex = 7;
            // 
            // satuanAkhir
            // 
            satuanAkhir.AutoSize = true;
            satuanAkhir.Location = new Point(39, 146);
            satuanAkhir.Name = "satuanAkhir";
            satuanAkhir.Size = new Size(112, 25);
            satuanAkhir.TabIndex = 8;
            satuanAkhir.Text = "Satuan Akhir";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(satuanAkhir);
            Controls.Add(cbSuhuAkhir);
            Controls.Add(btnConvert);
            Controls.Add(nilaiAkhir);
            Controls.Add(tfSuhuAkhir);
            Controls.Add(tfSuhuAwal);
            Controls.Add(nilaiAwal);
            Controls.Add(cbSuhuAwal);
            Controls.Add(satuanAwal);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label satuanAwal;
        private ComboBox cbSuhuAwal;
        private Label nilaiAwal;
        private TextBox tfSuhuAwal;
        private TextBox tfSuhuAkhir;
        private Label nilaiAkhir;
        private Button btnConvert;
        private ComboBox cbSuhuAkhir;
        private Label satuanAkhir;
    }
}
