using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[AddComponentMenu("ARCourse/SampleScript")]

public class SampleScript : MonoBehaviour
{
    public List<SomeData> Data;

    public int IntValue = 10;
    public float FloatValue = 152;
    public double DoubleValue = 600;
    public string StringValue = "Start";
    public bool BoolValue = false;
    [Header("Color for material")]
    [TooltipAttribute("This color for materials")]
    public Color Color = Color.green;
    public SampleScript SampleComponent;
    [Space(10)]

    [HideInInspector] public float HiddenFloat;

    [SerializeField][Range(1.0f, 10.0f)] private float _privateFloatValue;
    [SerializeField] private MessageLogger _logger;

    private Dictionary<string, float> _dict = new Dictionary<string, float>();

    // Start is called before the first frame update
    private void Start()
    {
        foreach (var item in Data)
        {
            _dict.Add(item.Key, item.Data);
        }
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.Log($"IntValue {IntValue}");
        Debug.Log($"FloatValue {FloatValue}");
        Debug.Log($"DoubleValue {DoubleValue}");
        Debug.Log($"StringValue {StringValue}");
        Debug.Log($"BoolValue {BoolValue}");
    }

    [Serializable]
    public struct SomeData
    {
        public string Key;
        public float Data;
    }
}
