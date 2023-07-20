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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            playercar = new PictureBox();
            enemycar1 = new PictureBox();
            enemycar2 = new PictureBox();
            enemycar3 = new PictureBox();
            gameover = new Label();
            startlabel = new Label();
            label1 = new Label();
            deathcounter = new Label();
            label2 = new Label();
            meter = new Label();
            travelrecord = new Label();
            travelrecordlabel = new Label();
            label3 = new Label();
            coincounter = new Label();
            coin = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playercar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemycar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemycar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemycar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(180, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(10, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Location = new Point(180, 130);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(10, 100);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Location = new Point(180, 260);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(10, 100);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Location = new Point(180, 390);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(10, 100);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Location = new Point(371, -20);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(10, 498);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.White;
            pictureBox6.Location = new Point(0, -20);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(10, 498);
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += Timer1_Tick;
            // 
            // playercar
            // 
            playercar.BackColor = Color.Transparent;
            playercar.Image = (Image)resources.GetObject("playercar.Image");
            playercar.Location = new Point(139, 390);
            playercar.Name = "playercar";
            playercar.Size = new Size(35, 60);
            playercar.SizeMode = PictureBoxSizeMode.StretchImage;
            playercar.TabIndex = 6;
            playercar.TabStop = false;
            // 
            // enemycar1
            // 
            enemycar1.BackColor = Color.Transparent;
            enemycar1.Image = (Image)resources.GetObject("enemycar1.Image");
            enemycar1.Location = new Point(40, 170);
            enemycar1.Name = "enemycar1";
            enemycar1.Size = new Size(35, 60);
            enemycar1.SizeMode = PictureBoxSizeMode.StretchImage;
            enemycar1.TabIndex = 7;
            enemycar1.TabStop = false;
            // 
            // enemycar2
            // 
            enemycar2.BackColor = Color.Transparent;
            enemycar2.Image = (Image)resources.GetObject("enemycar2.Image");
            enemycar2.Location = new Point(214, 112);
            enemycar2.Name = "enemycar2";
            enemycar2.Size = new Size(35, 60);
            enemycar2.SizeMode = PictureBoxSizeMode.StretchImage;
            enemycar2.TabIndex = 8;
            enemycar2.TabStop = false;
            // 
            // enemycar3
            // 
            enemycar3.BackColor = Color.Transparent;
            enemycar3.Image = (Image)resources.GetObject("enemycar3.Image");
            enemycar3.Location = new Point(293, 260);
            enemycar3.Name = "enemycar3";
            enemycar3.Size = new Size(35, 60);
            enemycar3.SizeMode = PictureBoxSizeMode.StretchImage;
            enemycar3.TabIndex = 9;
            enemycar3.TabStop = false;
            // 
            // gameover
            // 
            gameover.AutoSize = true;
            gameover.BackColor = Color.Gold;
            gameover.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            gameover.Location = new Point(125, 233);
            gameover.Name = "gameover";
            gameover.Size = new Size(124, 23);
            gameover.TabIndex = 10;
            gameover.Text = "Game Over";
            // 
            // startlabel
            // 
            startlabel.AutoSize = true;
            startlabel.BackColor = Color.Gold;
            startlabel.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            startlabel.Location = new Point(117, 257);
            startlabel.Name = "startlabel";
            startlabel.Size = new Size(139, 23);
            startlabel.TabIndex = 11;
            startlabel.Text = "press space";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(200, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 12;
            label1.Text = "Death:";
            // 
            // deathcounter
            // 
            deathcounter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deathcounter.AutoSize = true;
            deathcounter.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            deathcounter.Location = new Point(347, 9);
            deathcounter.Name = "deathcounter";
            deathcounter.Size = new Size(18, 20);
            deathcounter.TabIndex = 13;
            deathcounter.Text = "0";
            deathcounter.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 9);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 14;
            label2.Text = "Distance:";
            // 
            // meter
            // 
            meter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            meter.AutoSize = true;
            meter.BackColor = Color.Transparent;
            meter.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            meter.Location = new Point(139, 9);
            meter.Name = "meter";
            meter.Size = new Size(18, 20);
            meter.TabIndex = 15;
            meter.Text = "0";
            meter.TextAlign = ContentAlignment.TopRight;
            // 
            // travelrecord
            // 
            travelrecord.AutoSize = true;
            travelrecord.BackColor = Color.Gold;
            travelrecord.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            travelrecord.Location = new Point(214, 282);
            travelrecord.Name = "travelrecord";
            travelrecord.Size = new Size(22, 23);
            travelrecord.TabIndex = 16;
            travelrecord.Text = "0";
            // 
            // travelrecordlabel
            // 
            travelrecordlabel.AutoSize = true;
            travelrecordlabel.BackColor = Color.Gold;
            travelrecordlabel.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            travelrecordlabel.Location = new Point(117, 282);
            travelrecordlabel.Name = "travelrecordlabel";
            travelrecordlabel.Size = new Size(99, 23);
            travelrecordlabel.TabIndex = 17;
            travelrecordlabel.Text = "Record:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(201, 29);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 18;
            label3.Text = "Coins:";
            // 
            // coincounter
            // 
            coincounter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            coincounter.AutoSize = true;
            coincounter.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            coincounter.Location = new Point(347, 29);
            coincounter.Name = "coincounter";
            coincounter.Size = new Size(18, 20);
            coincounter.TabIndex = 19;
            coincounter.Text = "0";
            coincounter.TextAlign = ContentAlignment.TopRight;
            // 
            // coin
            // 
            coin.BackColor = Color.Transparent;
            coin.Image = (Image)resources.GetObject("coin.Image");
            coin.Location = new Point(16, 434);
            coin.Name = "coin";
            coin.Size = new Size(25, 25);
            coin.SizeMode = PictureBoxSizeMode.StretchImage;
            coin.TabIndex = 20;
            coin.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(384, 461);
            Controls.Add(coin);
            Controls.Add(coincounter);
            Controls.Add(label3);
            Controls.Add(travelrecordlabel);
            Controls.Add(travelrecord);
            Controls.Add(meter);
            Controls.Add(label2);
            Controls.Add(deathcounter);
            Controls.Add(label1);
            Controls.Add(startlabel);
            Controls.Add(gameover);
            Controls.Add(enemycar3);
            Controls.Add(enemycar2);
            Controls.Add(enemycar1);
            Controls.Add(playercar);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MaximumSize = new Size(400, 500);
            MinimumSize = new Size(400, 500);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CarGame";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)playercar).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemycar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemycar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemycar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label3;
        private Label coincounter;
        private PictureBox coin;
    }
}