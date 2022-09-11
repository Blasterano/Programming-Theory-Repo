using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{

    // Start is called before the first frame update
    void Start()
    {
        shapeName = "cylinder";
    }

    // Update is called once per frame
    void Update()
    {
        SecondaryInput();
    }

    public override void Description()
    {
        gameManager.shapeName.text = shapeName;
        gameManager.shapeDescription.text = "This is a CYLINDER.\n" +
            "a solid geometrical figure with straight parallel sides and a circular or oval cross section.\n" +
            "Total Surface Area: 2*pi*r^2 + 2*pi*r*h\n" +
            "Volume: pi*r^2*h";
    }
}
