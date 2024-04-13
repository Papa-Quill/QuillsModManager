using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace QMM.Util
{
    public class Mod
    {
        public string ModTitle { get; set; }
        public string ModAuthor { get; set; }
        public string ModVersion { get; set; }
        public string ModDescription { get; set; }
        public string ModLocation { get; set; }
        public bool ModToggleable { get; set; }
    }

    public static class CModListManager
    {
        public const string ModListFilePath = "modlist.json";

        public static void AddNewMod(string newModTitle, string newModAuthor, string newModVersion, string newModDescription, string newModLocation, bool newModToggleable)
        {
            List<Mod> modList = LoadModList();

            modList.Add(new Mod
            {
                ModTitle = newModTitle,
                ModAuthor = newModAuthor,
                ModVersion = newModVersion,
                ModDescription = newModDescription,
                ModLocation = newModLocation,
                ModToggleable = newModToggleable
            });

            SaveModList(modList);
        }

        public static void RemoveMod(string modTitle, string modVersion)
        {
            List<Mod> modList = LoadModList();

            int indexToRemove = modList.FindIndex(mod => mod.ModTitle == modTitle && mod.ModVersion == modVersion);

            if (indexToRemove != -1)
            {
                modList.RemoveAt(indexToRemove);
                SaveModList(modList);
            }
            else
            {
                throw new ArgumentException("Mod not found.");
            }
        }

        public static void RemoveAllMods()
        {
            SaveModList(new List<Mod>());
        }

        public static List<Mod> LoadModList()
        {
            if (File.Exists(ModListFilePath))
            {
                string json = File.ReadAllText(ModListFilePath);
                return JsonConvert.DeserializeObject<List<Mod>>(json);
            }
            else
            {
                return new List<Mod>();
            }
        }

        public static void SaveModList(List<Mod> modList)
        {
            string json = JsonConvert.SerializeObject(modList, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(ModListFilePath, json);
        }

        public static void MoveModPosition(int oldIndex, int newIndex)
        {
            List<Mod> modList = LoadModList();

            if (oldIndex >= 0 && oldIndex < modList.Count && newIndex >= 0 && newIndex < modList.Count)
            {
                Mod modToMove = modList[oldIndex];
                modList.RemoveAt(oldIndex);
                modList.Insert(newIndex, modToMove);
                SaveModList(modList);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Index out of range.");
            }
        }
    }
}
