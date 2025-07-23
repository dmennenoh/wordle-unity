using UnityEngine;
using System.Collections;

/*
 * Attached to a Row prefab
 */

namespace wordleUnity
{
    public class Row : MonoBehaviour
    {
        private Tile[] tiles;
        private RectTransform rectTransform;
        private float shakeDuration = 0.75f;
        private float shakeMagnitude = 8f;
        private Vector3 originalPos;


        private void Start()
        {
            rectTransform = GetComponent<RectTransform>();
        }

        void Awake()
        {
            tiles = GetComponentsInChildren<Tile>();
        }

        public Tile[] Tiles
        {
            get
            {
                return tiles;
            }
        }

        public void Shake()
        {
            originalPos = rectTransform.anchoredPosition;
            StartCoroutine(DoShake());
        }

        IEnumerator DoShake()
        {
            float elapsedTime = 0f;
            while (elapsedTime < shakeDuration)
            {
                float strength = Mathf.Lerp(shakeMagnitude, 0f, elapsedTime / shakeDuration);
                Vector2 randomOffset = Random.insideUnitCircle * strength;
                rectTransform.anchoredPosition = originalPos + new Vector3(randomOffset.x, 0f, 0f);
                elapsedTime += Time.deltaTime;
                yield return null;
            }
            rectTransform.anchoredPosition = originalPos; // Reset position
        }
    }
}