﻿using System;

namespace GameTemplate.Scripts.DialogueTree.Strategies
{
    public class ConditionStrategy:IStrategy
    {
        readonly Func<bool> _condition;
        

        public ConditionStrategy(Func<bool> condition)
        {
            _condition = condition;
        }
        
        public Node.Status Process(Action onCompleted = null) => _condition()?Node.Status.Done:Node.Status.Failed;

    }
}