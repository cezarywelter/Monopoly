using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{

    public Route currentRoute;

    int routePosition;

    public int steps;

    bool isMoving;
    public bool IsInPosition;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && !isMoving)
        {
            steps = Random.Range(1, 7);
            Debug.Log("Dice rolled " + steps);

            StartCoroutine(Move());        
        }
    }

    IEnumerator Move()
    {
        if(isMoving)
        {
            yield break;
        }
        isMoving = true;

        while(steps>0)
        {

            routePosition++;
            routePosition %= currentRoute.childNodeList.Count;

            Vector3 nextPos = currentRoute.childNodeList[routePosition].position;
            while (MoveToNextNode(nextPos)) { yield return null; }

            yield return new WaitForSeconds(0.1f);
            steps--;
            //routePosition++;

        }
        var a = GameManager.Instance.listofstones;
        foreach (var item in a)
        {
            item.GetComponent<Collider>().enabled = true;
            item.GetComponent<Collider>().isTrigger = true;
        }
        isMoving = false;
    }

    bool MoveToNextNode(Vector3 target)
    {
        return target != (transform.position = Vector3.MoveTowards(transform.position, target, 2f * Time.deltaTime));
            
    }
}
