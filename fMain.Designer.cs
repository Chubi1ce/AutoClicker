namespace AutoClicker
{
    partial class fMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNeoBux = new Button();
            txtCapcha = new TextBox();
            btnNext = new Button();
            pbCapcha = new PictureBox();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pbCapcha).BeginInit();
            SuspendLayout();
            // 
            // btnNeoBux
            // 
            btnNeoBux.Location = new Point(12, 12);
            btnNeoBux.Name = "btnNeoBux";
            btnNeoBux.Size = new Size(92, 52);
            btnNeoBux.TabIndex = 0;
            btnNeoBux.Text = "NeoBux";
            btnNeoBux.UseVisualStyleBackColor = true;
            btnNeoBux.Click += btnNeoBux_Click;
            // 
            // txtCapcha
            // 
            txtCapcha.Location = new Point(110, 41);
            txtCapcha.Name = "txtCapcha";
            txtCapcha.Size = new Size(91, 23);
            txtCapcha.TabIndex = 1;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(207, 12);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 52);
            btnNext.TabIndex = 2;
            btnNext.Text = "button1";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // pbCapcha
            // 
            pbCapcha.Location = new Point(110, 12);
            pbCapcha.Name = "pbCapcha";
            pbCapcha.Size = new Size(91, 23);
            pbCapcha.TabIndex = 3;
            pbCapcha.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(612, 225);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 4;
            btnExit.Text = "button1";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(pbCapcha);
            Controls.Add(btnNext);
            Controls.Add(txtCapcha);
            Controls.Add(btnNeoBux);
            Name = "fMain";
            Text = "AutoClicker";
            ((System.ComponentModel.ISupportInitialize)pbCapcha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNeoBux;
        private TextBox txtCapcha;
        private Button btnNext;
        private PictureBox pbCapcha;
        private Button btnExit;
    }
}
