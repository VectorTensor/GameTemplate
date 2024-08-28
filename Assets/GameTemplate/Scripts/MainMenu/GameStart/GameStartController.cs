using GameTemplate.Scripts.MainMenu.Interfaces;
using UnityEditor;
using UnityEngine;

namespace GameTemplate.Scripts.MainMenu.GameStart
{
    public class GameStartController:ButtonActionController
    {
        private GameStartView _view;
        public override void PerformRequiredAction()
        {
            
            //TODO: add logic to start game
            Debug.Log($"Game started");
            // SceneTransition.Instance.LoadScene(1);
            
        }

        #region Builder

        

        public class Builder : GenericBuilder<GameStartController>
        {

            public override GameStartController Build()
            {
                
                
                return new GameStartController
                {
                    _view = (GameStartView) this._view 
                    
                    
                };
                
            }

        } 
        
        #endregion
    }
}