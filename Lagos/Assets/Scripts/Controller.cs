using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private GameObject prefab;
    private Material material;
    private Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PressButtonToPlaceModel()
    {
        CreateModel(prefab, material, position);
    }


    private void CreateModel(GameObject prefab, Material materia, Vector3 position)
    {
        if (prefab != null && material != null && position != null)
        {
            Model model = new Model(prefab, material, position);
            model.Initialize();
        }

    }
}
