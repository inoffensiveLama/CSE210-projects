public class Words{

    //variables
    private List<int> _blackedOutWordsIndex = new List<int>();
    private int _numberOfWords;

    public Words()
    {

    }

    //methods
    public int GetRandomNumber(){
        //create a random Nuber between 1 and the number of words in the string that contains the scripture in the class of Scripture
        Random random = new Random();
        int randomNumber = random.Next(0,_numberOfWords+1);
        return randomNumber;
    }

    public void SetNumberOfWords(string[] scripture){
        //check how many words there are in the string and set the variable to that number
        _numberOfWords = scripture.Length;
    }

    public int GetNumberOfWords(){
        //returns the variable _numberOfWords
        return _numberOfWords;
    }

    public List<int> getBlackedOutWordIndex(){
        //returns the list with all the indexes, where the words should be blacked out
        return _blackedOutWordsIndex;
    }

    public void blackOutWord(){
        //this method will add a random number to the list of indexes that hold where the blacked out words are.
        int blackOutIndex = 0;
        do{
            blackOutIndex = GetRandomNumber();
        }while(_blackedOutWordsIndex.Contains(blackOutIndex));
        _blackedOutWordsIndex.Add(blackOutIndex);
    }

    public int getNumberOfBlackedOutWords(){
        //returns the number of blacked out words, this way we can keep track of how many words are still left
        int numberOfBlackedOutWords = _blackedOutWordsIndex.Count;
        return numberOfBlackedOutWords;
    }
}