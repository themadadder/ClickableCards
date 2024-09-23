
namespace ClickableNumberImages
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
            numberOne = new PictureBox();
            title = new Label();
            numberTwo = new PictureBox();
            numberThree = new PictureBox();
            numberFour = new PictureBox();
            numberFive = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numberOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberTwo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberThree).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberFour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberFive).BeginInit();
            SuspendLayout();
            // 
            // numberOne
            // 
            numberOne.Image = Properties.Resources.One;
            numberOne.Location = new Point(11, 44);
            numberOne.Name = "numberOne";
            numberOne.Size = new Size(118, 211);
            numberOne.SizeMode = PictureBoxSizeMode.Zoom;
            numberOne.TabIndex = 0;
            numberOne.TabStop = false;
            numberOne.Click += pictureBox1_Click;
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top;
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.Location = new Point(78, 9);
            title.Name = "title";
            title.Size = new Size(483, 32);
            title.TabIndex = 1;
            title.Text = "Click on a number below to see its value!";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numberTwo
            // 
            numberTwo.Image = Properties.Resources.Two;
            numberTwo.Location = new Point(135, 44);
            numberTwo.Name = "numberTwo";
            numberTwo.Size = new Size(118, 211);
            numberTwo.SizeMode = PictureBoxSizeMode.Zoom;
            numberTwo.TabIndex = 2;
            numberTwo.TabStop = false;
            numberTwo.Click += numberTwo_Click;
            // 
            // numberThree
            // 
            numberThree.Image = Properties.Resources.Three;
            numberThree.Location = new Point(259, 44);
            numberThree.Name = "numberThree";
            numberThree.Size = new Size(118, 211);
            numberThree.SizeMode = PictureBoxSizeMode.Zoom;
            numberThree.TabIndex = 3;
            numberThree.TabStop = false;
            numberThree.Click += numberThree_Click;
            // 
            // numberFour
            // 
            numberFour.Image = Properties.Resources.Four;
            numberFour.Location = new Point(383, 44);
            numberFour.Name = "numberFour";
            numberFour.Size = new Size(118, 211);
            numberFour.SizeMode = PictureBoxSizeMode.Zoom;
            numberFour.TabIndex = 4;
            numberFour.TabStop = false;
            numberFour.Click += numberFour_Click;
            // 
            // numberFive
            // 
            numberFive.Image = Properties.Resources.Five;
            numberFive.Location = new Point(507, 44);
            numberFive.Name = "numberFive";
            numberFive.Size = new Size(118, 211);
            numberFive.SizeMode = PictureBoxSizeMode.Zoom;
            numberFive.TabIndex = 5;
            numberFive.TabStop = false;
            numberFive.Click += numberFive_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 266);
            Controls.Add(numberFive);
            Controls.Add(numberFour);
            Controls.Add(numberThree);
            Controls.Add(numberTwo);
            Controls.Add(title);
            Controls.Add(numberOne);
            Name = "Form1";
            Text = "Clickable Numbers!";
            ((System.ComponentModel.ISupportInitialize)numberOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberTwo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberThree).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberFour).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberFive).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("One");
        }

        #endregion

        private PictureBox numberOne;
        private Label title;
        private PictureBox numberTwo;
        private PictureBox numberThree;
        private PictureBox numberFour;
        private PictureBox numberFive;
    }
}
