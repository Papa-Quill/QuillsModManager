using System.IO;
using System.Windows.Forms;

namespace QMM.Util
{
    public static class CFileManager
    {
        public static void SelectGameDirectory()
        {
            using (var folderBrowserDialog = new OpenFileDialog())
            {
                folderBrowserDialog.Title = "Select Game Directory";
                folderBrowserDialog.CheckFileExists = false;
                folderBrowserDialog.CheckPathExists = true;
                folderBrowserDialog.FileName = "Select Folder";
                folderBrowserDialog.Filter = "Folders|\n";

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(Path.GetDirectoryName(folderBrowserDialog.FileName)))
                {
                    Properties.Settings.Default.GameDir = Path.GetDirectoryName(folderBrowserDialog.FileName);
                }
                else
                {
                    folderBrowserDialog.Dispose();
                    CNotification.CreateNotif(Properties.Settings.Default.WarningColor, "You did not choose a game directory!");
                }
            }
        }

        public static void CopyDirectory(string sourceDir, string destinationDir, bool directoriesOnly)
        {
            if (!Directory.Exists(destinationDir))
                Directory.CreateDirectory(destinationDir);

            var dir = new DirectoryInfo(sourceDir);
            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

            if (!directoriesOnly)
            {
                foreach (string file in Directory.GetFiles(sourceDir))
                {
                    string targetFilePath = Path.Combine(destinationDir, Path.GetFileName(file));
                    File.Copy(file, targetFilePath, true);
                }
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            foreach (DirectoryInfo subDir in dirs)
            {
                string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                CopyDirectory(subDir.FullName, newDestinationDir, false);
            }
        }
    }
}