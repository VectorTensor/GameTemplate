namespace GameTemplate.Scripts.MainMenu.Interfaces
{
    public abstract class ButtonActionController
    {
        protected IGameActionModel _model;
        protected IGameActionView _view;
        
        

        public abstract void PerformRequiredAction();
        




    }
}