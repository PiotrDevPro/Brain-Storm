using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelGen : MonoBehaviour
{
    public static levelGen manage;
    public GameObject[] levelPrefabs;
    public Text lvl;

    private float spawnX = 1f;
    private float tileLength = 1f;
    private int firstPrefabIndex = 0;

    public int count = 0;
    private int counter = 0;

    private List<GameObject> activeTiles;

    private void Awake()
    {
        manage = this;

    }

    void Start()
    {

        //PlayerPrefs.SetInt("level",1);
        activeTiles = new List<GameObject>();
        SpawnTile();
    }

    void SpawnTile()
    {
        GameObject go;
        go = Instantiate(levelPrefabs[0]);
        go.transform.SetParent(transform);
        go.transform.position = new Vector3(0,0,0);
        go.transform.localScale = new Vector3(1,1,1);
        activeTiles.Add(go);
    }
}
