using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{

    float timer;
    List<GameObject> boxPrefabList = new List<GameObject>();
    public GameObject boxS;
    public GameObject boxM;
    public GameObject boxL;

    // Update is called once per frame
    void Update(){
        timer += Time.deltaTime;
        if(timer >= 2f)
        {
            timer = 0;
            boxPrefabList.Add(boxS);
            boxPrefabList.Add(boxM);
            boxPrefabList.Add(boxL);

            int prefabIndex = UnityEngine.Random.Range(0, boxPrefabList.Count - 1);
            Instantiate(boxPrefabList[prefabIndex]);
        }
    }
}
