using System;
using System.Collections.Generic;
using SaveAndLoad;
using UnityEngine;

namespace DefaultNamespace
{
    public class TestFile : MonoBehaviour
    {
        private void Start()
        {
            Save();
            
        }

        private void Save()
        {
            FileDataService fileDataService = new FileDataService(new JsonSerializer());
            GameData gd = new GameData();
            gd.saves = new List<SingleData>();
            gd.saves.Add(new SingleData() {name = "test", value = 1});
            gd.saves.Add(new SingleData() {name = "test2", value = 2});
            gd.saves.Add(new SingleData() {name = "test3", value = 3});
            fileDataService.Save(gd);
            
        }

        private void Load()
        {
            
            FileDataService fileDataService = new FileDataService(new JsonSerializer());
                
            var x = fileDataService.Load("GameSave"); 
            
        }
    }
}