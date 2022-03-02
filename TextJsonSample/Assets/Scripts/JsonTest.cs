using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using UnityEngine;

public class JsonTest : MonoBehaviour
{
    private void Start()
    {
        var data = new TestData()
        {
            Name = "Mike",
            Age = 5,
            IsMen = true,
        };

        var json = JsonSerializer.Serialize(data);
        Debug.Log(json);
        var revertData = JsonSerializer.Deserialize<TestData>(json);
    }
}

public class TestData
{
    public string Name { get; set; }
    public int Age { get; set; }
    public bool IsMen { get; set; }
}
