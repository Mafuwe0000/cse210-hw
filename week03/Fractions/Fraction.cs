class Fraction
{
    private int _top;
    private int _bottom;

    //Constructors

    public Fraction ()
    {
        _bottom = 1;
        _top = 1;

    }

    public Fraction (int wholeNumber)
    {
         _top= wholeNumber ;
        _bottom = 1;

    }

    public Fraction (int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //Get and setters

    public int GetTopValue()
        {
            return _top;
        }
        public int GetBottomValue( )
        {
            return _bottom;
        }

        public void SetTopValue( int TopValue)
        {
            _top = TopValue;
        }
        public void SetBottomValue( int BottomValue)
        {
            _bottom = BottomValue;
        }


        //Creation of methods to return the representation

        public string GetFractionString ( )
        {
            string text =$"{_top}/{_bottom}";
            return text;
        }

        public double GetDecimalValue ()
        {
            return (double)_top/ (double)_bottom;
        }
}