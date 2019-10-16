using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MandelbrotSet
{
    [Serializable]
    public class SaveData
    {
        private static readonly BinaryFormatter s_serializer = new BinaryFormatter();

        public double X { get; set; }
        public double Y { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }

        public Size Resolution { get; set; }
        public int PalleteLength { get; set; }

        public int Iterations { get; set; }
        public Color BodyColor { get; set; }
        public Color[] Colors { get; set; }

        public SaveData(double x, double y, double heigth, double width, Size resolution, int palleteLength, int iterations, Color bodyColor, Color[] colors) =>
            (X, Y, Height, Width, Resolution, PalleteLength, Iterations, BodyColor, Colors) = (x, y, heigth, width, resolution, palleteLength, iterations, bodyColor, colors);

        public void Save(string filePath)
        {
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                s_serializer.Serialize(stream, this);
            }
        }

        public static SaveData Load(string filePath)
        {
            using (var stream = new FileStream(filePath, FileMode.Open))
            {
                return (SaveData)s_serializer.Deserialize(stream);
            }
        }
    }
}