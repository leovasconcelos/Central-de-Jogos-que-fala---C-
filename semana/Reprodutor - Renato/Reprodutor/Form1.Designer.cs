namespace Reprodutor
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAcdc = new System.Windows.Forms.Button();
            this.btnCharlieBrown = new System.Windows.Forms.Button();
            this.btnPausar = new System.Windows.Forms.Button();
            this.btnEscolha = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Indigo;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(145, 69);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 57);
            this.textBox1.TabIndex = 0;
            // 
            // btnAcdc
            // 
            this.btnAcdc.Location = new System.Drawing.Point(436, 40);
            this.btnAcdc.Name = "btnAcdc";
            this.btnAcdc.Size = new System.Drawing.Size(100, 23);
            this.btnAcdc.TabIndex = 1;
            this.btnAcdc.Text = "Tocar Ac/DC";
            this.btnAcdc.UseVisualStyleBackColor = true;
            this.btnAcdc.Click += new System.EventHandler(this.btnAcdc_Click);
            // 
            // btnCharlieBrown
            // 
            this.btnCharlieBrown.Location = new System.Drawing.Point(436, 69);
            this.btnCharlieBrown.Name = "btnCharlieBrown";
            this.btnCharlieBrown.Size = new System.Drawing.Size(100, 23);
            this.btnCharlieBrown.TabIndex = 2;
            this.btnCharlieBrown.Text = "Tocar Charlie Brown";
            this.btnCharlieBrown.UseVisualStyleBackColor = true;
            this.btnCharlieBrown.Click += new System.EventHandler(this.btnCharlieBrown_Click);
            // 
            // btnPausar
            // 
            this.btnPausar.Location = new System.Drawing.Point(436, 103);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(100, 23);
            this.btnPausar.TabIndex = 3;
            this.btnPausar.Text = "Pausar/Resumir";
            this.btnPausar.UseVisualStyleBackColor = true;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // btnEscolha
            // 
            this.btnEscolha.Location = new System.Drawing.Point(419, 143);
            this.btnEscolha.Name = "btnEscolha";
            this.btnEscolha.Size = new System.Drawing.Size(117, 23);
            this.btnEscolha.TabIndex = 4;
            this.btnEscolha.Text = "Escolha uma Musica!";
            this.btnEscolha.UseVisualStyleBackColor = true;
            this.btnEscolha.Click += new System.EventHandler(this.btnEscolha_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.progressBar1.ForeColor = System.Drawing.Color.Indigo;
            this.progressBar1.Location = new System.Drawing.Point(12, 172);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(524, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(555, 196);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnEscolha);
            this.Controls.Add(this.btnPausar);
            this.Controls.Add(this.btnCharlieBrown);
            this.Controls.Add(this.btnAcdc);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Reprodutor de Audio(via voz)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAcdc;
        private System.Windows.Forms.Button btnCharlieBrown;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Button btnEscolha;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

