using System;
using GameTemplate.Scripts.DialogueTree;
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
            
            
            var root = new Selector("root");
            var seq1 = new Sequence("seq1");
            seq1.AddChild(new Leaf("",new ConditionStrategy(()=> st)));
            seq1.AddChild(new Leaf("",new DialogueStrategy("hi")));
            
            var seq2= new Sequence("seq2");
            seq2.AddChild(new Leaf("",new ConditionStrategy(()=> nt)));
            seq2.AddChild(new Leaf("",new DialogueStrategy("bye")));
            root.AddChild(seq1);
            root.AddChild(seq2);
            root.Process();


        }
    }
}