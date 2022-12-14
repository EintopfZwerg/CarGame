namespace CarGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playercar = new System.Windows.Forms.PictureBox();
            this.enemycar1 = new System.Windows.Forms.PictureBox();
            this.enemycar2 = new System.Windows.Forms.PictureBox();
            this.enemycar3 = new System.Windows.Forms.PictureBox();
            this.gameover = new System.Windows.Forms.Label();
            this.startlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deathcounter = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.meter = new System.Windows.Forms.Label();
            this.travelrecord = new System.Windows.Forms.Label();
            this.travelrecordlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playercar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemycar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemycar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemycar3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(180, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(180, 130);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 100);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(180, 260);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 100);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(180, 390);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 100);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(371, -20);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 498);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Location = new System.Drawing.Point(0, -20);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(10, 498);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // playercar
            // 
            this.playercar.BackColor = System.Drawing.Color.Transparent;
            this.playercar.Image = ((System.Drawing.Image)(resources.GetObject("playercar.Image")));
            this.playercar.Location = new System.Drawing.Point(139, 390);
            this.playercar.Name = "playercar";
            this.playercar.Size = new System.Drawing.Size(35, 60);
            this.playercar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playercar.TabIndex = 6;
            this.playercar.TabStop = false;
            // 
            // enemycar1
            // 
            this.enemycar1.BackColor = System.Drawing.Color.Transparent;
            this.enemycar1.Image = ((System.Drawing.Image)(resources.GetObject("enemycar1.Image")));
            this.enemycar1.Location = new System.Drawing.Point(40, 170);
            this.enemycar1.Name = "enemycar1";
            this.enemycar1.Size = new System.Drawing.Size(35, 60);
            this.enemycar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemycar1.TabIndex = 7;
            this.enemycar1.TabStop = false;
            // 
            // enemycar2
            // 
            this.enemycar2.BackColor = System.Drawing.Color.Transparent;
            this.enemycar2.Image = ((System.Drawing.Image)(resources.GetObject("enemycar2.Image")));
            this.enemycar2.Location = new System.Drawing.Point(214, 112);
            this.enemycar2.Name = "enemycar2";
            this.enemycar2.Size = new System.Drawing.Size(35, 60);
            this.enemycar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemycar2.TabIndex = 8;
            this.enemycar2.TabStop = false;
            // 
            // enemycar3
            // 
            this.enemycar3.BackColor = System.Drawing.Color.Transparent;
            this.enemycar3.Image = ((System.Drawing.Image)(resources.GetObject("enemycar3.Image")));
            this.enemycar3.Location = new System.Drawing.Point(293, 260);
            this.enemycar3.Name = "enemycar3";
            this.enemycar3.Size = new System.Drawing.Size(35, 60);
            this.enemycar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemycar3.TabIndex = 9;
            this.enemycar3.TabStop = false;
            // 
            // gameover
            // 
            this.gameover.AutoSize = true;
            this.gameover.BackColor = System.Drawing.Color.Gold;
            this.gameover.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gameover.Location = new System.Drawing.Point(125, 233);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(124, 23);
            this.gameover.TabIndex = 10;
            this.gameover.Text = "Game Over";
            // 
            // startlabel
            // 
            this.startlabel.AutoSize = true;
            this.startlabel.BackColor = System.Drawing.Color.Gold;
            this.startlabel.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startlabel.Location = new System.Drawing.Point(117, 257);
            this.startlabel.Name = "startlabel";
            this.startlabel.Size = new System.Drawing.Size(139, 23);
            this.startlabel.TabIndex = 11;
            this.startlabel.Text = "press space";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(200, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Death:";
            // 
            // deathcounter
            // 
            this.deathcounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deathcounter.AutoSize = true;
            this.deathcounter.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deathcounter.Location = new System.Drawing.Point(347, 9);
            this.deathcounter.Name = "deathcounter";
            this.deathcounter.Size = new System.Drawing.Size(18, 20);
            this.deathcounter.TabIndex = 13;
            this.deathcounter.Text = "0";
            this.deathcounter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Distance:";
            // 
            // meter
            // 
            this.meter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.meter.AutoSize = true;
            this.meter.BackColor = System.Drawing.Color.Transparent;
            this.meter.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.meter.Location = new System.Drawing.Point(139, 9);
            this.meter.Name = "meter";
            this.meter.Size = new System.Drawing.Size(18, 20);
            this.meter.TabIndex = 15;
            this.meter.Text = "0";
            this.meter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // travelrecord
            // 
            this.travelrecord.AutoSize = true;
            this.travelrecord.BackColor = System.Drawing.Color.Gold;
            this.travelrecord.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.travelrecord.Location = new System.Drawing.Point(214, 282);
            this.travelrecord.Name = "travelrecord";
            this.travelrecord.Size = new System.Drawing.Size(22, 23);
            this.travelrecord.TabIndex = 16;
            this.travelrecord.Text = "0";
            // 
            // travelrecordlabel
            // 
            this.travelrecordlabel.AutoSize = true;
            this.travelrecordlabel.BackColor = System.Drawing.Color.Gold;
            this.travelrecordlabel.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.travelrecordlabel.Location = new System.Drawing.Point(117, 282);
            this.travelrecordlabel.Name = "travelrecordlabel";
            this.travelrecordlabel.Size = new System.Drawing.Size(99, 23);
            this.travelrecordlabel.TabIndex = 17;
            this.travelrecordlabel.Text = "Record:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.travelrecordlabel);
            this.Controls.Add(this.travelrecord);
            this.Controls.Add(this.meter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deathcounter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startlabel);
            this.Controls.Add(this.gameover);
            this.Controls.Add(this.enemycar3);
            this.Controls.Add(this.enemycar2);
            this.Controls.Add(this.enemycar1);
            this.Controls.Add(this.playercar);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playercar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemycar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemycar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemycar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer1;
        private PictureBox playercar;
        private PictureBox enemycar1;
        private PictureBox enemycar2;
        private PictureBox enemycar3;
        private Label gameover;
        private Label startlabel;
        private Label label1;
        private Label deathcounter;
        private Label label2;
        private Label meter;
        private Label travelrecord;
        private Label travelrecordlabel;
    }
}