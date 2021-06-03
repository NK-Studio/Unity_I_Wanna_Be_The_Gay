using UnityEngine;
using UnityEngine.SceneManagement;

public class beginning : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var pos = other.gameObject.transform.position;

            //윗쪽
            if (pos.y > -2.75f)
            {
                GameManager.GetInstance
                    .gameDatas[GameManager.CurrentGameIndex]
                    .Difficulty = pos.x < 0 ? DIFFICULTY.HARD : DIFFICULTY.EXCRUCIATING;
            }
            //아래쪽
            else
            {
                GameManager.GetInstance
                    .gameDatas[GameManager.CurrentGameIndex]
                    .Difficulty = pos.x < 0 ? DIFFICULTY.MEDIUM : DIFFICULTY.VERYHARD;
            }

            GameManager.GetInstance.OnSave();
            SceneManager.LoadScene("Test");
        }
    }
}
