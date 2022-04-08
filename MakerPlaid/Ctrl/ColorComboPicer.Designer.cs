
namespace MakerPlaid.Ctrl
{
    partial class ColorComboPicer
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьЕщёЦветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(135, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 47);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЕщёЦветToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(180, 48);
            // 
            // добавитьЕщёЦветToolStripMenuItem
            // 
            this.добавитьЕщёЦветToolStripMenuItem.Name = "добавитьЕщёЦветToolStripMenuItem";
            this.добавитьЕщёЦветToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.добавитьЕщёЦветToolStripMenuItem.Text = "Добавить ещё цвет";
            this.добавитьЕщёЦветToolStripMenuItem.Click += new System.EventHandler(this.добавитьЕщёЦветToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // materialTextBox21
            // 
            this.materialTextBox21.AnimateReadOnly = false;
            this.materialTextBox21.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.materialTextBox21.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.materialTextBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox21.ContextMenuStrip = this.contextMenuStrip1;
            this.materialTextBox21.Depth = 0;
            this.materialTextBox21.Dock = System.Windows.Forms.DockStyle.Left;
            this.materialTextBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox21.HideSelection = true;
            this.materialTextBox21.LeadingIcon = null;
            this.materialTextBox21.Location = new System.Drawing.Point(2, 16);
            this.materialTextBox21.MaxLength = 32767;
            this.materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox21.Name = "materialTextBox21";
            this.materialTextBox21.PasswordChar = '\0';
            this.materialTextBox21.PrefixSuffixText = null;
            this.materialTextBox21.ReadOnly = true;
            this.materialTextBox21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox21.SelectedText = "";
            this.materialTextBox21.SelectionLength = 0;
            this.materialTextBox21.SelectionStart = 0;
            this.materialTextBox21.ShortcutsEnabled = true;
            this.materialTextBox21.Size = new System.Drawing.Size(128, 48);
            this.materialTextBox21.TabIndex = 0;
            this.materialTextBox21.TabStop = false;
            this.materialTextBox21.Text = "#001122";
            this.materialTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.materialTextBox21.TrailingIcon = null;
            this.materialTextBox21.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.ContextMenuStrip = this.contextMenuStrip1;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.materialLabel1.Location = new System.Drawing.Point(2, 2);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(180, 14);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "materialLabel1";
            // 
            // ColorComboPicer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialTextBox21);
            this.Controls.Add(this.materialLabel1);
            this.MaximumSize = new System.Drawing.Size(184, 65);
            this.MinimumSize = new System.Drawing.Size(184, 65);
            this.Name = "ColorComboPicer";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(184, 65);
            this.ParentChanged += new System.EventHandler(this.ColorComboPicer_ParentChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьЕщёЦветToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
    }
}
