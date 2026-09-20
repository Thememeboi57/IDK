namespace PigLatinTranslator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string TranslateWord(string word)
        {
            //Seperate puncuation from the word
            string puncuation = "";
            while (word.Length > 0 && !char.IsLetter(word[word.Length - 1]))
            {
                puncuation = word[word.Length - 1] + puncuation;
                word = word.Substring(0, word.Length - 1);
            }
            // Don't translate empty words
            if (word.Length == 0)
            {
                return puncuation;
            }
            // Don't translate words containing numbers or symbols
            foreach (char c in word)
            {
                if (!char.IsLetter(c) && c != '\'')
                {
                    return word + puncuation;
                }
            }
            // Remember the original capitalization
            bool allUpper = word == word.ToUpper();
            bool titleCase = char.IsUpper(word[0]) &&
                word.Substring(1) == word.Substring(1).ToLower();
            string lowerWord = word.ToLower();

            // Find the first vowel
            int vowelIndex = -1;
            for (int i = 0; i < lowerWord.Length; i++)
            {
                char c = lowerWord[i];
                if ("aeiou".Contains(c) || (c == 'y' && i > 0))
                {
                    vowelIndex = i;
                    break;
                }
            }
            string result;

            // word starts with a vowel
            if (vowelIndex == 0)
            {
                result = lowerWord + "way";
            }
            // word starts with consonants
            else if (vowelIndex > 0)
            {
                result = lowerWord.Substring(vowelIndex) + lowerWord.Substring(0, vowelIndex) + "ay";
            }
            else
            {
                result = lowerWord + "ay";
            }
            // Apply the original capitalization
            if (allUpper)
            {
                result = result.ToUpper();
            }
            else if (titleCase)
            {
                result = char.ToUpper(result[0]) + result.Substring(1);
            }
            return result + puncuation;
        }
        private void btnTranslate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                MessageBox.Show("Please enter some text.", "Pig Latin Translator");
                txtInput.Focus();
                return;
            }
            string[] words = txtInput.Text.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.None);
            for (int i = 0; i < words.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(words[i]))
                {
                    words[i] = TranslateWord(words[i]);
                }
            }
            txtOutput.Text = string.Join(" ", words);
            txtInput.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();

            txtInput.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
