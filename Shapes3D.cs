using System;
using Shapes;

namespace Shapes3D {

  public abstract class Shape3D {
    // Method for surface area
    public abstract double GetSurfaceArea();

    // Method for volume
    public abstract double GetVolume();
  }

  //First Shape Cuboid
  class Cuboid : Shape3D
  {
    public double depth;
    
    public double width;

    public double height;

    public Cuboid(double depth, double width, double height)
    {
        this.width = width;
        this.height = height;
        this.depth = depth;
    }

    //Surface area of a cuboid
    //(TSA) = 2 (lw + wh + lh) square units
    override public double GetSurfaceArea()
    {
        return 2 * (depth * width + width * height + height * depth);
    }
  }

  class Cuboid : Shape3D {
    public Shapes.Cuboid base;
    public double depth;

    public Cuboid(double height, double width, double depth) {
      this.base = new Shapes.Rectangle(height, width);
      this.depth = depth;
    }

    public override double GetSurfaceArea() {
      // Getting the area of both bases
      double baseArea = 2 * this.base.GetArea();
      // Finding the area of the perimiter times the depth
      // https://proof.com
      double sides = this.base.GetPerimeter() * this.depth;

      return sides + baseArea;
    }

    public override double GetVolume() {
      return this.base.GetArea() * this.depth;
    }
  }

}