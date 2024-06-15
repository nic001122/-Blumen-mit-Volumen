using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Prefabs
    [SerializeField] GameObject samuelEnemyPrefab;
    [SerializeField] GameObject blueEnemyPrefab;
    [SerializeField] GameObject smallWaspEnemyPrefab;
    [SerializeField] GameObject brownEnemyPrefab;
    [SerializeField] GameObject bigWaspEnemyPrefab;

    // Spawning
    public GameObject spawnLocation;
    [SerializeField] float enemySpawnRadius = 50;
    [SerializeField] float noEnemyRadius = 25;

    [SerializeField] private float interval;
    private float count = 0f;

    int roll;
    [SerializeField] int round = 1;
    int roundLength;
    int tempRoundLength;


    // Update is called once per frame
    private void Update()
    {    
        if(round == 1 && tempRoundLength <= roundLength)
        {
            SetVars(5, 8);  // float interval, int roundlength

            if(tempRoundLength < roundLength)
            {
                count += Time.deltaTime;
                if(count >= interval)
                {
                    FirstRoundRandom();
                    tempRoundLength++;
                    count = 0;
                }
            }
            if(tempRoundLength == roundLength)
            {
                tempRoundLength = 0;
                roundLength++;
                round++;
            }
        }

        if(round == 2 && tempRoundLength <= roundLength)
        {
            SetVars(3.75f, 10);

            if(tempRoundLength < roundLength)
            {
                count += Time.deltaTime;
                if(count >= interval)
                {
                    SecondRoundRandom();
                    tempRoundLength++;
                    count = 0;
                }
            }
            if(tempRoundLength == roundLength)
            {
                tempRoundLength = 0;
                roundLength++;
                round++;
            }
        }

        if(round == 3 && tempRoundLength <= roundLength)
        {
            SetVars(3, 5);
            
            if(tempRoundLength < roundLength)
            {
                count += Time.deltaTime;
                if(count >= interval)
                {
                    ThirdRoundRandom();
                    tempRoundLength++;
                    count = 0;
                }
            }
            if(tempRoundLength == roundLength)
            {
                tempRoundLength = 0;
                roundLength++;
                round++;
            }
        }

        if(round == 4 && tempRoundLength <= roundLength)
        {
            SetVars(3, 7);
            
            if(tempRoundLength < roundLength)
            {
                count += Time.deltaTime;
                if(count >= interval)
                {
                    FourthRoundRandom();
                    tempRoundLength++;
                    count = 0;
                }
            }
            if(tempRoundLength == roundLength)
            {
                tempRoundLength = 0;
                roundLength++;
                round++;
            }
        }

        if(round == 5 && tempRoundLength <= roundLength)
        {
            SetVars(3, 7);
            
            if(tempRoundLength < roundLength)
            {
                count += Time.deltaTime;
                if(count >= interval)
                {
                    FifthRoundRandom();
                    tempRoundLength++;
                    count = 0;
                }
            }
            if(tempRoundLength == roundLength)
            {
                tempRoundLength = 0;
                roundLength++;
                round++;
            }
        }

        if(round == 6 && tempRoundLength <= roundLength)
        {
            SetVars(3, 7);
            
            if(tempRoundLength < roundLength)
            {
                count += Time.deltaTime;
                if(count >= interval)
                {
                    SixthRoundRandom();
                    tempRoundLength++;
                    count = 0;
                }
            }
            if(tempRoundLength == roundLength)
            {
                tempRoundLength = 0;
                roundLength++;
                round++;
            }
        }

        if(round == 7 && tempRoundLength <= roundLength)
        {
            SetVars(3, 7);
            
            if(tempRoundLength < roundLength)
            {
                count += Time.deltaTime;
                if(count >= interval)
                {
                    SeventhRoundRandom();
                    tempRoundLength++;
                    count = 0;
                }
            }
            if(tempRoundLength == roundLength)
            {
                tempRoundLength = 0;
                roundLength++;
                round++;
            }
        }

        if(round == 8 && tempRoundLength <= roundLength)
        {
            SetVars(3, 7);
            
            if(tempRoundLength < roundLength)
            {
                count += Time.deltaTime;
                if(count >= interval)
                {
                    EighthRoundRandom();
                    tempRoundLength++;
                    count = 0;
                }
            }
            if(tempRoundLength == roundLength)
            {
                tempRoundLength = 0;
                roundLength++;
                round++;
            }
        }

        if(round == 9 && tempRoundLength <= roundLength)
        {
            SetVars(3, 7);
            
            if(tempRoundLength < roundLength)
            {
                count += Time.deltaTime;
                if(count >= interval)
                {
                    NinthRoundRandom();
                    tempRoundLength++;
                    count = 0;
                }
            }
            if(tempRoundLength == roundLength)
            {
                tempRoundLength = 0;
                roundLength++;
                round++;
            }
        }

        if(round >= 10)
        {
            count += Time.deltaTime;
            if(count >= interval)
            {
                FinalRoundRandom();
                count = 0;
            }
        }
    }

    void RollDie()
    {
        roll = Random.Range(1, 101);
    }

    void FirstRoundRandom()
    {
        RollDie();
        if(roll > 0 && roll <= 100)
        {
            RandomTypeOneEnemy();
        }
    }

    void SecondRoundRandom()
    {
        RollDie();
        if(roll > 0 && roll <= 100)
        {
            RandomTypeOneEnemy();
        }
    }

    void ThirdRoundRandom()
    {
        RollDie();
        if(roll > 0 && roll <= 80)
        {
            RandomTypeOneEnemy();
        }
        else
        {
            BrownSpawnEnemy();
        }
    }

    void FourthRoundRandom()
    {
        RollDie();
        if(roll > 0 && roll <= 60)
        {
            RandomTypeOneEnemy();
        }
        else
        {
            BrownSpawnEnemy();
        }
    }

    void FifthRoundRandom()
    {
        RollDie();
        if(roll > 0 && roll <= 40)
        {
            RandomTypeOneEnemy();
        }
        else
        {
            BrownSpawnEnemy();
        }
    }

    void SixthRoundRandom()
    {
        RollDie();
        if(roll > 0 && roll <= 40)
        {
            RandomTypeOneEnemy();
        }
        else if(roll > 40 && roll <= 90)
        {
            BrownSpawnEnemy();
        }
        else
        {
            BigWaspSpawnEnemy();
        }
    }

    void SeventhRoundRandom()
    {
        RollDie();
        if(roll > 0 && roll <= 40)
        {
            RandomTypeOneEnemy();
        }
        else if(roll > 40 && roll <= 70)
        {
            BrownSpawnEnemy();
        }
        else
        {
            BigWaspSpawnEnemy();
        }
    }

    void EighthRoundRandom()
    {
        RollDie();
        if(roll > 0 && roll <= 30)
        {
            RandomTypeOneEnemy();
        }
        else if(roll > 30 && roll <= 70)
        {
            BrownSpawnEnemy();
        }
        else
        {
            BigWaspSpawnEnemy();
        }
    }

    void NinthRoundRandom()
    {
        RollDie();
        if(roll > 0 && roll <= 20)
        {
            RandomTypeOneEnemy();
        }
        else if(roll > 20 && roll <= 50)
        {
            BrownSpawnEnemy();
        }
        else
        {
            BigWaspSpawnEnemy();
        }
    }

    void FinalRoundRandom()
    {
        RollDie();
        if(roll > 0 && roll <= 5)
        {
            RandomTypeOneEnemy();
        }
        else if(roll > 5 && roll  <= 30)
        {
            BrownSpawnEnemy();
        }
        else
        {
            BigWaspSpawnEnemy();
        }
    }



    void SetVars(float _interval, int _roundLength)
    {
        interval = _interval;
        roundLength = _roundLength;
    }

    void RandomTypeOneEnemy()
    {
        roll = Random.Range(1, 4);
        switch(roll)
        {
            case 1:
                BlueSpawnEnemy();
                break;
            case 2:
                SmallWaspSpawnEnemy();
                break;
            case 3:
                SamuelSpawnEnemy();
                break;
        }
    }



    void CheckSpawnLocation()
    {
        spawnLocation.transform.position = Random.insideUnitCircle * enemySpawnRadius;

        if(spawnLocation.transform.position.x <= noEnemyRadius && spawnLocation.transform.position.y <= noEnemyRadius)
        {
            CheckSpawnLocation();
        }

    }


    void SamuelSpawnEnemy()
    {
        CheckSpawnLocation();
        Instantiate(samuelEnemyPrefab, spawnLocation.transform.position, transform.rotation);
    }

    void BlueSpawnEnemy()
    {
        CheckSpawnLocation();
        Instantiate(blueEnemyPrefab, spawnLocation.transform.position, transform.rotation);
    }

    void SmallWaspSpawnEnemy()
    {
        CheckSpawnLocation();
        Instantiate(smallWaspEnemyPrefab, spawnLocation.transform.position, transform.rotation);
    }

    void BrownSpawnEnemy()
    {
        CheckSpawnLocation();
        Instantiate(brownEnemyPrefab, spawnLocation.transform.position, transform.rotation);
    }

    void BigWaspSpawnEnemy()
    {
        CheckSpawnLocation();
        Instantiate(bigWaspEnemyPrefab, spawnLocation.transform.position, transform.rotation);
    }
}
