using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // 이동에 사용할 리지드바디 컴포넌트
    public Rigidbody PlayerRigidbody;
    // 이동속력
    float speed = 8f;
    // Start is called before the first frame update

    public GameObject my;
    void Start()
    {
        //게임 오브젝트에서 Rigidbody 컴포넌트를 찾아
        //PlayerRigidbody에 할당
        PlayerRigidbody = GetComponent<Rigidbody>(); //Rigidbody가 비어있을때

    }

    // Update is called once per frame
    void Update()
    {
        //수평축과 수직축의 입력값을 감지해서 저장
        float xinput = Input.GetAxis("Horizontal");
        //키보드 : "A", ←: 음의방향 : -1.0f
        //키보드 : "D", →: 양의방향 : +1.0f
        float zinput = Input.GetAxis("vertical");
        //키보드 : "W", ↑: 양의방향 : +1.0f
        //키보드 : "S", ↓: 음의방향 : -1.0f
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
