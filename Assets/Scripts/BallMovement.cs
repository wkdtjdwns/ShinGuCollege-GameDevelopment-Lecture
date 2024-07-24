using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float Speed = 5.0f;          // 공의 속도
    public int HorizontalDirection = 1; // 공의 좌우 방향
    public int VerticalDirection = 1;   // 공의 상하 방향
    public Rigidbody2D Rigidbody;       // 물체의 물리 적용을 위한 Rigidbody2D

    // Start is called before the first frame update
    void Start()
    {
        int randomNumber = Random.Range(0, 2);      // 지역변수 randomNumber에 0 ~ 1까지의 랜덤 정수 저장

        if (randomNumber == 0)                      // 랜덤 숫자가 0일 때
        {
            HorizontalDirection = 1;                // 공의 방향을 오른쪽으로 변경
        }

        else                                        // 랜덤 숫자가 1이 아닐 때
        {
            HorizontalDirection = -1;               // 공의 방향을 왼쪽으로 변경
        }

        VerticalDirection = 1;                      // 공의 상하 방향을 아래로 고정

        // 공의 속도를 변경
        Rigidbody.velocity = new Vector2(Speed * HorizontalDirection, Speed * VerticalDirection);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "TopBottomWall")         // 내가 충돌한 물체의 tag가 TopBottomWall이라면
        {
            VerticalDirection *= -1;                            // 상하 방향 반전
        }

        if (collision.transform.tag == "LeftRightWall")         // 내가 충돌한 물체의 tag가 LeftRightWall이라면
        {
            HorizontalDirection *= -1;                            // 상하 방향 반전
        }

        if (collision.transform.tag == "Player")                // 내가 충돌한 물체의 tag가 Player라면
        {
            HorizontalDirection *= -1;                           // 좌우 방향 반전
        }

        // 공의 속도를 변경
        Rigidbody.velocity = new Vector2(Speed * HorizontalDirection, Speed * VerticalDirection);
    }
}
