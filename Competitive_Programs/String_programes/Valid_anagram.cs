


namespace Competitive_Programs.String_programes{

  internal class  Valid_anagram{
    public bool isAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

       int[] count = new int[26];

       foreach(char c in s.ToCharArray())
            ++count[c - 'a'];

       foreach (char c in t.ToCharArray()) 
       {
           if (count[c - 'a'] == 0)
                  return false;
           --count[c - 'a'];
       }

    return true;
    }
  }

}