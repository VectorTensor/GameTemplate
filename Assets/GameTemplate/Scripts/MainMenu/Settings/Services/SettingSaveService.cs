using DependencyInjection;
using GameTemplate.Scripts.MainMenu.Settings.ScriptObjects;
using UnityEngine;

namespace GameTemplate.Scripts.MainMenu.Settings.Services
{
    public class SettingSaveService:MonoBehaviour
    {

        [Inject] private GameSettings _settings;
        [Inject] private GameSettingsBuffer _settingsBuffer;

        public void Save()
        {

            Debug.Log($"Settings saved!!!");
            _settings.sound = _settingsBuffer.sound;
            _settings.music = _settingsBuffer.music;

        }

    }
}