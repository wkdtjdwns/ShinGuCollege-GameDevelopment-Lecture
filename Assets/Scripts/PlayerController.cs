using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 5.0f;                                          // 플레이어 속도

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))                              // 위쪽 화살표가 누르고 있을 때
        {
            transform.Translate(Vector2.up * Speed * Time.deltaTime);   // 오브젝트의 위치를 현재 위치에서 위 방향으로 Speed만큼 움직임.
        }

        if (Input.GetKey(KeyCode.DownArrow))                              // 아래쪽 화살표가 누르고 있을 때
        {
            transform.Translate(Vector2.down * Speed * Time.deltaTime);   // 오브젝트의 위치를 현재 위치에서 아래 방향으로 Speed만큼 움직임.
        }

        if (transform.position.y > 3.5f)                                            // 오브젝트의 y좌표가 최대높이 (3.5)보다 클 때
        {
            transform.position = new Vector2(transform.position.x, 3.5f);           // 오브젝트의 y좌표를 최대 높이 (3.5)로 이동
        }

        if (transform.position.y < -3.5f)                                           // 오브젝트의 y좌표가 최저높이 (-3.5)보다 낮을 때
        {
            transform.position = new Vector2(transform.position.x, -3.5f);          // 오브젝트의 y좌표를 최저 높이 (-3.5)로 이동
        }
    }
}
