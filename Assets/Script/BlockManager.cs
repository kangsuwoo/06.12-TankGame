using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{

    void Update()
    {
        if(this.transform.localPosition.y <= -10)
        {
            Destroy(gameObject);

           GameObject go = GameObject.Find("Text");
            go.GetComponent<fireCount>().PlusCount();
        }
    }
}
