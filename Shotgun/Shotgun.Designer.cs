namespace Shotgun
{
    partial class Shotgun
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
            buttonShoot = new Button();
            buttonBlock = new Button();
            buttonRelod = new Button();
            labelPlayerAmmo = new Label();
            labelComputerAmmo = new Label();
            buttonRestart = new Button();
            buttonShotgun = new Button();
            textBoxResult = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonShoot
            // 
            buttonShoot.Location = new Point(117, 206);
            buttonShoot.Name = "buttonShoot";
            buttonShoot.Size = new Size(75, 23);
            buttonShoot.TabIndex = 0;
            buttonShoot.Text = "Shoot";
            buttonShoot.UseVisualStyleBackColor = true;
            buttonShoot.Click += buttonShoot_Click;
            // 
            // buttonBlock
            // 
            buttonBlock.Location = new Point(198, 206);
            buttonBlock.Name = "buttonBlock";
            buttonBlock.Size = new Size(75, 23);
            buttonBlock.TabIndex = 1;
            buttonBlock.Text = "Block";
            buttonBlock.UseVisualStyleBackColor = true;
            buttonBlock.Click += buttonBlock_Click;
            // 
            // buttonRelod
            // 
            buttonRelod.Location = new Point(279, 206);
            buttonRelod.Name = "buttonRelod";
            buttonRelod.Size = new Size(75, 23);
            buttonRelod.TabIndex = 2;
            buttonRelod.Text = "buttonRelod";
            buttonRelod.UseVisualStyleBackColor = true;
            buttonRelod.Click += buttonRelod_Click;
            // 
            // labelPlayerAmmo
            // 
            labelPlayerAmmo.AutoSize = true;
            labelPlayerAmmo.Location = new Point(29, 42);
            labelPlayerAmmo.Name = "labelPlayerAmmo";
            labelPlayerAmmo.Size = new Size(44, 15);
            labelPlayerAmmo.TabIndex = 3;
            labelPlayerAmmo.Text = "Ammo";
            // 
            // labelComputerAmmo
            // 
            labelComputerAmmo.AutoSize = true;
            labelComputerAmmo.Location = new Point(384, 42);
            labelComputerAmmo.Name = "labelComputerAmmo";
            labelComputerAmmo.Size = new Size(101, 15);
            labelComputerAmmo.TabIndex = 4;
            labelComputerAmmo.Text = "Computer Ammo";
            // 
            // buttonRestart
            // 
            buttonRestart.Location = new Point(198, 250);
            buttonRestart.Name = "buttonRestart";
            buttonRestart.Size = new Size(75, 23);
            buttonRestart.TabIndex = 5;
            buttonRestart.Text = "Restart";
            buttonRestart.UseVisualStyleBackColor = true;
            buttonRestart.Click += buttonRestart_Click;
            // 
            // buttonShotgun
            // 
            buttonShotgun.BackgroundImageLayout = ImageLayout.None;
            buttonShotgun.Location = new Point(198, 161);
            buttonShotgun.Name = "buttonShotgun";
            buttonShotgun.Size = new Size(75, 23);
            buttonShotgun.TabIndex = 6;
            buttonShotgun.Text = "Shotgun";
            buttonShotgun.UseVisualStyleBackColor = true;
            buttonShotgun.Click += buttonShotgun_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(120, 12);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(249, 143);
            textBoxResult.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(384, 27);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 8;
            label1.Text = "Computer Ammo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 27);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 9;
            label2.Text = "Player Ammo:";
            // 
            // Shotgun
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 285);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxResult);
            Controls.Add(buttonShotgun);
            Controls.Add(buttonRestart);
            Controls.Add(labelComputerAmmo);
            Controls.Add(labelPlayerAmmo);
            Controls.Add(buttonRelod);
            Controls.Add(buttonBlock);
            Controls.Add(buttonShoot);
            Name = "Shotgun";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonShoot;
        private Button buttonBlock;
        private Button buttonRelod;
        private Label labelPlayerAmmo;
        private Label labelComputerAmmo;
        private Button buttonRestart;
        private Button buttonShotgun;
        private TextBox textBoxResult;
        private Label label1;
        private Label label2;
    }
}
