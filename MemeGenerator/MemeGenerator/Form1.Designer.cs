namespace MemeGenerator
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            nextmeme_btn = new Button();
            savememe_btn = new Button();
            memeBox = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memeBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(40, 40, 40);
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(25, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(501, 556);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(40, 40, 40);
            label1.Font = new Font("Poppins SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SlateBlue;
            label1.Location = new Point(85, 119);
            label1.Name = "label1";
            label1.Size = new Size(386, 50);
            label1.TabIndex = 1;
            label1.Text = "Meme Generator By Astro";
            label1.Click += label1_Click;
            // 
            // nextmeme_btn
            // 
            nextmeme_btn.Location = new Point(66, 484);
            nextmeme_btn.Name = "nextmeme_btn";
            nextmeme_btn.Size = new Size(194, 71);
            nextmeme_btn.TabIndex = 2;
            nextmeme_btn.Text = "Next Meme";
            nextmeme_btn.UseVisualStyleBackColor = true;
            nextmeme_btn.Click += nextmeme_btn_Click;
            // 
            // savememe_btn
            // 
            savememe_btn.Location = new Point(287, 484);
            savememe_btn.Name = "savememe_btn";
            savememe_btn.Size = new Size(194, 71);
            savememe_btn.TabIndex = 3;
            savememe_btn.Text = "Save Meme";
            savememe_btn.UseVisualStyleBackColor = true;
            savememe_btn.Click += savememe_btn_Click;
            // 
            // memeBox
            // 
            memeBox.Location = new Point(50, 184);
            memeBox.Name = "memeBox";
            memeBox.Size = new Size(452, 269);
            memeBox.SizeMode = PictureBoxSizeMode.Zoom;
            memeBox.TabIndex = 4;
            memeBox.TabStop = false;
            memeBox.Click += memeBox_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(242, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(87, 91);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(549, 587);
            Controls.Add(pictureBox2);
            Controls.Add(memeBox);
            Controls.Add(savememe_btn);
            Controls.Add(nextmeme_btn);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Meme Generator By Astro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)memeBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button nextmeme_btn;
        private Button savememe_btn;
        private PictureBox memeBox;
        private PictureBox pictureBox2;
    }
}