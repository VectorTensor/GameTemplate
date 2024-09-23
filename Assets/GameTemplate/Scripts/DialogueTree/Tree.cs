using UnityEngine;

namespace GameTemplate.Scripts.DialogueTree
{
    public class Tree:Node
    {
        public Tree(string name): base(name){}

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