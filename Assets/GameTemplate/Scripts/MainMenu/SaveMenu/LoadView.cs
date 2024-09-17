using GameTemplate.Scripts.MainMenu.Interfaces;
using UnityEngine;

namespace GameTemplate.Scripts.MainMenu.SaveMenu
{
    public class LoadView :IGameActionView 
    {


        public void Open()
        {
            gameObject.SetActive(true);
        }

        public void Close()
        {
            
            gameObject.SetActive(false);
            
        }
        
        
        
    }
}