using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float Speed = 5.0f;          // ���� �ӵ�
    public int HorizontalDirection = 1; // ���� �¿� ����
    public int VerticalDirection = 1;   // ���� ���� ����
    public Rigidbody2D Rigidbody;       // ��ü�� ���� ������ ���� Rigidbody2D

    // Start is called before the first frame update
    void Start()
    {
        int randomNumber = Random.Range(0, 2);      // �������� randomNumber�� 0 ~ 1������ ���� ���� ����

        if (randomNumber == 0)                      // ���� ���ڰ� 0�� ��
        {
            HorizontalDirection = 1;                // ���� ������ ���������� ����
        }

        else                                        // ���� ���ڰ� 1�� �ƴ� ��
        {
            HorizontalDirection = -1;               // ���� ������ �������� ����
        }

        VerticalDirection = 1;                      // ���� ���� ������ �Ʒ��� ����

        // ���� �ӵ��� ����
        Rigidbody.velocity = new Vector2(Speed * HorizontalDirection, Speed * VerticalDirection);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "TopBottomWall")         // ���� �浹�� ��ü�� tag�� TopBottomWall�̶��
        {
            VerticalDirection *= -1;                            // ���� ���� ����
        }

        if (collision.transform.tag == "LeftRightWall")         // ���� �浹�� ��ü�� tag�� LeftRightWall�̶��
        {
            HorizontalDirection *= -1;                            // ���� ���� ����
        }

        if (collision.transform.tag == "Player")                // ���� �浹�� ��ü�� tag�� Player���
        {
            HorizontalDirection *= -1;                           // �¿� ���� ����
        }

        // ���� �ӵ��� ����
        Rigidbody.velocity = new Vector2(Speed * HorizontalDirection, Speed * VerticalDirection);
    }
}
