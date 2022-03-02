using System;
using System.Text.Json;
using UnityEngine;

public class JsonTest : MonoBehaviour
{
    private void Start()
    {
        var origin = new TestData()
        {
            Name = "Mike",
            Age = 5,
            IsMen = true,
            Id = Guid.NewGuid(),
        };

        var json = JsonSerializer.Serialize(origin);
        Debug.Log(json);
        var revertData = JsonSerializer.Deserialize<TestData>(json);
        if (revertData != null && origin.Id == revertData.Id) GameObject.CreatePrimitive(PrimitiveType.Cube);
    }
}

public class TestData
{
    public string Name { get; set; }
    public int Age { get; set; }
    public bool IsMen { get; set; }
    public Guid Id { get; set; }
}
