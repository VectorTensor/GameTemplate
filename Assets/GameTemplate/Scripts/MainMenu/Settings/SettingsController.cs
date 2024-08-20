using GameTemplate.Scripts.MainMenu.Interfaces;
using UnityEngine;

namespace GameTemplate.Scripts.MainMenu.Settings
{
    public class SettingsController : ButtonActionController 
    {
        public override void PerformRequiredAction()
        {
            
            //TODO: add logic to start game
            Debug.Log($"Settings opened");
            
        }
        
        #region Builder

        public class Builder : GenericBuilder<SettingsController>
        {
            public override SettingsController Build()
            {
                
                return new SettingsController
                {
                    _model = this._model,
                    _view = this._view 
                };
                
            }
        }
        #endregion
    }
}