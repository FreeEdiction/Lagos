using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyModel : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DeleteModel()
    {
        GameObject model = GameObject.Find("Model");
        Destroy(model);
    }

}
