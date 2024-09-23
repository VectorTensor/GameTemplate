using UnityEngine;

namespace GameTemplate.Scripts.DialogueTree
{
    public class DiagTree:Node
    {
        public DiagTree(string name): base(name){}

        public override Status Process()
        {

            while (currentChild < children.Count)
            {

                var status = children[currentChild].Process();
                if (status != Status.Done)
                {

                    return status;

                }

                currentChild++;

            }

            return Status.Done;

        }
        
        
        
    }
}