using System;
using DependencyInjection;
using GameTemplate.Scripts.MainMenu.GameStart;
using GameTemplate.Scripts.MainMenu.Settings;
using GameTemplate.Scripts.MainMenu.Settings.ScriptObjects;
using GameTemplate.Scripts.MainMenu.Settings.Services;
using UnityEngine;
using UnityEngine.UI;

namespace GameTemplate.Scripts.MainMenu
{
    public class MainMenuUIManager:MonoBehaviour,IDependencyProvider
    {

        [SerializeField] private GameStartView gameStartView;
        private GameStartController _gameStartController;
        [SerializeField] private SettingsView settingsView;
        private SettingsController _settingsController;
        [SerializeField] private Button playButton;
        [SerializeField] private Button settingsButton;
        [SerializeField] private GameSettings gameSettings;
        private GameSettingsBuffer gbf;
        

        public void Awake()
        {
            
            _gameStartController = new GameStartController.Builder().WithViews(gameStartView).Build();
            playButton.onClick.AddListener(_gameStartController.PerformRequiredAction);
            gbf = new GameSettingsBuffer();
            _settingsController = new SettingsController.Builder()
                .WithBuffer(gbf)
                .WithViews(settingsView)
                .WithModel(gameSettings)
                .Build();
            settingsButton.onClick.AddListener(_settingsController.PerformRequiredAction);
            _settingsController.InitializeSettings();
            
        }

        [Provide]
        public GameSettingsBuffer ProvideBuffer()
        {
            return gbf;
        }

        [Provide]
        public GameSettings ProvideGameSettings()
        {
            return gameSettings;
        } 
        
        [Inject]
        public SettingSaveService ProvideSettingSaveService()
        {
            return new SettingSaveService();
        }
    }
}