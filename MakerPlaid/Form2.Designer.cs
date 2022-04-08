
namespace MakerPlaid
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plaidMakerControl1 = new MakerPlaid.Ctrl.PlaidMakerControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.pictureBox1.BackgroundImage = global::MakerPlaid.Properties.Resources.pled;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(8, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // plaidMakerControl1
            // 
            this.plaidMakerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plaidMakerControl1.Location = new System.Drawing.Point(3, 64);
            this.plaidMakerControl1.Name = "plaidMakerControl1";
            this.plaidMakerControl1.Padding = new System.Windows.Forms.Padding(8, 6, 6, 2);
            this.plaidMakerControl1.Size = new System.Drawing.Size(1161, 513);
            this.plaidMakerControl1.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 580);
            this.Controls.Add(this.plaidMakerControl1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "          Создание клеток";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Ctrl.PlaidMakerControl plaidMakerControl1;
    }
}