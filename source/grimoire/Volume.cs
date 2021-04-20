namespace grimoire
{
    using System.Numerics;

    public class Volume
    {
        /// <summary>
        /// Gets the shape of this volume based on the number of <see cref="Faces"/>.
        /// </summary>
        public Shapes Shape => Faces switch
        {
            0 => Shapes.Point,
            1 => Shapes.Sphere,
            2 => Shapes.Cone,
            3 => Shapes.Cylinder,
            _ => Shapes.Prism
        };

        /// <summary>
        /// Gets or sets the dimensions of this volume.
        /// </summary>
        public Matrix4x4 Size { get; set; } = default;

        /// <summary>
        /// Gets or sets the number of faces this volume has.
        /// </summary>
        public uint Faces { get; set; }
    }
}