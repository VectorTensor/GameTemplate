using DependencyInjection;
using GameTemplate.Scripts.MainMenu.Settings.ScriptObjects;

namespace GameTemplate.Scripts.MainMenu.Settings.Services
{
    public class MusicSettingOption:ISettingOptionService
    {
        [Inject] private GameSettingsBuffer _buffer;
        


        public void PerformRequiredAction(bool value)
        {
            
            _buffer.music = value;
            
            
        }
    }
}