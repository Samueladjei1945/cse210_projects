public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

<<<<<<< HEAD
=======
    // Constructor for a single verse
>>>>>>> 0092104ba04b871768374691eb0099207c7025d2
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;
    }

<<<<<<< HEAD
=======
    // Constructor for verse range
>>>>>>> 0092104ba04b871768374691eb0099207c7025d2
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (_startVerse == _endVerse)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }
<<<<<<< HEAD
} 
=======
}
>>>>>>> 0092104ba04b871768374691eb0099207c7025d2
