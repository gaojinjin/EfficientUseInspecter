using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class TestInspector : MonoBehaviour
{
    [HideInInspector]
    public int age;
    //[SerializeField]
    private int year;
    public string[] names;
    [Space(50)]
    public Vector2[] vector2s;
    public Dictionary<int, string> info = new Dictionary<int, string>();
    [Header("成绩信息")]
    public List<int> scores = new List<int>();
    [Tooltip("提示信息")]
    public StudentInfo studentInfo;
    [Range(-10f,100)]
    public float audioV;
    public Texture[] textures;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
[Serializable]
public class StudentInfo {
    public int id;
    public string name;
    public float score;
    public HomeInfo homeInfo;
}
[Serializable]
public class HomeInfo {
    public string address;
}