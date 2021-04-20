using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace grimoire
{
    public enum Shapes
    {
        /// <summary>
        /// No shape.
        /// </summary>
        Point = 0,
        /// <summary>
        /// Spherical shape.
        /// </summary>
        Sphere = 1,
        /// <summary>
        /// Conical shape.
        /// </summary>
        Cone = 2,
        /// <summary>
        /// Cylindrical shape.
        /// </summary>
        Cylinder = 3,
        /// <summary>
        /// Prism shape of at least 4 sides.
        /// </summary>
        Prism = 4
    }
}