using System;
using GameTemplate.Scripts.DialogueTree;
using GameTemplate.Scripts.DialogueTree.Strategies;
using UnityEngine;

namespace DefaultNamespace.DialougeTest
{
    public class TestDIag:MonoBehaviour
    {
        public bool st;
        public void Start()
        {
            
            DiagTree tree = new DiagTree("test");
            tree.AddChild(new Leaf("hello", new DialogueStrategy("hello")));
            var seq = new Sequence("seq");
            seq.AddChild(new Leaf("",new ConditionStrategy(()=> st)));
            seq.AddChild(new Leaf("",new DialogueStrategy("bye")));
            tree.AddChild(seq);
            tree.Process();


        }
    }
}