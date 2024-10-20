using System;
using System.Collections.Generic;
using GameTemplate.Scripts.DialogueTree;
using GameTemplate.Scripts.DialogueTree.Models;
using GameTemplate.Scripts.DialogueTree.Services;
using GameTemplate.Scripts.DialogueTree.Strategies;
using UnityEngine;

namespace DefaultNamespace.DialougeTest
{
    public class TestDIag:MonoBehaviour
    {
        public bool st;
        public bool nt;
        public void Start()
        {
            var root = new DiagTree("root");
            var d1 = new DialogueDto();
            d1.dialogue = "hi";
            d1.isPlayer = false;
            var d2 = new DialogueDto();
            d2.dialogue = "bye";
            d2.isPlayer = false;
            var d3 = new DialogueDto();
            d3.dialogue = "Part";
            d3.isPlayer = false;
            var d4 = new DialogueDto();
            d4.dialogue = "Nobody";
            d4.isPlayer = false;

            var seq1 = HybridNodeService.GetInstance().GetDi_Node("seq1", d1, () => st);
            var seq2 = HybridNodeService.GetInstance().GetDi_Node("seq2", d2, () => nt);
            var diag = HybridNodeService.GetInstance().GetBotChoiceNode("diag", new List<Sequence>(){seq1,seq2});                                                                                                                                                                                               
            root.AddChild(diag);
            var diag2 = HybridNodeService.GetInstance().GetUnConditionalNode("diag2", d3);
            var diag3 = HybridNodeService.GetInstance().GetUnConditionalNode("diag3", d4);
            root.AddChild(diag3);
            root.AddChild(diag2);
            root.Process();
            
                                
        }
    }
}