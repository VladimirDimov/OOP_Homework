
namespace DefiningClassesPartTwo.Point
{
    using System;
    using System.Text;
    using System.IO;
    using System.Linq;

    public static class PathStorage
    {
        public static void SavePath(Path path, string filePath)
        {
            try
            {
                var builder = new StringBuilder();
                StreamWriter writer = new StreamWriter(filePath);
                //write each point from path on separate line;
                foreach (var point in path.PathPoints)
                {
                    builder.AppendLine(string.Format("{0} {1} {2}", point.X, point.Y, point.Z));
                }
                writer.Write(builder);
                writer.Close();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void LoadPath(Path path, string filePath)
        {
            try
            {
                StreamReader reader = new StreamReader(filePath);
                string currentLine;

                while ((currentLine = reader.ReadLine()) != null)
                {
                    int[] coordinates = currentLine.Split().Select(x => int.Parse(x)).ToArray();
                    path.AddPoint(new Point3D(coordinates[0], coordinates[1], coordinates[2]));
                }
                reader.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
