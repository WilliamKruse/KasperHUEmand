namespace KasperHUEmand
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
            this.StartButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ChooseCountry = new System.Windows.Forms.ComboBox();
            this.HueHashInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.IPInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label4 = new System.Windows.Forms.Label();
            this.NewGeneratedCode = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.CurrentStatus = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.ToogleMusic = new System.Windows.Forms.CheckBox();
            this.TestLightButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.GeneratedHashCode = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BURHAN = new System.Windows.Forms.Button();
            this.NATHOLDET = new System.Windows.Forms.Button();
            this.UAK = new System.Windows.Forms.Button();
            this.GULDDRENG = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.ForeColor = System.Drawing.Color.Black;
            this.StartButton.Location = new System.Drawing.Point(300, 193);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ChooseCountry);
            this.groupBox1.Controls.Add(this.HueHashInput);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.IPInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 175);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oplysninger";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Vælg Land";
            // 
            // ChooseCountry
            // 
            this.ChooseCountry.AllowDrop = true;
            this.ChooseCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseCountry.FormattingEnabled = true;
            this.ChooseCountry.Location = new System.Drawing.Point(227, 94);
            this.ChooseCountry.Name = "ChooseCountry";
            this.ChooseCountry.Size = new System.Drawing.Size(121, 21);
            this.ChooseCountry.TabIndex = 6;
            this.ChooseCountry.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // HueHashInput
            // 
            this.HueHashInput.Location = new System.Drawing.Point(6, 140);
            this.HueHashInput.Name = "HueHashInput";
            this.HueHashInput.Size = new System.Drawing.Size(342, 20);
            this.HueHashInput.TabIndex = 5;
            this.HueHashInput.TextChanged += new System.EventHandler(this.HueKodeInput_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 10.25F);
            this.label3.Location = new System.Drawing.Point(3, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "DIN KODE FRA FØRSTE CONNECT";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 79);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(186, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Første gang jeg bruger denne app";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // IPInput
            // 
            this.IPInput.Location = new System.Drawing.Point(6, 52);
            this.IPInput.Name = "IPInput";
            this.IPInput.Size = new System.Drawing.Size(342, 20);
            this.IPInput.TabIndex = 2;
            this.IPInput.TextChanged += new System.EventHandler(this.IPInput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 12.25F);
            this.label2.Location = new System.Drawing.Point(74, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "( find den i din HUE-app )";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Impact", 10.25F);
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP ADRESSE";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 2;
            // 
            // NewGeneratedCode
            // 
            this.NewGeneratedCode.AutoSize = true;
            this.NewGeneratedCode.Location = new System.Drawing.Point(9, 228);
            this.NewGeneratedCode.Name = "NewGeneratedCode";
            this.NewGeneratedCode.Size = new System.Drawing.Size(322, 13);
            this.NewGeneratedCode.TabIndex = 3;
            this.NewGeneratedCode.Text = "Her kommer din Unikke kode hvis det er første gang du connecter:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(381, 22);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(50, 13);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "STATUS";
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(654, 74);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 6;
            this.StopButton.Text = "STOP";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.STOPKNAPPEN_Click);
            // 
            // ToogleMusic
            // 
            this.ToogleMusic.AutoSize = true;
            this.ToogleMusic.Location = new System.Drawing.Point(463, 200);
            this.ToogleMusic.Name = "ToogleMusic";
            this.ToogleMusic.Size = new System.Drawing.Size(77, 17);
            this.ToogleMusic.TabIndex = 7;
            this.ToogleMusic.Text = "Sluk musik";
            this.ToogleMusic.UseVisualStyleBackColor = true;
            this.ToogleMusic.CheckedChanged += new System.EventHandler(this.SlukMusik_CheckedChanged);
            // 
            // TestLightButton
            // 
            this.TestLightButton.Location = new System.Drawing.Point(66, 19);
            this.TestLightButton.Name = "TestLightButton";
            this.TestLightButton.Size = new System.Drawing.Size(75, 23);
            this.TestLightButton.TabIndex = 8;
            this.TestLightButton.Text = "Test Lys";
            this.TestLightButton.UseVisualStyleBackColor = true;
            this.TestLightButton.Click += new System.EventHandler(this.TestLys_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Kræver IP og KODE! Genstarter app efter test.";
            // 
            // GeneratedHashCode
            // 
            this.GeneratedHashCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GeneratedHashCode.Location = new System.Drawing.Point(12, 244);
            this.GeneratedHashCode.Multiline = true;
            this.GeneratedHashCode.Name = "GeneratedHashCode";
            this.GeneratedHashCode.ReadOnly = true;
            this.GeneratedHashCode.Size = new System.Drawing.Size(363, 20);
            this.GeneratedHashCode.TabIndex = 10;
            this.GeneratedHashCode.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TestLightButton);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 69);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test";
            // 
            // BURHAN
            // 
            this.BURHAN.Location = new System.Drawing.Point(463, 223);
            this.BURHAN.Name = "BURHAN";
            this.BURHAN.Size = new System.Drawing.Size(186, 23);
            this.BURHAN.TabIndex = 12;
            this.BURHAN.Text = "BURHAN G ft. LANDSHOLDET";
            this.BURHAN.UseVisualStyleBackColor = true;
            this.BURHAN.Click += new System.EventHandler(this.button2_Click);
            // 
            // NATHOLDET
            // 
            this.NATHOLDET.Location = new System.Drawing.Point(463, 252);
            this.NATHOLDET.Name = "NATHOLDET";
            this.NATHOLDET.Size = new System.Drawing.Size(186, 23);
            this.NATHOLDET.TabIndex = 13;
            this.NATHOLDET.Text = "NATHOLDET ft. CHRISTOPHER";
            this.NATHOLDET.UseVisualStyleBackColor = true;
            this.NATHOLDET.Click += new System.EventHandler(this.NATHOLDET_Click);
            // 
            // UAK
            // 
            this.UAK.Location = new System.Drawing.Point(463, 281);
            this.UAK.Name = "UAK";
            this.UAK.Size = new System.Drawing.Size(186, 23);
            this.UAK.TabIndex = 14;
            this.UAK.Text = "UAK";
            this.UAK.UseVisualStyleBackColor = true;
            this.UAK.Click += new System.EventHandler(this.UAK_Click);
            // 
            // GULDDRENG
            // 
            this.GULDDRENG.Location = new System.Drawing.Point(463, 310);
            this.GULDDRENG.Name = "GULDDRENG";
            this.GULDDRENG.Size = new System.Drawing.Size(186, 23);
            this.GULDDRENG.TabIndex = 15;
            this.GULDDRENG.Text = "GULDDRENG";
            this.GULDDRENG.UseVisualStyleBackColor = true;
            this.GULDDRENG.Click += new System.EventHandler(this.GULDDRENG_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 354);
            this.Controls.Add(this.GULDDRENG);
            this.Controls.Add(this.UAK);
            this.Controls.Add(this.NATHOLDET);
            this.Controls.Add(this.BURHAN);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GeneratedHashCode);
            this.Controls.Add(this.ToogleMusic);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.CurrentStatus);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.NewGeneratedCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "KasperHUEmand";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox IPInput;
        private System.Windows.Forms.TextBox HueHashInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CurrentStatus;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label NewGeneratedCode;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.CheckBox ToogleMusic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button TestLightButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox GeneratedHashCode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button NATHOLDET;
        private System.Windows.Forms.Button BURHAN;
        private System.Windows.Forms.Button GULDDRENG;
        private System.Windows.Forms.Button UAK;
        private System.Windows.Forms.ComboBox ChooseCountry;
    }
}

