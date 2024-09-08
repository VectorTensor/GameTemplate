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
        [SerializeField] private Button backButton;

        [SerializeField] private List<CustomToggle> customToggles;
        [SerializeField] private GameObject settingsPanel;
        
        public event Action OnSaveClicked;

        public event Action OnBackClicked;
        private void Awake()
        {
            saveButton.onClick.AddListener(() =>
            {
                OnSaveClicked?.Invoke();
            });

            backButton.onClick.AddListener(() =>
            {
                
                OnBackClicked?.Invoke();
                Close();

            });
            foreach (var customToggle in customToggles)
            {
                customToggle.onToggleClicked += ToggleHandle;
            }
        }

        public void Open()
        {
            
            gameObject.SetActive(true);
        }

        public void Close()
        {
            
            gameObject.SetActive(false);
            
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