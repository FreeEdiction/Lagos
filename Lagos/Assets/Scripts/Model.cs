using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model
{
    private GameObject pool;
    private Material material;
    private Vector3 position;

    public Model(GameObject pool, Material material, Vector3 position)
    {
        this.material = material;
        this.pool = pool;
        this.position = position;
    }


    public void Initialize()
    {
        GameObject poolModel = GameObject.Instantiate(pool);
        poolModel.name = "Model";
        poolModel.GetComponent<MeshRenderer>().material = material;
        poolModel.transform.position = position;
    }


}
