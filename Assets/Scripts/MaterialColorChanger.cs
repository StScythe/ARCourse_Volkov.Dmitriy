using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[AddComponentMenu("ARCourse/MaterialColorChanger")]
[RequireComponent(typeof(MeshRenderer))]

public class MaterialColorChanger : MonoBehaviour
{
    private MeshRenderer _meshRenderer;
    [SerializeField] private Color _color;

    // Start is called before the first frame update
    void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _meshRenderer.material.color = _color;
    }
}
