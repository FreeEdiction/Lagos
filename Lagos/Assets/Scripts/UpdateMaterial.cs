using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateMaterial : MonoBehaviour
{
    public Material material;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateMaterialClick()
    {
        GameObject model = GameObject.Find("Model");
        model.GetComponent<MeshRenderer>().material = material;
    }

}
