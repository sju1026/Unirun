using UnityEngine;
using UnityEngine.SceneManagement;

// 발판으로서 필요한 동작을 담은 스크립트
public class ClearP : MonoBehaviour
{
    public PlayerController pc;
    public bool isGameClear = false; // 게임 오버 상태
    private bool stepped = false; // 플레이어 캐릭터가 밟았었는가

    void OnCollisionEnter2D(Collision2D collision)
    {
        // 플레이어 캐릭터가 자신을 밟았을때 점수를 추가하는 처리
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
