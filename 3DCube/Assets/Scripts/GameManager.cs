using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;
    public GameObject completelvlUI;

    public void CompleteLevel()
    {
        completelvlUI.SetActive(true);
    }


    public void EndGame()
    {
        if (GameHasEnded==false)
        {
            GameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", 2f);
        }
       
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name) ;
    }

   
}
