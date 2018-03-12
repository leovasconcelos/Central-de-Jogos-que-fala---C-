namespace MicrosoftSpeechToTextExample
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
            this.btnWavFile = new System.Windows.Forms.Button();
            this.btnMic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWavFile
            // 
            this.btnWavFile.Location = new System.Drawing.Point(48, 31);
            this.btnWavFile.Name = "btnWavFile";
            this.btnWavFile.Size = new System.Drawing.Size(186, 37);
            this.btnWavFile.TabIndex = 0;
            this.btnWavFile.Text = "Transcribe a .WAV file";
            this.btnWavFile.UseVisualStyleBackColor = true;
            this.btnWavFile.Click += new System.EventHandler(this.btnWavFile_Click);
            // 
            // btnMic
            // 
            this.btnMic.Location = new System.Drawing.Point(48, 75);
            this.btnMic.Name = "btnMic";
            this.btnMic.Size = new System.Drawing.Size(186, 43);
            this.btnMic.TabIndex = 3;
            this.btnMic.Text = "Transcribe using your MIC";
            this.btnMic.UseVisualStyleBackColor = true;
            this.btnMic.Click += new System.EventHandler(this.btnMic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.btnMic);
            this.Controls.Add(this.btnWavFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWavFile;
        private System.Windows.Forms.Button btnMic;
    }
}

