using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    private Dictionary<string, GameObject> pools;
    private Dictionary<string, Material> materials;

    // Start is called before the first frame update
    void Start()
    {
        pools = new Dictionary<string, GameObject>();
        materials = new Dictionary<string, Material>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FillPools()
    {
        //pools.Add();
    }

    public void FillMaterials()
    {
        //materials.Add();
    }
}
