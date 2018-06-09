using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class plotRandom : MonoBehaviour
{
    public GameObject ground;
    //public Terrain terrain;
    List<GameObject> References;
    List<GameObject> References2;
    List<GameObject> References3;
    public int numberOfObjects;
    public int numberOfObjects2;
    public int numberOfObjects3;
    public int total;
    

    private int currentObjects;
    private int currentObjects2;
    private int currentObjects3;
    public GameObject objectToPlace;
    public GameObject objectToPlace2;
    public GameObject objectToPlace3;

    private int groundWidth;
    private int groundLength;
    private int groundPosX;
    private int groundPosZ;

    //numberOfObjects =;
    //InputFieldsn ifl;
    void Start()
    {
        Vector3 groundSize = GetComponent<Collider>().bounds.size;
        References = new List<GameObject>();
        References2 = new List<GameObject>();
        References3 = new List<GameObject>();

        //groundWidth = (int)groundSize.x;
        groundWidth = fromInputToSimulation.Width;
        //groundLength = (int)groundSize.z;
        groundLength = fromInputToSimulation.Length;
        groundPosX = (int)ground.transform.position.x;
        groundPosZ = (int)ground.transform.position.z;
        currentObjects = 0;
        numberOfObjects = fromInputToSimulation.Tree1;
        numberOfObjects2 = fromInputToSimulation.Tree2;
        numberOfObjects3 = fromInputToSimulation.Tree3;
        total = numberOfObjects + numberOfObjects2 + numberOfObjects3;
        int[] posX = new int[total];
        int[] posZ = new int[total];


        //Debug.Log(groundWidth);

        //Debug.Log("Num of object: "+ fromInputToSimulation.Tree1);

        while (currentObjects < numberOfObjects || currentObjects2 < numberOfObjects2 || currentObjects3 < numberOfObjects3)
        {
            if (currentObjects < numberOfObjects)
            {
                int posx = Random.Range((groundPosX - (groundWidth / 2)), (groundPosX + (groundWidth / 2)));
                int posz = Random.Range((groundPosZ - (groundLength / 2)), (groundPosZ + (groundLength / 2)));
                //float posy = Terrain.activeTerrain.SampleHeight(new Vector3(posx, 0, posz));
                // create new gameObject on random position
                //GameObject newObject = Instantiate(objectToPlace, new Vector3(posx, 0, posz), Quaternion.identity);
                References.Add(Instantiate(objectToPlace, new Vector3(posx, 0, posz), Quaternion.identity));
                currentObjects = currentObjects + 1;
                Debug.Log(currentObjects);
            }
            if(currentObjects2 < numberOfObjects2 && inputSceneStatus.tree2isOn)
            {
                int posx = Random.Range((groundPosX - (groundWidth / 2)), (groundPosX + (groundWidth / 2)));
                int posz = Random.Range((groundPosZ - (groundLength / 2)), (groundPosZ + (groundLength / 2)));
                References2.Add(Instantiate(objectToPlace2, new Vector3(posx, 0, posz), Quaternion.identity));
                currentObjects2 = currentObjects2 + 1;
                Debug.Log(currentObjects2);
            }
            if (currentObjects3 < numberOfObjects3 && inputSceneStatus.tree3isOn)
            {
                int posx = Random.Range((groundPosX - (groundWidth / 2)), (groundPosX + (groundWidth / 2)));
                int posz = Random.Range((groundPosZ - (groundLength / 2)), (groundPosZ + (groundLength / 2)));
                References3.Add(Instantiate(objectToPlace3, new Vector3(posx, 0, posz), Quaternion.identity));
                currentObjects3 = currentObjects3 + 1;
                Debug.Log(currentObjects3);
            }
        }
        if (currentObjects == numberOfObjects && currentObjects2 == numberOfObjects2 && currentObjects3 == numberOfObjects3)
        {
            Debug.Log("Generate objects complete!");
        }


    }
    static Vector3 temp;
    static Vector3 temp2;
    static Vector3 temp3;
    static Vector3 init=new Vector3(.1f,.1f,.1f);
    //static int i = 0;
    // Update is called once per frame
    //init.x = .1f;
    //init.y = .1f;
    //init.z = .1f;
    void Update()
    {
        
        for (int i=0;i<References.Count;i++)
        {
            //Debug.Log("Initial: "+ References[1].transform.localScale.y);
            
            References[i].transform.localScale = init;
            if (temp.x<1.5 || temp.y<7 || temp.z<1.5)
            {
                temp = References[i].transform.localScale;
                temp.x += (Time.deltaTime/30);
                temp.y += (Time.deltaTime/30);
                temp.z += (Time.deltaTime/30);
                References[i].transform.localScale=temp;
                init = temp;
            }
            
            //i++;
            /* References[i].transform.localScale = sc;*/
        }

        for (int i = 0; i < References2.Count; i++)
        {
            //Debug.Log("Initial: "+ References[1].transform.localScale.y);

            References2[i].transform.localScale = init;
            if (temp2.x < 1.5 || temp2.y < 7 || temp2.z < 1.5)
            {
                temp2 = References2[i].transform.localScale;
                temp2.x += (Time.deltaTime / 30);
                temp2.y += (Time.deltaTime / 30);
                temp2.z += (Time.deltaTime / 30);
                References2[i].transform.localScale = temp2;
                init = temp2;
            }
        }

        for (int i = 0; i < References3.Count; i++)
        {
            //Debug.Log("Initial: "+ References[1].transform.localScale.y);

            References3[i].transform.localScale = init;
            if (temp3.x < 1.5 || temp3.y < 7 || temp3.z < 1.5)
            {
                temp3 = References3[i].transform.localScale;
                temp3.x += (Time.deltaTime / 30);
                temp3.y += (Time.deltaTime / 30);
                temp3.z += (Time.deltaTime / 30);
                References3[i].transform.localScale = temp3;
                init = temp3;
            }
        }
       // Debug.Log(inputSceneStatus.tree1isOn+"  ssssss"+ inputSceneStatus.tree2isOn + "  ssssss");
    }
}