
namespace MakerPlaid.Ctrl.Maps
{
    partial class MyColorGrid
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
            this.SuspendLayout();
            // 
            // MyColorGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(200, 42);
            this.MinimumSize = new System.Drawing.Size(200, 42);
            this.Name = "MyColorGrid";
            this.Size = new System.Drawing.Size(200, 42);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MyColorGrid_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MyColorGrid_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
