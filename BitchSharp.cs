import bitches;
using bitches.lbozo;
using bitches;

public class BitchSharp
{
  public void GetBitches()
  {
    return null;
  }

  public Bitches fairMadensTest(string name)
  {
    if(Bitches.bitchList.Contains(name))
    {
      try{
          Bitches.bitchlist.getIndex(name).stab();
      }catch
      {
         return Bitches.bitchlist[Bitches.bitchlist.getIndex(name)];
      }
    }
  }
}
