using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 5.0f;                                          // �÷��̾� �ӵ�

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))                              // ���� ȭ��ǥ�� ������ ���� ��
        {
            transform.Translate(Vector2.up * Speed * Time.deltaTime);   // ������Ʈ�� ��ġ�� ���� ��ġ���� �� �������� Speed��ŭ ������.
        }

        if (Input.GetKey(KeyCode.DownArrow))                              // �Ʒ��� ȭ��ǥ�� ������ ���� ��
        {
            transform.Translate(Vector2.down * Speed * Time.deltaTime);   // ������Ʈ�� ��ġ�� ���� ��ġ���� �Ʒ� �������� Speed��ŭ ������.
        }

        if (transform.position.y > 3.5f)                                            // ������Ʈ�� y��ǥ�� �ִ���� (3.5)���� Ŭ ��
        {
            transform.position = new Vector2(transform.position.x, 3.5f);           // ������Ʈ�� y��ǥ�� �ִ� ���� (3.5)�� �̵�
        }

        if (transform.position.y < -3.5f)                                           // ������Ʈ�� y��ǥ�� �������� (-3.5)���� ���� ��
        {
            transform.position = new Vector2(transform.position.x, -3.5f);          // ������Ʈ�� y��ǥ�� ���� ���� (-3.5)�� �̵�
        }
    }
}
