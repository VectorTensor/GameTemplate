using System;
using UnityEngine;
using UnityEngine.UI;

namespace GameTemplate.Scripts.ReuseableViews
{
    public class CustomToggle : MonoBehaviour
    {
        
        private ToggleType _toggleType;

        [SerializeField] private GameObject toggleOn;

        [SerializeField] private GameObject toggleOff;
        public void SetToggleType(ToggleType toggleType)
        {
            
            _toggleType = toggleType;
            
            
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