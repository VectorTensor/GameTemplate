using System;
using GameTemplate.Scripts.DialogueTree.Models;
using GameTemplate.Scripts.DialogueTree.Views;
using GenericSingleton;
using UnityEngine;

namespace GameTemplate.Scripts.DialogueTree
{
    public class DialogueController: BasicSingleton<DialogueController> 
    {
        
        [SerializeField] private DialogueView dialogueView;
        Action _onCompleted;
        private bool _waitForDialogueCompletion = false;

        public void SetDialogue(DialogueDto dialogue, Action onCompleted)
        {
            _waitForDialogueCompletion = true;
            _onCompleted = onCompleted;
            dialogueView.nextButtonPressed += DialogueCompleted;
            dialogueView.SetDialogue(dialogue);
            
        }

        public void DialogueCompleted()
        {
            
            dialogueView.nextButtonPressed -= DialogueCompleted;
            if (_waitForDialogueCompletion)
            {
                
                _waitForDialogueCompletion = false;
                _onCompleted?.Invoke();
                
            }




        }
        
    }
}