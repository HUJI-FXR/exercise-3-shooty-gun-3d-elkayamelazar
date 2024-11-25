using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterControlScript : MonoBehaviour
{
    [SerializeField] private float monsterTimer;
    [SerializeField] private float monsterTime;
    [SerializeField] private float chasePlayerChance;
    [SerializeField] private GameObject player;
    [SerializeField] private bool chasePlayer;
    // Start is called before the first frame update
    void Start()
    {
        chasePlayer = true;
    }

    // Update is called once per frame
    void Update()
    {
        float chance = 0f;
        monsterTimer += Time.deltaTime;
        Vector3 direction = Vector3.forward;
        GetComponent<MovmentScript>().direction = direction;
        if (monsterTimer >= monsterTime)
        {
            monsterTimer = 0;
            chance = Random.Range(0, 1f);

        }
        if( chance < chasePlayerChance)
        {
            chasePlayer = true;
        }
        if (chasePlayer)
        {
            Vector3 playerPosition = player.transform.position - transform.position;
            float directionAngle = Vector3.Angle(playerPosition, Vector3.forward);
            Debug.Log(directionAngle);
            transform.Rotate(0,directionAngle, 0);
        }

    }
}
