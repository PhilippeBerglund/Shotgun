namespace Shotgun
{
    partial class FormShotgun
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnShoot = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShotgun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPlayShots = new System.Windows.Forms.Label();
            this.lblCpuShots = new System.Windows.Forms.Label();
            this.lblPlAction = new System.Windows.Forms.Label();
            this.lblCpuAction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(128, 204);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(139, 67);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnShoot
            // 
            this.btnShoot.Location = new System.Drawing.Point(314, 204);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(139, 67);
            this.btnShoot.TabIndex = 1;
            this.btnShoot.Text = "Shoot";
            this.btnShoot.UseVisualStyleBackColor = true;
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(500, 204);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(139, 67);
            this.btnBlock.TabIndex = 2;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(500, 333);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(140, 43);
            this.btnNewGame.TabIndex = 3;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Shotgun";
            // 
            // btnShotgun
            // 
            this.btnShotgun.Location = new System.Drawing.Point(128, 333);
            this.btnShotgun.Name = "btnShotgun";
            this.btnShotgun.Size = new System.Drawing.Size(325, 43);
            this.btnShotgun.TabIndex = 5;
            this.btnShotgun.Text = "Shotgun";
            this.btnShotgun.UseVisualStyleBackColor = true;
            this.btnShotgun.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Player Shots";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "CPU Shots";
            // 
            // lblPlayShots
            // 
            this.lblPlayShots.AutoSize = true;
            this.lblPlayShots.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayShots.Location = new System.Drawing.Point(310, 52);
            this.lblPlayShots.Name = "lblPlayShots";
            this.lblPlayShots.Size = new System.Drawing.Size(23, 25);
            this.lblPlayShots.TabIndex = 8;
            this.lblPlayShots.Text = "0";
            // 
            // lblCpuShots
            // 
            this.lblCpuShots.AutoSize = true;
            this.lblCpuShots.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpuShots.Location = new System.Drawing.Point(310, 119);
            this.lblCpuShots.Name = "lblCpuShots";
            this.lblCpuShots.Size = new System.Drawing.Size(23, 25);
            this.lblCpuShots.TabIndex = 9;
            this.lblCpuShots.Text = "0";
            // 
            // lblPlAction
            // 
            this.lblPlAction.AutoSize = true;
            this.lblPlAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlAction.Location = new System.Drawing.Point(589, 52);
            this.lblPlAction.Name = "lblPlAction";
            this.lblPlAction.Size = new System.Drawing.Size(19, 25);
            this.lblPlAction.TabIndex = 10;
            this.lblPlAction.Text = "-";
            // 
            // lblCpuAction
            // 
            this.lblCpuAction.AutoSize = true;
            this.lblCpuAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpuAction.Location = new System.Drawing.Point(588, 119);
            this.lblCpuAction.Name = "lblCpuAction";
            this.lblCpuAction.Size = new System.Drawing.Size(19, 25);
            this.lblCpuAction.TabIndex = 11;
            this.lblCpuAction.Text = "-";
            // 
            // FormShotgun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 492);
            this.Controls.Add(this.lblCpuAction);
            this.Controls.Add(this.lblPlAction);
            this.Controls.Add(this.lblCpuShots);
            this.Controls.Add(this.lblPlayShots);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnShotgun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.btnShoot);
            this.Controls.Add(this.btnLoad);
            this.Name = "FormShotgun";
            this.Text = "Shotgun";
            this.Load += new System.EventHandler(this.FormShotgun_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnShoot;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShotgun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPlayShots;
        private System.Windows.Forms.Label lblCpuShots;
        private System.Windows.Forms.Label lblPlAction;
        private System.Windows.Forms.Label lblCpuAction;
    }
}

