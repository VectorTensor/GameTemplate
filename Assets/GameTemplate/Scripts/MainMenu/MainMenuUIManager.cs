using System;
using GameTemplate.Scripts.MainMenu.GameStart;
using UnityEngine;

namespace GameTemplate.Scripts.MainMenu
{
    public class MainMenuUIManager:MonoBehaviour
    {

        [SerializeField] private GameStartView gameStartView;
        private GameStartController _gameStartController;

        public void Awake()
        {
            
            _gameStartController = new GameStartController.Builder().WithViews(gameStartView).Build();
            
            
        }
    }
}