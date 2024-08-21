using NUnit.Framework.Internal;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.Events;

namespace MyCode
{
    public class GameManager : MonoBehaviour
    {
        private static GameManager instance;
        public GameObject activePlayer;
        public GameObject playerPrefab;
        public bool isPlaying;

        // Start is called before the first frame update
        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public static GameManager GetInstance()
        {
            return instance;
        }

        // Update is called once per frame
        void Start()
        {
           
        }

        private void spawnPlayer()
        {
            activePlayer = Instantiate(playerPrefab);
        }

        public Vector3 getPlayerPosition()
        {
            if(activePlayer != null)
            {
                return activePlayer.transform.position;
            }
            return Vector3.zero;
        }

        public void startGame()
        {
            isPlaying = true;
            spawnPlayer();
        }

        public void resumeGame()
        {
            isPlaying = true;
            Time.timeScale = 1.0f;
        }

        public void pauseGame()
        {
            isPlaying = false;
            Time.timeScale = 0.0f;
        }

        public UnityAction OnGameOverAction;
        internal void gameOver()
        {
             isPlaying = false;
             OnGameOverAction?.Invoke();
        }

        public MyScriptableInteger life;
        public MyEnemySpawner spawner;

        internal void retry()
        {
            life.reseet();
            spawner.clearEnemy();
            MyObjectPool.GetInstance().deactivateAllObject();
            clearAllItem();
        }

        public List<GameObject> item;
        
        internal void addItem(GameObject gameObject)
        {
            item.Add(gameObject);
        }

        public void clearAllItem()
        {
            foreach(GameObject go in item)
            {
                Destroy(go);
            }
            item.Clear();
        }

    }
}
