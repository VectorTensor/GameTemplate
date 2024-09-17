using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GameTemplate.Scripts.MainMenu.SaveMenu
{
    public class SaveItemView : MonoBehaviour
    {
        [SerializeField] private TMP_Text nameT;
        [SerializeField] private TMP_Text date;

        public void Init(string nameT, int date)
        {
            
            this.nameT.text = nameT;
            this.date.text = date.ToString();
            
        }

    }
}