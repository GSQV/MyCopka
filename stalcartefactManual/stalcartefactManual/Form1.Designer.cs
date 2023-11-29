namespace stalcartefactManual
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDelArt = new System.Windows.Forms.Button();
            this.buttonAddArt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBuff5 = new System.Windows.Forms.TextBox();
            this.textBoxBuff4 = new System.Windows.Forms.TextBox();
            this.textBoxBuff3 = new System.Windows.Forms.TextBox();
            this.textBoxBuff2 = new System.Windows.Forms.TextBox();
            this.textBoxBuff1 = new System.Windows.Forms.TextBox();
            this.textBoxDebuff3 = new System.Windows.Forms.TextBox();
            this.textBoxDebuff2 = new System.Windows.Forms.TextBox();
            this.textBoxDebuff1 = new System.Windows.Forms.TextBox();
            this.textBoxAnomaly = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1260, 733);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.Gray;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonClose.Location = new System.Drawing.Point(1514, 1);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(45, 43);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDelArt
            // 
            this.buttonDelArt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelArt.BackColor = System.Drawing.Color.Gray;
            this.buttonDelArt.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelArt.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.buttonDelArt.Location = new System.Drawing.Point(900, 497);
            this.buttonDelArt.Name = "buttonDelArt";
            this.buttonDelArt.Size = new System.Drawing.Size(565, 109);
            this.buttonDelArt.TabIndex = 4;
            this.buttonDelArt.Text = "УДАЛИТЬ";
            this.buttonDelArt.UseVisualStyleBackColor = false;
            this.buttonDelArt.Click += new System.EventHandler(this.buttonDelArt_Click);
            // 
            // buttonAddArt
            // 
            this.buttonAddArt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddArt.BackColor = System.Drawing.Color.Gray;
            this.buttonAddArt.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddArt.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.buttonAddArt.Location = new System.Drawing.Point(900, 382);
            this.buttonAddArt.Name = "buttonAddArt";
            this.buttonAddArt.Size = new System.Drawing.Size(565, 109);
            this.buttonAddArt.TabIndex = 5;
            this.buttonAddArt.Text = "ДОБАВИТЬ";
            this.buttonAddArt.UseVisualStyleBackColor = false;
            this.buttonAddArt.Click += new System.EventHandler(this.buttonAddArt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::stalcartefactManual.Properties.Resources._6hang2CqMHA_transformed;
            this.pictureBox1.Location = new System.Drawing.Point(-40, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 185);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(961, 80);
            this.label1.TabIndex = 7;
            this.label1.Text = "STALCRAFT ARTEFACT REFERENCE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(803, 479);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 31);
            this.label7.TabIndex = 40;
            this.label7.Text = "BUFF 5";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(803, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 31);
            this.label8.TabIndex = 39;
            this.label8.Text = "BUFF 4";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(803, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 31);
            this.label9.TabIndex = 38;
            this.label9.Text = "BUFF 3";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(803, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 31);
            this.label10.TabIndex = 37;
            this.label10.Text = "BUFF 2";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(803, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 31);
            this.label11.TabIndex = 36;
            this.label11.Text = "BUFF 1";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(312, 476);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 31);
            this.label6.TabIndex = 35;
            this.label6.Text = "DEBUFF 3";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(312, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 31);
            this.label5.TabIndex = 34;
            this.label5.Text = "DEBUFF 2";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(312, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 31);
            this.label4.TabIndex = 33;
            this.label4.Text = "DEBUFF 1";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(312, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 31);
            this.label3.TabIndex = 32;
            this.label3.Text = "ANOMALY";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Location = new System.Drawing.Point(312, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 31);
            this.label2.TabIndex = 31;
            this.label2.Text = "NAME";
            // 
            // textBoxBuff5
            // 
            this.textBoxBuff5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxBuff5.BackColor = System.Drawing.Color.Gray;
            this.textBoxBuff5.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuff5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBoxBuff5.Location = new System.Drawing.Point(932, 476);
            this.textBoxBuff5.Name = "textBoxBuff5";
            this.textBoxBuff5.Size = new System.Drawing.Size(271, 38);
            this.textBoxBuff5.TabIndex = 30;
            // 
            // textBoxBuff4
            // 
            this.textBoxBuff4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxBuff4.BackColor = System.Drawing.Color.Gray;
            this.textBoxBuff4.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuff4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBoxBuff4.Location = new System.Drawing.Point(932, 413);
            this.textBoxBuff4.Name = "textBoxBuff4";
            this.textBoxBuff4.Size = new System.Drawing.Size(271, 38);
            this.textBoxBuff4.TabIndex = 29;
            // 
            // textBoxBuff3
            // 
            this.textBoxBuff3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxBuff3.BackColor = System.Drawing.Color.Gray;
            this.textBoxBuff3.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuff3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBoxBuff3.Location = new System.Drawing.Point(932, 349);
            this.textBoxBuff3.Name = "textBoxBuff3";
            this.textBoxBuff3.Size = new System.Drawing.Size(271, 38);
            this.textBoxBuff3.TabIndex = 28;
            // 
            // textBoxBuff2
            // 
            this.textBoxBuff2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxBuff2.BackColor = System.Drawing.Color.Gray;
            this.textBoxBuff2.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuff2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBoxBuff2.Location = new System.Drawing.Point(932, 283);
            this.textBoxBuff2.Name = "textBoxBuff2";
            this.textBoxBuff2.Size = new System.Drawing.Size(271, 38);
            this.textBoxBuff2.TabIndex = 27;
            // 
            // textBoxBuff1
            // 
            this.textBoxBuff1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxBuff1.BackColor = System.Drawing.Color.Gray;
            this.textBoxBuff1.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuff1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBoxBuff1.Location = new System.Drawing.Point(932, 222);
            this.textBoxBuff1.Name = "textBoxBuff1";
            this.textBoxBuff1.Size = new System.Drawing.Size(271, 38);
            this.textBoxBuff1.TabIndex = 26;
            // 
            // textBoxDebuff3
            // 
            this.textBoxDebuff3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxDebuff3.BackColor = System.Drawing.Color.Gray;
            this.textBoxDebuff3.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDebuff3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxDebuff3.Location = new System.Drawing.Point(457, 476);
            this.textBoxDebuff3.Name = "textBoxDebuff3";
            this.textBoxDebuff3.Size = new System.Drawing.Size(293, 38);
            this.textBoxDebuff3.TabIndex = 25;
            // 
            // textBoxDebuff2
            // 
            this.textBoxDebuff2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxDebuff2.BackColor = System.Drawing.Color.Gray;
            this.textBoxDebuff2.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDebuff2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxDebuff2.Location = new System.Drawing.Point(457, 413);
            this.textBoxDebuff2.Name = "textBoxDebuff2";
            this.textBoxDebuff2.Size = new System.Drawing.Size(293, 38);
            this.textBoxDebuff2.TabIndex = 24;
            // 
            // textBoxDebuff1
            // 
            this.textBoxDebuff1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxDebuff1.BackColor = System.Drawing.Color.Gray;
            this.textBoxDebuff1.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDebuff1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxDebuff1.Location = new System.Drawing.Point(457, 349);
            this.textBoxDebuff1.Name = "textBoxDebuff1";
            this.textBoxDebuff1.Size = new System.Drawing.Size(293, 38);
            this.textBoxDebuff1.TabIndex = 23;
            // 
            // textBoxAnomaly
            // 
            this.textBoxAnomaly.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxAnomaly.BackColor = System.Drawing.Color.Gray;
            this.textBoxAnomaly.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnomaly.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.textBoxAnomaly.Location = new System.Drawing.Point(457, 283);
            this.textBoxAnomaly.Name = "textBoxAnomaly";
            this.textBoxAnomaly.Size = new System.Drawing.Size(293, 38);
            this.textBoxAnomaly.TabIndex = 22;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxName.BackColor = System.Drawing.Color.Gray;
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.textBoxName.Location = new System.Drawing.Point(457, 219);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(293, 38);
            this.textBoxName.TabIndex = 21;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.BackColor = System.Drawing.Color.Gray;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.buttonSave.Location = new System.Drawing.Point(900, 612);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(565, 109);
            this.buttonSave.TabIndex = 41;
            this.buttonSave.Text = "ИЗМЕНИТЬ";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Location = new System.Drawing.Point(1501, 665);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 43);
            this.button1.TabIndex = 42;
            this.button1.Text = "R";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ID
            // 
            this.ID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.ID.Location = new System.Drawing.Point(595, 138);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(36, 31);
            this.ID.TabIndex = 44;
            this.ID.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxID.BackColor = System.Drawing.Color.Gray;
            this.textBoxID.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.textBoxID.Location = new System.Drawing.Point(740, 135);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(293, 38);
            this.textBoxID.TabIndex = 43;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1870, 720);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBuff5);
            this.Controls.Add(this.textBoxBuff4);
            this.Controls.Add(this.textBoxBuff3);
            this.Controls.Add(this.textBoxBuff2);
            this.Controls.Add(this.textBoxBuff1);
            this.Controls.Add(this.textBoxDebuff3);
            this.Controls.Add(this.textBoxDebuff2);
            this.Controls.Add(this.textBoxDebuff1);
            this.Controls.Add(this.textBoxAnomaly);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddArt);
            this.Controls.Add(this.buttonDelArt);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonDelArt;
        private System.Windows.Forms.Button buttonAddArt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBuff5;
        private System.Windows.Forms.TextBox textBoxBuff4;
        private System.Windows.Forms.TextBox textBoxBuff3;
        private System.Windows.Forms.TextBox textBoxBuff2;
        private System.Windows.Forms.TextBox textBoxBuff1;
        private System.Windows.Forms.TextBox textBoxDebuff3;
        private System.Windows.Forms.TextBox textBoxDebuff2;
        private System.Windows.Forms.TextBox textBoxDebuff1;
        private System.Windows.Forms.TextBox textBoxAnomaly;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox textBoxID;
    }
}

