namespace MandelbrotSet
{
    partial class SaveOptions
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
            this._savePicture = new MaterialSkin.Controls.MaterialFlatButton();
            this._saveAll = new MaterialSkin.Controls.MaterialFlatButton();
            this._saveDialog = new System.Windows.Forms.SaveFileDialog();
            this._loadButton = new MaterialSkin.Controls.MaterialFlatButton();
            this._openFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // _savePicture
            // 
            this._savePicture.AutoSize = true;
            this._savePicture.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._savePicture.Depth = 0;
            this._savePicture.Location = new System.Drawing.Point(13, 71);
            this._savePicture.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this._savePicture.MouseState = MaterialSkin.MouseState.HOVER;
            this._savePicture.Name = "_savePicture";
            this._savePicture.Primary = false;
            this._savePicture.Size = new System.Drawing.Size(105, 36);
            this._savePicture.TabIndex = 0;
            this._savePicture.Text = "Save Picture";
            this._savePicture.UseVisualStyleBackColor = true;
            this._savePicture.Click += new System.EventHandler(this.Click_savePicture);
            // 
            // _saveAll
            // 
            this._saveAll.AutoSize = true;
            this._saveAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._saveAll.Depth = 0;
            this._saveAll.Location = new System.Drawing.Point(126, 71);
            this._saveAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this._saveAll.MouseState = MaterialSkin.MouseState.HOVER;
            this._saveAll.Name = "_saveAll";
            this._saveAll.Primary = false;
            this._saveAll.Size = new System.Drawing.Size(112, 36);
            this._saveAll.TabIndex = 1;
            this._saveAll.Text = "Save All Data";
            this._saveAll.UseVisualStyleBackColor = true;
            this._saveAll.Click += new System.EventHandler(this.Click_saveAll);
            // 
            // _loadButton
            // 
            this._loadButton.AutoSize = true;
            this._loadButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._loadButton.Depth = 0;
            this._loadButton.Location = new System.Drawing.Point(102, 119);
            this._loadButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this._loadButton.MouseState = MaterialSkin.MouseState.HOVER;
            this._loadButton.Name = "_loadButton";
            this._loadButton.Primary = false;
            this._loadButton.Size = new System.Drawing.Size(47, 36);
            this._loadButton.TabIndex = 2;
            this._loadButton.Text = "Load";
            this._loadButton.UseVisualStyleBackColor = true;
            this._loadButton.Click += new System.EventHandler(this.Click_loadButton);
            // 
            // _openFile
            // 
            this._openFile.Filter = "Data Files|*.dat";
            // 
            // SaveOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 167);
            this.Controls.Add(this._loadButton);
            this.Controls.Add(this._saveAll);
            this.Controls.Add(this._savePicture);
            this.MaximizeBox = false;
            this.Name = "SaveOptions";
            this.Sizable = false;
            this.Text = "Save/Load";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton _savePicture;
        private MaterialSkin.Controls.MaterialFlatButton _saveAll;
        private System.Windows.Forms.SaveFileDialog _saveDialog;
        private MaterialSkin.Controls.MaterialFlatButton _loadButton;
        private System.Windows.Forms.OpenFileDialog _openFile;
    }
}