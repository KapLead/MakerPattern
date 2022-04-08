
namespace MakerPlaid.Ctrl
{
    partial class ColorWidth
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 4);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label1.Size = new System.Drawing.Size(26, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Move += new System.EventHandler(this.label1_Move);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown1.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.numericUpDown1.Location = new System.Drawing.Point(62, 4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(56, 31);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "▼";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Image = global::MakerPlaid.Properties.Resources.minus;
            this.label3.Location = new System.Drawing.Point(118, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 31);
            this.label3.TabIndex = 4;
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label3_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // ColorWidth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "ColorWidth";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(150, 39);
            this.Load += new System.EventHandler(this.ColorWidth_Load);
            this.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
