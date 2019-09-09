using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialSelection : MonoBehaviour
{
    public GameObject CreationButton;
    public GameObject UpdateMaterialButton;

    Dictionary<string, Material> materials;
    // Start is called before the first frame update
    void Start()
    {
        DataSelection data = new DataSelection();
        materials = data.GetMaterials();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectMaterial()
    {
        Material mat = materials[gameObject.name];
        CreationButton.GetComponent<Controller>().material = mat;
        UpdateMaterialButton.GetComponent<UpdateMaterial>().material = mat;
    }
}
