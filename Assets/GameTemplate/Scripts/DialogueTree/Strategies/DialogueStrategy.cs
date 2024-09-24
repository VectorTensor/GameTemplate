using System;
using UnityEngine;

namespace GameTemplate.Scripts.DialogueTree.Strategies
{
    public class DialogueStrategy: IStrategy
    {
        private string _dialogue;
        public DialogueStrategy(string dialogue)
        {
            
            _dialogue = dialogue;
            
        }
        public void Process(Action onCompleted = null, Action onFailed = null)
        {
            Debug.Log(_dialogue);
            onCompleted?.Invoke();
            return ;
        }

        public void Reset()
        {
            _dialogue = "";
        }
    }
}