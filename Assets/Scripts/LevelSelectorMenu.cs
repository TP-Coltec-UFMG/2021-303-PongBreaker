using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelectorMenu : MonoBehaviour
{
    public Button[] buttons;

    public GameObject FiltroP;
    public GameObject FiltroD;
    public GameObject FiltroT;
    public GameObject FiltroAC;

    private void Start()
    {
        int levelsCompleted = PlayerPrefs.GetInt("levelsCompleted", 1);

        for (int i = levelsCompleted; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }

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

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void Select(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
    
}
