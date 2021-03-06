using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class MenuManagerScript : MonoBehaviour
{

    public Canvas startMenu;
    public Canvas quitMenu;

    public Button playButton;
    public Button exitButton;

    public string gotoThisScene;

    void Start()
    {
        quitMenu = quitMenu.GetComponent<Canvas>();
        startMenu = startMenu.GetComponent<Canvas>();
        playButton = playButton.GetComponent<Button>();
        exitButton = exitButton.GetComponent<Button>();
        quitMenu.enabled = false;
    }

    public void ExitPress()
    {
        quitMenu.enabled = true;
        startMenu.enabled = false;
        playButton.enabled = false;
        exitButton.enabled = false;
    }

    public void NoPress()
    {
        quitMenu.enabled = false;
        startMenu.enabled = true;
        playButton.enabled = true;
        exitButton.enabled = true;    
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void StartLevel()
    {
        SceneManager.LoadScene( gotoThisScene );
    }

}