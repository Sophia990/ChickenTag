using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    SceneTransition sceneTransition;

    public float targetTime = 180.0f;
    public TMP_Text timeText;

    private CharacterAttributes attributes;

    // Start is called before the first frame update
    void Start()
    {
        attributes = GameObject.Find("Player").GetComponent<CharacterAttributes>();
        sceneTransition = FindObjectOfType<SceneTransition>();
    }

    // Update is called once per frame
    void Update()
    {
        targetTime -= Time.deltaTime;

        if (targetTime <= 0)
        {
            timerEnded();
        }

        displayTime(targetTime);
    }

    public void wonGame()
    {
        sceneTransition.LoadScene("Win");
    }

    public void lostGame()
    {
        sceneTransition.LoadScene("Lose");
    }

    void displayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    private void timerEnded()
    {
        targetTime = 0;

        if (attributes.it == true)
        {
            lostGame();
        }
        else
        {
            wonGame();
        }
    }
}
