using GenericSingleton;
using UnityEngine.SceneManagement;

namespace GameTemplate.Scripts
{
    public class SceneTransition:BasicSingleton<SceneTransition>
    {
        
        public void LoadScene(int i)
        {

            SceneManager.LoadScene(i);
        }
        
    }
}