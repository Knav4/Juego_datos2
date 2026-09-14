using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private Button playButton;
    [SerializeField] private string LevelSelector;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void goToNextScene()
    {
        SceneManager.LoadScene(LevelSelector);
    }
}
