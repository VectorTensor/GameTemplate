using System;
using System.Collections.Generic;
using GameTemplate.Scripts.DialogueTree.Models;
using GameTemplate.Scripts.DialogueTree.Strategies;
using Unity.VisualScripting;
using UnityEditorInternal;

namespace GameTemplate.Scripts.DialogueTree.Services
{
    public class HybridNodeService
    {
        private static HybridNodeService _instance;
        
        public static HybridNodeService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new HybridNodeService();
            }
            return _instance;
        }

        /// <summary>
        /// This function returns a Di-Node
        /// Di-Node is dialogue node which shows the dialogue when the condition is satisfied. It a sequence node with two child nodes.
        /// </summary>
        /// <param name="name"> Name of the node</param>
        /// <param name="dialogue">Dialogue you want to show </param>
        /// <param name="condition">Func for the condition</param>
        /// <returns></returns>
        public Sequence GetDi_Node(string name, DialogueDto dialogue, Func<bool> condition)
        {
            
            Sequence seq = new Sequence(name);
            seq.AddChild(new Leaf(name + " condition", new ConditionStrategy(condition)));
            seq.AddChild(new Leaf(name+" Dialogue" , new DialogueStrategy(dialogue)));
            return seq; 
            
        }
        /// <summary>
        /// Function for getting BotChoiceNode
        /// </summary>
        /// <param name="name">Name of the node</param>
        /// <param name="sequences">List of Di-Node </param>
        /// <returns></returns>
        public Selector GetBotChoiceNode(string name , List<Sequence> sequences)
        {

            Selector sel = new Selector(name);
            foreach (var seq in sequences)
            {
                sel.AddChild(seq);
            }

            return sel;

        }

        public Leaf GetUnConditionalNode(string name, DialogueDto dialogue)
        {
            
            return new Leaf(name, new DialogueStrategy(dialogue));
            
        }
        
        
        
    }
}