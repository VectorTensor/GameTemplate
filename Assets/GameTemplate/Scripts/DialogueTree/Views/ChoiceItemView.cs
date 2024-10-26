using GameTemplate.Scripts.DialogueTree.Models;
using TMPro;
using UnityEngine;

namespace GameTemplate.Scripts.DialogueTree.Views
{
    public class ChoiceItemView : MonoBehaviour
    {
        
        [SerializeField] private TMP_Text text;
        private int _id;

        public void SetText(ChoiceDto choice)
        {
            text.text = choice.text;
            _id = choice.id;
            
        }
        


    }
}