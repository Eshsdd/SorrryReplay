using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumoManager : MonoBehaviour
{

    //game objects
    public GameObject SumoPawn;
    public GameObject SumoStage;
    public GameObject ImageTargetObject;

    //lists
    public List<GameObject> SumoFightList;


    // Start is called before the first frame update
    void Start()
    {

        SumoFightList = new List<GameObject>();

        SumoSummon(SumoFightList, SumoPawn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SumoSummon(List<GameObject> listType, GameObject pawn)
    {
        float stageCenterX = SumoStage.GetComponent<Renderer>().bounds.center.x;
        float stageCenterZ = SumoStage.GetComponent<Renderer>().bounds.center.z;

        float stageWidth = SumoStage.GetComponent<Renderer>().bounds.size.x;
        float stageLength = SumoStage.GetComponent<Renderer>().bounds.size.z;
        float stageHeight = SumoStage.GetComponent<Renderer>().bounds.size.y;

        float pawnHeight = pawn.GetComponent<Renderer>().bounds.size.y;

        listType.Add((GameObject)Instantiate(pawn, new Vector3(stageCenterX + (stageWidth / 3), stageHeight + (pawnHeight / 2), stageCenterZ + (stageLength / 3)), Quaternion.Euler(0, 0, 0), ImageTargetObject.transform));
        listType.Add((GameObject)Instantiate(pawn, new Vector3(stageCenterX - (stageWidth / 3), stageHeight + (pawnHeight / 2), stageCenterZ - (stageLength / 3)), Quaternion.Euler(0, 0, 0), ImageTargetObject.transform));


    }
}
