using System;
using UnityEngine;

namespace GameTemplate.Scripts.DialogueTree
{
    public class Sequence: Node
    {
        private Action _onCompleted;
        private Action _onFailed;
        public Sequence(string name = "Sequence"): base(name){}  
        
        public override void Process(Action onCompleted = null, Action onFailed = null)
        {
            _onCompleted = onCompleted;
            _onFailed = onFailed;

            // Status status = Status.Failed;
            //
            // foreach (var child in children)
            // {
            //
            //     status = child.Process();
            //     if (status == Status.Failed)
            //     {
            //         return Status.Failed;
            //     }
            //     
            //
            // }
            //
            //
            // return status;
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
                Debug.Log("Sequence action failed ");
                _onFailed?.Invoke();
                
            }
                
                );

        }
        
        
        

    }
}