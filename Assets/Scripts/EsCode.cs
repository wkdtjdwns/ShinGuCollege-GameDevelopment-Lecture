using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsCode : MonoBehaviour
{
    public int Level = 10;              // int (정수) Level (변수 이름)을 선언하고 10의 값을 넣어줌.
    public float Hp = 100.0f;           // float (실수) Hp (변수이름)을 선언하고 100의 값을 넣어줌.
    public bool IsDead = false;         // bool (참/거짓) IsDead (변수 이름)을 선언하고 거짓의 값을 넣어줌.
    public string PlayerName = "이름";    // string (문자열) PlayerName (변수 이름)을 선언하고 "이름"의 값을 넣어줌.

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)                // 반복문 for(초기 실행; 조건문; 종료시 실행)
        {
            Debug.Log(i + "번째 반복입니다.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))        // 스페이스바 버튼이 눌렸을 때
        {
            // Debug.Log("이름 : " + PlayerName + " 레벨 : " + Level + " HP : " + Hp);
            Attack(5);

            if (Hp > 0)                             // Hp가 0보다 클 때
            {
                Debug.Log("현재 체력 : " + Hp);
            }

            else
            {
                                                    // Hp가 0보다 작거나 같을 때
            }
            {
                Debug.Log("죽었습니다.");
                IsDead = true;                      // IsDead bool값 참으로 변경
            }
        }
    }

    void Attack(float Damage)                       // 데미지 함수 선언 (매개변수)
    {
        //Hp = Hp - Damage;
        Hp -= Damage;
    }
}