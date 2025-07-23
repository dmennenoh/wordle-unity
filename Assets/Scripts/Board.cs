using UnityEngine;

namespace wordleUnity
{
    public class Board : MonoBehaviour
    {
        //rows has six Row objects
        private Row[] rows;

        void Start()
        {
            rows = GetComponentsInChildren<Row>();
        }

        public Row[] Rows
        {
            get
            {
                return rows;
            }
        }
    }
}
