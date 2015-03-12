
namespace DefiningClassesPartTwo.Point
{
    using System;
    using System.Text;
    using System.IO;

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
                writer.WriteLine(builder);
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
    }
}
