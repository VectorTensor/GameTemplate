using GameTemplate.Scripts.MainMenu.Interfaces;
using GameTemplate.Scripts.MainMenu.Settings.Services;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace GameTemplate.Scripts.MainMenu.Settings
{
    public class SettingsController : ButtonActionController
    {
        private SettingsView _view;
        
        public override void PerformRequiredAction()
        {
            
            //TODO: add logic to start game
            Debug.Log($"Settings opened");
            
        }

        private void ToggleValueChanged(ToggleTypeSettings type ,bool value)
        {
            Debug.Log($"Toggle {value}");
            
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

                    _view = (SettingsView)this._view
                };
                s.InitializeActions();

                return s;
            }
        }
        #endregion
    }
}