using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public bool gameStatus;

    [ContextMenu("Increase Score")]

    private void Start()
    {
        gameStatus = true;
    }
    public void addScore(int scoreToAdd)
    {
        playerScore= playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }
    public void restartGame()
    {
        gameStatus = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameStatus = false;
        gameOverScreen.SetActive(true);
    }
}
