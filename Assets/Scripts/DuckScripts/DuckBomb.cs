using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DuckShoot
{
    public class DuckBomb : MonoBehaviour
    {
        public Rigidbody bomb;
        public Transform bombBay;

        // Start is called before the first frame update
        void Start()
        {

        }

        void Update()
        {
            if(Input.GetKeyDown(KeyCode.V))
            {
                Rigidbody bombInstance;
                bombInstance = Instantiate(bomb, bombBay.position, bombBay.rotation) as Rigidbody;
                //bombInstance.AddForce(bombBay.down * 20f);
            }
        }
    }
}