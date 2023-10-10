public class Scripture{

    //variables
    private string[] _wordsInScripture;

    public Scripture()
    {

    }

    //methods
    public void LoadScripture(){
        //read the file with the name scripture.txt and save the lines to the variable _lines
        List<string> verses = new List<string>();
        string scripture = "";
        string[] lines = File.ReadAllLines("scripture.txt");
        int i = 0;
        foreach (string line in lines){
            if(i>0){
                scripture += ($"{line} ");
            }
            i++;
        }
        _wordsInScripture = scripture.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

    }

    public string[] GetScripture(){
        //return the array _wordsInScripture
        return _wordsInScripture;
    }

    public string GetBlackedOutScripture(List<int> blackedOutWords){
        //accepts a list of integers as an input. The list contains the indexes of the blacked out words. we create an empty string that will save the scripture and an int that keeps track of the index we are iterating through
        string blackedOutScripture = "";
        int i = 0;

        //iterating through each word in the array that holds the whole scripture
        foreach(string word in _wordsInScripture){
            string wordDummy = "";

            //if the index number is in the array of blacked out numbers we add _ instead of the word, if the index is not in the list, we add the word.
            if (blackedOutWords.Contains(i))
            {
                foreach(char c in _wordsInScripture[i]){
                    wordDummy += "_";
                }
                blackedOutScripture += ($"{wordDummy} ");
            }else{
                blackedOutScripture += ($"{_wordsInScripture[i]} ");
            }

            //increase the index number
            i++;
        }

        //return the puzzled together scripture, that has all the words at the blacked out indexes replaced with _ symbols
        return blackedOutScripture;
    }
}