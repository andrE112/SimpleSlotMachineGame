namespace SlotMachineGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tmrSlot1 = new System.Windows.Forms.Timer(this.components);
            this.btnSpin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.betBox = new System.Windows.Forms.TextBox();
            this.betLabel = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrSlot1
            // 
            this.tmrSlot1.Interval = 1;
            this.tmrSlot1.Tick += new System.EventHandler(this.tmrSlot1_Tick);
            // 
            // btnSpin
            // 
            this.btnSpin.BackColor = System.Drawing.Color.Moccasin;
            this.btnSpin.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSpin.Location = new System.Drawing.Point(841, 276);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(194, 76);
            this.btnSpin.TabIndex = 2;
            this.btnSpin.Text = "SPIN";
            this.btnSpin.UseVisualStyleBackColor = false;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SlotMachineGame.Properties.Resources.metal;
            this.panel1.Location = new System.Drawing.Point(25, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 201);
            this.panel1.TabIndex = 4;
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.BackColor = System.Drawing.Color.Transparent;
            this.pointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.pointsLabel.Location = new System.Drawing.Point(834, 173);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(187, 37);
            this.pointsLabel.TabIndex = 10;
            this.pointsLabel.Text = "Points: 100";
            // 
            // betBox
            // 
            this.betBox.BackColor = System.Drawing.Color.Moccasin;
            this.betBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.betBox.Location = new System.Drawing.Point(841, 250);
            this.betBox.Name = "betBox";
            this.betBox.Size = new System.Drawing.Size(194, 20);
            this.betBox.TabIndex = 11;
            this.betBox.Text = "10";
            this.betBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // betLabel
            // 
            this.betLabel.AutoSize = true;
            this.betLabel.BackColor = System.Drawing.Color.Transparent;
            this.betLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.betLabel.Location = new System.Drawing.Point(834, 210);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(77, 37);
            this.betLabel.TabIndex = 12;
            this.betLabel.Text = "Bet:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::SlotMachineGame.Properties.Resources.Slots2;
            this.pictureBox6.Location = new System.Drawing.Point(515, -600);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(200, 600);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SlotMachineGame.Properties.Resources.Slots2;
            this.pictureBox4.Location = new System.Drawing.Point(300, -600);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(200, 600);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SlotMachineGame.Properties.Resources.Slots2;
            this.pictureBox1.Location = new System.Drawing.Point(85, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SlotMachineGame.Properties.Resources.Slots2;
            this.pictureBox3.Location = new System.Drawing.Point(300, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 600);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::SlotMachineGame.Properties.Resources.Slots2;
            this.pictureBox5.Location = new System.Drawing.Point(515, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(200, 600);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SlotMachineGame.Properties.Resources.Slots2;
            this.pictureBox2.Location = new System.Drawing.Point(85, -600);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 600);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::SlotMachineGame.Properties.Resources.metal;
            this.panel2.Location = new System.Drawing.Point(25, 404);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 225);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::SlotMachineGame.Properties.Resources.metal;
            this.panel3.Location = new System.Drawing.Point(25, 201);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(61, 203);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::SlotMachineGame.Properties.Resources.metal;
            this.panel4.Location = new System.Drawing.Point(714, 201);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(87, 203);
            this.panel4.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::SlotMachineGame.Properties.Resources.metal;
            this.panel5.Location = new System.Drawing.Point(500, 201);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(15, 203);
            this.panel5.TabIndex = 15;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::SlotMachineGame.Properties.Resources.metal;
            this.panel6.Location = new System.Drawing.Point(285, 201);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(15, 203);
            this.panel6.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1047, 628);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.betLabel);
            this.Controls.Add(this.betBox);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Slot Machine";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer tmrSlot1;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.TextBox betBox;
        private System.Windows.Forms.Label betLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}

