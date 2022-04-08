
namespace MakerPlaid.Ctrl
{
    partial class PlaidMakerControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard7 = new MaterialSkin.Controls.MaterialCard();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialComboBox2 = new MaterialSkin.Controls.MaterialComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialSlider1 = new MaterialSkin.Controls.MaterialSlider();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.verCard = new MaterialSkin.Controls.MaterialCard();
            this.colorWidth2 = new MakerPlaid.Ctrl.ColorWidth();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.materialCheckbox2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.horCard = new MaterialSkin.Controls.MaterialCard();
            this.colorWidth1 = new MakerPlaid.Ctrl.ColorWidth();
            this.materialFloatingActionButton2 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.colorCard = new MaterialSkin.Controls.MaterialCard();
            this.colorComboPicer1 = new MakerPlaid.Ctrl.ColorComboPicer();
            this.selectColors1 = new MakerPlaid.Ctrl.SelectColors();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.materialCard7.SuspendLayout();
            this.materialCard6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.verCard.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.horCard.SuspendLayout();
            this.colorCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Image = global::MakerPlaid.Properties.Resources.plus;
            this.label1.Location = new System.Drawing.Point(410, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "   ";
            this.toolTip1.SetToolTip(this.label1, "Добавить цвет");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Image = global::MakerPlaid.Properties.Resources.plus;
            this.label2.Location = new System.Drawing.Point(617, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "   ";
            this.toolTip1.SetToolTip(this.label2, "Добавить цвет");
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Файл узора|*.uzor";
            this.saveFileDialog1.FilterIndex = 0;
            this.saveFileDialog1.Title = "Сохранение узора";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Файл узора|*.uzor";
            this.openFileDialog1.FilterIndex = 0;
            this.openFileDialog1.Title = "Загрузка узора";
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel6.HighEmphasis = true;
            this.materialLabel6.Location = new System.Drawing.Point(443, 480);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.materialLabel6.Size = new System.Drawing.Size(173, 23);
            this.materialLabel6.TabIndex = 3;
            this.materialLabel6.Text = "  Итого :";
            this.materialLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialLabel6.UseAccent = true;
            this.materialLabel6.Click += new System.EventHandler(this.HideAllOpen);
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel7.HighEmphasis = true;
            this.materialLabel7.Location = new System.Drawing.Point(238, 480);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.materialLabel7.Size = new System.Drawing.Size(170, 23);
            this.materialLabel7.TabIndex = 4;
            this.materialLabel7.Text = "  Итого :";
            this.materialLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialLabel7.UseAccent = true;
            this.materialLabel7.Click += new System.EventHandler(this.HideAllOpen);
            // 
            // materialCard7
            // 
            this.materialCard7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard7.Controls.Add(this.materialComboBox1);
            this.materialCard7.Controls.Add(this.materialLabel5);
            this.materialCard7.Depth = 0;
            this.materialCard7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard7.Location = new System.Drawing.Point(11, 8);
            this.materialCard7.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard7.Name = "materialCard7";
            this.materialCard7.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard7.Size = new System.Drawing.Size(219, 79);
            this.materialCard7.TabIndex = 29;
            this.materialCard7.Click += new System.EventHandler(this.HideAllOpen);
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Enabled = false;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.Hint = "плетение";
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Items.AddRange(new object[] {
            "1x1",
            "1x2"});
            this.materialComboBox1.Location = new System.Drawing.Point(16, 30);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(182, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 1;
            this.materialComboBox1.SelectedIndexChanged += new System.EventHandler(this.materialComboBox1_SelectedIndexChanged);
            // 
            // materialLabel5
            // 
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel5.HighEmphasis = true;
            this.materialLabel5.Location = new System.Drawing.Point(14, 14);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(191, 23);
            this.materialLabel5.TabIndex = 0;
            this.materialLabel5.Text = "Цвета";
            this.materialLabel5.Click += new System.EventHandler(this.HideAllOpen);
            // 
            // materialCard6
            // 
            this.materialCard6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.pictureBox1);
            this.materialCard6.Controls.Add(this.panel1);
            this.materialCard6.Controls.Add(this.materialSlider1);
            this.materialCard6.Controls.Add(this.materialLabel4);
            this.materialCard6.Depth = 0;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(648, 8);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(14, 14, 14, 1);
            this.materialCard6.Size = new System.Drawing.Size(510, 497);
            this.materialCard6.TabIndex = 28;
            this.materialCard6.Click += new System.EventHandler(this.HideAllOpen);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(14, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(482, 409);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.HideAllOpen);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialComboBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.materialButton2);
            this.panel1.Controls.Add(this.materialButton3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.materialButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(14, 446);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.panel1.Size = new System.Drawing.Size(482, 50);
            this.panel1.TabIndex = 4;
            this.panel1.Click += new System.EventHandler(this.HideAllOpen);
            // 
            // materialComboBox2
            // 
            this.materialComboBox2.AutoResize = false;
            this.materialComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox2.Depth = 0;
            this.materialComboBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox2.DropDownHeight = 118;
            this.materialComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox2.DropDownWidth = 121;
            this.materialComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox2.FormattingEnabled = true;
            this.materialComboBox2.IntegralHeight = false;
            this.materialComboBox2.ItemHeight = 29;
            this.materialComboBox2.Location = new System.Drawing.Point(96, 6);
            this.materialComboBox2.MaxDropDownItems = 4;
            this.materialComboBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox2.Name = "materialComboBox2";
            this.materialComboBox2.Size = new System.Drawing.Size(26, 35);
            this.materialComboBox2.StartIndex = 0;
            this.materialComboBox2.TabIndex = 4;
            this.materialComboBox2.UseAccent = false;
            this.materialComboBox2.UseTallSize = false;
            this.materialComboBox2.SelectedIndexChanged += new System.EventHandler(this.materialComboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label4.Location = new System.Drawing.Point(122, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(7, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label5.Location = new System.Drawing.Point(89, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(7, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = " ";
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(0, 6);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(89, 38);
            this.materialButton2.TabIndex = 3;
            this.materialButton2.Text = "загрузить как...";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.LoadUzor);
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.Dock = System.Windows.Forms.DockStyle.Right;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(129, 6);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(196, 38);
            this.materialButton3.TabIndex = 5;
            this.materialButton3.Text = "Сохранить результат";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label3.Location = new System.Drawing.Point(325, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(7, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = " ";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(332, 6);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(150, 38);
            this.materialButton1.TabIndex = 2;
            this.materialButton1.Text = "Сохранить узор";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.saveMaket);
            // 
            // materialSlider1
            // 
            this.materialSlider1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialSlider1.Depth = 0;
            this.materialSlider1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialSlider1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSlider1.Location = new System.Drawing.Point(362, 2);
            this.materialSlider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSlider1.Name = "materialSlider1";
            this.materialSlider1.RangeMax = 10;
            this.materialSlider1.RangeMin = 1;
            this.materialSlider1.ShowText = false;
            this.materialSlider1.ShowValue = false;
            this.materialSlider1.Size = new System.Drawing.Size(148, 40);
            this.materialSlider1.TabIndex = 5;
            this.materialSlider1.Text = "";
            this.materialSlider1.Value = 1;
            this.materialSlider1.ValueMax = 10;
            this.materialSlider1.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.materialSlider1_onValueChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel4.HighEmphasis = true;
            this.materialLabel4.Location = new System.Drawing.Point(14, 14);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(482, 23);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "Предварительный просмотр";
            this.materialLabel4.Click += new System.EventHandler(this.HideAllOpen);
            // 
            // verCard
            // 
            this.verCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.verCard.AutoScroll = true;
            this.verCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.verCard.Controls.Add(this.colorWidth2);
            this.verCard.Depth = 0;
            this.verCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.verCard.Location = new System.Drawing.Point(442, 93);
            this.verCard.Margin = new System.Windows.Forms.Padding(14);
            this.verCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.verCard.Name = "verCard";
            this.verCard.Padding = new System.Windows.Forms.Padding(14, 14, 14, 36);
            this.verCard.Size = new System.Drawing.Size(200, 411);
            this.verCard.TabIndex = 27;
            this.verCard.Click += new System.EventHandler(this.HideAllOpen);
            this.verCard.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.verCard_ControlAdded);
            this.verCard.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.verCard_ControlAdded);
            // 
            // colorWidth2
            // 
            this.colorWidth2.Color = System.Drawing.Color.Gainsboro;
            this.colorWidth2.CountPixel = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.colorWidth2.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorWidth2.Location = new System.Drawing.Point(14, 14);
            this.colorWidth2.Name = "colorWidth2";
            this.colorWidth2.Padding = new System.Windows.Forms.Padding(4);
            this.colorWidth2.Size = new System.Drawing.Size(172, 40);
            this.colorWidth2.TabIndex = 2;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.materialCheckbox2);
            this.materialCard4.Controls.Add(this.materialLabel2);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(442, 8);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(200, 79);
            this.materialCard4.TabIndex = 26;
            this.materialCard4.Click += new System.EventHandler(this.HideAllOpen);
            // 
            // materialCheckbox2
            // 
            this.materialCheckbox2.AutoSize = true;
            this.materialCheckbox2.Depth = 0;
            this.materialCheckbox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCheckbox2.Location = new System.Drawing.Point(14, 37);
            this.materialCheckbox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox2.Name = "materialCheckbox2";
            this.materialCheckbox2.ReadOnly = false;
            this.materialCheckbox2.Ripple = true;
            this.materialCheckbox2.Size = new System.Drawing.Size(172, 37);
            this.materialCheckbox2.TabIndex = 1;
            this.materialCheckbox2.Text = "Зеркально";
            this.materialCheckbox2.UseVisualStyleBackColor = true;
            this.materialCheckbox2.CheckedChanged += new System.EventHandler(this.ReCalculate);
            this.materialCheckbox2.Click += new System.EventHandler(this.HideAllOpen);
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel2.HighEmphasis = true;
            this.materialLabel2.Location = new System.Drawing.Point(14, 14);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(172, 23);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "По вертикали";
            this.materialLabel2.Click += new System.EventHandler(this.HideAllOpen);
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.materialCheckbox1);
            this.materialCard3.Controls.Add(this.materialLabel1);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(236, 8);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(200, 79);
            this.materialCard3.TabIndex = 25;
            this.materialCard3.Click += new System.EventHandler(this.HideAllOpen);
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.AutoSize = true;
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCheckbox1.Location = new System.Drawing.Point(14, 37);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.ReadOnly = false;
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(172, 37);
            this.materialCheckbox1.TabIndex = 1;
            this.materialCheckbox1.Text = "Зеркально";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            this.materialCheckbox1.CheckedChanged += new System.EventHandler(this.ReCalculate);
            this.materialCheckbox1.Click += new System.EventHandler(this.HideAllOpen);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel1.HighEmphasis = true;
            this.materialLabel1.Location = new System.Drawing.Point(14, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(172, 23);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "По горизонтали";
            this.materialLabel1.Click += new System.EventHandler(this.HideAllOpen);
            // 
            // horCard
            // 
            this.horCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.horCard.AutoScroll = true;
            this.horCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.horCard.Controls.Add(this.colorWidth1);
            this.horCard.Depth = 0;
            this.horCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.horCard.Location = new System.Drawing.Point(236, 93);
            this.horCard.Margin = new System.Windows.Forms.Padding(14);
            this.horCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.horCard.Name = "horCard";
            this.horCard.Padding = new System.Windows.Forms.Padding(14);
            this.horCard.Size = new System.Drawing.Size(200, 411);
            this.horCard.TabIndex = 24;
            this.horCard.Click += new System.EventHandler(this.HideAllOpen);
            this.horCard.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.materialCard2_ControlAdded);
            this.horCard.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.materialCard2_ControlAdded);
            // 
            // colorWidth1
            // 
            this.colorWidth1.Color = System.Drawing.Color.Gainsboro;
            this.colorWidth1.CountPixel = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.colorWidth1.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorWidth1.Location = new System.Drawing.Point(14, 14);
            this.colorWidth1.Name = "colorWidth1";
            this.colorWidth1.Padding = new System.Windows.Forms.Padding(4);
            this.colorWidth1.Size = new System.Drawing.Size(172, 40);
            this.colorWidth1.TabIndex = 2;
            // 
            // materialFloatingActionButton2
            // 
            this.materialFloatingActionButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialFloatingActionButton2.AutoSize = true;
            this.materialFloatingActionButton2.Depth = 0;
            this.materialFloatingActionButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialFloatingActionButton2.Icon = global::MakerPlaid.Properties.Resources.block__plus;
            this.materialFloatingActionButton2.Image = global::MakerPlaid.Properties.Resources.block__plus;
            this.materialFloatingActionButton2.Location = new System.Drawing.Point(96, 471);
            this.materialFloatingActionButton2.Mini = true;
            this.materialFloatingActionButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton2.Name = "materialFloatingActionButton2";
            this.materialFloatingActionButton2.Size = new System.Drawing.Size(41, 41);
            this.materialFloatingActionButton2.TabIndex = 22;
            this.materialFloatingActionButton2.Text = "+";
            this.materialFloatingActionButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.materialFloatingActionButton2.UseVisualStyleBackColor = true;
            this.materialFloatingActionButton2.Click += new System.EventHandler(this.materialFloatingActionButton2_Click);
            // 
            // colorCard
            // 
            this.colorCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.colorCard.AutoScroll = true;
            this.colorCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.colorCard.Controls.Add(this.colorComboPicer1);
            this.colorCard.Depth = 0;
            this.colorCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorCard.Location = new System.Drawing.Point(11, 93);
            this.colorCard.Margin = new System.Windows.Forms.Padding(14);
            this.colorCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.colorCard.Name = "colorCard";
            this.colorCard.Padding = new System.Windows.Forms.Padding(14, 14, 14, 36);
            this.colorCard.Size = new System.Drawing.Size(219, 411);
            this.colorCard.TabIndex = 21;
            this.colorCard.Click += new System.EventHandler(this.HideAllOpen);
            // 
            // colorComboPicer1
            // 
            this.colorComboPicer1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorComboPicer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorComboPicer1.Location = new System.Drawing.Point(14, 14);
            this.colorComboPicer1.MaximumSize = new System.Drawing.Size(184, 65);
            this.colorComboPicer1.MinimumSize = new System.Drawing.Size(184, 65);
            this.colorComboPicer1.Name = "colorComboPicer1";
            this.colorComboPicer1.Padding = new System.Windows.Forms.Padding(2);
            this.colorComboPicer1.Size = new System.Drawing.Size(184, 65);
            this.colorComboPicer1.TabIndex = 2;
            this.colorComboPicer1.Title = "Цвет #1";
            this.colorComboPicer1.VisibleCombo = false;
            // 
            // selectColors1
            // 
            this.selectColors1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.selectColors1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.selectColors1.Depth = 0;
            this.selectColors1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.selectColors1.Location = new System.Drawing.Point(267, 173);
            this.selectColors1.Margin = new System.Windows.Forms.Padding(14);
            this.selectColors1.MouseState = MaterialSkin.MouseState.HOVER;
            this.selectColors1.Name = "selectColors1";
            this.selectColors1.Padding = new System.Windows.Forms.Padding(14);
            this.selectColors1.Size = new System.Drawing.Size(149, 32);
            this.selectColors1.TabIndex = 30;
            this.selectColors1.Visible = false;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // PlaidMakerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectColors1);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialCard7);
            this.Controls.Add(this.materialCard6);
            this.Controls.Add(this.verCard);
            this.Controls.Add(this.materialCard4);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.horCard);
            this.Controls.Add(this.materialFloatingActionButton2);
            this.Controls.Add(this.colorCard);
            this.DoubleBuffered = true;
            this.Name = "PlaidMakerControl";
            this.Padding = new System.Windows.Forms.Padding(8, 6, 6, 2);
            this.Size = new System.Drawing.Size(1164, 514);
            this.VisibleChanged += new System.EventHandler(this.PlaidMakerControl_VisibleChanged);
            this.materialCard7.ResumeLayout(false);
            this.materialCard6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.verCard.ResumeLayout(false);
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.horCard.ResumeLayout(false);
            this.colorCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ColorComboPicer colorComboPicer1;
        private MaterialSkin.Controls.MaterialCard colorCard;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton2;
        private MaterialSkin.Controls.MaterialCard horCard;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private ColorWidth colorWidth1;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCard verCard;
        private ColorWidth colorWidth2;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.Panel panel1;
        public SelectColors selectColors1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MaterialSkin.Controls.MaterialSlider materialSlider1;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}
