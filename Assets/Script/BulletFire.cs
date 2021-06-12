using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour
{
    // Editor ���� �������� �������� ���
    public GameObject Prefab;
    public float ForceValue;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // Prefab ��ü�� ���� ���� �����Ѵ� (Clone)
            GameObject prefab = Instantiate(Prefab, transform.position,transform.rotation);

            Rigidbody body = prefab.GetComponent<Rigidbody>();

            // �� ������ �������� ���� �����ش�
            body.AddRelativeForce(0, 0, 10000f, ForceMode.Impulse);

            
            // Transform ������ �ڽİ� �θ�, �� ��ġ�� �θ� ��ġ�� �Ű����Ѵ�
            // transform.localPosition = ���� �� ������
            // transform.position = �θ���ġ + ����ġ

        }    
    }
}
