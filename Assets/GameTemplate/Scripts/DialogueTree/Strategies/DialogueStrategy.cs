using System;
using GameTemplate.Scripts.DialogueTree.Models;
using UnityEngine;

namespace GameTemplate.Scripts.DialogueTree.Strategies
{
    public class DialogueStrategy: IStrategy
    {
        private DialogueDto _dialogue;
        public DialogueStrategy(DialogueDto dialogue)
        {
            
            _dialogue = dialogue;
            
        }
        public void Process(Action onCompleted = null, Action onFailed = null)
        {
            Debug.Log(_dialogue.dialogue);
            onCompleted?.Invoke();
        }

        // public void Reset() {
        //     _dialogue = "";
        // }
    }
}