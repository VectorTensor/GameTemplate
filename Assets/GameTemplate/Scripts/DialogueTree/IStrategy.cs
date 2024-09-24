using System;

namespace GameTemplate.Scripts.DialogueTree
{
    public interface IStrategy
    {
        void Process(Action onCompleted = null, Action onFailed = null);

        void Reset()
        {
        }

    }
    
    
}