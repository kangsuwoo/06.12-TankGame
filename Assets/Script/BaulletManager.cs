using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaulletManager : MonoBehaviour
{

    void Update()
    {
        if (this.transform.localPosition.y <= -10)
        {
            Destroy(gameObject);
        }
    }
}
