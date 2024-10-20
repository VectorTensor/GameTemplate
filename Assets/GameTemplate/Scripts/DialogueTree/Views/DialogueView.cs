using GameTemplate.Scripts.DialogueTree.Models;
using TMPro;
using UnityEngine;

namespace GameTemplate.Scripts.DialogueTree.Views
{
    public class DialogueView : MonoBehaviour
    {
        
        [SerializeField] private TMP_Text dialogueText;
        
        [SerializeField] private TMP_Text nameText;
        

        public void SetDialogue(DialogueDto dialogue)
        {
            dialogueText.text = dialogue.dialogue;
            nameText.text = dialogue.name;
        }
        
    }
}