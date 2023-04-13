namespace simpleGame
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
            this.scoreLabel = new System.Windows.Forms.Label();
            this.ground = new System.Windows.Forms.PictureBox();
            this.defaultPlatform0 = new System.Windows.Forms.PictureBox();
            this.defaultPlatform1 = new System.Windows.Forms.PictureBox();
            this.playerBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultPlatform0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultPlatform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ground.Location = new System.Drawing.Point(-1, 587);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(966, 35);
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            this.ground.Tag = "platform";
            // 
            // defaultPlatform0
            // 
            this.defaultPlatform0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.defaultPlatform0.Location = new System.Drawing.Point(233, 535);
            this.defaultPlatform0.Name = "defaultPlatform0";
            this.defaultPlatform0.Size = new System.Drawing.Size(137, 25);
            this.defaultPlatform0.TabIndex = 2;
            this.defaultPlatform0.TabStop = false;
            this.defaultPlatform0.Tag = "platform";
            // 
            // defaultPlatform1
            // 
            this.defaultPlatform1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.defaultPlatform1.Location = new System.Drawing.Point(544, 494);
            this.defaultPlatform1.Name = "defaultPlatform1";
            this.defaultPlatform1.Size = new System.Drawing.Size(70, 25);
            this.defaultPlatform1.TabIndex = 3;
            this.defaultPlatform1.TabStop = false;
            this.defaultPlatform1.Tag = "platform";
            // 
            // playerBox
            // 
            this.playerBox.Location = new System.Drawing.Point(85, 523);
            this.playerBox.Name = "playerBox";
            this.playerBox.Size = new System.Drawing.Size(42, 69);
            this.playerBox.TabIndex = 4;
            this.playerBox.TabStop = false;
            this.playerBox.Tag = "player";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(964, 622);
            this.Controls.Add(this.playerBox);
            this.Controls.Add(this.defaultPlatform1);
            this.Controls.Add(this.defaultPlatform0);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.scoreLabel);
            this.Name = "Form1";
            this.Text = "placeholderName";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultPlatform0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultPlatform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox defaultPlatform0;
        private System.Windows.Forms.PictureBox defaultPlatform1;
        private System.Windows.Forms.PictureBox playerBox;
    }
}

