namespace ClientTSP
{
    partial class Przycisk
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
            this.Adress = new System.Windows.Forms.TextBox();
            this.port_p = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Polaczenie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.port_p)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zamknij\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Adress
            // 
            this.Adress.Location = new System.Drawing.Point(37, 31);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(210, 20);
            this.Adress.TabIndex = 1;
            this.Adress.Text = "Adress";
            // 
            // port_p
            // 
            this.port_p.Location = new System.Drawing.Point(465, 37);
            this.port_p.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.port_p.Name = "port_p";
            this.port_p.Size = new System.Drawing.Size(240, 20);
            this.port_p.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(37, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(668, 355);
            this.listBox1.TabIndex = 3;
            // 
            // Polaczenie
            // 
            this.Polaczenie.Location = new System.Drawing.Point(144, 441);
            this.Polaczenie.Name = "Polaczenie";
            this.Polaczenie.Size = new System.Drawing.Size(137, 50);
            this.Polaczenie.TabIndex = 4;
            this.Polaczenie.Text = "Polacz";
            this.Polaczenie.UseVisualStyleBackColor = true;
            this.Polaczenie.Click += new System.EventHandler(this.Polaczenie_Click);
            // 
            // Przycisk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 530);
            this.Controls.Add(this.Polaczenie);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.port_p);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.button1);
            this.Name = "Przycisk";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.port_p)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Adress;
        private System.Windows.Forms.NumericUpDown port_p;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Polaczenie;
    }
}

