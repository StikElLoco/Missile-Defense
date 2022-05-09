using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private GameObject[] buildingsObj;
    public Vector3[] buildingsPos;
    private int buildingsIndex;

    private void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        buildingsObj = GameObject.FindGameObjectsWithTag("Building");
        buildingsPos = new Vector3[buildingsObj.Length];
        
        for (int i = 0; i < buildingsObj.Length; i++)
        {
            buildingsPos[i] = buildingsObj[i].transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector3 AcquireTarget()
    {
        Vector3 target = buildingsPos[Random.Range(0,buildingsPos.Length)];
        target.z = 0;
        return target;
    }
}
