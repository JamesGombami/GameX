using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameX : MonoBehaviour
{
    public GameObject HSpanel;
    private Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = HSpanel.GetComponent<Animator>();
    }

    public void changeScene(string name)
    {
        SceneManager.LoadSceneAsync(name);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void hideObject(string name)
    {
        GameObject.Find(name).SetActive(false);

    }
    public void playHSpanel()
    {
        anim.SetTrigger("play");
    }
    public void backHSpanel()
    {
        anim.SetTrigger("Stop");
    }
}
