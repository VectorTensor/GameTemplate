using System;
using GameTemplate.Scripts.MainMenu.Interfaces;
using GameTemplate.Scripts.MainMenu.Settings.ScriptObjects;
using GameTemplate.Scripts.MainMenu.Settings.Services;
using Debug = UnityEngine.Debug;

namespace GameTemplate.Scripts.MainMenu.Settings
{
    public class SettingsController : ButtonActionController
    {
        private SettingsView _view;
        private GameSettings _gameSettings;
        private GameSettingsBuffer _settingsBuffer;
        private SettingSaveService _saveService;
        public override void PerformRequiredAction()
        {
            _view.Open();
            
            
            //TODO: add logic to start game
            Debug.Log($"Settings opened");
            
        }

        private void ToggleValueChanged(ToggleTypeSettings type ,bool value)
        {
            Debug.Log($"Toggle {value}");
            UpdateBufferAccordingToChange(type, value);
            
            _view.SetToggleOfType(type, value);

        }

        private void UpdateBufferAccordingToChange(ToggleTypeSettings type, bool value)
        {
            switch (type)
            {
                case ToggleTypeSettings.Music:
                    _settingsBuffer.music = value;
                    break;
                case ToggleTypeSettings.Sound:
                    _settingsBuffer.sound = value;
                    break;

                default:
                    throw new Exception($"{type} not supported"); 
            }
        }

        private void SaveSettings()
        {
            
            _saveService.Save();
            
            
        }
        

        public void InitializeSettings()
        {
            
            _view.SetToggleOfType(ToggleTypeSettings.Sound, _gameSettings.sound); 
            _view.SetToggleOfType(ToggleTypeSettings.Music, _gameSettings.music); 
            _settingsBuffer.music = _gameSettings.music;
            _settingsBuffer.sound = _gameSettings.sound;
        }


        private SettingsController()
        {
            

        }

        private void InitializeActions()
        {
            _view.OnToggleClicked += ToggleValueChanged;
            _view.OnSaveClicked +=  SaveSettings;
        }

        ~SettingsController()
        {
            
            _view.OnToggleClicked -= ToggleValueChanged;
            
            _view.OnSaveClicked -=  SaveSettings;
            
        }
        
        #region Builder

        public class Builder : GenericBuilder<SettingsController>
        {
            private GameSettingsBuffer _gameSettingsBuffer;
            private SettingSaveService _saveService;

            public Builder WithBuffer(GameSettingsBuffer b)
            {
                _gameSettingsBuffer = b;

                return this;
            }

            public Builder WithService(SettingSaveService s)
            {

                _saveService = s;
                return this;

            }
            public override SettingsController Build()
            {
                var s = new SettingsController
                {

                    _view = (SettingsView)this._view,
                    _gameSettings = (GameSettings) this._model,
                    _settingsBuffer = _gameSettingsBuffer ,
                    _saveService = this._saveService
                };
                s.InitializeActions();

                return s;
            }
        }
        #endregion
    }
}