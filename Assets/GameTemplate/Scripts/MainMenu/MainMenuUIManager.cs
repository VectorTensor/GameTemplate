using System;
using DependencyInjection;
using GameTemplate.Scripts.MainMenu.GameStart;
using GameTemplate.Scripts.MainMenu.SaveMenu;
using GameTemplate.Scripts.MainMenu.Settings;
using GameTemplate.Scripts.MainMenu.Settings.ScriptObjects;
using GameTemplate.Scripts.MainMenu.Settings.Services;
using SaveAndLoad;
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
        [SerializeField] private SettingSaveService saveService;
        [SerializeField] private Button loadButton;
        [SerializeField] private LoadView loadView;
        private SaveController _saveController;
        
        private GameSettingsBuffer gbf;
        

        public void Awake()
        {
            
            _gameStartController = new GameStartController.Builder().WithViews(gameStartView).Build();
            playButton.onClick.AddListener(_gameStartController.PerformRequiredAction);
            _settingsController = new SettingsController.Builder()
                .WithService(saveService)
                .WithBuffer(gbf)
                .WithViews(settingsView)
                .WithModel(gameSettings)
                .Build();
            settingsButton.onClick.AddListener(_settingsController.PerformRequiredAction);
            _settingsController.InitializeSettings();
            FileDataService fileDataService = new FileDataService(new JsonSerializer());
            var saveData = fileDataService.Load("GameSave"); 
            
            _saveController = new SaveController.Builder()
                .WithModel(saveData)
                .WithViews(loadView)
                .Build();
            loadButton.onClick.AddListener(_saveController.PerformRequiredAction);
            
            
            
        }

        [Provide]
        public GameSettingsBuffer ProvideBuffer()
        {
            gbf = new GameSettingsBuffer();
            return gbf;
        }

        [Provide]
        public GameSettings ProvideGameSettings()
        {
            return gameSettings;
        } 
        
       
    }
}