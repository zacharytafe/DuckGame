using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DuckShoot
{
    public class CrosshairFollow : MonoBehaviour
    {
        private SpriteRenderer rend;
        public Sprite crossHair;

        // Start is called before the first frame update
        void Start()
        {
            Cursor.visible = false;
            rend = GetComponent<SpriteRenderer>();
        }

        // Update is called once per frame
        void Update()
        {
            Vector2 curorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = curorPos;
        }
    }
}