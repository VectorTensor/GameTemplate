using System;
using System.Collections.Generic;

namespace GameTemplate.Scripts.DialogueTree
{
    public class Node
    {
        public enum Status{Done, Running, Failed}

        public readonly string name;

        public readonly List<Node> children = new();

        protected int currentChild;

        public Node(string name = "Node")
        {
            this.name = name;

        }

        public void AddChild(Node child) => children.Add(child);

        public virtual Status Process(Action onCompleted = null) => children[currentChild].Process();

        public virtual void Reset()
        {

            currentChild = 0;

            foreach (var child in children)
            {
                
                child.Reset();
                
            }

        }





    }
}