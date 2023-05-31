namespace Final_Project_205674047_208078212
{
    partial class birdForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(birdForm));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            birdsGrid = new DataGridView();
            birdBtn = new Button();
            cageBtn = new Button();
            addTabs = new TabControl();
            birdTab = new TabPage();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            changesBtn = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            birdSnLabel = new Label();
            birdSnTbox = new TextBox();
            speciesLabel = new Label();
            subSpeciesLabel = new Label();
            hatchingDatePicker = new DateTimePicker();
            genderLabel = new Label();
            birdCageNumLabel = new Label();
            fatherSnLabel = new Label();
            genderCbox = new ComboBox();
            motherSnLabel = new Label();
            hatchingLabel = new Label();
            motherSnTbox = new TextBox();
            speciesTbox = new TextBox();
            subspeciesTbox = new TextBox();
            fatherSnTbox = new TextBox();
            cageNumTbox = new TextBox();
            offspringBtn = new Button();
            panel1 = new Panel();
            birdSNRadioBtn = new RadioButton();
            genderRadioBtn = new RadioButton();
            speciesRadioBtn = new RadioButton();
            hatchingDateRadioBtn = new RadioButton();
            birdsearchBtn = new Button();
            searchLabel = new Label();
            birdSearchTBox = new TextBox();
            cageTab = new TabPage();
            cageBirdsList = new ListView();
            BirdSN = new ColumnHeader();
            Species = new ColumnHeader();
            Subspecies = new ColumnHeader();
            HatchingDate = new ColumnHeader();
            Gender = new ColumnHeader();
            CageSN = new ColumnHeader();
            FatherSN = new ColumnHeader();
            MotherSN = new ColumnHeader();
            panel4 = new Panel();
            cageMaterialRadioBtn = new RadioButton();
            cagesRadioBtn = new RadioButton();
            pictureBox12 = new PictureBox();
            button1 = new Button();
            pictureBox11 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            cagesSearchBtn = new Button();
            cagesMsg = new Label();
            cagesSearchTbox = new TextBox();
            cagesGrid = new DataGridView();
            lengthTbox = new TextBox();
            lengthLabel = new Label();
            cageTypeLabel = new Label();
            widthLabel = new Label();
            hightLabel = new Label();
            cageSnLabel = new Label();
            materialCBox = new ComboBox();
            heightTbox = new TextBox();
            widthTbox = new TextBox();
            cageSnTbox = new TextBox();
            panel3 = new Panel();
            closeBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)birdsGrid).BeginInit();
            addTabs.SuspendLayout();
            birdTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            cageTab.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cagesGrid).BeginInit();
            SuspendLayout();
            // 
            // birdsGrid
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            birdsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            birdsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            birdsGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            birdsGrid.BorderStyle = BorderStyle.None;
            birdsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            birdsGrid.Location = new Point(350, 140);
            birdsGrid.Name = "birdsGrid";
            birdsGrid.RowTemplate.Height = 25;
            birdsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            birdsGrid.Size = new Size(761, 340);
            birdsGrid.TabIndex = 0;
            // 
            // birdBtn
            // 
            birdBtn.BackColor = Color.RosyBrown;
            birdBtn.FlatStyle = FlatStyle.Popup;
            birdBtn.Location = new Point(140, 331);
            birdBtn.Name = "birdBtn";
            birdBtn.Size = new Size(89, 68);
            birdBtn.TabIndex = 1;
            birdBtn.Text = "Add Bird";
            birdBtn.UseVisualStyleBackColor = false;
            birdBtn.Click += birdBtn_Click;
            // 
            // cageBtn
            // 
            cageBtn.Location = new Point(72, 307);
            cageBtn.Name = "cageBtn";
            cageBtn.Size = new Size(89, 69);
            cageBtn.TabIndex = 2;
            cageBtn.Text = "Add Cage";
            cageBtn.UseVisualStyleBackColor = true;
            cageBtn.Click += cageBtn_Click;
            // 
            // addTabs
            // 
            addTabs.Controls.Add(birdTab);
            addTabs.Controls.Add(cageTab);
            addTabs.Dock = DockStyle.Bottom;
            addTabs.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addTabs.HotTrack = true;
            addTabs.ItemSize = new Size(60, 60);
            addTabs.Location = new Point(0, 27);
            addTabs.Name = "addTabs";
            addTabs.Padding = new Point(80, 6);
            addTabs.SelectedIndex = 0;
            addTabs.Size = new Size(1127, 641);
            addTabs.TabIndex = 2;
            addTabs.Tag = "";
            // 
            // birdTab
            // 
            birdTab.BackgroundImage = (Image)resources.GetObject("birdTab.BackgroundImage");
            birdTab.Controls.Add(pictureBox6);
            birdTab.Controls.Add(pictureBox5);
            birdTab.Controls.Add(pictureBox4);
            birdTab.Controls.Add(changesBtn);
            birdTab.Controls.Add(pictureBox3);
            birdTab.Controls.Add(pictureBox2);
            birdTab.Controls.Add(pictureBox1);
            birdTab.Controls.Add(panel2);
            birdTab.Controls.Add(offspringBtn);
            birdTab.Controls.Add(panel1);
            birdTab.Controls.Add(birdsearchBtn);
            birdTab.Controls.Add(searchLabel);
            birdTab.Controls.Add(birdSearchTBox);
            birdTab.Controls.Add(birdsGrid);
            birdTab.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            birdTab.Location = new Point(4, 64);
            birdTab.Name = "birdTab";
            birdTab.Padding = new Padding(3);
            birdTab.Size = new Size(1119, 573);
            birdTab.TabIndex = 0;
            birdTab.Text = "Birds";
            birdTab.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(795, 486);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(49, 44);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 31;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(549, 486);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(61, 44);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 30;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(783, 78);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 29;
            pictureBox4.TabStop = false;
            // 
            // changesBtn
            // 
            changesBtn.BackColor = Color.RosyBrown;
            changesBtn.FlatStyle = FlatStyle.Popup;
            changesBtn.Location = new Point(768, 536);
            changesBtn.Name = "changesBtn";
            changesBtn.Size = new Size(104, 31);
            changesBtn.TabIndex = 28;
            changesBtn.Text = "Apply Changes";
            changesBtn.UseVisualStyleBackColor = false;
            changesBtn.Click += changesBtn_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(462, 19);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(102, 73);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 27;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(991, 59);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(birdSnLabel);
            panel2.Controls.Add(birdSnTbox);
            panel2.Controls.Add(speciesLabel);
            panel2.Controls.Add(subSpeciesLabel);
            panel2.Controls.Add(hatchingDatePicker);
            panel2.Controls.Add(genderLabel);
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
            panel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.Location = new Point(3, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(341, 468);
            panel2.TabIndex = 24;
            // 
            // birdSnLabel
            // 
            birdSnLabel.AutoSize = true;
            birdSnLabel.Location = new Point(49, 28);
            birdSnLabel.Name = "birdSnLabel";
            birdSnLabel.Size = new Size(90, 15);
            birdSnLabel.TabIndex = 1;
            birdSnLabel.Text = "Serial Number:";
            // 
            // birdSnTbox
            // 
            birdSnTbox.Location = new Point(140, 28);
            birdSnTbox.Name = "birdSnTbox";
            birdSnTbox.Size = new Size(100, 23);
            birdSnTbox.TabIndex = 0;
            // 
            // speciesLabel
            // 
            speciesLabel.AutoSize = true;
            speciesLabel.Location = new Point(49, 62);
            speciesLabel.Name = "speciesLabel";
            speciesLabel.Size = new Size(52, 15);
            speciesLabel.TabIndex = 2;
            speciesLabel.Text = "Species:";
            // 
            // subSpeciesLabel
            // 
            subSpeciesLabel.AutoSize = true;
            subSpeciesLabel.Location = new Point(49, 98);
            subSpeciesLabel.Name = "subSpeciesLabel";
            subSpeciesLabel.Size = new Size(71, 15);
            subSpeciesLabel.TabIndex = 3;
            subSpeciesLabel.Text = "Subspecies:";
            // 
            // hatchingDatePicker
            // 
            hatchingDatePicker.Location = new Point(141, 285);
            hatchingDatePicker.Name = "hatchingDatePicker";
            hatchingDatePicker.Size = new Size(191, 23);
            hatchingDatePicker.TabIndex = 17;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new Point(49, 133);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(52, 15);
            genderLabel.TabIndex = 4;
            genderLabel.Text = "Gender:";
            // 
            // birdCageNumLabel
            // 
            birdCageNumLabel.AutoSize = true;
            birdCageNumLabel.Location = new Point(49, 171);
            birdCageNumLabel.Name = "birdCageNumLabel";
            birdCageNumLabel.Size = new Size(84, 15);
            birdCageNumLabel.TabIndex = 5;
            birdCageNumLabel.Text = "Cage number:";
            // 
            // fatherSnLabel
            // 
            fatherSnLabel.AutoSize = true;
            fatherSnLabel.Location = new Point(49, 207);
            fatherSnLabel.Name = "fatherSnLabel";
            fatherSnLabel.Size = new Size(65, 15);
            fatherSnLabel.TabIndex = 6;
            fatherSnLabel.Text = "Father SN:";
            // 
            // genderCbox
            // 
            genderCbox.FormattingEnabled = true;
            genderCbox.Items.AddRange(new object[] { "Male", "Female" });
            genderCbox.Location = new Point(140, 133);
            genderCbox.Name = "genderCbox";
            genderCbox.Size = new Size(100, 23);
            genderCbox.TabIndex = 16;
            // 
            // motherSnLabel
            // 
            motherSnLabel.AutoSize = true;
            motherSnLabel.Location = new Point(49, 247);
            motherSnLabel.Name = "motherSnLabel";
            motherSnLabel.Size = new Size(68, 15);
            motherSnLabel.TabIndex = 7;
            motherSnLabel.Text = "MotherSN:";
            // 
            // hatchingLabel
            // 
            hatchingLabel.AutoSize = true;
            hatchingLabel.Location = new Point(49, 285);
            hatchingLabel.Name = "hatchingLabel";
            hatchingLabel.Size = new Size(90, 15);
            hatchingLabel.TabIndex = 8;
            hatchingLabel.Text = "Hatching Date:";
            // 
            // motherSnTbox
            // 
            motherSnTbox.Location = new Point(140, 247);
            motherSnTbox.Name = "motherSnTbox";
            motherSnTbox.Size = new Size(100, 23);
            motherSnTbox.TabIndex = 14;
            // 
            // speciesTbox
            // 
            speciesTbox.AutoCompleteCustomSource.AddRange(new string[] { "gouldian american", "gouldian european", "gouldian australian" });
            speciesTbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            speciesTbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            speciesTbox.Location = new Point(140, 62);
            speciesTbox.Name = "speciesTbox";
            speciesTbox.Size = new Size(100, 23);
            speciesTbox.TabIndex = 9;
            // 
            // subspeciesTbox
            // 
            subspeciesTbox.AutoCompleteCustomSource.AddRange(new string[] { "northern american", "central american", "southern american", "eastern european", "western european", "central australian", "coastal forests" });
            subspeciesTbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            subspeciesTbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            subspeciesTbox.Location = new Point(140, 98);
            subspeciesTbox.Name = "subspeciesTbox";
            subspeciesTbox.Size = new Size(100, 23);
            subspeciesTbox.TabIndex = 10;
            // 
            // fatherSnTbox
            // 
            fatherSnTbox.Location = new Point(140, 207);
            fatherSnTbox.Name = "fatherSnTbox";
            fatherSnTbox.Size = new Size(100, 23);
            fatherSnTbox.TabIndex = 13;
            // 
            // cageNumTbox
            // 
            cageNumTbox.Location = new Point(140, 171);
            cageNumTbox.Name = "cageNumTbox";
            cageNumTbox.Size = new Size(100, 23);
            cageNumTbox.TabIndex = 12;
            // 
            // offspringBtn
            // 
            offspringBtn.BackColor = Color.RosyBrown;
            offspringBtn.FlatStyle = FlatStyle.Popup;
            offspringBtn.Location = new Point(531, 536);
            offspringBtn.Name = "offspringBtn";
            offspringBtn.Size = new Size(104, 31);
            offspringBtn.TabIndex = 23;
            offspringBtn.Text = "Add Offspring";
            offspringBtn.UseVisualStyleBackColor = false;
            offspringBtn.Click += offspringBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(birdSNRadioBtn);
            panel1.Controls.Add(genderRadioBtn);
            panel1.Controls.Add(speciesRadioBtn);
            panel1.Controls.Add(hatchingDateRadioBtn);
            panel1.Location = new Point(580, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(142, 56);
            panel1.TabIndex = 22;
            // 
            // birdSNRadioBtn
            // 
            birdSNRadioBtn.AutoSize = true;
            birdSNRadioBtn.Location = new Point(3, 3);
            birdSNRadioBtn.Name = "birdSNRadioBtn";
            birdSNRadioBtn.Size = new Size(67, 19);
            birdSNRadioBtn.TabIndex = 18;
            birdSNRadioBtn.TabStop = true;
            birdSNRadioBtn.Text = "Bird SN";
            birdSNRadioBtn.UseVisualStyleBackColor = true;
            // 
            // genderRadioBtn
            // 
            genderRadioBtn.AutoSize = true;
            genderRadioBtn.Location = new Point(73, 30);
            genderRadioBtn.Name = "genderRadioBtn";
            genderRadioBtn.Size = new Size(67, 19);
            genderRadioBtn.TabIndex = 21;
            genderRadioBtn.TabStop = true;
            genderRadioBtn.Text = "Gender";
            genderRadioBtn.UseVisualStyleBackColor = true;
            // 
            // speciesRadioBtn
            // 
            speciesRadioBtn.AutoSize = true;
            speciesRadioBtn.Location = new Point(73, 5);
            speciesRadioBtn.Name = "speciesRadioBtn";
            speciesRadioBtn.Size = new Size(67, 19);
            speciesRadioBtn.TabIndex = 19;
            speciesRadioBtn.TabStop = true;
            speciesRadioBtn.Text = "Species";
            speciesRadioBtn.UseVisualStyleBackColor = true;
            // 
            // hatchingDateRadioBtn
            // 
            hatchingDateRadioBtn.AutoSize = true;
            hatchingDateRadioBtn.Location = new Point(3, 30);
            hatchingDateRadioBtn.Name = "hatchingDateRadioBtn";
            hatchingDateRadioBtn.Size = new Size(52, 19);
            hatchingDateRadioBtn.TabIndex = 20;
            hatchingDateRadioBtn.TabStop = true;
            hatchingDateRadioBtn.Text = "Date";
            hatchingDateRadioBtn.UseVisualStyleBackColor = true;
            // 
            // birdsearchBtn
            // 
            birdsearchBtn.Location = new Point(702, 91);
            birdsearchBtn.Name = "birdsearchBtn";
            birdsearchBtn.Size = new Size(75, 23);
            birdsearchBtn.TabIndex = 5;
            birdsearchBtn.Text = "Search";
            birdsearchBtn.UseVisualStyleBackColor = true;
            birdsearchBtn.Click += birdsearchBtn_Click;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(580, 18);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(150, 15);
            searchLabel.TabIndex = 4;
            searchLabel.Text = "What are you looking for?";
            // 
            // birdSearchTBox
            // 
            birdSearchTBox.Location = new Point(583, 91);
            birdSearchTBox.Name = "birdSearchTBox";
            birdSearchTBox.Size = new Size(100, 23);
            birdSearchTBox.TabIndex = 3;
            // 
            // cageTab
            // 
            cageTab.BackgroundImage = (Image)resources.GetObject("cageTab.BackgroundImage");
            cageTab.Controls.Add(cageBirdsList);
            cageTab.Controls.Add(panel4);
            cageTab.Controls.Add(pictureBox12);
            cageTab.Controls.Add(button1);
            cageTab.Controls.Add(pictureBox11);
            cageTab.Controls.Add(pictureBox7);
            cageTab.Controls.Add(pictureBox8);
            cageTab.Controls.Add(pictureBox9);
            cageTab.Controls.Add(pictureBox10);
            cageTab.Controls.Add(cagesSearchBtn);
            cageTab.Controls.Add(cagesMsg);
            cageTab.Controls.Add(cagesSearchTbox);
            cageTab.Controls.Add(cagesGrid);
            cageTab.Controls.Add(lengthTbox);
            cageTab.Controls.Add(cageBtn);
            cageTab.Controls.Add(lengthLabel);
            cageTab.Controls.Add(cageTypeLabel);
            cageTab.Controls.Add(widthLabel);
            cageTab.Controls.Add(hightLabel);
            cageTab.Controls.Add(cageSnLabel);
            cageTab.Controls.Add(materialCBox);
            cageTab.Controls.Add(heightTbox);
            cageTab.Controls.Add(widthTbox);
            cageTab.Controls.Add(cageSnTbox);
            cageTab.Location = new Point(4, 64);
            cageTab.Name = "cageTab";
            cageTab.Padding = new Padding(3);
            cageTab.Size = new Size(1119, 573);
            cageTab.TabIndex = 1;
            cageTab.Text = "Cage";
            cageTab.UseVisualStyleBackColor = true;
            // 
            // cageBirdsList
            // 
            cageBirdsList.Columns.AddRange(new ColumnHeader[] { BirdSN, Species, Subspecies, HatchingDate, Gender, CageSN, FatherSN, MotherSN });
            cageBirdsList.Location = new Point(688, 103);
            cageBirdsList.Name = "cageBirdsList";
            cageBirdsList.Size = new Size(423, 384);
            cageBirdsList.TabIndex = 38;
            cageBirdsList.UseCompatibleStateImageBehavior = false;
            cageBirdsList.View = View.Details;
            // 
            // BirdSN
            // 
            BirdSN.Text = "BirdSN";
            BirdSN.Width = 40;
            // 
            // Species
            // 
            Species.Text = "Species";
            Species.Width = 120;
            // 
            // Subspecies
            // 
            Subspecies.Text = "Subspecies";
            Subspecies.Width = 120;
            // 
            // HatchingDate
            // 
            HatchingDate.Text = "HatchingDate";
            HatchingDate.Width = 80;
            // 
            // Gender
            // 
            Gender.Text = "Gender";
            // 
            // CageSN
            // 
            CageSN.Text = "CageSn";
            // 
            // FatherSN
            // 
            FatherSN.Text = "FatherSN";
            // 
            // MotherSN
            // 
            MotherSN.Text = "MotherSN";
            // 
            // panel4
            // 
            panel4.Controls.Add(cageMaterialRadioBtn);
            panel4.Controls.Add(cagesRadioBtn);
            panel4.Location = new Point(628, 24);
            panel4.Name = "panel4";
            panel4.Size = new Size(168, 30);
            panel4.TabIndex = 37;
            // 
            // cageMaterialRadioBtn
            // 
            cageMaterialRadioBtn.AutoSize = true;
            cageMaterialRadioBtn.Location = new Point(89, 2);
            cageMaterialRadioBtn.Name = "cageMaterialRadioBtn";
            cageMaterialRadioBtn.Size = new Size(71, 19);
            cageMaterialRadioBtn.TabIndex = 1;
            cageMaterialRadioBtn.TabStop = true;
            cageMaterialRadioBtn.Text = "Material";
            cageMaterialRadioBtn.UseVisualStyleBackColor = true;
            // 
            // cagesRadioBtn
            // 
            cagesRadioBtn.AutoSize = true;
            cagesRadioBtn.Location = new Point(12, 2);
            cagesRadioBtn.Name = "cagesRadioBtn";
            cagesRadioBtn.Size = new Size(71, 19);
            cagesRadioBtn.TabIndex = 0;
            cagesRadioBtn.TabStop = true;
            cagesRadioBtn.Text = "Cage SN";
            cagesRadioBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(459, 493);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(49, 44);
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.TabIndex = 36;
            pictureBox12.TabStop = false;
            pictureBox12.Click += pictureBox12_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.RosyBrown;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(432, 543);
            button1.Name = "button1";
            button1.Size = new Size(104, 31);
            button1.TabIndex = 35;
            button1.Text = "Apply Changes";
            button1.UseVisualStyleBackColor = false;
            button1.Click += applyChangesCages_Click;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(167, 294);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(102, 73);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 34;
            pictureBox11.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(841, 47);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(100, 50);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 33;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(506, 6);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(102, 73);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 32;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(973, 6);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(120, 69);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 31;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(41, 413);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(120, 69);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 30;
            pictureBox10.TabStop = false;
            // 
            // cagesSearchBtn
            // 
            cagesSearchBtn.Location = new Point(760, 60);
            cagesSearchBtn.Name = "cagesSearchBtn";
            cagesSearchBtn.Size = new Size(75, 23);
            cagesSearchBtn.TabIndex = 13;
            cagesSearchBtn.Text = "Search";
            cagesSearchBtn.UseVisualStyleBackColor = true;
            cagesSearchBtn.Click += cagesSearchBtn_Click;
            // 
            // cagesMsg
            // 
            cagesMsg.AutoSize = true;
            cagesMsg.Location = new Point(630, 6);
            cagesMsg.Name = "cagesMsg";
            cagesMsg.Size = new Size(150, 15);
            cagesMsg.TabIndex = 12;
            cagesMsg.Text = "What are you looking for?";
            // 
            // cagesSearchTbox
            // 
            cagesSearchTbox.Location = new Point(654, 60);
            cagesSearchTbox.Name = "cagesSearchTbox";
            cagesSearchTbox.Size = new Size(100, 23);
            cagesSearchTbox.TabIndex = 11;
            // 
            // cagesGrid
            // 
            cagesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            cagesGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            cagesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            cagesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            cagesGrid.DefaultCellStyle = dataGridViewCellStyle3;
            cagesGrid.Location = new Point(291, 103);
            cagesGrid.Name = "cagesGrid";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            cagesGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            cagesGrid.RowTemplate.Height = 25;
            cagesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cagesGrid.Size = new Size(391, 384);
            cagesGrid.TabIndex = 10;
            // 
            // lengthTbox
            // 
            lengthTbox.Location = new Point(140, 188);
            lengthTbox.Name = "lengthTbox";
            lengthTbox.Size = new Size(100, 23);
            lengthTbox.TabIndex = 9;
            // 
            // lengthLabel
            // 
            lengthLabel.AutoSize = true;
            lengthLabel.Location = new Point(47, 188);
            lengthLabel.Name = "lengthLabel";
            lengthLabel.Size = new Size(49, 15);
            lengthLabel.TabIndex = 8;
            lengthLabel.Text = "Length:";
            // 
            // cageTypeLabel
            // 
            cageTypeLabel.AutoSize = true;
            cageTypeLabel.Location = new Point(47, 228);
            cageTypeLabel.Name = "cageTypeLabel";
            cageTypeLabel.Size = new Size(86, 15);
            cageTypeLabel.TabIndex = 7;
            cageTypeLabel.Text = "Cage Material:";
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Location = new Point(47, 139);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new Size(44, 15);
            widthLabel.TabIndex = 6;
            widthLabel.Text = "Width:";
            // 
            // hightLabel
            // 
            hightLabel.AutoSize = true;
            hightLabel.Location = new Point(47, 92);
            hightLabel.Name = "hightLabel";
            hightLabel.Size = new Size(48, 15);
            hightLabel.TabIndex = 5;
            hightLabel.Text = "Height:";
            // 
            // cageSnLabel
            // 
            cageSnLabel.AutoSize = true;
            cageSnLabel.Location = new Point(47, 47);
            cageSnLabel.Name = "cageSnLabel";
            cageSnLabel.Size = new Size(56, 15);
            cageSnLabel.TabIndex = 4;
            cageSnLabel.Text = "Cage SN:";
            // 
            // materialCBox
            // 
            materialCBox.FormattingEnabled = true;
            materialCBox.Items.AddRange(new object[] { "Metal", "Wood", "Plastic" });
            materialCBox.Location = new Point(140, 228);
            materialCBox.Name = "materialCBox";
            materialCBox.Size = new Size(121, 23);
            materialCBox.TabIndex = 3;
            // 
            // heightTbox
            // 
            heightTbox.Location = new Point(140, 92);
            heightTbox.Name = "heightTbox";
            heightTbox.Size = new Size(100, 23);
            heightTbox.TabIndex = 2;
            // 
            // widthTbox
            // 
            widthTbox.Location = new Point(140, 139);
            widthTbox.Name = "widthTbox";
            widthTbox.Size = new Size(100, 23);
            widthTbox.TabIndex = 1;
            // 
            // cageSnTbox
            // 
            cageSnTbox.Location = new Point(140, 47);
            cageSnTbox.Name = "cageSnTbox";
            cageSnTbox.Size = new Size(100, 23);
            cageSnTbox.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Location = new Point(0, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1081, 22);
            panel3.TabIndex = 3;
            panel3.MouseDown += panel3_MouseDown;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.RosyBrown;
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.FlatAppearance.MouseOverBackColor = Color.White;
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            closeBtn.ForeColor = Color.FromArgb(41, 128, 185);
            closeBtn.Location = new Point(1087, -1);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(40, 40);
            closeBtn.TabIndex = 7;
            closeBtn.Text = "X";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // birdForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1127, 668);
            Controls.Add(closeBtn);
            Controls.Add(panel3);
            Controls.Add(addTabs);
            FormBorderStyle = FormBorderStyle.None;
            Name = "birdForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "birdForm";
            Load += birdForm_Load;
            ((System.ComponentModel.ISupportInitialize)birdsGrid).EndInit();
            addTabs.ResumeLayout(false);
            birdTab.ResumeLayout(false);
            birdTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            cageTab.ResumeLayout(false);
            cageTab.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)cagesGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button birdBtn;
        private Button cageBtn;
        private TabControl addTabs;
        private TabPage birdTab;
        private TabPage cageTab;
        private TextBox motherSnTbox;
        private TextBox fatherSnTbox;
        private TextBox cageNumTbox;
        private TextBox subspeciesTbox;
        private TextBox speciesTbox;
        private Label hatchingLabel;
        private Label motherSnLabel;
        private Label fatherSnLabel;
        private Label birdCageNumLabel;
        private Label genderLabel;
        private Label subSpeciesLabel;
        private Label speciesLabel;
        private Label birdSnLabel;
        private TextBox birdSnTbox;
        private Label cageSnLabel;
        private ComboBox materialCBox;
        private TextBox heightTbox;
        private TextBox widthTbox;
        private TextBox cageSnTbox;
        private Label cageTypeLabel;
        private Label widthLabel;
        private Label hightLabel;
        private ComboBox genderCbox;
        private DateTimePicker hatchingDatePicker;
        private TextBox lengthTbox;
        private Label lengthLabel;
        private TextBox birdSearchTBox;
        private Label searchLabel;
        private Button birdsearchBtn;
        private Button cagesSearchBtn;
        private Label cagesMsg;
        private TextBox cagesSearchTbox;
        private DataGridView cagesGrid;
        private RadioButton genderRadioBtn;
        private RadioButton hatchingDateRadioBtn;
        private RadioButton speciesRadioBtn;
        private RadioButton birdSNRadioBtn;
        private Panel panel1;
        private Button offspringBtn;
        private Panel panel2;
        public DataGridView birdsGrid;
        private Panel panel3;
        private Button closeBtn;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Button changesBtn;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox12;
        private Button button1;
        private PictureBox pictureBox11;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private Panel panel4;
        private RadioButton cageMaterialRadioBtn;
        private RadioButton cagesRadioBtn;
        private ListView cageBirdsList;
        private ColumnHeader BirdSN;
        private ColumnHeader Species;
        private ColumnHeader Subspecies;
        private ColumnHeader HatchingDate;
        private ColumnHeader Gender;
        private ColumnHeader CageSN;
        private ColumnHeader FatherSN;
        private ColumnHeader MotherSN;
    }
}