using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;                   // ����Ƽ UI ����� ���� ���̺귯�� ����
using UnityEngine.SceneManagement;      // ����Ƽ �� ��ȭ�� ���� ���̺귯�� ����

public class Manager : MonoBehaviour
{
    public Text TimeText;               // Text UI

    public GameObject BallPrefabs;      // �� ������Ʈ�� Prefabs
    public GameObject GameOverUI;       // ���� ���� UI

    private bool ballExists = false;    // ���� ������ ���� �����ϴ��� Ȯ���ϴ� bool ����
    private bool Play = false;          // ���� ������ ���������� Ȯ���ϴ� bool ����
    private float playTime = 0.0f;      // ���� ������ ����� �ð�

    // Start is called before the first frame update
    void Start()
    {
        Play = true;
        ballExists = false;
        playTime = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!ballExists)                                                            // ���� ���� �������� ���� ��
        {
            if (Input.anyKeyDown)                                                   // �ƹ� ��ư�̳� ������
            {
                ballExists = true;                                                  // ���� �����Ѵٰ� ����
                Instantiate(BallPrefabs, new Vector2(0, 2), Quaternion.identity);   // ���� �������� ����
            }   
        }

        if (Play && ballExists)                                                     // ���� �÷��� ���̰�, ���� ������ ��
        {
            playTime += Time.deltaTime;                                             // �÷��� Ÿ���� �������ְ�

            TimeText.text = "PlayTIme : " + playTime.ToString("00.00");             // �÷��� Ÿ�� �ؽ�Ʈ�� ������Ʈ
        }

        if (!Play)                                                                  // ���� �÷��� ���� �ƴ� ��
        {
            if (Input.anyKeyDown)                                                   // �ƹ� Ű�� ������
            {
                SceneManager.LoadScene("GameScene");                                // GameScene �ٽ� �ε�
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)                          // �ٸ� ��ü�� �浹 �� ���
    {
        if (collision.transform.tag == "Ball")                                      // �浹�� ��ü�� tag�� Ball�̸�
        {
            Destroy(collision.gameObject);                                          // �浹�� ��ü �ı�
            Play = false;                                                           // �÷��� ���� false�� ����
            GameOverUI.SetActive(true);                                             // ���ӿ��� UI Ȱ��ȭ 
        }
    }
}
