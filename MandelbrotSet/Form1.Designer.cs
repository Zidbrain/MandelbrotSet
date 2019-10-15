namespace MandelbrotSet
{
    partial class Form1
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
                _changeColors.Dispose();
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
            this._updateButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this._iterationsField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this._xField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this._yField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this._loading = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this._heightField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this._widthField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this._paletteLengthBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this._plusButton = new MaterialSkin.Controls.MaterialFlatButton();
            this._minusButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this._saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this._resolutionHeightField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this._resolutionWidthField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this._coordinatesField = new MaterialSkin.Controls.MaterialLabel();
            this._progress = new MaterialSkin.Controls.MaterialLabel();
            this._panel = new System.Windows.Forms.Panel();
            this._pictureBox = new System.Windows.Forms.PictureBox();
            this._changeColorsButton = new MaterialSkin.Controls.MaterialFlatButton();
            this._panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _updateButton
            // 
            this._updateButton.AutoSize = true;
            this._updateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._updateButton.Depth = 0;
            this._updateButton.Location = new System.Drawing.Point(802, 595);
            this._updateButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this._updateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this._updateButton.Name = "_updateButton";
            this._updateButton.Primary = true;
            this._updateButton.Size = new System.Drawing.Size(64, 36);
            this._updateButton.TabIndex = 1;
            this._updateButton.Text = "Update";
            this._updateButton.UseVisualStyleBackColor = true;
            this._updateButton.Click += new System.EventHandler(this.MaterialFlatButton1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(807, 77);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(73, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Iterations";
            // 
            // _iterationsField
            // 
            this._iterationsField.Depth = 0;
            this._iterationsField.Hint = "";
            this._iterationsField.Location = new System.Drawing.Point(811, 99);
            this._iterationsField.MouseState = MaterialSkin.MouseState.HOVER;
            this._iterationsField.Name = "_iterationsField";
            this._iterationsField.PasswordChar = '\0';
            this._iterationsField.SelectedText = "";
            this._iterationsField.SelectionLength = 0;
            this._iterationsField.SelectionStart = 0;
            this._iterationsField.Size = new System.Drawing.Size(169, 23);
            this._iterationsField.TabIndex = 3;
            this._iterationsField.Text = "1000";
            this._iterationsField.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(807, 213);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(65, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Position";
            // 
            // _xField
            // 
            this._xField.Depth = 0;
            this._xField.Hint = "";
            this._xField.Location = new System.Drawing.Point(833, 235);
            this._xField.MouseState = MaterialSkin.MouseState.HOVER;
            this._xField.Name = "_xField";
            this._xField.PasswordChar = '\0';
            this._xField.SelectedText = "";
            this._xField.SelectionLength = 0;
            this._xField.SelectionStart = 0;
            this._xField.Size = new System.Drawing.Size(147, 23);
            this._xField.TabIndex = 5;
            this._xField.Text = "1000";
            this._xField.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(807, 235);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(20, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "x:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(807, 264);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(20, 19);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "y:";
            // 
            // _yField
            // 
            this._yField.Depth = 0;
            this._yField.Hint = "";
            this._yField.Location = new System.Drawing.Point(833, 264);
            this._yField.MouseState = MaterialSkin.MouseState.HOVER;
            this._yField.Name = "_yField";
            this._yField.PasswordChar = '\0';
            this._yField.SelectedText = "";
            this._yField.SelectionLength = 0;
            this._yField.SelectionStart = 0;
            this._yField.Size = new System.Drawing.Size(147, 23);
            this._yField.TabIndex = 7;
            this._yField.Text = "1000";
            this._yField.UseSystemPasswordChar = false;
            // 
            // _loading
            // 
            this._loading.AutoSize = true;
            this._loading.Depth = 0;
            this._loading.Font = new System.Drawing.Font("Roboto", 11F);
            this._loading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._loading.Location = new System.Drawing.Point(865, 523);
            this._loading.MouseState = MaterialSkin.MouseState.HOVER;
            this._loading.Name = "_loading";
            this._loading.Size = new System.Drawing.Size(74, 19);
            this._loading.TabIndex = 11;
            this._loading.Text = "Loading...";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(807, 362);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(20, 19);
            this.materialLabel5.TabIndex = 16;
            this.materialLabel5.Text = "y:";
            // 
            // _heightField
            // 
            this._heightField.Depth = 0;
            this._heightField.Hint = "";
            this._heightField.Location = new System.Drawing.Point(833, 362);
            this._heightField.MouseState = MaterialSkin.MouseState.HOVER;
            this._heightField.Name = "_heightField";
            this._heightField.PasswordChar = '\0';
            this._heightField.SelectedText = "";
            this._heightField.SelectionLength = 0;
            this._heightField.SelectionStart = 0;
            this._heightField.Size = new System.Drawing.Size(147, 23);
            this._heightField.TabIndex = 15;
            this._heightField.Text = "1000";
            this._heightField.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(807, 333);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(20, 19);
            this.materialLabel6.TabIndex = 14;
            this.materialLabel6.Text = "x:";
            // 
            // _widthField
            // 
            this._widthField.Depth = 0;
            this._widthField.Hint = "";
            this._widthField.Location = new System.Drawing.Point(833, 333);
            this._widthField.MouseState = MaterialSkin.MouseState.HOVER;
            this._widthField.Name = "_widthField";
            this._widthField.PasswordChar = '\0';
            this._widthField.SelectedText = "";
            this._widthField.SelectionLength = 0;
            this._widthField.SelectionStart = 0;
            this._widthField.Size = new System.Drawing.Size(147, 23);
            this._widthField.TabIndex = 13;
            this._widthField.Text = "1000";
            this._widthField.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(807, 311);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(37, 19);
            this.materialLabel7.TabIndex = 12;
            this.materialLabel7.Text = "Size";
            // 
            // _paletteLengthBox
            // 
            this._paletteLengthBox.Depth = 0;
            this._paletteLengthBox.Hint = "";
            this._paletteLengthBox.Location = new System.Drawing.Point(811, 166);
            this._paletteLengthBox.MouseState = MaterialSkin.MouseState.HOVER;
            this._paletteLengthBox.Name = "_paletteLengthBox";
            this._paletteLengthBox.PasswordChar = '\0';
            this._paletteLengthBox.SelectedText = "";
            this._paletteLengthBox.SelectionLength = 0;
            this._paletteLengthBox.SelectionStart = 0;
            this._paletteLengthBox.Size = new System.Drawing.Size(169, 23);
            this._paletteLengthBox.TabIndex = 18;
            this._paletteLengthBox.Text = "1000";
            this._paletteLengthBox.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(807, 144);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(105, 19);
            this.materialLabel8.TabIndex = 17;
            this.materialLabel8.Text = "Palette Length";
            // 
            // _plusButton
            // 
            this._plusButton.AutoSize = true;
            this._plusButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._plusButton.Depth = 0;
            this._plusButton.Location = new System.Drawing.Point(892, 394);
            this._plusButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this._plusButton.MouseState = MaterialSkin.MouseState.HOVER;
            this._plusButton.Name = "_plusButton";
            this._plusButton.Primary = false;
            this._plusButton.Size = new System.Drawing.Size(20, 36);
            this._plusButton.TabIndex = 20;
            this._plusButton.Text = "+";
            this._plusButton.UseVisualStyleBackColor = true;
            this._plusButton.Click += new System.EventHandler(this.Click_plusButton);
            // 
            // _minusButton
            // 
            this._minusButton.AutoSize = true;
            this._minusButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._minusButton.Depth = 0;
            this._minusButton.Location = new System.Drawing.Point(868, 394);
            this._minusButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this._minusButton.MouseState = MaterialSkin.MouseState.HOVER;
            this._minusButton.Name = "_minusButton";
            this._minusButton.Primary = false;
            this._minusButton.Size = new System.Drawing.Size(16, 36);
            this._minusButton.TabIndex = 21;
            this._minusButton.Text = "-";
            this._minusButton.UseVisualStyleBackColor = true;
            this._minusButton.Click += new System.EventHandler(this.Click_minusButton);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(934, 595);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(46, 36);
            this.materialFlatButton2.TabIndex = 22;
            this.materialFlatButton2.Text = "Save";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.MaterialFlatButton2_Click);
            // 
            // _saveDialog
            // 
            this._saveDialog.Filter = "PNG files|*.png";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(807, 495);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(20, 19);
            this.materialLabel9.TabIndex = 27;
            this.materialLabel9.Text = "y:";
            // 
            // _resolutionHeightField
            // 
            this._resolutionHeightField.Depth = 0;
            this._resolutionHeightField.Hint = "";
            this._resolutionHeightField.Location = new System.Drawing.Point(833, 495);
            this._resolutionHeightField.MouseState = MaterialSkin.MouseState.HOVER;
            this._resolutionHeightField.Name = "_resolutionHeightField";
            this._resolutionHeightField.PasswordChar = '\0';
            this._resolutionHeightField.SelectedText = "";
            this._resolutionHeightField.SelectionLength = 0;
            this._resolutionHeightField.SelectionStart = 0;
            this._resolutionHeightField.Size = new System.Drawing.Size(147, 23);
            this._resolutionHeightField.TabIndex = 26;
            this._resolutionHeightField.Text = "1000";
            this._resolutionHeightField.UseSystemPasswordChar = false;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(807, 466);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(20, 19);
            this.materialLabel10.TabIndex = 25;
            this.materialLabel10.Text = "x:";
            // 
            // _resolutionWidthField
            // 
            this._resolutionWidthField.Depth = 0;
            this._resolutionWidthField.Hint = "";
            this._resolutionWidthField.Location = new System.Drawing.Point(833, 466);
            this._resolutionWidthField.MouseState = MaterialSkin.MouseState.HOVER;
            this._resolutionWidthField.Name = "_resolutionWidthField";
            this._resolutionWidthField.PasswordChar = '\0';
            this._resolutionWidthField.SelectedText = "";
            this._resolutionWidthField.SelectionLength = 0;
            this._resolutionWidthField.SelectionStart = 0;
            this._resolutionWidthField.Size = new System.Drawing.Size(147, 23);
            this._resolutionWidthField.TabIndex = 24;
            this._resolutionWidthField.Text = "1000";
            this._resolutionWidthField.UseSystemPasswordChar = false;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(807, 444);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(81, 19);
            this.materialLabel11.TabIndex = 23;
            this.materialLabel11.Text = "Resolution";
            // 
            // _coordinatesField
            // 
            this._coordinatesField.AutoSize = true;
            this._coordinatesField.Depth = 0;
            this._coordinatesField.Font = new System.Drawing.Font("Roboto", 11F);
            this._coordinatesField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._coordinatesField.Location = new System.Drawing.Point(12, 641);
            this._coordinatesField.MouseState = MaterialSkin.MouseState.HOVER;
            this._coordinatesField.Name = "_coordinatesField";
            this._coordinatesField.Size = new System.Drawing.Size(43, 19);
            this._coordinatesField.TabIndex = 28;
            this._coordinatesField.Text = "x:- y:-";
            // 
            // _progress
            // 
            this._progress.AutoSize = true;
            this._progress.Depth = 0;
            this._progress.Font = new System.Drawing.Font("Roboto", 11F);
            this._progress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._progress.Location = new System.Drawing.Point(696, 641);
            this._progress.MouseState = MaterialSkin.MouseState.HOVER;
            this._progress.Name = "_progress";
            this._progress.Size = new System.Drawing.Size(96, 19);
            this._progress.TabIndex = 42;
            this._progress.Text = "Progress: 0%";
            // 
            // _panel
            // 
            this._panel.Controls.Add(this._pictureBox);
            this._panel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this._panel.Location = new System.Drawing.Point(16, 77);
            this._panel.Name = "_panel";
            this._panel.Size = new System.Drawing.Size(777, 554);
            this._panel.TabIndex = 43;
            this._panel.SizeChanged += new System.EventHandler(this.SizeChanged_panel);
            this._panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_panel);
            this._panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_panel);
            this._panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_panel);
            // 
            // _pictureBox
            // 
            this._pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._pictureBox.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this._pictureBox.Image = global::MandelbrotSet.Resource.im_01;
            this._pictureBox.InitialImage = null;
            this._pictureBox.Location = new System.Drawing.Point(0, 0);
            this._pictureBox.Name = "_pictureBox";
            this._pictureBox.Size = new System.Drawing.Size(777, 554);
            this._pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._pictureBox.TabIndex = 0;
            this._pictureBox.TabStop = false;
            this._pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_pictureBox);
            this._pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_pictureBox);
            this._pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_pictureBox);
            // 
            // _changeColorsButton
            // 
            this._changeColorsButton.AutoSize = true;
            this._changeColorsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._changeColorsButton.Depth = 0;
            this._changeColorsButton.Location = new System.Drawing.Point(842, 547);
            this._changeColorsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this._changeColorsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this._changeColorsButton.Name = "_changeColorsButton";
            this._changeColorsButton.Primary = false;
            this._changeColorsButton.Size = new System.Drawing.Size(122, 36);
            this._changeColorsButton.TabIndex = 44;
            this._changeColorsButton.Text = "Change colors";
            this._changeColorsButton.UseVisualStyleBackColor = true;
            this._changeColorsButton.Click += new System.EventHandler(this.Click_changeColorsButton);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(992, 664);
            this.Controls.Add(this._panel);
            this.Controls.Add(this._progress);
            this.Controls.Add(this._coordinatesField);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this._resolutionHeightField);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this._resolutionWidthField);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this._minusButton);
            this.Controls.Add(this._plusButton);
            this.Controls.Add(this._paletteLengthBox);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this._heightField);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this._widthField);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this._loading);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this._yField);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this._xField);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this._iterationsField);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this._updateButton);
            this.Controls.Add(this._changeColorsButton);
            this.Name = "Form1";
            this.Text = "Mandelbrot Set";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this._panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _pictureBox;
        private volatile MaterialSkin.Controls.MaterialFlatButton _updateButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField _iterationsField;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField _xField;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField _yField;
        private volatile MaterialSkin.Controls.MaterialLabel _loading;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField _heightField;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField _widthField;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField _paletteLengthBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialFlatButton _plusButton;
        private MaterialSkin.Controls.MaterialFlatButton _minusButton;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private System.Windows.Forms.SaveFileDialog _saveDialog;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialSingleLineTextField _resolutionHeightField;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialSingleLineTextField _resolutionWidthField;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel _coordinatesField;
        private volatile MaterialSkin.Controls.MaterialLabel _progress;
        private System.Windows.Forms.Panel _panel;
        private MaterialSkin.Controls.MaterialFlatButton _changeColorsButton;
    }
}

