﻿namespace Memory_game
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
            label1 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox14 = new PictureBox();
            pictureBox15 = new PictureBox();
            pictureBox16 = new PictureBox();
            ctimer = new System.Windows.Forms.Timer(components);
            timer = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 487);
            label1.Name = "label1";
            label1.Size = new Size(143, 49);
            label1.TabIndex = 0;
            label1.Text = "00:60";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(372, 494);
            button1.Name = "button1";
            button1.Size = new Size(135, 46);
            button1.TabIndex = 1;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += startGame;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(169, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += clickImage;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(304, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += clickImage;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Location = new Point(441, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 100);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += clickImage;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.Center;
            pictureBox4.Location = new Point(589, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 100);
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            pictureBox4.Click += clickImage;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImageLayout = ImageLayout.Center;
            pictureBox5.Location = new Point(589, 137);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(100, 100);
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            pictureBox5.Click += clickImage;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImageLayout = ImageLayout.Center;
            pictureBox6.Location = new Point(441, 137);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(100, 100);
            pictureBox6.TabIndex = 8;
            pictureBox6.TabStop = false;
            pictureBox6.Click += clickImage;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImageLayout = ImageLayout.Center;
            pictureBox7.Location = new Point(304, 137);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(100, 100);
            pictureBox7.TabIndex = 7;
            pictureBox7.TabStop = false;
            pictureBox7.Click += clickImage;
            // 
            // pictureBox8
            // 
            pictureBox8.BackgroundImageLayout = ImageLayout.Center;
            pictureBox8.Location = new Point(169, 137);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(100, 100);
            pictureBox8.TabIndex = 6;
            pictureBox8.TabStop = false;
            pictureBox8.Click += clickImage;
            // 
            // pictureBox9
            // 
            pictureBox9.BackgroundImageLayout = ImageLayout.Center;
            pictureBox9.Location = new Point(589, 261);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(100, 100);
            pictureBox9.TabIndex = 13;
            pictureBox9.TabStop = false;
            pictureBox9.Click += clickImage;
            // 
            // pictureBox10
            // 
            pictureBox10.BackgroundImageLayout = ImageLayout.Center;
            pictureBox10.Location = new Point(441, 261);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(100, 100);
            pictureBox10.TabIndex = 12;
            pictureBox10.TabStop = false;
            pictureBox10.Click += clickImage;
            // 
            // pictureBox11
            // 
            pictureBox11.BackgroundImageLayout = ImageLayout.Center;
            pictureBox11.Location = new Point(304, 261);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(100, 100);
            pictureBox11.TabIndex = 11;
            pictureBox11.TabStop = false;
            pictureBox11.Click += clickImage;
            // 
            // pictureBox12
            // 
            pictureBox12.BackgroundImageLayout = ImageLayout.Center;
            pictureBox12.Location = new Point(169, 261);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(100, 100);
            pictureBox12.TabIndex = 10;
            pictureBox12.TabStop = false;
            pictureBox12.Click += clickImage;
            // 
            // pictureBox13
            // 
            pictureBox13.BackgroundImageLayout = ImageLayout.Center;
            pictureBox13.Location = new Point(589, 377);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(100, 100);
            pictureBox13.TabIndex = 17;
            pictureBox13.TabStop = false;
            pictureBox13.Click += clickImage;
            // 
            // pictureBox14
            // 
            pictureBox14.BackgroundImageLayout = ImageLayout.Center;
            pictureBox14.Location = new Point(441, 377);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(100, 100);
            pictureBox14.TabIndex = 16;
            pictureBox14.TabStop = false;
            pictureBox14.Click += clickImage;
            // 
            // pictureBox15
            // 
            pictureBox15.BackgroundImageLayout = ImageLayout.Center;
            pictureBox15.Location = new Point(304, 377);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(100, 100);
            pictureBox15.TabIndex = 15;
            pictureBox15.TabStop = false;
            pictureBox15.Click += clickImage;
            // 
            // pictureBox16
            // 
            pictureBox16.BackgroundImageLayout = ImageLayout.Center;
            pictureBox16.Location = new Point(169, 377);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(100, 100);
            pictureBox16.TabIndex = 14;
            pictureBox16.TabStop = false;
            pictureBox16.Click += clickImage;
            // 
            // ctimer
            // 
            ctimer.Enabled = true;
            // 
            // timer
            // 
            timer.Interval = 1000;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(214, 43);
            label2.Name = "label2";
            label2.Size = new Size(486, 47);
            label2.TabIndex = 18;
            label2.Text = "Bun venit la Memory-Game!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1204024766_612x612;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(897, 572);
            Controls.Add(label2);
            Controls.Add(pictureBox13);
            Controls.Add(pictureBox14);
            Controls.Add(pictureBox15);
            Controls.Add(pictureBox16);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private System.Windows.Forms.Timer ctimer;
        private System.Windows.Forms.Timer timer;
        private Label label2;
    }
}
