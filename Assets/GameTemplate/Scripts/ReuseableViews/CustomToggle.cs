using System;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;

namespace GameTemplate.Scripts.ReuseableViews
{
    public class CustomToggle : MonoBehaviour
    {
        
        private ToggleType _toggleType;

        [SerializeField] private GameObject toggleOn;

        [SerializeField] private GameObject toggleOff;

        private void Start()
        {
            toggleOn.GetComponent<Button>().onClick.AddListener(toggleOnHandle);
            
            toggleOff.GetComponent<Button>().onClick.AddListener(toggleOffHandle);
        }

        private void toggleOnHandle()
        {
            SetToggleType(ToggleType.Off);
            onToggleClicked?.Invoke(false);
            
        }

        private void toggleOffHandle()
        {
            
            SetToggleType(ToggleType.On);
            onToggleClicked?.Invoke(false);
        }
        public event Action<bool> onToggleClicked;
        
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