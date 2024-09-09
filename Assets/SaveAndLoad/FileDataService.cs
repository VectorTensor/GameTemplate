using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace SaveAndLoad
{
    public class FileDataService:IDataService
    {
        private ISerializer serializer;
        private string dataPath;
        private string fileExtension;


        public FileDataService(ISerializer serializer)
        {
            
            this.dataPath = Application.persistentDataPath;
            this.fileExtension = "json";
            this.serializer = serializer;
            
        }
        
        string GetPathToFile(string filename)
        {

            return Path.Combine(dataPath, string.Concat(filename, ".", fileExtension));

        }
        public void Save(GameData data, bool overwrite = true)
        {

            string json = serializer.Serialize<GameData>(data);

            string path = GetPathToFile("GameSave");

            if (File.Exists(path) && !overwrite)
            {
                return;
            }
            else
            {
                File.WriteAllText(path, json);
                
            }

        }


        public GameData Load(string name)
        {
            
            string path = GetPathToFile(name);
            var data = File.ReadAllText(path);

            return serializer.Deserialize<GameData>(data);
            
        }

        public void Delete(string name)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteAll()
        {
            string path = GetPathToFile("GameSave");
            File.Delete(path);
        }

        public IEnumerable<string> ListSaves()
        {
            throw new System.NotImplementedException();
        }
    }
}