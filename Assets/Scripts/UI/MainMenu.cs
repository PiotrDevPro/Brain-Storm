using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public static MainMenu manage;
    public _levelList lv_list;
    public GameObject Levels;

    private int _startapp = 0;

    [System.Serializable]
    public class _levelList
    {
        public Text lvlText;
        public GameObject _lv1;
        public GameObject _lv2;
        public GameObject _lv3;
        public GameObject _lv4;
    }

    private void Awake()
    {
        manage = this;
        //PlayerPrefs.SetInt("FirstStart", _startapp + 1);
    }

    private void Start()
    {
        lv_list.lvlText.text = "Level " + PlayerPrefs.GetInt("level");
        Levels.SetActive(false);
        lv_list._lv1.SetActive(false);
        lv_list._lv2.SetActive(false);
        lv_list._lv3.SetActive(false);
        lv_list._lv4.SetActive(false);
        print(PlayerPrefs.GetInt("level"));
    }

    #region Settings

    public void menuLevelsOpen()
    {
        Levels.SetActive(true);
    }

    public void menuLevelsClose()
    {
        Levels.SetActive(false);
    }

    public void Erase()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(Application.loadedLevel);
    }

    #endregion

    #region game_mechanics
    public void Level1()
    {
        lv_list._lv1.SetActive(true);
        lv_list._lv2.SetActive(false);
        lv_list._lv3.SetActive(false);
        PlayerPrefs.SetInt("level", 1);
        
    }

    public void Level2()
    {
        lv_list._lv1.SetActive(false);
        lv_list._lv2.SetActive(true);
        lv_list._lv3.SetActive(false);
        PlayerPrefs.SetInt("level", 2);
    }
    public void Level3()
    {
        lv_list._lv1.SetActive(false);
        lv_list._lv2.SetActive(false);
        lv_list._lv3.SetActive(true);
        PlayerPrefs.SetInt("level", 3);
    }

    public void Level4()
    {
        lv_list._lv1.SetActive(false);
        lv_list._lv2.SetActive(false);
        lv_list._lv3.SetActive(false);
        lv_list._lv4.SetActive(true);
    }

    public void Back()
    {
        lv_list._lv1.SetActive(false);
        lv_list._lv2.SetActive(false);
        lv_list._lv3.SetActive(false);
        lv_list._lv4.SetActive(false);
        lv_list.lvlText.text = "Level " + PlayerPrefs.GetInt("level");
    }

    public void StartToGame()
    {
        if (PlayerPrefs.GetInt("level") == 0)
        {
            lv_list._lv1.SetActive(true);
            lv_list._lv2.SetActive(false);
            lv_list._lv3.SetActive(false);
        }

        if (PlayerPrefs.GetInt("level") == 1)
        {
            lv_list._lv1.SetActive(false);
            lv_list._lv2.SetActive(true);
            lv_list._lv3.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level") == 2)
        {

            lv_list._lv1.SetActive(false);
            lv_list._lv2.SetActive(false);
            lv_list._lv3.SetActive(true);
        }

        if (PlayerPrefs.GetInt("level") == 3)
        {

            lv_list._lv1.SetActive(false);
            lv_list._lv2.SetActive(false);
            lv_list._lv3.SetActive(false);
            lv_list._lv4.SetActive(true);
        }

    }
    #endregion

}
