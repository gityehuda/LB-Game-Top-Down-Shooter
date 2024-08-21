using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyEnemySpawner : MonoBehaviour
{
    [Header("Nilai X Kiri dan Kanan Spawner")]
    public float leftX;
    public float RightX;
    public MyObjectSpawnRate[] enemy;
    [SerializeField] List<GameObject> enemyList;

    [Header("Delay Waktu Spawn")]
    public int delay;

    // Start is called before the first frame update
    void Start()
    {
        enemyList = new List<GameObject>();
        StartCoroutine(spawner());
    }

    private IEnumerator spawner()
    {
        while(true)
        {
            if(MyCode.GameManager.GetInstance().isPlaying == true)
            {
                Spawn();
                yield return new WaitForSeconds(delay);
            }
            else
            {
                yield return new WaitForSeconds(delay);
            }
        }
    }

    public void Spawn()
    {
        Vector3 newPosition = transform.position;
        newPosition.x = Random.Range(leftX, RightX);
        enemyList.Add(Instantiate(getEnemy(), newPosition, Quaternion.Euler(new Vector3(0, 0, 270))));
    }

    private GameObject getEnemy()
    {
        int limit = 0;

        foreach(MyObjectSpawnRate osr in enemy)
        {
            limit += osr.rate;
        }

        int random = Random.Range(0, limit);

        foreach(MyObjectSpawnRate osr in enemy)
        {
            if(random < osr.rate)
            {
                return osr.prefab;
            }
            else
            {
                random -= osr.rate;
            }
        }
        return null;
    }

    public void clearEnemy()
    {
        foreach(GameObject go in enemyList)
        {
            Destroy(go);
        }
        enemyList.Clear();

    }

}
