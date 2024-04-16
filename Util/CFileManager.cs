using System.IO;
using System.Windows.Forms;

namespace QMM.Util
{
    public static class CFileManager
    {
        public static string SelectDirectory(string title, string defaultFolderName, string warningMessage)
        {
            using (var folderBrowserDialog = new OpenFileDialog())
            {
                folderBrowserDialog.Title = title;
                folderBrowserDialog.CheckFileExists = false;
                folderBrowserDialog.CheckPathExists = true;
                folderBrowserDialog.FileName = defaultFolderName;
                folderBrowserDialog.Filter = "Folders|\n";

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    return Path.GetDirectoryName(folderBrowserDialog.FileName);
                }
                else
                {
                    CNotification.CreateNotif(Properties.Settings.Default.WarningColor, warningMessage);
                    return null;
                }
            }
        }

        public static void SelectGameDirectory()
        {
            string selectedPath = SelectDirectory("Select Game Directory", "Select Folder", "You did not choose a game directory!");

            if (!string.IsNullOrWhiteSpace(selectedPath))
            {
                Properties.Settings.Default.GameDir = selectedPath;
                CNotification.CreateNotif(Properties.Settings.Default.SuccessColor, "Game path set to: " + selectedPath);
            }
        }

        public static void SelectUserDataDirectory()
        {
            string selectedPath = SelectDirectory("Select User Data Directory", "Select Folder", "You did not choose your user data directory!");

            if (!string.IsNullOrWhiteSpace(selectedPath))
            {
                Properties.Settings.Default.UserDataDir = selectedPath;
                CNotification.CreateNotif(Properties.Settings.Default.SuccessColor, "User Data path set to: " + selectedPath);
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