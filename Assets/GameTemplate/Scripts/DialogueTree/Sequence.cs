namespace GameTemplate.Scripts.DialogueTree
{
    public class Sequence: Node
    {
        public Sequence(string name = "Sequence"): base(name){}  
        
        public override Status Process()
        {

            Status status = Status.Failed;

            foreach (var child in children)
            {

                status = child.Process();
                

            }


            return status;


        }
        
        

    }
}