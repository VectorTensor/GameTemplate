using GameTemplate.Scripts.MainMenu.Interfaces;
using SaveAndLoad;
using UnityEngine;

namespace GameTemplate.Scripts.MainMenu.SaveMenu
{
    public class LoadView :IGameActionView 
    {

        [SerializeField] private SaveItemView saveItemPrefab;
        [SerializeField] private Transform container;

        public void Open(GameData data)
        {
            InitializeSaveLists(data);
            gameObject.SetActive(true);
        }

        public void Close()
        {
            
            gameObject.SetActive(false);
            
        }

        private void InitializeSaveLists(GameData data)
        {

            var saves = data.saves;

            foreach (var save in saves)
            {
                var item = Instantiate(saveItemPrefab, container); 
                item.Init(save.name, save.value);
                
            }

        }
        
        
        
    }
}