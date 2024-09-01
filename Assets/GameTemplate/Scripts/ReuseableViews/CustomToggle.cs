using System;
using GameTemplate.Scripts.MainMenu.Settings.Services;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;

namespace GameTemplate.Scripts.ReuseableViews
{
    public class CustomToggle : MonoBehaviour
    {
        [SerializeField] private ToggleTypeSettings settingType;
        
        private ToggleType _toggleType;

        [SerializeField] private GameObject toggleOn;

        [SerializeField] private GameObject toggleOff;
        
        public event Action<ToggleTypeSettings, bool> onToggleClicked;

        private void Start()
        {
            toggleOn.GetComponent<Button>().onClick.AddListener(toggleOnHandle);
            
            toggleOff.GetComponent<Button>().onClick.AddListener(toggleOffHandle);
        }

        private void toggleOnHandle()
        {
            SetToggleType(ToggleType.Off);
            onToggleClicked?.Invoke(settingType,false);
            
        }

        private void toggleOffHandle()
        {
            
            SetToggleType(ToggleType.On);
            onToggleClicked?.Invoke(settingType,true);
        }
        
        public void SetToggleType(ToggleType toggleType)
        {
            
            _toggleType = toggleType;
            SetRequiredImage(toggleType);
            
            
        }

        private void SetRequiredImage(ToggleType toggleType)
        {
            
            if (toggleType == ToggleType.On)
            {
                
                toggleOn.SetActive(true);
                toggleOff.SetActive(false);
                
            }
            else
            {
                toggleOn.SetActive(false);
                toggleOff.SetActive(true);
                
            }
            
        }
        
        
        
        
    }
    public enum ToggleType
    {
        On,
        Off
    }
    
}