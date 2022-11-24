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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.HueKodeInput = new System.Windows.Forms.TextBox();
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
            this.STOPKNAPPEN = new System.Windows.Forms.Button();
            this.SlukMusik = new System.Windows.Forms.CheckBox();
            this.TestLys = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.NewGeneratedCode2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PrevSong = new System.Windows.Forms.Button();
            this.NextSong = new System.Windows.Forms.Button();
            this.UAK = new System.Windows.Forms.Button();
            this.GULDDRENG = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(300, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.HueKodeInput);
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
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(227, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // HueKodeInput
            // 
            this.HueKodeInput.Location = new System.Drawing.Point(6, 140);
            this.HueKodeInput.Name = "HueKodeInput";
            this.HueKodeInput.Size = new System.Drawing.Size(342, 20);
            this.HueKodeInput.TabIndex = 5;
            this.HueKodeInput.TextChanged += new System.EventHandler(this.HueKodeInput_TextChanged);
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
            // CurrentStatus
            // 
            this.CurrentStatus.AutoSize = true;
            this.CurrentStatus.Location = new System.Drawing.Point(381, 53);
            this.CurrentStatus.Name = "CurrentStatus";
            this.CurrentStatus.Size = new System.Drawing.Size(118, 13);
            this.CurrentStatus.TabIndex = 5;
            this.CurrentStatus.Text = "Venter på oplysninger...";
            this.CurrentStatus.Click += new System.EventHandler(this.CurrentStatus_Click);
            // 
            // STOPKNAPPEN
            // 
            this.STOPKNAPPEN.BackColor = System.Drawing.SystemColors.Desktop;
            this.STOPKNAPPEN.Enabled = false;
            this.STOPKNAPPEN.Location = new System.Drawing.Point(654, 74);
            this.STOPKNAPPEN.Name = "STOPKNAPPEN";
            this.STOPKNAPPEN.Size = new System.Drawing.Size(75, 23);
            this.STOPKNAPPEN.TabIndex = 6;
            this.STOPKNAPPEN.Text = "STOP";
            this.STOPKNAPPEN.UseVisualStyleBackColor = false;
            this.STOPKNAPPEN.Click += new System.EventHandler(this.STOPKNAPPEN_Click);
            // 
            // SlukMusik
            // 
            this.SlukMusik.AutoSize = true;
            this.SlukMusik.Location = new System.Drawing.Point(463, 200);
            this.SlukMusik.Name = "SlukMusik";
            this.SlukMusik.Size = new System.Drawing.Size(77, 17);
            this.SlukMusik.TabIndex = 7;
            this.SlukMusik.Text = "Sluk musik";
            this.SlukMusik.UseVisualStyleBackColor = true;
            this.SlukMusik.CheckedChanged += new System.EventHandler(this.SlukMusik_CheckedChanged);
            // 
            // TestLys
            // 
            this.TestLys.Location = new System.Drawing.Point(66, 19);
            this.TestLys.Name = "TestLys";
            this.TestLys.Size = new System.Drawing.Size(75, 23);
            this.TestLys.TabIndex = 8;
            this.TestLys.Text = "Test Lys";
            this.TestLys.UseVisualStyleBackColor = true;
            this.TestLys.Click += new System.EventHandler(this.TestLys_Click);
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
            // NewGeneratedCode2
            // 
            this.NewGeneratedCode2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewGeneratedCode2.Location = new System.Drawing.Point(12, 244);
            this.NewGeneratedCode2.Multiline = true;
            this.NewGeneratedCode2.Name = "NewGeneratedCode2";
            this.NewGeneratedCode2.ReadOnly = true;
            this.NewGeneratedCode2.Size = new System.Drawing.Size(363, 20);
            this.NewGeneratedCode2.TabIndex = 10;
            this.NewGeneratedCode2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TestLys);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 69);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test";
            // 
            // PrevSong
            // 
            this.PrevSong.Location = new System.Drawing.Point(463, 223);
            this.PrevSong.Name = "PrevSong";
            this.PrevSong.Size = new System.Drawing.Size(186, 23);
            this.PrevSong.TabIndex = 12;
            this.PrevSong.Text = "BURHAN G ft. LANDSHOLDET";
            this.PrevSong.UseVisualStyleBackColor = true;
            this.PrevSong.Click += new System.EventHandler(this.button2_Click);
            // 
            // NextSong
            // 
            this.NextSong.Location = new System.Drawing.Point(463, 252);
            this.NextSong.Name = "NextSong";
            this.NextSong.Size = new System.Drawing.Size(186, 23);
            this.NextSong.TabIndex = 13;
            this.NextSong.Text = "NATHOLDET ft. CHRISTOPHER";
            this.NextSong.UseVisualStyleBackColor = true;
            this.NextSong.Click += new System.EventHandler(this.NextSong_Click);
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
            this.ClientSize = new System.Drawing.Size(741, 356);
            this.Controls.Add(this.GULDDRENG);
            this.Controls.Add(this.UAK);
            this.Controls.Add(this.NextSong);
            this.Controls.Add(this.PrevSong);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.NewGeneratedCode2);
            this.Controls.Add(this.SlukMusik);
            this.Controls.Add(this.STOPKNAPPEN);
            this.Controls.Add(this.CurrentStatus);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.NewGeneratedCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
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

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox IPInput;
        private System.Windows.Forms.TextBox HueKodeInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CurrentStatus;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label NewGeneratedCode;
        private System.Windows.Forms.Button STOPKNAPPEN;
        private System.Windows.Forms.CheckBox SlukMusik;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button TestLys;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NewGeneratedCode2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button NextSong;
        private System.Windows.Forms.Button PrevSong;
        private System.Windows.Forms.Button GULDDRENG;
        private System.Windows.Forms.Button UAK;
    }
}

