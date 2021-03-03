namespace Interfaces_2
{

    class Shape:InterfaceObject
    {



        private double _height;
        private double _width;

        public double Height { get; set; }
        public double Width { get; set; }

        public Shape(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }
        public double Calculate()
        {
            return Height * Width;
        }
        public override string ToString()
        {
            return "Surface is : " + Height * Width + "m²";
        }
    }
}
