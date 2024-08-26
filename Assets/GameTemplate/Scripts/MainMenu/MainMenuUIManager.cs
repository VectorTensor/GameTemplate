using System;
using GameTemplate.Scripts.MainMenu.GameStart;
using GameTemplate.Scripts.MainMenu.Settings;
using UnityEngine;
using UnityEngine.UI;

namespace GameTemplate.Scripts.MainMenu
{
    public class MainMenuUIManager:MonoBehaviour
    {

        [SerializeField] private GameStartView gameStartView;
        private GameStartController _gameStartController;
        private SettingsController _settingsController;
        [SerializeField] private Button playButton;
        [SerializeField] private Button settingsButton;

        public void Awake()
        {
            
            _gameStartController = new GameStartController.Builder().WithViews(gameStartView).Build();
            playButton.onClick.AddListener(_gameStartController.PerformRequiredAction);
            _settingsController = new SettingsController.Builder().Build();
            settingsButton.onClick.AddListener(_settingsController.PerformRequiredAction);
            
            
            
        }
    }
}