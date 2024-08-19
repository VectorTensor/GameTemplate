using System;
using GameTemplate.Scripts.MainMenu.GameStart;
using UnityEngine;
using UnityEngine.UI;

namespace GameTemplate.Scripts.MainMenu
{
    public class MainMenuUIManager:MonoBehaviour
    {

        [SerializeField] private GameStartView gameStartView;
        private GameStartController _gameStartController;
        [SerializeField] private Button playButton;

        public void Awake()
        {
            
            _gameStartController = new GameStartController.Builder().WithViews(gameStartView).Build();
            playButton.onClick.AddListener(_gameStartController.PerformRequiredAction);
            
            
        }
    }
}