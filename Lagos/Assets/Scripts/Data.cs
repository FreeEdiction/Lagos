using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSelection
{
    private Dictionary<string, GameObject> pools = new Dictionary<string, GameObject>();
    private Dictionary<string, Material> materials = new Dictionary<string, Material>();

    public void FillPools()
    {
        //pools.Add();
    }

    public void FillMaterials()
    {
        //materials.Add();
    }

    public Dictionary<string, GameObject> GetPools()
    {
        return pools;
    }


    public Dictionary<string, Material> GetMaterials()
    {
        return materials;
    }
}
