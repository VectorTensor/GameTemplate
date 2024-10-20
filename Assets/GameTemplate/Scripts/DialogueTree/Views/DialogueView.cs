using System;
using GameTemplate.Scripts.DialogueTree.Models;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GameTemplate.Scripts.DialogueTree.Views
{
    public class DialogueView : MonoBehaviour
    {
        
        [SerializeField] private TMP_Text dialogueText;
        
        [SerializeField] private TMP_Text nameText;
        
        [SerializeField] private Button nextButton;

        public event Action nextButtonPressed;
        

        public void SetDialogue(DialogueDto dialogue)
        {
            dialogueText.text = dialogue.dialogue;
            nameText.text = dialogue.name;
            nextButton.onClick.AddListener(NextButtonHandler);
        }

        public void NextButtonHandler()
        {
            
            nextButton.onClick.RemoveListener(NextButtonHandler);
            nextButtonPressed?.Invoke();
            
        }
        
    }
}