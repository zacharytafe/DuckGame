using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BallGame
{
    public class Bullet : MonoBehaviour
    {
        public float timer = 10;

        private void LateUpdate()
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}