namespace Final_Project_205674047_208078212
{
    partial class Offspring
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Offspring));
            panel2 = new Panel();
            panel1 = new Panel();
            motherELabel = new Label();
            fatherELabel = new Label();
            genderLa = new Label();
            snELabel = new Label();
            pictureBox1 = new PictureBox();
            closeBtn = new Button();
            birdSnLabel = new Label();
            birdSnTbox = new TextBox();
            speciesLabel = new Label();
            subSpeciesLabel = new Label();
            hatchingDatePicker = new DateTimePicker();
            genderELabel = new Label();
            birdCageNumLabel = new Label();
            fatherSnLabel = new Label();
            genderCbox = new ComboBox();
            motherSnLabel = new Label();
            birdBtn = new Button();
            hatchingLabel = new Label();
            motherSnTbox = new TextBox();
            speciesTbox = new TextBox();
            subspeciesTbox = new TextBox();
            fatherSnTbox = new TextBox();
            cageNumTbox = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.PeachPuff;
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(motherELabel);
            panel2.Controls.Add(fatherELabel);
            panel2.Controls.Add(genderLa);
            panel2.Controls.Add(snELabel);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(closeBtn);
            panel2.Controls.Add(birdSnLabel);
            panel2.Controls.Add(birdSnTbox);
            panel2.Controls.Add(speciesLabel);
            panel2.Controls.Add(subSpeciesLabel);
            panel2.Controls.Add(hatchingDatePicker);
            panel2.Controls.Add(genderELabel);
            panel2.Controls.Add(birdCageNumLabel);
            panel2.Controls.Add(fatherSnLabel);
            panel2.Controls.Add(genderCbox);
            panel2.Controls.Add(motherSnLabel);
            panel2.Controls.Add(birdBtn);
            panel2.Controls.Add(hatchingLabel);
            panel2.Controls.Add(motherSnTbox);
            panel2.Controls.Add(speciesTbox);
            panel2.Controls.Add(subspeciesTbox);
            panel2.Controls.Add(fatherSnTbox);
            panel2.Controls.Add(cageNumTbox);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(343, 467);
            panel2.TabIndex = 25;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(302, 28);
            panel1.TabIndex = 24;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // motherELabel
            // 
            motherELabel.AutoSize = true;
            motherELabel.ForeColor = Color.Red;
            motherELabel.Location = new Point(34, 319);
            motherELabel.Name = "motherELabel";
            motherELabel.Size = new Size(12, 15);
            motherELabel.TabIndex = 23;
            motherELabel.Text = "*";
            motherELabel.Visible = false;
            // 
            // fatherELabel
            // 
            fatherELabel.AutoSize = true;
            fatherELabel.ForeColor = Color.Red;
            fatherELabel.Location = new Point(34, 279);
            fatherELabel.Name = "fatherELabel";
            fatherELabel.Size = new Size(12, 15);
            fatherELabel.TabIndex = 22;
            fatherELabel.Text = "*";
            fatherELabel.Visible = false;
            // 
            // genderLa
            // 
            genderLa.AutoSize = true;
            genderLa.ForeColor = Color.Red;
            genderLa.Location = new Point(34, 205);
            genderLa.Name = "genderLa";
            genderLa.Size = new Size(12, 15);
            genderLa.TabIndex = 21;
            genderLa.Text = "*";
            genderLa.Visible = false;
            // 
            // snELabel
            // 
            snELabel.AutoSize = true;
            snELabel.ForeColor = Color.Red;
            snELabel.Location = new Point(34, 100);
            snELabel.Name = "snELabel";
            snELabel.Size = new Size(12, 15);
            snELabel.TabIndex = 20;
            snELabel.Text = "*";
            snELabel.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(149, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // closeBtn
            // 
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.FlatAppearance.MouseOverBackColor = Color.White;
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            closeBtn.ForeColor = Color.FromArgb(41, 128, 185);
            closeBtn.Location = new Point(308, 0);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(35, 35);
            closeBtn.TabIndex = 18;
            closeBtn.Text = "X";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // birdSnLabel
            // 
            birdSnLabel.AutoSize = true;
            birdSnLabel.Location = new Point(43, 100);
            birdSnLabel.Name = "birdSnLabel";
            birdSnLabel.Size = new Size(85, 15);
            birdSnLabel.TabIndex = 1;
            birdSnLabel.Text = "Serial Number:";
            // 
            // birdSnTbox
            // 
            birdSnTbox.Location = new Point(134, 100);
            birdSnTbox.Name = "birdSnTbox";
            birdSnTbox.Size = new Size(133, 23);
            birdSnTbox.TabIndex = 0;
            // 
            // speciesLabel
            // 
            speciesLabel.AutoSize = true;
            speciesLabel.Location = new Point(43, 134);
            speciesLabel.Name = "speciesLabel";
            speciesLabel.Size = new Size(49, 15);
            speciesLabel.TabIndex = 2;
            speciesLabel.Text = "Species:";
            // 
            // subSpeciesLabel
            // 
            subSpeciesLabel.AutoSize = true;
            subSpeciesLabel.Location = new Point(43, 170);
            subSpeciesLabel.Name = "subSpeciesLabel";
            subSpeciesLabel.Size = new Size(68, 15);
            subSpeciesLabel.TabIndex = 3;
            subSpeciesLabel.Text = "Subspecies:";
            // 
            // hatchingDatePicker
            // 
            hatchingDatePicker.Location = new Point(135, 357);
            hatchingDatePicker.Name = "hatchingDatePicker";
            hatchingDatePicker.Size = new Size(191, 23);
            hatchingDatePicker.TabIndex = 17;
            // 
            // genderELabel
            // 
            genderELabel.AutoSize = true;
            genderELabel.Location = new Point(43, 205);
            genderELabel.Name = "genderELabel";
            genderELabel.Size = new Size(48, 15);
            genderELabel.TabIndex = 4;
            genderELabel.Text = "Gender:";
            // 
            // birdCageNumLabel
            // 
            birdCageNumLabel.AutoSize = true;
            birdCageNumLabel.Location = new Point(43, 243);
            birdCageNumLabel.Name = "birdCageNumLabel";
            birdCageNumLabel.Size = new Size(82, 15);
            birdCageNumLabel.TabIndex = 5;
            birdCageNumLabel.Text = "Cage number:";
            // 
            // fatherSnLabel
            // 
            fatherSnLabel.AutoSize = true;
            fatherSnLabel.Location = new Point(43, 279);
            fatherSnLabel.Name = "fatherSnLabel";
            fatherSnLabel.Size = new Size(61, 15);
            fatherSnLabel.TabIndex = 6;
            fatherSnLabel.Text = "Father SN:";
            // 
            // genderCbox
            // 
            genderCbox.FormattingEnabled = true;
            genderCbox.Items.AddRange(new object[] { "Male", "Female" });
            genderCbox.Location = new Point(134, 205);
            genderCbox.Name = "genderCbox";
            genderCbox.Size = new Size(133, 23);
            genderCbox.TabIndex = 16;
            // 
            // motherSnLabel
            // 
            motherSnLabel.AutoSize = true;
            motherSnLabel.Location = new Point(43, 319);
            motherSnLabel.Name = "motherSnLabel";
            motherSnLabel.Size = new Size(64, 15);
            motherSnLabel.TabIndex = 7;
            motherSnLabel.Text = "MotherSN:";
            // 
            // birdBtn
            // 
            birdBtn.Location = new Point(136, 393);
            birdBtn.Name = "birdBtn";
            birdBtn.Size = new Size(89, 68);
            birdBtn.TabIndex = 1;
            birdBtn.Text = "Add Offspring";
            birdBtn.UseVisualStyleBackColor = true;
            birdBtn.Click += birdBtn_Click;
            // 
            // hatchingLabel
            // 
            hatchingLabel.AutoSize = true;
            hatchingLabel.Location = new Point(43, 357);
            hatchingLabel.Name = "hatchingLabel";
            hatchingLabel.Size = new Size(86, 15);
            hatchingLabel.TabIndex = 8;
            hatchingLabel.Text = "Hatching Date:";
            // 
            // motherSnTbox
            // 
            motherSnTbox.Location = new Point(134, 319);
            motherSnTbox.Name = "motherSnTbox";
            motherSnTbox.Size = new Size(133, 23);
            motherSnTbox.TabIndex = 14;
            // 
            // speciesTbox
            // 
            speciesTbox.AutoCompleteCustomSource.AddRange(new string[] { "gouldian american", "gouldian european", "gouldian australian" });
            speciesTbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            speciesTbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            speciesTbox.Location = new Point(134, 134);
            speciesTbox.Name = "speciesTbox";
            speciesTbox.Size = new Size(133, 23);
            speciesTbox.TabIndex = 9;
            // 
            // subspeciesTbox
            // 
            subspeciesTbox.AutoCompleteCustomSource.AddRange(new string[] { "northern american", "central american", "southern american", "eastern european", "western european", "central australian", "coastal forests" });
            subspeciesTbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            subspeciesTbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            subspeciesTbox.Location = new Point(134, 170);
            subspeciesTbox.Name = "subspeciesTbox";
            subspeciesTbox.Size = new Size(133, 23);
            subspeciesTbox.TabIndex = 10;
            // 
            // fatherSnTbox
            // 
            fatherSnTbox.Location = new Point(134, 279);
            fatherSnTbox.Name = "fatherSnTbox";
            fatherSnTbox.Size = new Size(133, 23);
            fatherSnTbox.TabIndex = 13;
            // 
            // cageNumTbox
            // 
            cageNumTbox.Location = new Point(134, 243);
            cageNumTbox.Name = "cageNumTbox";
            cageNumTbox.Size = new Size(133, 23);
            cageNumTbox.TabIndex = 12;
            // 
            // Offspring
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 466);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Offspring";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Offspring";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label birdSnLabel;
        private Label speciesLabel;
        private Label subSpeciesLabel;
        private Label genderELabel;
        private Label birdCageNumLabel;
        private Label fatherSnLabel;
        private Label motherSnLabel;
        private Label hatchingLabel;
        private Button closeBtn;
        public TextBox birdSnTbox;
        public DateTimePicker hatchingDatePicker;
        public ComboBox genderCbox;
        public Button birdBtn;
        public TextBox motherSnTbox;
        public TextBox speciesTbox;
        public TextBox subspeciesTbox;
        public TextBox fatherSnTbox;
        public TextBox cageNumTbox;
        private PictureBox pictureBox1;
        public Label motherELabel;
        public Label fatherELabel;
        public Label genderLa;
        public Label snELabel;
        private Panel panel1;
    }
}