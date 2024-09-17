using GameTemplate.Scripts.MainMenu.Interfaces;
using UnityEngine;

namespace GameTemplate.Scripts.MainMenu.SaveMenu
{
    public class SaveController: ButtonActionController
    {
        private LoadView _view;
        public override void PerformRequiredAction()
        {
            
            _view.gameObject.SetActive(true);
            
        }

        #region Builder
        public class Builder : GenericBuilder<SaveController>
        {
            public override SaveController Build()
            {

                var sc = new SaveController();
                sc._view =(LoadView) _view;
                return sc;

            }
        }
        #endregion
    }
}