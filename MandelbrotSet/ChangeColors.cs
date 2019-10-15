using MaterialSkin.Controls;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace MandelbrotSet
{
    public partial class ChangeColors : MaterialForm
    {
        private List<(PictureBox picture, Point location, Color color, MaterialFlatButton minusButton)> _pictures;
        private Point _buttonLocation;
        private int _scrollInt;

        private static readonly Font s_font = new Font("Microsoft Sans Serif", 16f, FontStyle.Regular, GraphicsUnit.Point, 204);

        private Bitmap FromColor(Color color)
        {
            var ret = new Bitmap(_plusButton.Size.Width, _plusButton.Size.Height);
            for (var x = 0; x < ret.Width; x++)
                for (var y = 0; y < ret.Height; y++)
                    ret.SetPixel(x, y, color);
            return ret;
        }

        private Point GetLocation(int i)
        {
            var irem = (_panel.Size.Width - _scroll.Size.Width) / (_plusButton.Size.Width + 4);
            return new Point(4 + (_plusButton.Size.Width + 4) * (i % irem), 6 + (_plusButton.Size.Height + 6) * (i / irem));
        }

        public void PlaceWithScroll()
        {
            _panel.SuspendLayout();
            for (int i = 0; i < _pictures.Count; i++)
            {
                var control = _pictures[i].picture;
                control.Location = new Point(_pictures[i].location.X, (int)(_pictures[i].location.Y - _scrollInt / 100f * (100f / _scroll.LargeChange) * _panel.Height));
            }
            _plusButton.Location = new Point(_buttonLocation.X, (int)(_buttonLocation.Y - _scrollInt / 100f * (100f / _scroll.LargeChange) * _panel.Height));
            _panel.ResumeLayout(true);
        }

        private void AddPictureBox(Color color, int i)
        {
            var picture = new PictureBox()
            {
                Image = FromColor(color),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = _plusButton.Size,
                Location = GetLocation(i),
                Cursor = Cursors.Hand
            };
            _panel.Controls.Add(picture);

            var minusButton = new MaterialFlatButton()
            {
                AutoSize = false,
                Text = "-",
                Font = s_font,
                AutoEllipsis = false,
                Size = new Size(24, 24),
                TextAlign = ContentAlignment.MiddleCenter
            };
            minusButton.Location = new Point(picture.Size.Width - minusButton.Size.Width, 0);
            picture.Controls.Add(minusButton);

            picture.Click += ChangeColor;
            minusButton.Click += RemovePicture;

            _pictures.Add((picture, picture.Location, color, minusButton));
        }

        private void RemovePicture(object sender, EventArgs e)
        {
            for (int i = 0; i < _pictures.Count; i++)
                if (_pictures[i].minusButton == sender)
                {
                    _panel.Controls.Remove(_pictures[i].picture);
                    _pictures[i].picture.Dispose();
                    _pictures[i].minusButton.Dispose();
                    _pictures.RemoveAt(i);

                    for (int j = i; j < _pictures.Count; j++)
                        _pictures[j] = (_pictures[j].picture, GetLocation(j), _pictures[j].color, _pictures[j].minusButton);
                    _buttonLocation = GetLocation(_pictures.Count);
                    PlaceWithScroll();

                    return;
                }
        }

        public Color[] Colors
        {
            get
            {
                var ret = new Color[_pictures.Count];
                for (int i = 0; i < ret.Length; i++)
                    ret[i] = _pictures[i].color;
                return ret;
            }
        }

        public Color BodyColor { get; private set; }

        public DialogResult ShowDialog(Color[] colors, Color bodyColor)
        {
            _bodyColor.Image = FromColor(bodyColor);

            _pictures = new List<(PictureBox picture, Point location, Color color, MaterialFlatButton button)>();

            for (var i = 0; i < colors.Length; i++)
                AddPictureBox(colors[i], i);
            _plusButton.Location = GetLocation(_pictures.Count);
            _buttonLocation = _plusButton.Location;

            BodyColor = bodyColor;

            var ret = ShowDialog();

            for (int i =0; i < _pictures.Count; i++)
            {
                _pictures[i].picture.Controls.Remove(_pictures[i].minusButton);
                _panel.Controls.Remove(_pictures[i].picture);

                _pictures[i].minusButton.Dispose();
                _pictures[i].picture.Dispose();
            }

            return ret;
        }

        public ChangeColors()
        {
            InitializeComponent();

            SuspendLayout();
            _plusButton.AutoSize = false;
            _plusButton.Size = new Size(72, 72);
            _okButton.AutoSize = false;
            _okButton.Size = new Size(85, 36);
            ResumeLayout(true);
        }

        private void ChangeColor(object sender, EventArgs e)
        {
            var pictureBox = sender as PictureBox;

            if (_colorDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image.Dispose();
                pictureBox.Image = FromColor(_colorDialog.Color);

                for (int i = 0; i < _pictures.Count; i++)
                    if (_pictures[i].picture == pictureBox)
                    {
                        _pictures[i] = (pictureBox, _pictures[i].location, _colorDialog.Color, _pictures[i].minusButton);
                        return;
                    }
            }
        }

        private void Scroll_scroll(object sender, ScrollEventArgs e)
        {
            _scrollInt = e.NewValue;
            PlaceWithScroll();
        }

        private void Click_plusButton(object sender, System.EventArgs e)
        {
            if (_colorDialog.ShowDialog() == DialogResult.OK)
            {
                AddPictureBox(_colorDialog.Color, _pictures.Count);

                _plusButton.Location = GetLocation(_pictures.Count);
                _buttonLocation = _plusButton.Location;

                PlaceWithScroll();
            }
        }

        private void Click_bodyColor(object sender, EventArgs e)
        {
            if (_colorDialog.ShowDialog() == DialogResult.OK)
            {
                _bodyColor.Image.Dispose();
                _bodyColor.Image = FromColor(_colorDialog.Color);
                BodyColor = _colorDialog.Color;
            }
        }

        private void Click_okButton(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
