class Circle 
{


    private double dia;
    public double diameter
    {
        set {
            this.dia = value; 
            this.calculate(); 
        }

        get { return this.dia; }
    }
    public double circumference;
    public double surface;
    public Circle(double diameter)
    {
        this.diameter = diameter;

    }

    public void calculate()
    {
        double radius = this.diameter / 2;

        this.circumference = Math.PI * this.diameter; 

        this.surface =  Math.PI * (radius * radius);
    }

    
}