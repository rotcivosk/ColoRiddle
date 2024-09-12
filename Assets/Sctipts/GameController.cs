using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject endScreen;
    public GameObject pauseScreen;
    public GameObject pauseButton;
    [SerializeField] string nextSceneName;
    string startMenuName = "StartMenuScene";

    void Start(){
            Time.timeScale = 1;
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)){
            PauseGame();
        }
    }


    public void TriggerEndGame()
    {
        Time.timeScale = 0;
        endScreen.SetActive(true);
        pauseButton.SetActive(false);        
    }
    public void LoadNextScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(nextSceneName);
    }

    public void RestartScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        pauseButton.SetActive(true);
    }

    public void ExittoMenuPage()
    {
       Time.timeScale = 0;
        SceneManager.LoadScene(startMenuName);
    }
    public void ExittoWindows()
    {
        Application.Quit();
       // UnityEditor.EditorApplication.isPlaying = false;
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseScreen.SetActive(true);
        pauseButton.SetActive(false);
    }
    public void UnpauseGame()
    {
        Time.timeScale = 1;
        pauseScreen.SetActive(false);
        pauseButton.SetActive(true);
    }


}