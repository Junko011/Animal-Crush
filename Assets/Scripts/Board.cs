using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public int width;
    public int height;
    public GameObject titleObject;



    // Start is called before the first frame update
    void Start()
    {
        SetupBoard();
    }


    private void SetupBoard(){
        for(int x=0; x<width; x++){
            for(int y=0; y<height; y++)
            {var o = Instantiate (titleObject, new Vector3(x, y, -5),  Quaternion.identify);
             o.transform.parent = transform;
            }
        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
