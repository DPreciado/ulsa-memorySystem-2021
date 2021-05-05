using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;

namespace MyLibs.MemorySystem
{
    public class MemorySystem
    {
        static string gameName = "GameHealth";
        static string dataExtension = ".data";
        static string mainPath => Path.Combine(Application.persistentDataPath, gameName + dataExtension);
        
        public static void NewGame(int health)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Create(mainPath);
            bf.Serialize(file, health);
            file.Close();
            Debug.Log("game saved at: " + mainPath);
        }
    }

}

