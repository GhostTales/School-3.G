import BeautifulSoup;

String text;  // the text to be checked for plagiarism
StringList database;  // the database of known text

void setup() {
  // load the text file into a String[]
  String[] textArray = loadStrings("text.txt");

  // concatenate the String objects in the array into a single String
  text = join(textArray, "");

  // search the text in Google and save the resulting websites to a file
  saveStrings("websites.txt", searchInGoogle(text));

  // load the database of known text from the internet into a StringList
  database = new StringList(loadStrings("websites.txt"));
}

void draw() {
  // iterate over the database of known text
  for (String knownText : database) {
    // check if the known text appears in the text to be checked
    if (text.contains(knownText)) {
      // if it does, print a message indicating that plagiarism was detected
      println("Plagiarism detected: " + knownText);

      // find the index of the plagiarized text in the original text
      int startIndex = text.indexOf(knownText);
      int endIndex = startIndex + knownText.length();

      // calculate the percentage of the original text that is plagiarized
      float percentage = (endIndex - startIndex) / text.length() * 100;

      // print the percentage of plagiarized text
      println("Percentage of plagiarized text: " + percentage + "%");
    }
  }
}

// searches the given text in Google and returns an array of websites
String[] searchInGoogle(String text) {
  // construct the URL for the Google search
  String query = text.replace(" ", "+");
  String url = "https://www.google.com/search?q=" + query;

  // send a GET request to the URL
  response = requests.get(url);

  // parse the response using BeautifulSoup
  soup = new BeautifulSoup(response.text, "html.parser");

  // find all the "a" elements with the "href" attribute
  links = soup.find_all("a", href=True);

 // return the "href" attribute of the links as an array of strings
String[] hrefs = new String[links.length];
int i = 0;
for (String link : links) {
  hrefs[i] = link["href"];
  i++;
}
return hrefs;

}
