using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public string nextLevel;
    public int nextLevelIndex;

    public void WinLevel()
    {   
        if (PlayerPrefs.GetInt("levelsCompleted") < nextLevelIndex){
            PlayerPrefs.SetInt("levelsCompleted", nextLevelIndex);
            PlayerPrefs.SetString("NextLevel", nextLevel);
        }
        
        SceneManager.LoadScene("LevelSelector");
    }

}
