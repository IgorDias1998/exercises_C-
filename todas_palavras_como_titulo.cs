using System.Globalization;

public static class PhraseCase
{
  public static string ToPhraseCase(this string phrase)
  {
    TextInfo textInfo = new CultureInfo("pt-BR", false).TextInfo;
    return textInfo.ToTitleCase(phrase);
  }
}

/* Exemplo:

Futuros desenvolvedores de software
Futuros Desenvolvedores De Software

*/
