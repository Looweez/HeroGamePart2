namespace CleanCode
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
            this.btnAtkLeft = new System.Windows.Forms.Button();
            this.btnAtkUp = new System.Windows.Forms.Button();
            this.btnAtkRight = new System.Windows.Forms.Button();
            this.btnAtkDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.lblHeroStats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(611, 668);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btnAtkLeft
            // 
            this.btnAtkLeft.Location = new System.Drawing.Point(591, 431);
            this.btnAtkLeft.Name = "btnAtkLeft";
            this.btnAtkLeft.Size = new System.Drawing.Size(80, 44);
            this.btnAtkLeft.TabIndex = 2;
            this.btnAtkLeft.Text = "Attack Left";
            this.btnAtkLeft.UseVisualStyleBackColor = true;
            this.btnAtkLeft.Click += new System.EventHandler(this.btnAtkLeft_Click);
            // 
            // btnAtkUp
            // 
            this.btnAtkUp.Location = new System.Drawing.Point(669, 381);
            this.btnAtkUp.Name = "btnAtkUp";
            this.btnAtkUp.Size = new System.Drawing.Size(80, 44);
            this.btnAtkUp.TabIndex = 3;
            this.btnAtkUp.Text = "Attack up";
            this.btnAtkUp.UseVisualStyleBackColor = true;
            this.btnAtkUp.Click += new System.EventHandler(this.btnAtkUp_Click);
            // 
            // btnAtkRight
            // 
            this.btnAtkRight.Location = new System.Drawing.Point(747, 431);
            this.btnAtkRight.Name = "btnAtkRight";
            this.btnAtkRight.Size = new System.Drawing.Size(80, 44);
            this.btnAtkRight.TabIndex = 4;
            this.btnAtkRight.Text = "Attack Right";
            this.btnAtkRight.UseVisualStyleBackColor = true;
            this.btnAtkRight.Click += new System.EventHandler(this.btnAtkRight_Click);
            // 
            // btnAtkDown
            // 
            this.btnAtkDown.Location = new System.Drawing.Point(669, 481);
            this.btnAtkDown.Name = "btnAtkDown";
            this.btnAtkDown.Size = new System.Drawing.Size(80, 44);
            this.btnAtkDown.TabIndex = 5;
            this.btnAtkDown.Text = "Attack Down";
            this.btnAtkDown.UseVisualStyleBackColor = true;
            this.btnAtkDown.Click += new System.EventHandler(this.btnAtkDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(669, 151);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(80, 44);
            this.btnUp.TabIndex = 6;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(591, 196);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(80, 44);
            this.btnLeft.TabIndex = 7;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(669, 246);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(80, 44);
            this.btnDown.TabIndex = 8;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(747, 196);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(80, 44);
            this.btnRight.TabIndex = 8;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // lblHeroStats
            // 
            this.lblHeroStats.AutoSize = true;
            this.lblHeroStats.Location = new System.Drawing.Point(683, 50);
            this.lblHeroStats.Name = "lblHeroStats";
            this.lblHeroStats.Size = new System.Drawing.Size(35, 13);
            this.lblHeroStats.TabIndex = 9;
            this.lblHeroStats.Text = "label2";
            this.lblHeroStats.Click += new System.EventHandler(this.lblHeroStats_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 686);
            this.Controls.Add(this.lblHeroStats);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnAtkDown);
            this.Controls.Add(this.btnAtkRight);
            this.Controls.Add(this.btnAtkUp);
            this.Controls.Add(this.btnAtkLeft);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtkLeft;
        private System.Windows.Forms.Button btnAtkUp;
        private System.Windows.Forms.Button btnAtkRight;
        private System.Windows.Forms.Button btnAtkDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Label lblHeroStats;
    }
}

