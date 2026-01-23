using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainLobbyBTN : MonoBehaviour
{
    [SerializeField]private Button startButton;
    [SerializeField]private Button exitButton;
    [SerializeField] private Button optionButton;
    [SerializeField] private Button exitOptionButton;
    [SerializeField] private GameObject optionBg;
    [SerializeField] private Button soundButton;
    [SerializeField] private Button exitSoundButton;
    [SerializeField]private GameObject soundBg;
    [SerializeField] private Button mainLobbyButton;
    [SerializeField] private Button armoryButton;
    [SerializeField] private Button exitPauseButton;
    [SerializeField]private GameObject pauseBg;



    private void Update()
    {
        Pause();
    }
    public void StartButton()
    {
        SceneManager.LoadScene("05.BattleScene");
        

    }
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("게임 종료");
    }
    public void OptionButton()
    {
        optionBg.gameObject.SetActive(true);
    }
    public void OptionExitBTN()
    {
        optionBg.gameObject.SetActive(false);
    }
    public void SoundBTN()
    {
        soundBg.gameObject.SetActive(true);
    }
    public void SoundExitBTN()
    {
        soundBg.gameObject.SetActive(false);
    }
    public void MainLobbyBTNClick()
    {
        Time.timeScale = 1f;
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        SceneManager.LoadScene("01.MainLobby");
    }
    public void ArmoryBTNClick()
    {
        SceneManager.LoadScene("02.Armory");
    }
    public void ExitPauseBTNClick()
    {
        pauseBg.gameObject.SetActive(false);

        Time.timeScale = 1f; // 게임 재개
    }
    public void Pause()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseBg.gameObject.SetActive(true);

            Time.timeScale = 0f; // 게임 일시정지


        }

    }

}
