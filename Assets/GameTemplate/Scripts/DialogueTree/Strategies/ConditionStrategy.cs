using System;

namespace GameTemplate.Scripts.DialogueTree.Strategies
{
    public class ConditionStrategy:IStrategy
    {
        readonly Func<bool> _condition;
        

        public ConditionStrategy(Func<bool> condition)
        {
            _condition = condition;
        }

        public void Process(Action onCompleted = null, Action onFailed = null)
        {
            
            var inv = _condition()?onCompleted:onFailed;
            inv?.Invoke();
        }

    }
}