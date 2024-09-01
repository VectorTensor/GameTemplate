using UnityEngine;

namespace GameTemplate.Scripts.MainMenu.Settings.ScriptObjects
{
    [CreateAssetMenu(fileName = "GameSettings", menuName = "Settings/GameSettings", order = 0)]
    public class GameSettings : ScriptableObject
    {

        public bool music;
        public bool sound;

    }
}