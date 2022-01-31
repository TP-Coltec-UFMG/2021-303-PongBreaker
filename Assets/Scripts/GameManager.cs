using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public string nextLevel;
    public int nextLevelIndex;

    bool gameHasEnded = false;

    public float restartDelay = 1f;
    public float winDelay = 5f;

    public GameObject completeLevelUI;

    public GameObject FiltroP;
    public GameObject FiltroD;
    public GameObject FiltroT;
    public GameObject FiltroAC;

    private void Start()
    {
        if (PlayerPrefs.GetInt("FiltroP") == 1)
        {
            FiltroP.SetActive(true);
        }
        if (PlayerPrefs.GetInt("FiltroT") == 1)
        {
            FiltroT.SetActive(true);
        }
        if (PlayerPrefs.GetInt("FiltroD") == 1)
        {
            FiltroD.SetActive(true);
        }
        if (PlayerPrefs.GetInt("FiltroAC") == 1)
        {
            FiltroAC.SetActive(true);
        }
    }

    private void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Brick").Length == 0)
        {
            CompleteLevel();
            FindObjectOfType<ballMovement>().GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            FindObjectOfType<ballMovement>().GetComponent<Rigidbody2D>().angularVelocity = 0f; ;
        }
    }

    public void WinLevel()
    {
        if (PlayerPrefs.GetInt("levelsCompleted") < nextLevelIndex)
        {
            PlayerPrefs.SetInt("levelsCompleted", nextLevelIndex);
            PlayerPrefs.SetString("NextLevel", nextLevel);
        }

        SceneManager.LoadScene("LevelSelector");
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        Invoke("WinLevel", winDelay);
    }

    public void EndGame ()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
