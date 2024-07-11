using Newtonsoft.Json.Linq;
using QMM.Util;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace QMM
{
    public class Settings
    {
        private readonly string settingsFilePath = "settings.json";

        public Color ButtonColor { get; set; }
        public Color BGPrimary { get; set; }
        public Color BGSecondary { get; set; }
        public Color BGTertiary { get; set; }
        public Color DetailColor { get; set; }
        public Color DetailActive { get; set; }
        public Color TextColor { get; set; }
        public Color PlaceholderColor { get; set; }
        public Color SuccessColor { get; set; }
        public Color WarningColor { get; set; }
        public Color NotifColor { get; set; }

        public string Version { get; set; }
        public string GameDir { get; set; }
        public string UserDataDir { get; set; }

        public bool RoundedControls { get; set; }
        public bool FormShadows { get; set; }
        public bool ToolTips { get; set; }

        public int BorderRadius { get; set; }

        public Settings()
        {
            LoadSettingsFromConfig();
            if (File.Exists(settingsFilePath))
                LoadSettingsFromJson();
        }

        private void LoadSettingsFromConfig()
        {
            PropertyInfo[] properties = typeof(Settings).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (property.PropertyType == typeof(Color))
                    property.SetValue(this, Properties.Settings.Default[property.Name]);
                else if (property.PropertyType == typeof(string))
                    property.SetValue(this, Properties.Settings.Default[property.Name]);
                else if (property.PropertyType == typeof(bool))
                    property.SetValue(this, Properties.Settings.Default[property.Name]);
                else if (property.PropertyType == typeof(int))
                    property.SetValue(this, Properties.Settings.Default[property.Name]);
            }
        }

        private void LoadSettingsFromJson()
        {
            try
            {
                string json = File.ReadAllText(settingsFilePath);
                JObject jObject = JObject.Parse(json);

                foreach (PropertyInfo property in typeof(Settings).GetProperties())
                {
                    if (property.PropertyType == typeof(Color))
                        property.SetValue(this, ColorTranslator.FromHtml((string)jObject[property.Name]));
                    else if (property.PropertyType == typeof(string))
                        property.SetValue(this, (string)jObject[property.Name]);
                    else if (property.PropertyType == typeof(bool))
                        property.SetValue(this, (bool)jObject[property.Name]);
                    else if (property.PropertyType == typeof(int))
                        property.SetValue(this, (int)jObject[property.Name]);
                }
            }
            catch (Exception ex)
            {
                CNotification.CreateNotif(Properties.Settings.Default.WarningColor, "Error loading settings from JSON: " + ex.Message);
            }
        }

        public void SaveSettingsToJson()
        {
            try
            {
                JObject jObject = new JObject();

                PropertyInfo[] properties = Properties.Settings.Default.GetType().GetProperties();

                foreach (PropertyInfo property in properties)
                {
                    if (property.PropertyType == typeof(Color))
                        jObject[property.Name] = ColorTranslator.ToHtml((Color)property.GetValue(Properties.Settings.Default));
                    else if (property.PropertyType == typeof(string))
                        jObject[property.Name] = (string)property.GetValue(Properties.Settings.Default);
                    else if (property.PropertyType == typeof(bool))
                        jObject[property.Name] = (bool)property.GetValue(Properties.Settings.Default);
                    else if (property.PropertyType == typeof(int))
                        jObject[property.Name] = (int)property.GetValue(Properties.Settings.Default);
                }

                File.WriteAllText(settingsFilePath, jObject.ToString());

                foreach (PropertyInfo property in properties)
                {
                    if (jObject[property.Name] != null)
                    {
                        if (property.PropertyType == typeof(Color))
                            property.SetValue(Properties.Settings.Default, ColorTranslator.FromHtml((string)jObject[property.Name]));
                        else if (property.PropertyType == typeof(string))
                            property.SetValue(Properties.Settings.Default, (string)jObject[property.Name]);
                        else if (property.PropertyType == typeof(bool))
                            property.SetValue(Properties.Settings.Default, (bool)jObject[property.Name]);
                        else if (property.PropertyType == typeof(int))
                            property.SetValue(Properties.Settings.Default, (int)jObject[property.Name]);
                    }
                }

                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving settings to JSON: " + ex.Message);
            }
        }
    }
}