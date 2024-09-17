using GameTemplate.Scripts.MainMenu.Interfaces;
using SaveAndLoad;
using UnityEngine;

namespace GameTemplate.Scripts.MainMenu.SaveMenu
{
    public class SaveController: ButtonActionController
    {
        private LoadView _view;
        private GameData _model;
        public override void PerformRequiredAction()
        {
            
            _view.Open(_model);
            
        }

        #region Builder
        public class Builder : GenericBuilder<SaveController>
        {
            private new GameData _model;
            public override SaveController Build()
            {

                var sc = new SaveController();
                sc._view =(LoadView) _view;
                sc._model = this._model;
                return sc;

            }

            public Builder WithModel(GameData model)
            {
                
                _model = model;
                return this;
                
            }
        }
        #endregion
    }
}