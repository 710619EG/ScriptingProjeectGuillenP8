using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBasic : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            Destroy(gameObject);
        }
    }
}
