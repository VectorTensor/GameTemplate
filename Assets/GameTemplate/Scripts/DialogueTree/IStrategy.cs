namespace GameTemplate.Scripts.DialogueTree
{
    public interface IStrategy
    {
        Node.Status Process();

        void Reset()
        {
        }

    }
    
    
}