using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{

    // Start is called before the first frame update
    void Start()
    {
        shapeName = "sphere";
    }

    // Update is called once per frame
    void Update()
    {
        SecondaryInput();
    }

    public override void Description()
    {
        gameManager.shapeName.text = shapeName;
        gameManager.shapeDescription.text = "This is a Sphere.\n" +
            "Every point on its surface are equidistant from its centre.\n" +
            "Its 2D form is a Circle.\n" +
            "Total Surface Area: 4*pi*r^2\n" +
            "Volume: 4/3*r^3";
    }
}
