namespace GameTemplate.Scripts.DialogueTree
{
    public class Sequence: Node
    {
        public Sequence(string name = "Sequence"): base(name){}  
        
        public override Status Process(){
            if (currentChild < children.Count)
            {

                switch (children[currentChild].Process())
                {
                    
                    case Status.Running:
                        return Status.Running;
                    
                    default:
                        currentChild++;
                        return currentChild == children.Count? Status.Done:Status.Running;
                        
                    
                }
                
            }

            Reset();
            return Status.Done;

        }
        
        

    }
}