using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manualto : MonoBehaviour {
    //manualからの遷移
	public void back_to_title()
    {
        SceneManager.LoadScene("title");
    } 
}
