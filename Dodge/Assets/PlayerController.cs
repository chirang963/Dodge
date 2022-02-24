using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // �̵��� ����� ������ٵ� ������Ʈ
    public Rigidbody PlayerRigidbody;
    // �̵��ӷ�
    float speed = 8f;
    // Start is called before the first frame update

    public GameObject my;
    void Start()
    {
        //���� ������Ʈ���� Rigidbody ������Ʈ�� ã��
        //PlayerRigidbody�� �Ҵ�
        PlayerRigidbody = GetComponent<Rigidbody>(); //Rigidbody�� ���������

    }

    // Update is called once per frame
    void Update()
    {
        //������� �������� �Է°��� �����ؼ� ����
        float xinput = Input.GetAxis("Horizontal");
        //Ű���� : "A", ��: ���ǹ��� : -1.0f
        //Ű���� : "D", ��: ���ǹ��� : +1.0f
        float zinput = Input.GetAxis("vertical");
        //Ű���� : "W", ��: ���ǹ��� : +1.0f
        //Ű���� : "S", ��: ���ǹ��� : -1.0f
    }


    void Directinput()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            PlayerRigidbody.AddForce(0f, 0f, speed);
        }

        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            PlayerRigidbody.AddForce(0f, 0f, -speed);
        }

        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            PlayerRigidbody.AddForce(speed, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            PlayerRigidbody.AddForce(-speed, 0f, 0f);
        }
    }

    void Die()
    {
        my.SetActive(false);
        //gameObject.SetActive(false);
    }
}
