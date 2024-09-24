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
        public Node.Status Process(Action onCompleted = null)
        {
            Debug.Log(_dialogue);
            return Node.Status.Done;
        }

        public void Reset()
        {
            _dialogue = "";
        }
    }
}