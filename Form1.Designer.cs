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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
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
            // HueKodeInput
            // 
            this.HueKodeInput.Location = new System.Drawing.Point(6, 140);
            this.HueKodeInput.Name = "HueKodeInput";
            this.HueKodeInput.Size = new System.Drawing.Size(194, 20);
            this.HueKodeInput.TabIndex = 5;
            this.HueKodeInput.TextChanged += new System.EventHandler(this.HueKodeInput_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 10.25F);
            this.label3.Location = new System.Drawing.Point(6, 119);
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
            this.IPInput.Size = new System.Drawing.Size(194, 20);
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
            this.NewGeneratedCode.Location = new System.Drawing.Point(180, 230);
            this.NewGeneratedCode.Name = "NewGeneratedCode";
            this.NewGeneratedCode.Size = new System.Drawing.Size(319, 13);
            this.NewGeneratedCode.TabIndex = 3;
            this.NewGeneratedCode.Text = "Her kommer din Unikke kode hvis det er første gang du connecter";
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
            this.STOPKNAPPEN.Location = new System.Drawing.Point(558, 193);
            this.STOPKNAPPEN.Name = "STOPKNAPPEN";
            this.STOPKNAPPEN.Size = new System.Drawing.Size(75, 23);
            this.STOPKNAPPEN.TabIndex = 6;
            this.STOPKNAPPEN.Text = "STOP";
            this.STOPKNAPPEN.UseVisualStyleBackColor = false;
            this.STOPKNAPPEN.Click += new System.EventHandler(this.STOPKNAPPEN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 263);
            this.Controls.Add(this.STOPKNAPPEN);
            this.Controls.Add(this.CurrentStatus);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.NewGeneratedCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "HUE APP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
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
    }
}

