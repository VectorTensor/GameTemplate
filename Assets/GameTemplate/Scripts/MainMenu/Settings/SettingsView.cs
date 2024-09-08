using System;
using System.Collections.Generic;
using GameTemplate.Scripts.MainMenu.Interfaces;
using GameTemplate.Scripts.MainMenu.Settings.Services;
using GameTemplate.Scripts.ReuseableViews;
using UnityEngine;
using UnityEngine.UI;

namespace GameTemplate.Scripts.MainMenu.Settings
{
    public class SettingsView:IGameActionView
    {
        
        public event Action<ToggleTypeSettings, bool> OnToggleClicked;
        [SerializeField] private Button saveButton;

        [SerializeField] private List<CustomToggle> customToggles;
        
        public event Action OnSaveClicked;

        private void Awake()
        {
            saveButton.onClick.AddListener(() =>
            {
                OnSaveClicked?.Invoke();
            });
            foreach (var customToggle in customToggles)
            {
                customToggle.onToggleClicked += ToggleHandle;
            }
        }


        public void SetToggleOfType(ToggleTypeSettings t, bool toggle)
        {
            
            foreach (var customToggle in customToggles)
            {
                if (customToggle.GetSettingType()== t)
                {
                    customToggle.SetToggleType(toggle ? ToggleType.On : ToggleType.Off);
                }
            }
            
        }

        private void ToggleHandle(ToggleTypeSettings type, bool value)
        {
            
            OnToggleClicked?.Invoke(type, value);
            
        }

        private void OnDestroy()
        {

            foreach (var customToggle in customToggles)
            {
                customToggle.onToggleClicked -= ToggleHandle;
            }

        }
    }
}