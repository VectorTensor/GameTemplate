using DependencyInjection;
using GameTemplate.Scripts.MainMenu.Settings.ScriptObjects;

namespace GameTemplate.Scripts.MainMenu.Settings.Services
{
    public class SoundSettingOption : ISettingOptionService
    {
        
        [Inject] private GameSettings _gameSettings;


        public void PerformRequiredAction(bool value)
        {
            
            _gameSettings.sound= value;
            
            
        }
    }
}