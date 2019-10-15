namespace MandelbrotSet
{
    partial class ChangeColors
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
            this._panel = new System.Windows.Forms.Panel();
            this._plusButton = new MaterialSkin.Controls.MaterialFlatButton();
            this._scroll = new System.Windows.Forms.VScrollBar();
            this._colorDialog = new System.Windows.Forms.ColorDialog();
            this._bodyColor = new System.Windows.Forms.PictureBox();
            this._bodyColorLabel = new MaterialSkin.Controls.MaterialLabel();
            this._okButton = new MaterialSkin.Controls.MaterialFlatButton();
            this._panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._bodyColor)).BeginInit();
            this.SuspendLayout();
            // 
            // _panel
            // 
            this._panel.Controls.Add(this._plusButton);
            this._panel.Controls.Add(this._scroll);
            this._panel.Location = new System.Drawing.Point(13, 71);
            this._panel.Name = "_panel";
            this._panel.Size = new System.Drawing.Size(690, 367);
            this._panel.TabIndex = 0;
            // 
            // _plusButton
            // 
            this._plusButton.AutoSize = true;
            this._plusButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._plusButton.Depth = 0;
            this._plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._plusButton.Location = new System.Drawing.Point(4, 6);
            this._plusButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this._plusButton.MouseState = MaterialSkin.MouseState.HOVER;
            this._plusButton.Name = "_plusButton";
            this._plusButton.Primary = false;
            this._plusButton.Size = new System.Drawing.Size(20, 36);
            this._plusButton.TabIndex = 1;
            this._plusButton.Text = "+";
            this._plusButton.UseVisualStyleBackColor = true;
            this._plusButton.Click += new System.EventHandler(this.Click_plusButton);
            // 
            // _scroll
            // 
            this._scroll.LargeChange = 100;
            this._scroll.Location = new System.Drawing.Point(673, 0);
            this._scroll.Name = "_scroll";
            this._scroll.Size = new System.Drawing.Size(17, 367);
            this._scroll.TabIndex = 0;
            this._scroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Scroll_scroll);
            // 
            // _bodyColor
            // 
            this._bodyColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this._bodyColor.Location = new System.Drawing.Point(716, 71);
            this._bodyColor.Name = "_bodyColor";
            this._bodyColor.Size = new System.Drawing.Size(72, 72);
            this._bodyColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._bodyColor.TabIndex = 1;
            this._bodyColor.TabStop = false;
            this._bodyColor.Click += new System.EventHandler(this.Click_bodyColor);
            // 
            // _bodyColorLabel
            // 
            this._bodyColorLabel.AutoSize = true;
            this._bodyColorLabel.Depth = 0;
            this._bodyColorLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this._bodyColorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._bodyColorLabel.Location = new System.Drawing.Point(712, 146);
            this._bodyColorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this._bodyColorLabel.Name = "_bodyColorLabel";
            this._bodyColorLabel.Size = new System.Drawing.Size(83, 19);
            this._bodyColorLabel.TabIndex = 2;
            this._bodyColorLabel.Text = "Body Color";
            // 
            // _okButton
            // 
            this._okButton.AutoSize = true;
            this._okButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._okButton.Depth = 0;
            this._okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._okButton.Location = new System.Drawing.Point(710, 402);
            this._okButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this._okButton.MouseState = MaterialSkin.MouseState.HOVER;
            this._okButton.Name = "_okButton";
            this._okButton.Primary = false;
            this._okButton.Size = new System.Drawing.Size(30, 36);
            this._okButton.TabIndex = 5;
            this._okButton.Text = "OK";
            this._okButton.UseVisualStyleBackColor = true;
            this._okButton.Click += new System.EventHandler(this.Click_okButton);
            // 
            // ChangeColors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this._bodyColorLabel);
            this.Controls.Add(this._bodyColor);
            this.Controls.Add(this._panel);
            this.MaximizeBox = false;
            this.Name = "ChangeColors";
            this.Text = "Change Colors";
            this._panel.ResumeLayout(false);
            this._panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._bodyColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel _panel;
        private System.Windows.Forms.VScrollBar _scroll;
        private MaterialSkin.Controls.MaterialFlatButton _plusButton;
        private System.Windows.Forms.ColorDialog _colorDialog;
        private System.Windows.Forms.PictureBox _bodyColor;
        private MaterialSkin.Controls.MaterialLabel _bodyColorLabel;
        private MaterialSkin.Controls.MaterialFlatButton _okButton;
    }
}