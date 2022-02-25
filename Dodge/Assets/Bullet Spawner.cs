using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject bulletPrefab;
    // �ּ� ���� �ֱ�
    public float spawnRateMin = 0.5f;
    // �ִ� ���� �ֱ�
    public float spawnRateMax = 3f;

    // ���� ���� �ֱ�
    private float spawnRate;
    // �ֱ� ���� �������� ���� �ð�
    private float timeAfterSpqwn;
    // �߻��� ���
    private Transform target;
    void Start()
    {
        // �ֱ� ���� ������ ���� �ð��� 0���� �ʱ�ȭ
        timeAfterSpqwn = 0f;
        // ź�� ���� ������ spwanRatemin�� spawnRateMax ���̿��� ������ ����
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);

        // PlayerController ������Ʈ�� ���� ���� ������Ʈ�� ã�Ƽ� �� ������Ʈ�� ��ġ���� ������
        target = FindObjectOfType<PlayerController>().transform;


    }

    // Update is called once per frame
    void Update()
    {

        Instantiate(bulletPrefab);

    }
}
