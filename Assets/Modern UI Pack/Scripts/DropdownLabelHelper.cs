using UnityEngine;
using UnityEngine.UI;

namespace Michsky.UI.ModernUIPack
{
    public class DropdownLabelHelper : MonoBehaviour
    {
        [Header("RESOURCES")]
        public Text mainText;
        public Text highlightedText;

        void Update()
        {
            highlightedText.text = mainText.text;
        }
    }
}
