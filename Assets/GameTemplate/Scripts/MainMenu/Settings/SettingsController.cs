using System.Diagnostics;
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
            public override SettingsController Build()
            {
                var s = new SettingsController
                {

                    _view = (SettingsView)this._view,
                    _gameSettings = (GameSettings) this._model
                };
                s.InitializeActions();

                return s;
            }
        }
        #endregion
    }
}