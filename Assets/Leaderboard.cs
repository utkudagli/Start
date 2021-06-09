using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Leaderboard : MonoBehaviour
{
    PlayfabManager playfabManager;
    Button playAgain;

    // Start is called before the first frame update
    void Start()
    {
        playAgain = transform.GetChild(1).GetComponent<Button>();

        playAgain.onClick.AddListener(PlayAgain);
    }

    void PlayAgain()
    {
        SceneManager.LoadScene("SampleScene", 0);
    }
}
