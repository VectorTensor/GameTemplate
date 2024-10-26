using System.Collections.Generic;
using GameTemplate.Scripts.DialogueTree.Models;
using UnityEngine;

namespace GameTemplate.Scripts.DialogueTree.Views
{
    public class ChoiceView : MonoBehaviour
    {
        [SerializeField] private ChoiceItemView choiceItemPrefab;
        [SerializeField] private GameObject choiceItemContainer;

        public void ShowChoice(List<ChoiceDto> choices)
        {

            foreach (var choice in choices)
            {
                var item  =  Instantiate(choiceItemPrefab, choiceItemContainer.transform);
                item.SetText(choice);
            }
            
        }
        
    }
}