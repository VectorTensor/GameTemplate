﻿using System;

namespace GameTemplate.Scripts.DialogueTree
{
    public class Selector : Node
    {

        public Selector(string name) : base(name)
        {
        }

        public override Status Process(Action onCompleted = null)
        {

            foreach (var child in children)
            {
                
                var status = child.Process();
                if (status == Status.Done)
                {
                    
                    return status;
                    
                }
                
            }

            return Status.Failed;

        }

    }
}