using UnityEngine;
using TMPro;
using UnityEngine.UI;

/*
 * Attached to a Tile prefab
 */

namespace wordleUnity
{
    public enum MarkedColor
    {
        Green,
        Yellow,
        Gray,
        Unset
    }
    public class Tile : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI tField;
        [SerializeField] private Outline outline;
        [SerializeField] private Image bgImage;
        
        //gets set to true in SetGreen() or SetYellow()
        private bool isInWord = false;
        private MarkedColor myColor;

        public string Letter
        {
            get
            {
                return tField.text;
            }
            set
            {
                tField.text = value;
            }
        }

        public bool IsInWord
        {
            get
            {
                return isInWord;
            }
        }

        public string GetColorChar()
        {
            string cc = "B";//default gray - black

            if(myColor == MarkedColor.Green)
            {
                cc = "G";
            }
            else if(myColor == MarkedColor.Yellow)
            {
                cc = "Y";
            }

            return cc;
        }

        //empty square
        public void SetDarkOutline()
        {
            outline.effectColor = new Color32(61, 61, 61, 255);
            bgImage.color = new Color32(0, 0, 0, 255);
        }

        //Has a letter, but it's not yet been checked - user just typed it in
        public void SetLightOutline()
        {
            outline.effectColor = new Color32(100, 100, 100, 255);
            bgImage.color = new Color32(0, 0, 0, 255);
        }

        public void SetColor(float delay)
        {
            if(myColor == MarkedColor.Yellow)
            {
                SetYellow(delay);
            }
            else if(myColor == MarkedColor.Green)
            {
                SetGreen(delay);
            }
            else
            {
                SetGray(delay);
            }
        }

        public void MarkYellow()
        {
            isInWord = true;
            myColor = MarkedColor.Yellow;
        }
        //has a letter in the word, but in the wrong spot
        private void SetYellow(float delay)
        {            
            outline.effectColor = new Color32(120, 120, 120, 0);
            LeanTween.scaleY(gameObject, 0, .25f).setDelay(delay).setOnComplete(finishYellow);            
        }

        private void finishYellow()
        {
            bgImage.color = new Color32(181, 159, 71, 255);
            LeanTween.scaleY(gameObject, 1, .25f);
        }

        //letter in word at the correct spot
        public void MarkGreen()
        {
            isInWord = true;
            myColor = MarkedColor.Green;
        }
        private void SetGreen(float delay)
        {            
            outline.effectColor = new Color32(120, 120, 120, 0);
            LeanTween.scaleY(gameObject, 0, .25f).setDelay(delay).setOnComplete(finishGreen);
        }

        private void finishGreen()
        { 
            bgImage.color = new Color32(83, 141, 78, 255);
            LeanTween.scaleY(gameObject, 1, .25f);            
        }

        //letter is not in the word - just a gray box
        public void MarkGray()
        {
            myColor = MarkedColor.Gray;
        }

        private void SetGray(float delay)
        {           
            outline.effectColor = new Color32(80, 80, 80, 0);
            LeanTween.scaleY(gameObject, 0, .25f).setDelay(delay).setOnComplete(finishGray);
        }

        private void finishGray()
        {
            bgImage.color = new Color32(100, 100, 100, 255);
            LeanTween.scaleY(gameObject, 1, .25f);            
        }
    }
}