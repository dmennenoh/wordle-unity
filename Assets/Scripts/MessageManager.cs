using UnityEngine;
using TMPro;

namespace wordleUnity
{
    public class MessageManager : MonoBehaviour
    {
        [SerializeField] private GameObject messageBase;
        private CanvasGroup cg;
        private TextMeshProUGUI tfield;

        private void Start()
        {
            tfield = messageBase.GetComponentInChildren<TextMeshProUGUI>();
            cg = messageBase.GetComponent<CanvasGroup>();
            cg.alpha = 0;
        }

        public void showMessage(string message)
        {
            cg.alpha = 0;
            tfield.text = message;
            LeanTween.alphaCanvas(cg, 1, .5f).setOnComplete(fOut);
        }

        private void fOut()
        {
            LeanTween.alphaCanvas(cg, 0, .5f).setDelay(3);
        }
    }
}
