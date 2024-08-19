using System;
using UnityEngine;

namespace GameTemplate.Scripts
{
    public class DontDestroy:MonoBehaviour
    {
        private void Start()
        {
            
            DontDestroyOnLoad(gameObject);
            
        }
    }
}