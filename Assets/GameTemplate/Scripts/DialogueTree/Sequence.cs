using System;

namespace GameTemplate.Scripts.DialogueTree
{
    public class Sequence: Node
    {
        public Sequence(string name = "Sequence"): base(name){}  
        
        public override Status Process(Action onCompleted = null)
        {

            Status status = Status.Failed;

            foreach (var child in children)
            {

                status = child.Process();
                if (status == Status.Failed)
                {
                    return Status.Failed;
                }
                

            }


            return status;


        }
        
        

    }
}