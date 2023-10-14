public class Entry{
        
        //Menu variables
        public string _date = "";
        public string _prompt = "";
        public string _response = "";


        public Entry()
        {

        }
        //methods
        public string getDisplayMenu(){
            //returns a single string of the stored date, prompt and response
            string displayString = _date + _prompt + _response;
            return displayString;
        }

}