using System;
using GameTemplate.Scripts.MainMenu.Interfaces;
using GameTemplate.Scripts.ReuseableViews;
using UnityEngine;

namespace GameTemplate.Scripts.MainMenu.Settings
{
    public class SettingsView:IGameActionView
    {
        
        public event Action<bool> OnToggleClicked;

        [SerializeField] private CustomToggle customToggle;

        private void Awake()
        {
            customToggle.onToggleClicked += ToggleHandle;
            
            
            
        }

        private void ToggleHandle(bool value)
        {
            
            OnToggleClicked?.Invoke(value);
            
        }

        private void OnDestroy()
        {

            customToggle.onToggleClicked -= ToggleHandle;

        }
    }
}