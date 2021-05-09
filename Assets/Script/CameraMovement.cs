using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraMovement : MonoBehaviour
{
    float CameraZ = -20;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Camera.main.aspect = 16f / 9f; //ȭ�� ���� 16�� 9�� ����
        Screen.SetResolution(1920, 1080, true); //�ػ� 1920 1080, ��üȭ�� true
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(Player.transform.position.x, Player.transform.position.y, CameraZ), Time.deltaTime * 1f);
        //�ε巯�� ��ǥ ����
    }

}