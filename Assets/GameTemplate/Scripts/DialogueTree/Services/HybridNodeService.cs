using System;
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
        public Sequence GetDi_Node(string name, string dialogue, Func<bool> condition)
        {

            Sequence seq = new Sequence(name);
            seq.AddChild(new Leaf(name + " condition", new ConditionStrategy(condition)));
            seq.AddChild(new Leaf(name+" Dialogue" , new DialogueStrategy(dialogue)));

            return seq; 

        }
        
        
        
    }
}