using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject quitGameMenuUI;

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
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (quitGameMenuUI.activeSelf)
            {
                quitGameMenuUI.SetActive(false);
            } else
            {
                quitGameMenuUI.SetActive(true);
            }

        }
    }

    public void goToOptions()
    {
        SceneManager.LoadScene("OptionsMenu");
    }

    public void goToLevelSelector()
    {
        SceneManager.LoadScene("LevelSelector");
    }

    public void resume()
    {
        SceneManager.LoadScene(PlayerPrefs.GetString("NextLevel"));
    }

    public void Quit()
    {
        Debug.Log("Application Quit");
        Application.Quit();
    }

    public void Return()
    {
        quitGameMenuUI.SetActive(false);
    }


}
