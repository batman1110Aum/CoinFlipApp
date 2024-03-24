namespace CoinFlip
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            coinImage = new PictureBox();
            flipButton = new Button();
            HeadsLabel = new Label();
            TailsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)coinImage).BeginInit();
            SuspendLayout();
            // 
            // coinImage
            // 
            coinImage.Image = (Image)resources.GetObject("coinImage.Image");
            coinImage.Location = new Point(283, 28);
            coinImage.Name = "coinImage";
            coinImage.Size = new Size(259, 236);
            coinImage.SizeMode = PictureBoxSizeMode.StretchImage;
            coinImage.TabIndex = 0;
            coinImage.TabStop = false;
            // 
            // flipButton
            // 
            flipButton.FlatStyle = FlatStyle.System;
            flipButton.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flipButton.ForeColor = Color.Black;
            flipButton.Location = new Point(299, 321);
            flipButton.Name = "flipButton";
            flipButton.Size = new Size(243, 60);
            flipButton.TabIndex = 1;
            flipButton.Text = "FLIP!";
            flipButton.UseVisualStyleBackColor = true;
            flipButton.Click += flipButton_Click;
            // 
            // HeadsLabel
            // 
            HeadsLabel.AccessibleName = "HeadsLabel";
            HeadsLabel.BackColor = Color.White;
            HeadsLabel.Location = new Point(283, 282);
            HeadsLabel.Name = "HeadsLabel";
            HeadsLabel.Size = new Size(126, 36);
            HeadsLabel.TabIndex = 2;
            HeadsLabel.Text = "Heads";
            HeadsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TailsLabel
            // 
            TailsLabel.AccessibleName = "TailsLabel";
            TailsLabel.BackColor = Color.White;
            TailsLabel.Location = new Point(431, 282);
            TailsLabel.Name = "TailsLabel";
            TailsLabel.Size = new Size(126, 36);
            TailsLabel.TabIndex = 3;
            TailsLabel.Text = "Tails";
            TailsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(TailsLabel);
            Controls.Add(HeadsLabel);
            Controls.Add(flipButton);
            Controls.Add(coinImage);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "CoinFlipGame";
            ((System.ComponentModel.ISupportInitialize)coinImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox coinImage;
        private Button flipButton;
        private Label HeadsLabel;
        private Label TailsLabel;
    }
}
