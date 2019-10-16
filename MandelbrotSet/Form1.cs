using System;
using System.Drawing;
using System.Numerics;
using System.Threading;
using System.Windows.Forms;

namespace MandelbrotSet
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        private double _center_x = -0.5d;
        private double _center_y = 0;
        private double _width = 3;
        private double _height = 2;
        private int _paletteLength = 35;
        private int _resolutionHeight = 1080;
        private int _resolutionWidth = 1920;
        private int _iterations = 35;
        private Color _bodyColor = Color.Black;
        private bool _mouseDown;
        private Point _savedPoint;
        private bool _resolutionChanged;
        private Point _delta;

        private Color[] _palette;
        private volatile Bitmap _image;
        private Thread _thread;
        private Color[,] _pixels;
        private Color[] _colors;

        private readonly SaveOptions _saveOptions;
        private readonly ChangeColors _changeColors;

        public Form1()
        {
            InitializeComponent();
            _changeColors = new ChangeColors();
            _saveOptions = new SaveOptions();
        }

        private void SetFields()
        {
            _iterationsField.Text = _iterations.ToString();
            _xField.Text = _center_x.ToString();
            _yField.Text = _center_y.ToString();
            _widthField.Text = _width.ToString();
            _heightField.Text = _height.ToString();
            _paletteLengthBox.Text = _paletteLength.ToString();
            _resolutionHeightField.Text = _resolutionHeight.ToString();
            _resolutionWidthField.Text = _resolutionWidth.ToString();
        }

        private float _count;
        private int _imageSize;

        private void RedrawImageThread()
        {
            if (_resolutionChanged)
                _pixels = new Color[_resolutionWidth, _resolutionHeight];

            var percent = 0;

            for (var x = 0; x < _resolutionWidth; x++)
                for (var y = 0; y < _resolutionHeight; y++)
                {
                    _pixels[x, y] = GetColor(x, y);
                    _count++;

                    var n = (int)(_count / _imageSize * 100f);
                    if (percent != n)
                    {
                        percent = n;
                        var text = $"Progress: {percent}%";

                        _progress.Invoke(new Action(delegate ()
                        {
                            _progress.Text = text;
                            _progress.Location = new Point(792 - _progress.Size.Width, 660 - _progress.Size.Height);
                        }));
                    }
                }

            _pictureBox.Invoke(new Action(delegate ()
            {
                if (_resolutionChanged)
                {
                    _image = new Bitmap(_resolutionWidth, _resolutionHeight);
                    _pictureBox.Image = _image;
                }

                for (var x = 0; x < _resolutionWidth; x++)
                    for (var y = 0; y < _resolutionHeight; y++)
                        ((Bitmap)_pictureBox.Image).SetPixel(x, y, _pixels[x, y]);
                _pictureBox.Refresh();

                _loading.Visible = false;
                _updateButton.Enabled = true;

                _pictureBox.Location = new Point(0, 0);
                _pictureBox.Size = _panel.Size;
            }));

            _resolutionChanged = false;
        }

        private void RedrawImage()
        {
            _palette = new Color[_paletteLength];

            for (var i = 0; i < _palette.Length; i++)
            {
                var index = (int)((float)i / _paletteLength * _colors.Length);
                _palette[i] = ToColor(Vector3.Lerp(FromColor(_colors[index]), FromColor(_colors[(index + 1) % _colors.Length]), (float)i / _paletteLength % (1f / _colors.Length) * _colors.Length));
            }

            _loading.Visible = true;
            _updateButton.Enabled = false;

            _count = 0;
            _imageSize = _resolutionWidth * _resolutionHeight;

            _thread = new Thread(RedrawImageThread) { Name = nameof(RedrawImageThread) };
            _thread.Start();
        }

        private static Vector3 FromColor(Color color) =>
            new Vector3(color.R, color.G, color.B);

        private static Color ToColor(Vector3 vector) =>
            Color.FromArgb((int)vector.X, (int)vector.Y, (int)vector.Z);

        private Complex ToComplex(int x, int y) =>
            new Complex(x / (double)_resolutionWidth * _width + (_center_x - _width / 2d),
                _height - y / (double)_resolutionHeight * _height + (_center_y - _height / 2d));

        private static double SqrMagnitude(Complex number) => number.Real * number.Real + number.Imaginary * number.Imaginary;

        private Color GetColor(int x, int y)
        {
            var c = ToComplex(x, y);
            var z = new Complex(0, 0);

            double iterations = 0;
            var i_iterations = 0;
            var sqrMagniture = 0d;

            for (var i = 0; i < _iterations; i++)
            {
                iterations = i;
                i_iterations = i;
                z = z * z + c;
                sqrMagniture = SqrMagnitude(z);
                if (sqrMagniture > 1 << 16)
                    break;
            }

            if (iterations == _iterations - 1)
                return _bodyColor;

            if (iterations < _iterations - 1)
                iterations += 2 - Math.Log(Math.Log(sqrMagniture, 2), 2);

            var color1 = FromColor(_palette[i_iterations % _paletteLength]);
            var color2 = FromColor(_palette[(i_iterations + 1) % _paletteLength]);

            return ToColor(Vector3.Lerp(color1, color2, (float)(iterations - Math.Truncate(iterations))));
        }

        private void SetData()
        {
            _iterations = Convert.ToInt32(_iterationsField.Text);
            _center_x = Convert.ToDouble(_xField.Text);
            _center_y = Convert.ToDouble(_yField.Text);
            _width = Convert.ToDouble(_widthField.Text);
            _height = Convert.ToDouble(_heightField.Text);
            _paletteLength = Convert.ToInt32(_paletteLengthBox.Text);

            var temp = Convert.ToInt32(_resolutionHeightField.Text);
            if (temp != _resolutionHeight)
            {
                _resolutionHeight = Convert.ToInt32(_resolutionHeightField.Text);
                _resolutionChanged = true;
            }

            temp = Convert.ToInt32(_resolutionWidthField.Text);
            if (temp != _resolutionWidth)
            {
                _resolutionWidth = Convert.ToInt32(_resolutionWidthField.Text);
                _resolutionChanged = true;
            }
        }

        private void MaterialFlatButton1_Click(object sender, EventArgs e)
        {
            SetData();
            Update();
            RedrawImage();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            _loading.Visible = false;
            _updateButton.Size = new Size(178, 36);
            SetFields();

            _pixels = new Color[_resolutionWidth, _resolutionHeight];
            _colors = new Color[]
            {
                Color.DarkBlue,
                Color.LightBlue,
                Color.Orange
            };
        }

        private void Click_minusButton(object sender, EventArgs e)
        {
            _heightField.Text = (Convert.ToDouble(_heightField.Text) * 2d).ToString();
            _widthField.Text = (Convert.ToDouble(_widthField.Text) * 2d).ToString();

            _width = Convert.ToDouble(_widthField.Text);
            _height = Convert.ToDouble(_heightField.Text);

            PlaceBox(0.5f);
        }

        private void PlaceBox(float multiplier)
        {
            var center = new Point(_pictureBox.Location.X + _pictureBox.Size.Width / 2 - _panel.Size.Width / 2,
                _pictureBox.Location.Y + _pictureBox.Size.Height / 2 - _panel.Size.Height / 2);

            _pictureBox.Size = new Size((int)(_pictureBox.Size.Width * multiplier), (int)(_pictureBox.Size.Height * multiplier));
            _pictureBox.Location = new Point((int)(center.X * multiplier + (_panel.Size.Width - _pictureBox.Size.Width) / 2),
                (int)(center.Y * multiplier + (_panel.Size.Height - _pictureBox.Size.Height) / 2));

        }

        private void Click_plusButton(object sender, EventArgs e)
        {
            _heightField.Text = (Convert.ToDouble(_heightField.Text) / 2d).ToString();
            _widthField.Text = (Convert.ToDouble(_widthField.Text) / 2d).ToString();

            _width = Convert.ToDouble(_widthField.Text);
            _height = Convert.ToDouble(_heightField.Text);

            PlaceBox(2f);
        }

        private void MaterialFlatButton2_Click(object sender, EventArgs e)
        {
            SetData();
            var data = new SaveData(_center_x, _center_y, _height, _width, new Size(_resolutionWidth, _resolutionHeight), _paletteLength, _iterations, _bodyColor, _colors);

            if (_saveOptions.ShowDialog(data, (Bitmap)_pictureBox.Image) == SaveOptionsResult.Load)
            {
                data = _saveOptions.Loaded;

                _center_x = data.X;
                _center_y = data.Y;
                _height = data.Height;
                _width = data.Width;
                _resolutionWidth = data.Resolution.Width;
                _resolutionHeight = data.Resolution.Height;
                _paletteLength = data.PalleteLength;
                _iterations = data.Iterations;
                _bodyColor = data.BodyColor;
                _colors = data.Colors;

                SetFields();
                MaterialFlatButton1_Click(sender, e);
            }
        }

        private void MouseMove_pictureBox(object sender, MouseEventArgs e)
        {
            var coor = ToComplex((int)((double)(e.X) / _pictureBox.Width * _resolutionWidth), (int)((double)(_pictureBox.Height - e.Y) / _pictureBox.Height * _resolutionHeight));

            _coordinatesField.Text = $"x:{coor.Real} y:{coor.Imaginary}";

            if ((!_thread?.IsAlive ?? true) && _mouseDown)
            {
                var delta = new Point(e.X - _savedPoint.X, e.Y - _savedPoint.Y);
                _pictureBox.Location = new Point(_pictureBox.Location.X + delta.X, _pictureBox.Location.Y + delta.Y);
            }
        }

        private void MouseDown_pictureBox(object sender, MouseEventArgs e)
        {
            if (!_thread?.IsAlive ?? true)
            {
                _savedPoint = e.Location;
                _mouseDown = true;
                _delta = _pictureBox.Location;
            }
        }

        private void MouseUp_pictureBox(object sender, MouseEventArgs e)
        {
            if (!_thread?.IsAlive ?? true)
            {
                _mouseDown = false;

                _center_x += (double)(_delta.X - _pictureBox.Location.X) / _panel.Width * _width;
                _center_y -= (double)(_delta.Y - _pictureBox.Location.Y) / _panel.Height * _height;

                var center = ToComplex((int)(0.5d * _resolutionWidth), (int)(0.5d * _resolutionHeight));

                _xField.Text = center.Real.ToString();
                _yField.Text = center.Imaginary.ToString();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_thread?.IsAlive ?? false)
                _thread.Abort();
        }

        private void MouseUp_panel(object sender, MouseEventArgs e) => MouseUp_pictureBox(sender, new MouseEventArgs(e.Button, e.Clicks, e.X - _pictureBox.Location.X, e.Y - _pictureBox.Location.Y, e.Delta));

        private void MouseMove_panel(object sender, MouseEventArgs e) => MouseMove_pictureBox(sender, new MouseEventArgs(e.Button, e.Clicks, e.X - _pictureBox.Location.X, e.Y - _pictureBox.Location.Y, e.Delta));

        private void MouseDown_panel(object sender, MouseEventArgs e) => MouseDown_pictureBox(sender, new MouseEventArgs(e.Button, e.Clicks, e.X - _pictureBox.Location.X, e.Y - _pictureBox.Location.Y, e.Delta));

        private void Click_changeColorsButton(object sender, EventArgs e)
        {
            if (_changeColors.ShowDialog(_colors, _bodyColor) == DialogResult.OK)
            {
                _colors = _changeColors.Colors;
                _bodyColor = _changeColors.BodyColor;
            }
        }
    }
}
