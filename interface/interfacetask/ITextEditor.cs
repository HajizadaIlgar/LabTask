namespace interfacetask
{
    public interface ITextEditor
    {
        void Open();
        void Write(string text);
        void Save();
        void SaveAndClose(string filename);
    }
    class Word : ITextEditor
    {
        private string _currentText;
        public string CurrentText
        {
            get { return _currentText; }
        }
        public void Open()
        {
            _currentText = string.Empty;
        }
        public void Write(string text)
        {
            _currentText = text;
        }
        public void Save()
        {
            Console.WriteLine(_currentText);
        }
        public void SaveAndClose(string filename)
        {
            Save();
            Console.WriteLine($"C:/Users/Word/{filename}.docx");
        }
    }
    class Notepad : ITextEditor
    {
        private string _currentText;
        public string CurrentText
        {
            get { return _currentText; }
        }
        public void Open()
        {
            _currentText = string.Empty;
        }
        public void Write(string text)
        {
            _currentText = text;
        }
        public void Save()
        {
            Console.WriteLine(_currentText);
        }
        public void SaveAndClose(string filename)
        {
            Save();
            Console.WriteLine($"C:/Users/Desktop/{filename}.txt");
        }
    }
    class WordPad : ITextEditor
    {

        private string _currentText;
        public string CurrentText
        {
            get { return _currentText; }
        }
        public void Open()
        {
            _currentText = string.Empty;
        }
        public void Write(string text)
        {
            _currentText = text;
        }
        public void Save()
        {
            Console.WriteLine(_currentText);
        }
        public void SaveAndClose(string filename)
        {
            Save();
            Console.WriteLine($"C:/Users/Documents/{filename}.txt");
        }
    }


}