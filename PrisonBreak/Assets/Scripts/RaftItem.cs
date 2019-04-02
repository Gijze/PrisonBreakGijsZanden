using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaftItem : Item
{
    public GameObject Part1;
    public GameObject Part2;
    public int points;

    public RaftItem(string name, float weight, int points) : base(name, weight)
    {
        this.points = points;
    }
}
