using System;

namespace GameTemplate.Scripts.DialogueTree
{
    public class Selector : Node
    {

        public Selector(string name) : base(name)
        {
        }

        public override void Process(Action onCompleted = null, Action onFailed = null)
        {

            // foreach (var child in children)
            // {
            //     
            //     var status = child.Process();
            //     if (status == Status.Done)
            //     {
            //         
            //         return status;
            //         
            //     }
            //     
            // }
            //
            // return Status.Failed;

        }

    }
}