using UnityEngine;
using UnityEngine.SceneManagement;

// �������μ� �ʿ��� ������ ���� ��ũ��Ʈ
public class ClearP : MonoBehaviour
{
    public PlayerController pc;
    public bool isGameClear = false; // ���� ���� ����
    private bool stepped = false; // �÷��̾� ĳ���Ͱ� ��Ҿ��°�

    void OnCollisionEnter2D(Collision2D collision)
    {
        // �÷��̾� ĳ���Ͱ� �ڽ��� ������� ������ �߰��ϴ� ó��
        if (collision.gameObject.CompareTag("Player"))
        {
            stepped = true;
            GameManager.instance.OnGameClear();
        }

        if (collision.gameObject.CompareTag("Finish"))
        {
            pc.Clear();
        }
    }
    
}
