using System;
using System.Collections.Generic;
using GameTemplate.Scripts.MainMenu.Interfaces;
using GameTemplate.Scripts.MainMenu.Settings.Services;
using GameTemplate.Scripts.ReuseableViews;
using UnityEngine;

namespace GameTemplate.Scripts.MainMenu.Settings
{
    public class SettingsView:IGameActionView
    {
        
        public event Action<ToggleTypeSettings, bool> OnToggleClicked;

        [SerializeField] private CustomToggle customToggle;
        [SerializeField] private List<ToggleAction> toggleAction;

        private void Awake()
        {
            customToggle.onToggleClicked += ToggleHandle;
            
            
            
        }

        private void ToggleHandle(ToggleTypeSettings type, bool value)
        {
            
            OnToggleClicked?.Invoke(type, value);
            
        }

        private void OnDestroy()
        {

            customToggle.onToggleClicked -= ToggleHandle;

        }
    }
}