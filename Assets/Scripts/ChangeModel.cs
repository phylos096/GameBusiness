using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeModel : MonoBehaviour
{
    [SerializeField]
    List<GameObject> SetModels = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void change()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

        }
    }
}
