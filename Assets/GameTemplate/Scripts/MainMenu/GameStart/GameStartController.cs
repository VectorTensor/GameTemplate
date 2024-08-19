using GameTemplate.Scripts.MainMenu.Interfaces;
using UnityEditor;

namespace GameTemplate.Scripts.MainMenu.GameStart
{
    public class GameStartController:ButtonActionController
    {
        public override void PerformRequiredAction()
        {
            
            SceneTransition.Instance.LoadScene(1);
            
        }

        public class Builder : GenericBuilder<GameStartController>
        {

            public override GameStartController Build()
            {
                
                return new GameStartController
                {
                    _model = this._model,
                    _view = this._view 
                };
                
            }

        } 
    }
}