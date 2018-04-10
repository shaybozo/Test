public class CensoredStringTokenizerDemo {
    
    public static void main(String[] args) {

             String text = "eat the apple or the banana but not the sushi";
             String[] censoredWords = {"the", "and" , "or", "not"};

             CensoredStringTokenizer cst =
                           new CensoredStringTokenizer(text, censoredWords);
             
             while (cst.hasMoreTokens()) {
               System.out.println(cst.nextToken());
             }
    }
 }

public class CensoredStringTokenizer
{
    private const string DELEMITER { get; set; }

    private List<string> m_tokens { get; set; }

    public CensoredStringTokenizer(string text, string[] censoredWords)
    {
        m_tokens = new List<string>();
        string[] words = phrase.Split(DELEMITER);
        m_tokens.AddRange(words);
        m_tokens.ReomveAll(token => censoredWords.Contains(token));
    }

    public bool hasMoreTokens()
    {
        bool result = m_tokens != null && m_tokens.Any();
    }

    public string nextToken()
    {
        string result = null;

        if(hasMoreTokens())
        {
            result = m_tokens.First();
            m_tokens.RemoveAt(0);
        }
        else
        {
            throw new Excption("No more tokens");
        }

        return result;
    }
}