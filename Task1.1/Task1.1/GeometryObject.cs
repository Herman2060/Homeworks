namespace Task1._1
{
    public interface IGeometryObject
    {
        public string Name { get; set; }
        public float Width { get; set; }

        public float Length { get; set; }
        

        public float Square();

    }
}
