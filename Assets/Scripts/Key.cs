using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace wordleUnity
{
    public class Key : MonoBehaviour
    {
        [SerializeField] private string keyText;
        private TextMeshProUGUI tField;
        private Image bgImage;
        private bool colorSet;
        private MarkedColor myColor;

        private void Start()
        {
            tField = GetComponentInChildren<TextMeshProUGUI>();
            bgImage = GetComponent<Image>();
            tField.text = keyText;
            colorSet = false;
            myColor = MarkedColor.Unset;
        }

        public void SetYellow()
        {
            if (myColor == MarkedColor.Green) return;           
            myColor = MarkedColor.Yellow;
            bgImage.color = new Color32(181, 159, 71, 255);                      
        }

        public void SetGreen()
        {
            myColor = MarkedColor.Green;
            bgImage.color = new Color32(83, 141, 78, 255);
        }

        public void SetGray()
        {
            myColor = MarkedColor.Gray;
            bgImage.color = new Color32(60,60,60, 255);
        }
    }
}