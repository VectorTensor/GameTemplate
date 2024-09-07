using System.Diagnostics;
using System.Runtime.InteropServices;
using DependencyInjection;
using GameTemplate.Scripts.MainMenu.Interfaces;
using GameTemplate.Scripts.MainMenu.Settings.ScriptObjects;
using GameTemplate.Scripts.MainMenu.Settings.Services;
using Unity.VisualScripting;
using UnityEngine.PlayerLoop;
using Debug = UnityEngine.Debug;

namespace GameTemplate.Scripts.MainMenu.Settings
{
    public class SettingsController : ButtonActionController
    {
        private SettingsView _view;
        private GameSettings _gameSettings;
        private GameSettingsBuffer _settingsBuffer;
        [Inject] private SettingSaveService _saveService;
        public override void PerformRequiredAction()
        {
            
            //TODO: add logic to start game
            Debug.Log($"Settings opened");
            
        }

        private void ToggleValueChanged(ToggleTypeSettings type ,bool value)
        {
            Debug.Log($"Toggle {value}");
            ISettingOptionService settingsOptService = type switch
            {
                ToggleTypeSettings.Music => new MusicSettingOption(),
                ToggleTypeSettings.Sound => new SoundSettingOption()
            };
            
            _view.SetToggleOfType(type, value);

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
        }

        ~SettingsController()
        {
            
            _view.OnToggleClicked -= ToggleValueChanged;
            
        }
        
        #region Builder

        public class Builder : GenericBuilder<SettingsController>
        {
            private GameSettingsBuffer _gameSettingsBuffer;

            public Builder WithBuffer(GameSettingsBuffer b)
            {
                _gameSettingsBuffer = b;

                return this;
            } 
            public override SettingsController Build()
            {
                var s = new SettingsController
                {

                    _view = (SettingsView)this._view,
                    _gameSettings = (GameSettings) this._model,
                    _settingsBuffer = _gameSettingsBuffer 
                };
                s.InitializeActions();

                return s;
            }
        }
        #endregion
    }
}