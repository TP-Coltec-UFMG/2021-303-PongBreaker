using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public GameObject creditsUI;
    public Slider sfxSlider;
    public Slider musicSlider;

    public GameObject FiltroP;
    public GameObject FiltroD;
    public GameObject FiltroT;
    public GameObject FiltroAC;

    public Toggle toggleP;
    public Toggle toggleD;
    public Toggle toggleT;
    public Toggle toggleAC;

    private void Start()
    {
        sfxSlider.value = PlayerPrefs.GetFloat("sfx");
        musicSlider.value = PlayerPrefs.GetFloat("music");

        if (PlayerPrefs.GetInt("FiltroP") == 1)
        {
            FiltroP.SetActive(true);
            toggleP.SetIsOnWithoutNotify(true);
        }
        if (PlayerPrefs.GetInt("FiltroT") == 1)
        {
            FiltroT.SetActive(true);
            toggleT.SetIsOnWithoutNotify(true);
        }
        if (PlayerPrefs.GetInt("FiltroD") == 1)
        {
            FiltroD.SetActive(true);
            toggleD.SetIsOnWithoutNotify(true);
        }
        if (PlayerPrefs.GetInt("FiltroAC") == 1)
        {
            FiltroAC.SetActive(true);
            toggleAC.SetIsOnWithoutNotify(true);
        }
    }

    public void SetSfx (float sfxVolume)
    {
        audioMixer.SetFloat("sfx", sfxVolume);
        PlayerPrefs.SetFloat("sfx", sfxVolume);
    }

    public void SetMusic (float musicVolume)
    {
        audioMixer.SetFloat("music", musicVolume);
        PlayerPrefs.SetFloat("music", musicVolume);
    }

    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (creditsUI.activeSelf)
            {
                creditsUI.SetActive(false);
            }
            else
            {
                SceneManager.LoadScene("MainMenu");
            }
        }

    }

    public void ResetData()
    {
        PlayerPrefs.SetInt("levelsCompleted", 1);
        PlayerPrefs.SetString("NextLevel", "Level1");
    }

    public void OpenCredits()
    {
        creditsUI.SetActive(true);
    }

    public void ToggleP()
    {
        if (FiltroP.activeSelf)
        {
            FiltroP.SetActive(false);
            PlayerPrefs.SetInt("FiltroP", 0);
        } else
        {
            FiltroP.SetActive(true);
            PlayerPrefs.SetInt("FiltroP", 1);
        }
    }

    public void ToggleD()
    {
        if (FiltroD.activeSelf)
        {
            FiltroD.SetActive(false);
            PlayerPrefs.SetInt("FiltroD", 0);
        }
        else
        {
            FiltroD.SetActive(true);
            PlayerPrefs.SetInt("FiltroD", 1);
        }
    }

    public void ToggleT()
    {
        if (FiltroT.activeSelf)
        {
            FiltroT.SetActive(false);
        PlayerPrefs.SetInt("FiltroT", 0);

        }
        else
        {
            FiltroT.SetActive(true);
            PlayerPrefs.SetInt("FiltroT", 1);
        }
    }

    public void ToggleAC()
    {
        if (FiltroAC.activeSelf)
        {
            FiltroAC.SetActive(false);
            PlayerPrefs.SetInt("FiltroAC", 0);
        }
        else
        {
            FiltroAC.SetActive(true);
            PlayerPrefs.SetInt("FiltroAC", 1);
        }
    }
}
