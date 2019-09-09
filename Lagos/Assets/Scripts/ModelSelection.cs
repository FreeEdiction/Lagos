using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelSelection : MonoBehaviour
{
    public GameObject CreationButton;

    DataSelection data;
    Dictionary<string, GameObject> pools;

    // Start is called before the first frame update
    void Start()
    {
        data = new DataSelection();
        pools = data.GetPools();
        
    }


    public void SelectModel()
    {
        CreationButton.GetComponent<Controller>().prefab = pools[gameObject.name];
    }
}
