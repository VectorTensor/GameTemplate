using GameTemplate.Scripts.MainMenu.Interfaces;
using UnityEngine;

namespace GameTemplate.Scripts.MainMenu.Settings.ScriptObjects
{
    [CreateAssetMenu(fileName = "GameSettings", menuName = "Settings/GameSettings", order = 0)]
    public class GameSettings : ScriptableObject,IGameActionModel
    {

        public bool music;
        public bool sound;

    }

    public class GameSettingsBuffer
    {
        public bool music;
        public bool sound;
    }
}