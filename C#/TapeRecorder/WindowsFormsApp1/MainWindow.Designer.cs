namespace TapeRecorder
{
    partial class MainWindow
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonRecord = new System.Windows.Forms.Button();
            this.buttonRewind = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonFastForward = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.playHead = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.playHead)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(114, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(471, 116);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "STOPPED";
            // 
            // buttonRecord
            // 
            this.buttonRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecord.Location = new System.Drawing.Point(54, 236);
            this.buttonRecord.Name = "buttonRecord";
            this.buttonRecord.Size = new System.Drawing.Size(112, 50);
            this.buttonRecord.TabIndex = 1;
            this.buttonRecord.Text = "REC";
            this.buttonRecord.UseVisualStyleBackColor = true;
            this.buttonRecord.Click += new System.EventHandler(this.buttonRecord_Click);
            // 
            // buttonRewind
            // 
            this.buttonRewind.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRewind.Location = new System.Drawing.Point(172, 236);
            this.buttonRewind.Name = "buttonRewind";
            this.buttonRewind.Size = new System.Drawing.Size(112, 50);
            this.buttonRewind.TabIndex = 1;
            this.buttonRewind.Text = "<<";
            this.buttonRewind.UseVisualStyleBackColor = true;
            this.buttonRewind.Click += new System.EventHandler(this.buttonRewind_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.Location = new System.Drawing.Point(290, 236);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(112, 50);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.Text = ">";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonFastForward
            // 
            this.buttonFastForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFastForward.Location = new System.Drawing.Point(408, 236);
            this.buttonFastForward.Name = "buttonFastForward";
            this.buttonFastForward.Size = new System.Drawing.Size(112, 50);
            this.buttonFastForward.TabIndex = 1;
            this.buttonFastForward.Text = ">>";
            this.buttonFastForward.UseVisualStyleBackColor = true;
            this.buttonFastForward.Click += new System.EventHandler(this.buttonFastForward_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.Location = new System.Drawing.Point(526, 236);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(112, 50);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "STOP";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // trackBar1
            // 
            this.playHead.Location = new System.Drawing.Point(54, 174);
            this.playHead.Maximum = 1000;
            this.playHead.Name = "trackBar1";
            this.playHead.Size = new System.Drawing.Size(584, 45);
            this.playHead.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 316);
            this.Controls.Add(this.playHead);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonFastForward);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonRewind);
            this.Controls.Add(this.buttonRecord);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.playHead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonRecord;
        private System.Windows.Forms.Button buttonRewind;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonFastForward;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TrackBar playHead;
    }
}

