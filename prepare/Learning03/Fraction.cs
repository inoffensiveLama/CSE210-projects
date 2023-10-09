public class Fraction{
    //attributes
    private int _top;
    private int _bottom;

    //constructors
    public Fraction()
    {

    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //methods
    public int GetTopNumber(){
        return _top;
    }

    public void SetTopNumber(int top){
        _top = top;
    }

    public int GetBottomNumber(){
        return _bottom;
    }

    public void SetBottomNumber(int bottom){
        _bottom = bottom;
    }

    public string GetFractionString(){
        return ($"{_top}/{_bottom}");
    }

    public double GetDecimalValue(){
        return (double)_top/(double)_bottom;
    }
}