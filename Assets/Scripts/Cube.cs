using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        shapeName = "cube";
    }

    // Update is called once per frame
    void Update()
    {
        SecondaryInput();
    }

    // POLYMORPHISM
    public override void Description()
    {
        string description = "This is a CUBE.\n" +
             "It has 6 Faces, 12 Edges, 12 Vertices.\n" +
             "Its 2D form is a SQUARE.\n" +
             "Total Surface Area: 6*(side)^2\n" +
             "Volume: (side)^3";
        gameManager.SetShapeProperties(shapeName,description);
    }
}
