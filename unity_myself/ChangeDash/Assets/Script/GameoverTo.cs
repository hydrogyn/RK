using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameoverTo : MonoBehaviour {
    //gameoverシーンから遷移
    public void back_to_title()
    {
        SceneManager.LoadScene("title");
    }
	public void retry_game()
    {
        SceneManager.LoadScene("game_main");
    }
}
