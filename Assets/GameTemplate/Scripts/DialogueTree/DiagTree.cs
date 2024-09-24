using System;
using UnityEngine;

namespace GameTemplate.Scripts.DialogueTree
{
    /// <summary>
    /// Diag Tree run all its nodes regardless if any of them fail.
    /// </summary>
    public class DiagTree:Node
    {
        private Action _onCompleted;
        public DiagTree(string name): base(name){}

        public override void Process(Action onCompleted = null, Action onFailed = null)
        {
            _onCompleted = onCompleted;

            RecursiveProcess();

        }
        
        private void RecursiveProcess()
        {
            
            if (currentChild > children.Count - 1)
            {
                _onCompleted?.Invoke();
                return;
                
            }
            children[currentChild].Process(() =>
            {
                currentChild++;
                RecursiveProcess();
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