using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace QMM
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            string fontName = "Azonix";
            if (IsFontInstalled(fontName))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                LoadSettingsFromJson();
                Application.Run(new MainForm());
            }
            else
            {
                Process.Start(fontName + ".ttf");
                MessageBox.Show("Please install the Azonix font.", "Font Missing!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        static bool IsFontInstalled(string fontName)
        {
            using (InstalledFontCollection fontsCollection = new InstalledFontCollection())
            {
                foreach (FontFamily fontFamily in fontsCollection.Families)
                {
                    if (fontFamily.Name.Equals(fontName, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        static void LoadSettingsFromJson()
        {
            try
            {
                string jsonFilePath = "settings.json";
                if (!File.Exists(jsonFilePath))
                {
                    // Create a new JSON object with default settings
                    JObject defaultSettings = new JObject(
                        new JProperty("ButtonColor", ColorTranslator.ToHtml(Properties.Settings.Default.ButtonColor)),
                        new JProperty("BGPrimary", ColorTranslator.ToHtml(Properties.Settings.Default.BGPrimary)),
                        new JProperty("BGSecondary", ColorTranslator.ToHtml(Properties.Settings.Default.BGSecondary)),
                        new JProperty("BGTertiary", ColorTranslator.ToHtml(Properties.Settings.Default.BGTertiary)),
                        new JProperty("DetailColor", ColorTranslator.ToHtml(Properties.Settings.Default.DetailColor)),
                        new JProperty("DetailActive", ColorTranslator.ToHtml(Properties.Settings.Default.DetailActive)),
                        new JProperty("TextColor", ColorTranslator.ToHtml(Properties.Settings.Default.TextColor)),
                        new JProperty("PlaceholderColor", ColorTranslator.ToHtml(Properties.Settings.Default.PlaceholderColor)),
                        new JProperty("SuccessColor", ColorTranslator.ToHtml(Properties.Settings.Default.SuccessColor)),
                        new JProperty("WarningColor", ColorTranslator.ToHtml(Properties.Settings.Default.WarningColor)),
                        new JProperty("NotifColor", ColorTranslator.ToHtml(Properties.Settings.Default.NotifColor)),
                        new JProperty("GameDir", Properties.Settings.Default.GameDir),
                        new JProperty("UserDataDir", Properties.Settings.Default.UserDataDir),
                        new JProperty("RoundedControls", Properties.Settings.Default.RoundedControls),
                        new JProperty("FormShadows", Properties.Settings.Default.FormShadows),
                        new JProperty("ToolTips", Properties.Settings.Default.ToolTips),
                        new JProperty("BorderRadius", Properties.Settings.Default.BorderRadius)
                    );

                    // Write the default settings to the JSON file
                    File.WriteAllText(jsonFilePath, defaultSettings.ToString());
                }

                // Load settings from the JSON file
                string json = File.ReadAllText(jsonFilePath);
                JObject jObject = JObject.Parse(json);

                // Update each setting in Properties.Settings.Default
                Properties.Settings.Default.ButtonColor = ColorTranslator.FromHtml((string)jObject["ButtonColor"]);
                Properties.Settings.Default.BGPrimary = ColorTranslator.FromHtml((string)jObject["BGPrimary"]);
                Properties.Settings.Default.BGSecondary = ColorTranslator.FromHtml((string)jObject["BGSecondary"]);
                Properties.Settings.Default.BGTertiary = ColorTranslator.FromHtml((string)jObject["BGTertiary"]);
                Properties.Settings.Default.DetailColor = ColorTranslator.FromHtml((string)jObject["DetailColor"]);
                Properties.Settings.Default.DetailActive = ColorTranslator.FromHtml((string)jObject["DetailActive"]);
                Properties.Settings.Default.TextColor = ColorTranslator.FromHtml((string)jObject["TextColor"]);
                Properties.Settings.Default.PlaceholderColor = ColorTranslator.FromHtml((string)jObject["PlaceholderColor"]);
                Properties.Settings.Default.SuccessColor = ColorTranslator.FromHtml((string)jObject["SuccessColor"]);
                Properties.Settings.Default.WarningColor = ColorTranslator.FromHtml((string)jObject["WarningColor"]);
                Properties.Settings.Default.NotifColor = ColorTranslator.FromHtml((string)jObject["NotifColor"]);
                Properties.Settings.Default.GameDir = (string)jObject["GameDir"];
                Properties.Settings.Default.UserDataDir = (string)jObject["UserDataDir"];
                Properties.Settings.Default.RoundedControls = (bool)jObject["RoundedControls"];
                Properties.Settings.Default.FormShadows = (bool)jObject["FormShadows"];
                Properties.Settings.Default.ToolTips = (bool)jObject["ToolTips"];
                Properties.Settings.Default.BorderRadius = (int)jObject["BorderRadius"];

                // Save changes to Properties.Settings.Default
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading settings from JSON: " + ex.Message);
            }
        }
    }
}