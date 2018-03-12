namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtV1 = new System.Windows.Forms.TextBox();
            this.txtV2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSoma = new System.Windows.Forms.Label();
            this.lblMulti = new System.Windows.Forms.Label();
            this.lblDiv = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora:";
            // 
            // txtV1
            // 
            this.txtV1.Location = new System.Drawing.Point(101, 118);
            this.txtV1.Multiline = true;
            this.txtV1.Name = "txtV1";
            this.txtV1.Size = new System.Drawing.Size(94, 81);
            this.txtV1.TabIndex = 1;
            this.txtV1.Text = "1";
            this.txtV1.TextChanged += new System.EventHandler(this.txtV1_TextChanged);
            // 
            // txtV2
            // 
            this.txtV2.Location = new System.Drawing.Point(226, 118);
            this.txtV2.Multiline = true;
            this.txtV2.Name = "txtV2";
            this.txtV2.Size = new System.Drawing.Size(94, 81);
            this.txtV2.TabIndex = 2;
            this.txtV2.Text = "1";
            this.txtV2.TextChanged += new System.EventHandler(this.txtV2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Multiplicação:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Divisão:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Subtração:";
            // 
            // lblSoma
            // 
            this.lblSoma.AutoSize = true;
            this.lblSoma.Location = new System.Drawing.Point(162, 289);
            this.lblSoma.Name = "lblSoma";
            this.lblSoma.Size = new System.Drawing.Size(19, 13);
            this.lblSoma.TabIndex = 4;
            this.lblSoma.Text = " ...";
            // 
            // lblMulti
            // 
            this.lblMulti.AutoSize = true;
            this.lblMulti.Location = new System.Drawing.Point(165, 302);
            this.lblMulti.Name = "lblMulti";
            this.lblMulti.Size = new System.Drawing.Size(16, 13);
            this.lblMulti.TabIndex = 5;
            this.lblMulti.Text = "...";
            // 
            // lblDiv
            // 
            this.lblDiv.AutoSize = true;
            this.lblDiv.Location = new System.Drawing.Point(165, 315);
            this.lblDiv.Name = "lblDiv";
            this.lblDiv.Size = new System.Drawing.Size(16, 13);
            this.lblDiv.TabIndex = 6;
            this.lblDiv.Text = "...";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Location = new System.Drawing.Point(165, 328);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(16, 13);
            this.lblSub.TabIndex = 7;
            this.lblSub.Text = "...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 102);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 493);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lblDiv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMulti);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSoma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtV2);
            this.Controls.Add(this.txtV1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtV1;
        private System.Windows.Forms.TextBox txtV2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSoma;
        private System.Windows.Forms.Label lblMulti;
        private System.Windows.Forms.Label lblDiv;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Button button1;
    }
}

