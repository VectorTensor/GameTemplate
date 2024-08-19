namespace GameTemplate.Scripts.MainMenu.Interfaces
{
    public abstract class GenericBuilder<T>
    {
        
            protected IGameActionModel _model;
            protected IGameActionView _view;

            public GenericBuilder<T> WithViews(IGameActionView v)
            {
                _view = v;

                return this;    

            }
            
            public GenericBuilder<T> WithModel(IGameActionModel m)
            {
                _model = m;
                return this;
            
            }

            public abstract T Build();


    }
}