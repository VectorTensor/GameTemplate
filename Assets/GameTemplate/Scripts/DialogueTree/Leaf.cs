using System;

namespace GameTemplate.Scripts.DialogueTree
{
    public class Leaf:Node
    {
        private readonly IStrategy _strategy;

        public Leaf(string name, IStrategy strategy) : base(name)
        {

            this._strategy = strategy;

        }
        
        public override void Process(Action onCompleted = null, Action onFailed = null) => this._strategy.Process();
        
        public override void Reset() => this._strategy.Reset();



    }
}