using System;
using UnityEngine.Events;

namespace GameTemplate.Scripts.MainMenu.Settings.Services
{
    public enum ToggleTypeSettings
    {
        
        Music,
        Sound
        
        
    }
    [Serializable]
    public struct ToggleAction
    {

        public ToggleTypeSettings setting;
        public UnityEvent<bool> onToggleClicked;

    }
}