public class Word{

    //variables
    private string _word = "";
    private bool _visible = true;

    public Word(string word)
    {
        _word = word;
    }

    //methods

    public string GetWord(){
        //returns the variable _word if _visible is true, if not it will return _ equal to the number of letters in the word
        
        if(_visible){
            return _word;
        }else{
            string blackedOutWord = "";
            foreach(char c in _word){
                    blackedOutWord += "_";
                }
            return blackedOutWord;
        }
        
    }


    public bool GetVisibility(){
        //returns the bool that defines if the word is visible or not
        return _visible;
    }

    public void SetVisibilityToFalse(){
        _visible = false;
    }
}