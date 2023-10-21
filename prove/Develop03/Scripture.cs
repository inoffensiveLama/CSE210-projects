public class Scripture{

    //variables
    List<Word> _WordsList = new List<Word>();

    Reference _reference = new Reference();

    private int _numberOfWords = 0;

    private int _numberBlackedOutWords = 0;


    public Scripture()
    {

    }

    //methods
    public void LoadScripture(){
        //read the file with the name scripture.txt and save the lines to the variable _lines

        string[] wordsInScripture;
        string scripture = "";
        string[] lines = File.ReadAllLines("scripture.txt");
        int i = 0;
        foreach (string line in lines){
            if(i>0){
                scripture += ($"{line} ");
            }else if(i == 0){
                _reference.SetReference(line);
            }
            i++;
        }
        wordsInScripture = scripture.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        
        i = 0;

        foreach(string wordFromArray in wordsInScripture){
            Word Word = new Word(wordFromArray);
            _WordsList.Add(Word);
            i++;
        }
        _numberOfWords = i;
    }

    public string GetScripture(){
        //return the scripture as a string
        string scripture = "";
        scripture += ($"{_reference.GetReference()}\n");
        foreach(Word word in _WordsList){
            scripture += ($"{word.GetWord()} ");
        }

        return scripture;
    }

    public int GetNumberOfWords(){
        return _numberOfWords;
    }

    public int GetNumberOfBlackedOutWords(){
        return _numberBlackedOutWords;
    }

    public void CountBlackedOutWords(){
        int i = 0;
        foreach(Word word in _WordsList){
            if (!word.GetVisibility()){
                i++;
            }
        }

        _numberBlackedOutWords = i;
    }

    public void BlackOutRandomWord(){
        Random random = new Random();
        
        bool successfullyBlackedOut = false;

        while(!successfullyBlackedOut){
            int randomNumber = random.Next(0, _numberOfWords);
            if(_WordsList[randomNumber].GetVisibility()){
                _WordsList[randomNumber].SetVisibilityToFalse();
                successfullyBlackedOut = true;
            }
        }

    }

    
}