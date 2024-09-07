using DependencyInjection;
using GameTemplate.Scripts.MainMenu.Settings.ScriptObjects;

namespace GameTemplate.Scripts.MainMenu.Settings.Services
{
    public class SettingSaveService
    {

        [Inject] private GameSettings _settings;
        [Inject] private GameSettingsBuffer _settingsBuffer;

        public void Save()
        {

            _settings.sound = _settingsBuffer.sound;
            _settings.music = _settingsBuffer.music;

        }

    }
}