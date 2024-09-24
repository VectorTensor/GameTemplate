using System;

namespace GameTemplate.Scripts.DialogueTree
{
    public interface IStrategy
    {
        Node.Status Process(Action onCompleted = null);

        void Reset()
        {
        }

    }
    
    
}