using System;
using UnityEngine;

namespace GameTemplate.Scripts.DialogueTree
{
    public class Selector : Node
    {
        private Action _onCompleted;
        private Action _onFailed;
        
        public Selector(string name) : base(name)
        {
        }

        public override void Process(Action onCompleted = null, Action onFailed = null)
        {
            
            _onCompleted = onCompleted;
            _onFailed = onFailed;

            RecursiveProcess();
            


        }
         private void RecursiveProcess()
        {
            
            if (currentChild > children.Count - 1)
            {
                _onFailed?.Invoke();
                return;
                
            }
            children[currentChild].Process(() =>
            {
                _onCompleted?.Invoke(); 
            },
            () =>
            {
                currentChild++;
                RecursiveProcess();
                
            }
                
            );

        }

    }
}