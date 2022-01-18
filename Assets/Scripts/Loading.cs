using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Loading : MonoBehaviour
{
    public float loading;
    public Text loadingBar;
    public GameObject bar;
    void Update()
    {
        loadingBar.text = "%" + (int)loading;
        bar.transform.localScale = new Vector2(loading / 100, 1);
        if (loading < 100)
        {
            loading += Time.deltaTime * 50;
        }
        if (loading >= 100)
        {
            loading = 100;
            SceneManager.LoadScene("Menu");
        } 
    }
}
