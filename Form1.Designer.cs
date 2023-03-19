namespace MLblackjack
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DCvalue = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.DealerTitle = new System.Windows.Forms.Label();
            this.GameTitle = new System.Windows.Forms.Label();
            this.HitButton = new System.Windows.Forms.Button();
            this.StayButton = new System.Windows.Forms.Button();
            this.DCard1 = new System.Windows.Forms.Button();
            this.DCard2 = new System.Windows.Forms.Button();
            this.DCard4 = new System.Windows.Forms.Button();
            this.DCard3 = new System.Windows.Forms.Button();
            this.DCard5 = new System.Windows.Forms.Button();
            this.PCard5 = new System.Windows.Forms.Button();
            this.PCard4 = new System.Windows.Forms.Button();
            this.PCard3 = new System.Windows.Forms.Button();
            this.PCard2 = new System.Windows.Forms.Button();
            this.PCard1 = new System.Windows.Forms.Button();
            this.PlayerTitle = new System.Windows.Forms.Label();
            this.PCvalue = new System.Windows.Forms.Label();
            this.DCard1Value = new System.Windows.Forms.Label();
            this.DCard2Value = new System.Windows.Forms.Label();
            this.DCard3Value = new System.Windows.Forms.Label();
            this.DCard4Value = new System.Windows.Forms.Label();
            this.DCard5Value = new System.Windows.Forms.Label();
            this.PCard5Value = new System.Windows.Forms.Label();
            this.PCard4Value = new System.Windows.Forms.Label();
            this.PCard3Value = new System.Windows.Forms.Label();
            this.PCard2Value = new System.Windows.Forms.Label();
            this.PCard1Value = new System.Windows.Forms.Label();
            this.GiveAcesButton = new System.Windows.Forms.Button();
            this.DealerAcesButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.BetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // DCvalue
            // 
            this.DCvalue.AutoSize = true;
            this.DCvalue.BackColor = System.Drawing.Color.Maroon;
            this.DCvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DCvalue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DCvalue.Location = new System.Drawing.Point(164, 26);
            this.DCvalue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DCvalue.Name = "DCvalue";
            this.DCvalue.Size = new System.Drawing.Size(74, 29);
            this.DCvalue.TabIndex = 2;
            this.DCvalue.Text = "Total:";
            this.DCvalue.Click += new System.EventHandler(this.DCvalue_Click);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Transparent;
            this.StartButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartButton.BackgroundImage")));
            this.StartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.StartButton.FlatAppearance.BorderSize = 3;
            this.StartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Location = new System.Drawing.Point(783, 68);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(170, 70);
            this.StartButton.TabIndex = 8;
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // DealerTitle
            // 
            this.DealerTitle.AutoSize = true;
            this.DealerTitle.BackColor = System.Drawing.Color.Maroon;
            this.DealerTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DealerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DealerTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DealerTitle.Location = new System.Drawing.Point(34, 24);
            this.DealerTitle.Name = "DealerTitle";
            this.DealerTitle.Size = new System.Drawing.Size(123, 31);
            this.DealerTitle.TabIndex = 16;
            this.DealerTitle.Text = "DEALER";
            this.DealerTitle.Click += new System.EventHandler(this.DealerTitle_Click);
            // 
            // GameTitle
            // 
            this.GameTitle.AutoSize = true;
            this.GameTitle.BackColor = System.Drawing.Color.Teal;
            this.GameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GameTitle.Location = new System.Drawing.Point(350, 0);
            this.GameTitle.Name = "GameTitle";
            this.GameTitle.Size = new System.Drawing.Size(330, 31);
            this.GameTitle.TabIndex = 17;
            this.GameTitle.Text = "Miguel Llanes\'  Black Jack";
            // 
            // HitButton
            // 
            this.HitButton.BackColor = System.Drawing.Color.Transparent;
            this.HitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HitButton.BackgroundImage")));
            this.HitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.HitButton.FlatAppearance.BorderSize = 3;
            this.HitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HitButton.Location = new System.Drawing.Point(783, 419);
            this.HitButton.Margin = new System.Windows.Forms.Padding(4);
            this.HitButton.Name = "HitButton";
            this.HitButton.Size = new System.Drawing.Size(170, 70);
            this.HitButton.TabIndex = 18;
            this.HitButton.UseVisualStyleBackColor = false;
            this.HitButton.Click += new System.EventHandler(this.HitButton_Click);
            // 
            // StayButton
            // 
            this.StayButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StayButton.BackgroundImage")));
            this.StayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StayButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.StayButton.FlatAppearance.BorderSize = 3;
            this.StayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StayButton.Location = new System.Drawing.Point(783, 497);
            this.StayButton.Margin = new System.Windows.Forms.Padding(4);
            this.StayButton.Name = "StayButton";
            this.StayButton.Size = new System.Drawing.Size(170, 70);
            this.StayButton.TabIndex = 19;
            this.StayButton.UseVisualStyleBackColor = true;
            this.StayButton.Click += new System.EventHandler(this.StayButton_Click_1);
            // 
            // DCard1
            // 
            this.DCard1.BackColor = System.Drawing.Color.Transparent;
            this.DCard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DCard1.BackgroundImage")));
            this.DCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DCard1.FlatAppearance.BorderSize = 3;
            this.DCard1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.DCard1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DCard1.Location = new System.Drawing.Point(31, 68);
            this.DCard1.Margin = new System.Windows.Forms.Padding(4);
            this.DCard1.Name = "DCard1";
            this.DCard1.Size = new System.Drawing.Size(136, 190);
            this.DCard1.TabIndex = 20;
            this.DCard1.UseVisualStyleBackColor = false;
            this.DCard1.Click += new System.EventHandler(this.DCard1_Click);
            // 
            // DCard2
            // 
            this.DCard2.BackColor = System.Drawing.Color.Transparent;
            this.DCard2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DCard2.BackgroundImage")));
            this.DCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DCard2.FlatAppearance.BorderSize = 3;
            this.DCard2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.DCard2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DCard2.Location = new System.Drawing.Point(175, 68);
            this.DCard2.Margin = new System.Windows.Forms.Padding(4);
            this.DCard2.Name = "DCard2";
            this.DCard2.Size = new System.Drawing.Size(136, 190);
            this.DCard2.TabIndex = 21;
            this.DCard2.UseVisualStyleBackColor = false;
            this.DCard2.Click += new System.EventHandler(this.DCard2_Click);
            // 
            // DCard4
            // 
            this.DCard4.BackColor = System.Drawing.Color.Transparent;
            this.DCard4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DCard4.BackgroundImage")));
            this.DCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DCard4.FlatAppearance.BorderSize = 3;
            this.DCard4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.DCard4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DCard4.Location = new System.Drawing.Point(463, 68);
            this.DCard4.Margin = new System.Windows.Forms.Padding(4);
            this.DCard4.Name = "DCard4";
            this.DCard4.Size = new System.Drawing.Size(136, 190);
            this.DCard4.TabIndex = 23;
            this.DCard4.UseVisualStyleBackColor = false;
            this.DCard4.Click += new System.EventHandler(this.DCard4_Click);
            // 
            // DCard3
            // 
            this.DCard3.BackColor = System.Drawing.Color.Transparent;
            this.DCard3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DCard3.BackgroundImage")));
            this.DCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DCard3.FlatAppearance.BorderSize = 3;
            this.DCard3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.DCard3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DCard3.Location = new System.Drawing.Point(319, 68);
            this.DCard3.Margin = new System.Windows.Forms.Padding(4);
            this.DCard3.Name = "DCard3";
            this.DCard3.Size = new System.Drawing.Size(136, 190);
            this.DCard3.TabIndex = 22;
            this.DCard3.UseVisualStyleBackColor = false;
            this.DCard3.Click += new System.EventHandler(this.DCard3_Click);
            // 
            // DCard5
            // 
            this.DCard5.BackColor = System.Drawing.Color.Transparent;
            this.DCard5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DCard5.BackgroundImage")));
            this.DCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DCard5.FlatAppearance.BorderSize = 3;
            this.DCard5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.DCard5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DCard5.Location = new System.Drawing.Point(607, 68);
            this.DCard5.Margin = new System.Windows.Forms.Padding(4);
            this.DCard5.Name = "DCard5";
            this.DCard5.Size = new System.Drawing.Size(136, 190);
            this.DCard5.TabIndex = 24;
            this.DCard5.UseVisualStyleBackColor = false;
            this.DCard5.Click += new System.EventHandler(this.DCard5_Click);
            // 
            // PCard5
            // 
            this.PCard5.BackColor = System.Drawing.Color.Transparent;
            this.PCard5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PCard5.BackgroundImage")));
            this.PCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PCard5.FlatAppearance.BorderSize = 3;
            this.PCard5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.PCard5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PCard5.Location = new System.Drawing.Point(607, 397);
            this.PCard5.Margin = new System.Windows.Forms.Padding(4);
            this.PCard5.Name = "PCard5";
            this.PCard5.Size = new System.Drawing.Size(136, 190);
            this.PCard5.TabIndex = 29;
            this.PCard5.UseVisualStyleBackColor = false;
            this.PCard5.Click += new System.EventHandler(this.PCard5_Click);
            // 
            // PCard4
            // 
            this.PCard4.BackColor = System.Drawing.Color.Transparent;
            this.PCard4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PCard4.BackgroundImage")));
            this.PCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PCard4.FlatAppearance.BorderSize = 3;
            this.PCard4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.PCard4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PCard4.Location = new System.Drawing.Point(463, 397);
            this.PCard4.Margin = new System.Windows.Forms.Padding(4);
            this.PCard4.Name = "PCard4";
            this.PCard4.Size = new System.Drawing.Size(136, 190);
            this.PCard4.TabIndex = 28;
            this.PCard4.UseVisualStyleBackColor = false;
            this.PCard4.Click += new System.EventHandler(this.PCard4_Click);
            // 
            // PCard3
            // 
            this.PCard3.BackColor = System.Drawing.Color.Transparent;
            this.PCard3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PCard3.BackgroundImage")));
            this.PCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PCard3.FlatAppearance.BorderSize = 3;
            this.PCard3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.PCard3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PCard3.Location = new System.Drawing.Point(319, 397);
            this.PCard3.Margin = new System.Windows.Forms.Padding(4);
            this.PCard3.Name = "PCard3";
            this.PCard3.Size = new System.Drawing.Size(136, 190);
            this.PCard3.TabIndex = 27;
            this.PCard3.UseVisualStyleBackColor = false;
            this.PCard3.Click += new System.EventHandler(this.PCard3_Click);
            // 
            // PCard2
            // 
            this.PCard2.BackColor = System.Drawing.Color.Transparent;
            this.PCard2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PCard2.BackgroundImage")));
            this.PCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PCard2.FlatAppearance.BorderSize = 3;
            this.PCard2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.PCard2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PCard2.Location = new System.Drawing.Point(175, 397);
            this.PCard2.Margin = new System.Windows.Forms.Padding(4);
            this.PCard2.Name = "PCard2";
            this.PCard2.Size = new System.Drawing.Size(136, 190);
            this.PCard2.TabIndex = 26;
            this.PCard2.UseVisualStyleBackColor = false;
            this.PCard2.Click += new System.EventHandler(this.PCard2_Click);
            // 
            // PCard1
            // 
            this.PCard1.BackColor = System.Drawing.Color.Transparent;
            this.PCard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PCard1.BackgroundImage")));
            this.PCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PCard1.FlatAppearance.BorderSize = 3;
            this.PCard1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.PCard1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PCard1.Location = new System.Drawing.Point(31, 397);
            this.PCard1.Margin = new System.Windows.Forms.Padding(4);
            this.PCard1.Name = "PCard1";
            this.PCard1.Size = new System.Drawing.Size(136, 190);
            this.PCard1.TabIndex = 25;
            this.PCard1.UseVisualStyleBackColor = false;
            this.PCard1.Click += new System.EventHandler(this.PCard1_Click);
            // 
            // PlayerTitle
            // 
            this.PlayerTitle.AutoSize = true;
            this.PlayerTitle.BackColor = System.Drawing.Color.ForestGreen;
            this.PlayerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PlayerTitle.Location = new System.Drawing.Point(32, 355);
            this.PlayerTitle.Name = "PlayerTitle";
            this.PlayerTitle.Size = new System.Drawing.Size(73, 31);
            this.PlayerTitle.TabIndex = 30;
            this.PlayerTitle.Text = "YOU";
            this.PlayerTitle.Click += new System.EventHandler(this.PlayerTitle_Click);
            // 
            // PCvalue
            // 
            this.PCvalue.AutoSize = true;
            this.PCvalue.BackColor = System.Drawing.Color.ForestGreen;
            this.PCvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCvalue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PCvalue.Location = new System.Drawing.Point(112, 357);
            this.PCvalue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PCvalue.Name = "PCvalue";
            this.PCvalue.Size = new System.Drawing.Size(74, 29);
            this.PCvalue.TabIndex = 31;
            this.PCvalue.Text = "Total:";
            this.PCvalue.Click += new System.EventHandler(this.PCvalue_Click);
            // 
            // DCard1Value
            // 
            this.DCard1Value.AutoSize = true;
            this.DCard1Value.BackColor = System.Drawing.Color.Transparent;
            this.DCard1Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DCard1Value.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DCard1Value.Location = new System.Drawing.Point(56, 273);
            this.DCard1Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DCard1Value.Name = "DCard1Value";
            this.DCard1Value.Size = new System.Drawing.Size(0, 29);
            this.DCard1Value.TabIndex = 32;
            // 
            // DCard2Value
            // 
            this.DCard2Value.AutoSize = true;
            this.DCard2Value.BackColor = System.Drawing.Color.Transparent;
            this.DCard2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DCard2Value.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DCard2Value.Location = new System.Drawing.Point(207, 273);
            this.DCard2Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DCard2Value.Name = "DCard2Value";
            this.DCard2Value.Size = new System.Drawing.Size(0, 29);
            this.DCard2Value.TabIndex = 33;
            // 
            // DCard3Value
            // 
            this.DCard3Value.AutoSize = true;
            this.DCard3Value.BackColor = System.Drawing.Color.Transparent;
            this.DCard3Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DCard3Value.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DCard3Value.Location = new System.Drawing.Point(352, 273);
            this.DCard3Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DCard3Value.Name = "DCard3Value";
            this.DCard3Value.Size = new System.Drawing.Size(0, 29);
            this.DCard3Value.TabIndex = 34;
            // 
            // DCard4Value
            // 
            this.DCard4Value.AutoSize = true;
            this.DCard4Value.BackColor = System.Drawing.Color.Transparent;
            this.DCard4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DCard4Value.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DCard4Value.Location = new System.Drawing.Point(494, 273);
            this.DCard4Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DCard4Value.Name = "DCard4Value";
            this.DCard4Value.Size = new System.Drawing.Size(0, 29);
            this.DCard4Value.TabIndex = 35;
            // 
            // DCard5Value
            // 
            this.DCard5Value.AutoSize = true;
            this.DCard5Value.BackColor = System.Drawing.Color.Transparent;
            this.DCard5Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DCard5Value.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DCard5Value.Location = new System.Drawing.Point(637, 273);
            this.DCard5Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DCard5Value.Name = "DCard5Value";
            this.DCard5Value.Size = new System.Drawing.Size(0, 29);
            this.DCard5Value.TabIndex = 36;
            // 
            // PCard5Value
            // 
            this.PCard5Value.AutoSize = true;
            this.PCard5Value.BackColor = System.Drawing.Color.Transparent;
            this.PCard5Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCard5Value.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PCard5Value.Location = new System.Drawing.Point(643, 600);
            this.PCard5Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PCard5Value.Name = "PCard5Value";
            this.PCard5Value.Size = new System.Drawing.Size(0, 29);
            this.PCard5Value.TabIndex = 41;
            // 
            // PCard4Value
            // 
            this.PCard4Value.AutoSize = true;
            this.PCard4Value.BackColor = System.Drawing.Color.Transparent;
            this.PCard4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCard4Value.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PCard4Value.Location = new System.Drawing.Point(500, 600);
            this.PCard4Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PCard4Value.Name = "PCard4Value";
            this.PCard4Value.Size = new System.Drawing.Size(0, 29);
            this.PCard4Value.TabIndex = 40;
            // 
            // PCard3Value
            // 
            this.PCard3Value.AutoSize = true;
            this.PCard3Value.BackColor = System.Drawing.Color.Transparent;
            this.PCard3Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCard3Value.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PCard3Value.Location = new System.Drawing.Point(358, 600);
            this.PCard3Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PCard3Value.Name = "PCard3Value";
            this.PCard3Value.Size = new System.Drawing.Size(0, 29);
            this.PCard3Value.TabIndex = 39;
            // 
            // PCard2Value
            // 
            this.PCard2Value.AutoSize = true;
            this.PCard2Value.BackColor = System.Drawing.Color.Transparent;
            this.PCard2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCard2Value.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PCard2Value.Location = new System.Drawing.Point(213, 600);
            this.PCard2Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PCard2Value.Name = "PCard2Value";
            this.PCard2Value.Size = new System.Drawing.Size(0, 29);
            this.PCard2Value.TabIndex = 38;
            // 
            // PCard1Value
            // 
            this.PCard1Value.AutoSize = true;
            this.PCard1Value.BackColor = System.Drawing.Color.Transparent;
            this.PCard1Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCard1Value.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PCard1Value.Location = new System.Drawing.Point(62, 600);
            this.PCard1Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PCard1Value.Name = "PCard1Value";
            this.PCard1Value.Size = new System.Drawing.Size(0, 29);
            this.PCard1Value.TabIndex = 37;
            // 
            // GiveAcesButton
            // 
            this.GiveAcesButton.BackColor = System.Drawing.Color.Transparent;
            this.GiveAcesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GiveAcesButton.BackgroundImage")));
            this.GiveAcesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GiveAcesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.GiveAcesButton.FlatAppearance.BorderSize = 3;
            this.GiveAcesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GiveAcesButton.Location = new System.Drawing.Point(853, 269);
            this.GiveAcesButton.Margin = new System.Windows.Forms.Padding(4);
            this.GiveAcesButton.Name = "GiveAcesButton";
            this.GiveAcesButton.Size = new System.Drawing.Size(100, 45);
            this.GiveAcesButton.TabIndex = 42;
            this.GiveAcesButton.UseVisualStyleBackColor = false;
            this.GiveAcesButton.Click += new System.EventHandler(this.GiveAcesButton_Click);
            // 
            // DealerAcesButton
            // 
            this.DealerAcesButton.BackColor = System.Drawing.Color.Transparent;
            this.DealerAcesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DealerAcesButton.BackgroundImage")));
            this.DealerAcesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DealerAcesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DealerAcesButton.FlatAppearance.BorderSize = 3;
            this.DealerAcesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DealerAcesButton.Location = new System.Drawing.Point(853, 323);
            this.DealerAcesButton.Margin = new System.Windows.Forms.Padding(4);
            this.DealerAcesButton.Name = "DealerAcesButton";
            this.DealerAcesButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DealerAcesButton.Size = new System.Drawing.Size(100, 45);
            this.DealerAcesButton.TabIndex = 43;
            this.DealerAcesButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DealerAcesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.DealerAcesButton.UseVisualStyleBackColor = false;
            this.DealerAcesButton.Click += new System.EventHandler(this.DealerAcesButton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.Control;
            this.numericUpDown1.Location = new System.Drawing.Point(813, 177);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(111, 22);
            this.numericUpDown1.TabIndex = 44;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // BetLabel
            // 
            this.BetLabel.AutoSize = true;
            this.BetLabel.BackColor = System.Drawing.Color.Green;
            this.BetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BetLabel.Location = new System.Drawing.Point(788, 145);
            this.BetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BetLabel.Name = "BetLabel";
            this.BetLabel.Size = new System.Drawing.Size(136, 29);
            this.BetLabel.TabIndex = 45;
            this.BetLabel.Text = "Money: $$$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.BetLabel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.DealerAcesButton);
            this.Controls.Add(this.GiveAcesButton);
            this.Controls.Add(this.PCard5Value);
            this.Controls.Add(this.PCard4Value);
            this.Controls.Add(this.PCard3Value);
            this.Controls.Add(this.PCard2Value);
            this.Controls.Add(this.PCard1Value);
            this.Controls.Add(this.DCard5Value);
            this.Controls.Add(this.DCard4Value);
            this.Controls.Add(this.DCard3Value);
            this.Controls.Add(this.DCard2Value);
            this.Controls.Add(this.DCard1Value);
            this.Controls.Add(this.PCvalue);
            this.Controls.Add(this.PlayerTitle);
            this.Controls.Add(this.PCard5);
            this.Controls.Add(this.PCard4);
            this.Controls.Add(this.PCard3);
            this.Controls.Add(this.PCard2);
            this.Controls.Add(this.PCard1);
            this.Controls.Add(this.DCard5);
            this.Controls.Add(this.DCard4);
            this.Controls.Add(this.DCard3);
            this.Controls.Add(this.DCard2);
            this.Controls.Add(this.DCard1);
            this.Controls.Add(this.StayButton);
            this.Controls.Add(this.HitButton);
            this.Controls.Add(this.GameTitle);
            this.Controls.Add(this.DealerTitle);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.DCvalue);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "COP2362 Black Jack!!!!";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DCvalue;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label DealerTitle;
        private System.Windows.Forms.Label GameTitle;
        private System.Windows.Forms.Button HitButton;
        private System.Windows.Forms.Button StayButton;
        private System.Windows.Forms.Button DCard1;
        private System.Windows.Forms.Button DCard2;
        private System.Windows.Forms.Button DCard4;
        private System.Windows.Forms.Button DCard3;
        private System.Windows.Forms.Button DCard5;
        private System.Windows.Forms.Button PCard5;
        private System.Windows.Forms.Button PCard4;
        private System.Windows.Forms.Button PCard3;
        private System.Windows.Forms.Button PCard2;
        private System.Windows.Forms.Button PCard1;
        private System.Windows.Forms.Label PlayerTitle;
        private System.Windows.Forms.Label PCvalue;
        private System.Windows.Forms.Label DCard1Value;
        private System.Windows.Forms.Label DCard2Value;
        private System.Windows.Forms.Label DCard3Value;
        private System.Windows.Forms.Label DCard4Value;
        private System.Windows.Forms.Label DCard5Value;
        private System.Windows.Forms.Label PCard5Value;
        private System.Windows.Forms.Label PCard4Value;
        private System.Windows.Forms.Label PCard3Value;
        private System.Windows.Forms.Label PCard2Value;
        private System.Windows.Forms.Label PCard1Value;
        private System.Windows.Forms.Button GiveAcesButton;
        private System.Windows.Forms.Button DealerAcesButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label BetLabel;
    }
}

