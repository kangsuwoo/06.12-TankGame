using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour
{
    // Editor 에서 프리팹을 가져오는 방법
    public GameObject Prefab;
    public float ForceValue;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // Prefab 객체를 새로 만들어서 복사한다 (Clone)
            GameObject prefab = Instantiate(Prefab, transform.position,transform.rotation);

            Rigidbody body = prefab.GetComponent<Rigidbody>();

            // 내 가가도 기준으로 힘을 가해준다
            body.AddRelativeForce(0, 0, 10000f, ForceMode.Impulse);

            
            // Transform 에서는 자식과 부모, 내 위치와 부모 위치를 신경써야한다
            // transform.localPosition = 정말 내 포지션
            // transform.position = 부모위치 + 내위치

        }    
    }
}
