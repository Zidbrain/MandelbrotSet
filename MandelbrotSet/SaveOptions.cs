using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MandelbrotSet
{
    public enum SaveOptionsResult
    {
        Save, Load, Exit
    }

    public partial class SaveOptions : MaterialForm
    {
        private SaveData _data;
        private Bitmap _image;
        private SaveOptionsResult _result;

        public SaveData Loaded { get; private set; }

        public SaveOptions() => InitializeComponent();

        public SaveOptionsResult ShowDialog(SaveData data, Bitmap image)
        {
            _data = data;
            _image = image;
            var result = ShowDialog();
            if (result == DialogResult.Cancel)
                return SaveOptionsResult.Exit;
            else
                return _result;
        }

        private void Click_savePicture(object sender, EventArgs e)
        {
            _saveDialog.Filter = "PNG Files|*.png";
            if (_saveDialog.ShowDialog() == DialogResult.OK)
            {
                _image.Save(_saveDialog.FileName);
                DialogResult = DialogResult.OK;
                _result = SaveOptionsResult.Save;
                Close();
            }
        }

        private void Click_saveAll(object sender, EventArgs e)
        {
            _saveDialog.Filter = "Data Files|.dat";
            if (_saveDialog.ShowDialog() == DialogResult.OK)
            {
                _data.Save(_saveDialog.FileName);
                DialogResult = DialogResult.OK;
                _result = SaveOptionsResult.Save;
                Close();
            }
        }

        private void Click_loadButton(object sender, EventArgs e)
        {
            if (_openFile.ShowDialog() == DialogResult.OK)
            {
                Loaded = SaveData.Load(_openFile.FileName);
                DialogResult = DialogResult.OK;
                _result = SaveOptionsResult.Load;
                Close();
            }
        }
    }
}
